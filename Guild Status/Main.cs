using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using OfficeOpenXml.Table;

namespace Guild_Status
{
    public partial class Main : Form
    {

        private readonly List<Character> _characterList = new List<Character>();
        private readonly DataTable _dtCharacters = new DataTable("characters");
        private BindingSource _bindingSource = new BindingSource();

        public Main()
        {
            InitializeComponent();
            dgvDetails.AutoGenerateColumns = true;
            textBoxGuildId.Text = Properties.Settings.Default.guildId;
            textBoxLeague.Text = Properties.Settings.Default.selectedLeague;
        }

        private void UpdateDatagrid()
        {
            if (_dtCharacters.Columns.Count == 0)
            {
                #region init DataTable

                _dtCharacters.Columns.Add("id", typeof (string));
                _dtCharacters.Columns.Add("name", typeof (string));
                _dtCharacters.Columns.Add("account", typeof (string));
                _dtCharacters.Columns.Add("level", typeof (int));
                _dtCharacters.Columns.Add("experience", typeof (string));
                _dtCharacters.Columns.Add("last_online", typeof (DateTime));
                _dtCharacters.Columns.Add("online", typeof (bool));
                _dtCharacters.Columns.Add("rank", typeof (int));
                _dtCharacters.Columns.Add("dead", typeof (bool));
                _dtCharacters.Columns.Add("class", typeof (string));

                #endregion
            }

            foreach (var character in _characterList)
            {
                _dtCharacters.Rows.Add(character.Id, character.Name, character.Account, character.Level,
                    character.Experience.ToString("N0"), character.LastOnline, character.Online, character.Rank, character.Dead,
                    character.Class);
            }
            _bindingSource = new BindingSource
            {
                DataSource = _dtCharacters,
                Sort = "rank ASC"
            };
            dgvDetails.DataSource = _bindingSource;
            if (dgvDetails.Rows.Count > 0) buttonExport.Visible = true;
        }

        private void textBoxAccounts_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Accounts = textBoxAccounts.Text;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _characterList.Clear();
            dgvDetails.DataSource = _bindingSource;
            buttonExport.Visible = false;
            if (textBoxLeague.Text == String.Empty)
            {
                extendedStatusStrip.AddStatus(@"No league selected, type a valid league in the textbox labeled 'League'.");
                return;
            }
            if (!bgwJson.IsBusy)
            {
                var guild = tabControlAccounts.SelectedTab == tabPageGuild;
                bgwJson.RunWorkerAsync(guild);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            textBoxSearch.Text = CleanSearch(textBoxSearch.Text);
            var filter = textBoxSearch.Text;
            if (filter == String.Empty) _bindingSource.RemoveFilter();
            _bindingSource.Filter = "account LIKE '%" + filter + "%' OR " +
                                    "name LIKE '%" + filter + "%' OR " +
                                    "class LIKE '%" + filter + "%'";
        }

        private static string CleanSearch(string input)
        {
            if (input.Contains("'")) return input.Replace("'", "");
            if (input.Contains("*")) return input.Replace("*", "");
            if (input.Contains("[")) return input.Replace("[", "");
            if (input.Contains("]")) return input.Replace("]", "");
            return input;
        }

        private void dgvDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((bool)dgvDetails["columnDead", e.RowIndex].Value)
            {
                dgvDetails.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Silver;
            }
        }

        private void bgwJson_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int progCount = 0, failCount = 0, characterCount = 0;
            var guildMembers = new string[listBoxMembers.Items.Count];
            for (var i = 0; i < listBoxMembers.Items.Count; i++) guildMembers[i] = listBoxMembers.Items[i].ToString();
            var memberList = (bool)e.Argument ?  guildMembers : textBoxAccounts.Lines;
            bgwJson.ReportProgress(-1, String.Format("Requesting {0} accounts and character details...", memberList.Count()));
            foreach (var account in memberList)
            {
                var jObj = JsonHandler.ParseJsonObject(String.Format("http://poe.pwx.me/api/ladder?league={0}&account={1}", textBoxLeague.Text, account));
                if (jObj == null)
                {
                    failCount++;
                    continue;
                }
                foreach (var entry in jObj)
                {
                    dynamic values = entry.Value;
                    int charLevel, rank;
                    Int64 experience;
                    long lastOnline;
                    var newCharacter = new Character
                    {
                        Id = entry.Name,
                        Name = values["charName"].ToString(),
                        Account = values["accountName"].ToString(),
                        Level = int.TryParse(values["level"].ToString(), out charLevel) ? charLevel : 0,
                        Experience = Int64.TryParse(values["experience"].ToString(), out experience) ? experience : 0,
                        LastOnline =
                            new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(
                                long.TryParse(values["lastOnline"].ToString(), out lastOnline) ? lastOnline : 0)
                                .ToLocalTime(),
                        Online = values["online"].ToString() == "1",
                        Rank = int.TryParse(values["rank"].ToString(), out rank) ? rank : 0,
                        Dead = values["dead"].ToString() == "1",
                        Class = values["class"].ToString()
                    };
                    characterCount++;
                    _characterList.Add(newCharacter);
                }
                progCount++;
                bgwJson.ReportProgress((int) (((float)progCount/memberList.Length) * 100));
            }
            bgwJson.ReportProgress(-1, String.Format("Retrieved {0} characters from {1} accounts, no results from {2} accounts", characterCount, progCount, failCount));
        }

        private void bgwJson_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 0) progressBar.Value = e.ProgressPercentage;
            if (e.ProgressPercentage == -1 && e.UserState != null)
            {
                extendedStatusStrip.AddStatus(e.UserState.ToString());
                extendedStatusStrip.Refresh();
            }
        }

        private void bgwJson_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) extendedStatusStrip.AddStatus(@"Error occured: " + e.Error.Message);
            UpdateDatagrid();
            progressBar.Value = 0;
        }

        private Guild FetchGuild(string guildId)
        {
            int id;
            if (!int.TryParse(guildId, out id))
            {
                bgwGuild.ReportProgress(-1, @"Guild ID mismatch, please make sure that you've entered a valid numerical guild ID.");
                return null;
            }
            var webPage = String.Format("http://www.pathofexile.com/guild/profile/{0}", id);
            bgwGuild.ReportProgress(15);
            var memberList = new List<string>();
            var web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = null;
            try
            {
                doc = web.Load(webPage);
                if (doc == null)
                {
                    bgwGuild.ReportProgress(-1, @"Web page failed to load!");
                    return null;
                }
                var paragraphs = doc.DocumentNode.SelectNodes("//*[contains(@class, 'details-content')]/p");
                var members = doc.DocumentNode.SelectNodes("//*[contains(@class, 'profile-link')]");
                if (paragraphs == null || members == null)
                {
                    bgwGuild.ReportProgress(-1, @"Failed to load the guild page, verify your guild ID is valid.");
                    return null;
                }
                bgwGuild.ReportProgress(30);
                var createdString = paragraphs[0].InnerText.Trim().Replace("  ", "").Replace("Created:", "").Replace("\r\n", "");
                memberList.AddRange(members.Select(member => member.InnerText));
                //var statusNode = doc.DocumentNode.SelectNodes("//*[contains(@class,'guild-status')]");
                var tagNode = doc.DocumentNode.SelectSingleNode("//*[contains(@class,'guild-tag')]");
                bgwGuild.ReportProgress(60);
                var guild = new Guild
                {
                    Name = doc.DocumentNode.SelectSingleNode("//*[contains(@class,'name')]").InnerText,
                    Tag = tagNode != null ? tagNode.InnerText : "",
                    //Status = statusNode != null ? statusNode.First().InnerText : "",
                    Created = createdString,
                    TotalMembers = members.Count,
                    Members = memberList,
                };
                bgwGuild.ReportProgress(100);
                return guild;
            }
            catch (WebException e)
            {
                bgwGuild.ReportProgress(-1, @"Failed to load webpage: " + webPage);
                return null;
            }
            catch (Exception ex)
            {
                bgwGuild.ReportProgress(-1, @"Error occured: " + ex.Message);
                return null;
            }
        }

        private void textBoxGuildId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter && textBoxGuildId.Text.Length > 0 && !bgwGuild.IsBusy)
            {
                listBoxMembers.DataSource = null;
                labelGuildName.Text = String.Empty;
                labelGuildTag.Text = String.Empty;
                labelCreated.Text = String.Empty;
                labelMemberCount.Text = String.Empty;
                bgwGuild.RunWorkerAsync();
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void buttonSearchGuild_Click(object sender, EventArgs e)
        {
            if (textBoxGuildId.Text.Length <= 0 || bgwGuild.IsBusy) return;
            listBoxMembers.DataSource = null;
            labelGuildName.Text = String.Empty;
            labelGuildTag.Text = String.Empty;
            labelCreated.Text = String.Empty;
            labelMemberCount.Text = String.Empty;
            bgwGuild.RunWorkerAsync();
        }

        private void bgwGuild_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var guild = FetchGuild(textBoxGuildId.Text);
            if (guild != null) e.Result = guild;
        }

        private void bgwGuild_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            var guildResult = (Guild) e.Result;
            if (guildResult == null)
            {
                return;
            }
            labelGuildName.Text = guildResult.Name;
            labelGuildTag.Text = guildResult.Tag.Replace("&lt;", "<").Replace("&gt;", ">");
            labelCreated.Text = guildResult.Created;
            labelMemberCount.Text = @"Members: " + guildResult.TotalMembers;
            listBoxMembers.DataSource = guildResult.Members;
        }

        private void bgwGuild_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 0) progressBar.Value = e.ProgressPercentage;
            if (e.ProgressPercentage == -1 && e.UserState != null)
            {
                extendedStatusStrip.AddStatus(e.UserState.ToString());
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (_dtCharacters.Rows.Count <= 0) return;
            try
            {
                var fileSave = new SaveFileDialog()
                {
                    AddExtension = true,
                    Filter = @"Excel Spreadsheet (*.xlsx)|*.xlsx",
                    DefaultExt = "xlsx",
                    Title = @"Export save location",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };
                fileSave.ShowDialog();
                if (fileSave.FileName == String.Empty) return;
                var newFile = new FileInfo(fileSave.FileName);
                using (var pck = new ExcelPackage(newFile))
                {
                    var ws = pck.Workbook.Worksheets.Add("Guild Status");
                    ws.Cells["A1"].LoadFromDataTable(_dtCharacters, true, TableStyles.Medium13);
                    ws.Cells.AutoFitColumns();
                    pck.Save();
                }
                extendedStatusStrip.AddStatus(@"Successfully exported to: " + fileSave.FileName);
            }
            catch (Exception ex)
            {
                extendedStatusStrip.AddStatus(@"Error occured: " + ex.Message);
            }

        }

        private void textBoxGuildId_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.guildId = textBoxGuildId.Text;
            Properties.Settings.Default.Save();
        }

        private void textBoxLeague_Leave(object sender, EventArgs e)
        {
            if (textBoxLeague.Text == String.Empty) return;
            Properties.Settings.Default.selectedLeague = textBoxLeague.Text;
        }

    }
}