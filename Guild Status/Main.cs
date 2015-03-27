using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Guild_Status
{
    public partial class Main : Form
    {

        private List<Character> _characterList = new List<Character>();
        private BindingSource _bindingSource = new BindingSource();

        public Main()
        {
            InitializeComponent();
            dgvDetails.AutoGenerateColumns = true;
        }

        private void GrabDetails()
        {
            foreach (var account in textBoxAccounts.Lines)
            {
                var jObj = JsonHandler.ParseJsonObject(String.Format("http://poe.pwx.me/api/ladder?league=omrtbhc&account={0}", account));
                if (jObj == null) continue;
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

                    _characterList.Add(newCharacter);
                }
            }
        }

        private void UpdateDatagrid()
        {

            var dtCharacters = new DataTable("characters");

            #region init DataTable
            dtCharacters.Columns.Add("id", typeof(string));
            dtCharacters.Columns.Add("name", typeof(string));
            dtCharacters.Columns.Add("account", typeof(string));
            dtCharacters.Columns.Add("level", typeof(int));
            dtCharacters.Columns.Add("experience", typeof(string));
            dtCharacters.Columns.Add("last_online", typeof(DateTime));
            dtCharacters.Columns.Add("online", typeof(bool));
            dtCharacters.Columns.Add("rank", typeof(int));
            dtCharacters.Columns.Add("dead", typeof(bool));
            dtCharacters.Columns.Add("class", typeof(string));
            #endregion

            foreach (var character in _characterList)
            {
                dtCharacters.Rows.Add(character.Id, character.Name, character.Account, character.Level,
                    character.Experience.ToString("N0"), character.LastOnline, character.Online, character.Rank, character.Dead,
                    character.Class);
            }
            _bindingSource = new BindingSource
            {
                DataSource = dtCharacters,
            };
            dgvDetails.DataSource = _bindingSource;
        }

        private void textBoxAccounts_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Accounts = textBoxAccounts.Text;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _characterList.Clear();
            dgvDetails.DataSource = _bindingSource;
            GrabDetails();
            UpdateDatagrid();
        }

    }
}