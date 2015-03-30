namespace Guild_Status
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelLeague = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxGuildId = new System.Windows.Forms.TextBox();
            this.textBoxLeague = new System.Windows.Forms.TextBox();
            this.textBoxAccounts = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.columnOnline = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastOnline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDead = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.bgwJson = new System.ComponentModel.BackgroundWorker();
            this.tabControlAccounts = new System.Windows.Forms.TabControl();
            this.tabPageGuild = new System.Windows.Forms.TabPage();
            this.buttonSearchGuild = new System.Windows.Forms.Button();
            this.labelMemberCount = new System.Windows.Forms.Label();
            this.labelCreated = new System.Windows.Forms.Label();
            this.labelGuildTag = new System.Windows.Forms.Label();
            this.labelGuildName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.tabPageAccounts = new System.Windows.Forms.TabPage();
            this.bgwGuild = new System.ComponentModel.BackgroundWorker();
            this.buttonExport = new System.Windows.Forms.Button();
            this.extendedStatusStrip = new Guild_Status.ExtendedStatusStrip();
            this.listBoxMembers = new Guild_Status.ListBoxScrollbar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.tabControlAccounts.SuspendLayout();
            this.tabPageGuild.SuspendLayout();
            this.tabPageAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLeague
            // 
            this.labelLeague.AutoSize = true;
            this.labelLeague.Location = new System.Drawing.Point(118, 9);
            this.labelLeague.Name = "labelLeague";
            this.labelLeague.Size = new System.Drawing.Size(46, 13);
            this.labelLeague.TabIndex = 0;
            this.labelLeague.Text = "League:";
            this.toolTip.SetToolTip(this.labelLeague, "Specifies the league to query the status of characters on.");
            // 
            // textBoxGuildId
            // 
            this.textBoxGuildId.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGuildId.Location = new System.Drawing.Point(30, 9);
            this.textBoxGuildId.Name = "textBoxGuildId";
            this.textBoxGuildId.Size = new System.Drawing.Size(38, 18);
            this.textBoxGuildId.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxGuildId, "Press enter to search");
            this.textBoxGuildId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGuildId_KeyPress);
            this.textBoxGuildId.Leave += new System.EventHandler(this.textBoxGuildId_Leave);
            // 
            // textBoxLeague
            // 
            this.textBoxLeague.AutoCompleteCustomSource.AddRange(new string[] {
            "omrtb",
            "omrtbhc",
            "Standard",
            "Hardcore"});
            this.textBoxLeague.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxLeague.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxLeague.Location = new System.Drawing.Point(170, 6);
            this.textBoxLeague.Name = "textBoxLeague";
            this.textBoxLeague.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeague.TabIndex = 1;
            this.textBoxLeague.Leave += new System.EventHandler(this.textBoxLeague_Leave);
            // 
            // textBoxAccounts
            // 
            this.textBoxAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAccounts.Location = new System.Drawing.Point(3, 3);
            this.textBoxAccounts.Multiline = true;
            this.textBoxAccounts.Name = "textBoxAccounts";
            this.textBoxAccounts.Size = new System.Drawing.Size(101, 275);
            this.textBoxAccounts.TabIndex = 3;
            this.textBoxAccounts.Leave += new System.EventHandler(this.textBoxAccounts_Leave);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(551, 9);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(44, 13);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(601, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(166, 20);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnOnline,
            this.columnRank,
            this.columnAccount,
            this.columnName,
            this.columnClass,
            this.columnLevel,
            this.columnExperience,
            this.columnLastOnline,
            this.columnDead,
            this.columnId});
            this.dgvDetails.Location = new System.Drawing.Point(121, 31);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.Size = new System.Drawing.Size(646, 287);
            this.dgvDetails.TabIndex = 6;
            this.dgvDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetails_CellFormatting);
            // 
            // columnOnline
            // 
            this.columnOnline.DataPropertyName = "online";
            this.columnOnline.HeaderText = "";
            this.columnOnline.Name = "columnOnline";
            this.columnOnline.ReadOnly = true;
            this.columnOnline.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnOnline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnOnline.ToolTipText = "Online";
            this.columnOnline.Width = 25;
            // 
            // columnRank
            // 
            this.columnRank.DataPropertyName = "rank";
            this.columnRank.HeaderText = "Rank";
            this.columnRank.MaxInputLength = 40;
            this.columnRank.Name = "columnRank";
            this.columnRank.ReadOnly = true;
            this.columnRank.Width = 40;
            // 
            // columnAccount
            // 
            this.columnAccount.DataPropertyName = "account";
            this.columnAccount.HeaderText = "Account";
            this.columnAccount.MaxInputLength = 40;
            this.columnAccount.Name = "columnAccount";
            this.columnAccount.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.DataPropertyName = "name";
            this.columnName.HeaderText = "Name";
            this.columnName.MaxInputLength = 80;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnClass
            // 
            this.columnClass.DataPropertyName = "class";
            this.columnClass.HeaderText = "Class";
            this.columnClass.Name = "columnClass";
            this.columnClass.ReadOnly = true;
            this.columnClass.Width = 85;
            // 
            // columnLevel
            // 
            this.columnLevel.DataPropertyName = "level";
            this.columnLevel.HeaderText = "Level";
            this.columnLevel.Name = "columnLevel";
            this.columnLevel.ReadOnly = true;
            this.columnLevel.Width = 40;
            // 
            // columnExperience
            // 
            this.columnExperience.DataPropertyName = "experience";
            this.columnExperience.HeaderText = "Experience";
            this.columnExperience.MaxInputLength = 50;
            this.columnExperience.Name = "columnExperience";
            this.columnExperience.ReadOnly = true;
            // 
            // columnLastOnline
            // 
            this.columnLastOnline.DataPropertyName = "last_online";
            this.columnLastOnline.HeaderText = "Last Online";
            this.columnLastOnline.MaxInputLength = 80;
            this.columnLastOnline.Name = "columnLastOnline";
            this.columnLastOnline.ReadOnly = true;
            this.columnLastOnline.Width = 125;
            // 
            // columnDead
            // 
            this.columnDead.DataPropertyName = "dead";
            this.columnDead.HeaderText = "Dead";
            this.columnDead.Name = "columnDead";
            this.columnDead.ReadOnly = true;
            this.columnDead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnDead.Visible = false;
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "id";
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(273, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(44, 20);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // bgwJson
            // 
            this.bgwJson.WorkerReportsProgress = true;
            this.bgwJson.WorkerSupportsCancellation = true;
            this.bgwJson.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwJson_DoWork);
            this.bgwJson.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwJson_ProgressChanged);
            this.bgwJson.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwJson_RunWorkerCompleted);
            // 
            // tabControlAccounts
            // 
            this.tabControlAccounts.Controls.Add(this.tabPageGuild);
            this.tabControlAccounts.Controls.Add(this.tabPageAccounts);
            this.tabControlAccounts.Location = new System.Drawing.Point(4, 12);
            this.tabControlAccounts.Name = "tabControlAccounts";
            this.tabControlAccounts.SelectedIndex = 0;
            this.tabControlAccounts.Size = new System.Drawing.Size(115, 307);
            this.tabControlAccounts.TabIndex = 10;
            // 
            // tabPageGuild
            // 
            this.tabPageGuild.Controls.Add(this.buttonSearchGuild);
            this.tabPageGuild.Controls.Add(this.listBoxMembers);
            this.tabPageGuild.Controls.Add(this.labelMemberCount);
            this.tabPageGuild.Controls.Add(this.labelCreated);
            this.tabPageGuild.Controls.Add(this.labelGuildTag);
            this.tabPageGuild.Controls.Add(this.labelGuildName);
            this.tabPageGuild.Controls.Add(this.textBoxGuildId);
            this.tabPageGuild.Controls.Add(this.labelId);
            this.tabPageGuild.Location = new System.Drawing.Point(4, 22);
            this.tabPageGuild.Name = "tabPageGuild";
            this.tabPageGuild.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGuild.Size = new System.Drawing.Size(107, 281);
            this.tabPageGuild.TabIndex = 0;
            this.tabPageGuild.Text = "Guild";
            this.tabPageGuild.UseVisualStyleBackColor = true;
            // 
            // buttonSearchGuild
            // 
            this.buttonSearchGuild.FlatAppearance.BorderSize = 0;
            this.buttonSearchGuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchGuild.Location = new System.Drawing.Point(71, 8);
            this.buttonSearchGuild.Name = "buttonSearchGuild";
            this.buttonSearchGuild.Size = new System.Drawing.Size(27, 20);
            this.buttonSearchGuild.TabIndex = 12;
            this.buttonSearchGuild.Text = "→";
            this.buttonSearchGuild.UseVisualStyleBackColor = true;
            this.buttonSearchGuild.Click += new System.EventHandler(this.buttonSearchGuild_Click);
            // 
            // labelMemberCount
            // 
            this.labelMemberCount.AutoSize = true;
            this.labelMemberCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberCount.Location = new System.Drawing.Point(19, 96);
            this.labelMemberCount.Name = "labelMemberCount";
            this.labelMemberCount.Size = new System.Drawing.Size(0, 12);
            this.labelMemberCount.TabIndex = 5;
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreated.Location = new System.Drawing.Point(14, 81);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(0, 12);
            this.labelCreated.TabIndex = 4;
            // 
            // labelGuildTag
            // 
            this.labelGuildTag.AutoSize = true;
            this.labelGuildTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuildTag.Location = new System.Drawing.Point(33, 57);
            this.labelGuildTag.Name = "labelGuildTag";
            this.labelGuildTag.Size = new System.Drawing.Size(0, 12);
            this.labelGuildTag.TabIndex = 3;
            this.labelGuildTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuildName
            // 
            this.labelGuildName.AutoSize = true;
            this.labelGuildName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuildName.Location = new System.Drawing.Point(10, 41);
            this.labelGuildName.MaximumSize = new System.Drawing.Size(90, 0);
            this.labelGuildName.Name = "labelGuildName";
            this.labelGuildName.Size = new System.Drawing.Size(0, 12);
            this.labelGuildName.TabIndex = 2;
            this.labelGuildName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(6, 12);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 12);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            // 
            // tabPageAccounts
            // 
            this.tabPageAccounts.Controls.Add(this.textBoxAccounts);
            this.tabPageAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccounts.Name = "tabPageAccounts";
            this.tabPageAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccounts.Size = new System.Drawing.Size(107, 281);
            this.tabPageAccounts.TabIndex = 1;
            this.tabPageAccounts.Text = "Accounts";
            this.tabPageAccounts.UseVisualStyleBackColor = true;
            // 
            // bgwGuild
            // 
            this.bgwGuild.WorkerReportsProgress = true;
            this.bgwGuild.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGuild_DoWork);
            this.bgwGuild.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwGuild_ProgressChanged);
            this.bgwGuild.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGuild_RunWorkerCompleted);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(490, 6);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(55, 21);
            this.buttonExport.TabIndex = 11;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Visible = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // extendedStatusStrip
            // 
            this.extendedStatusStrip.BackColor = System.Drawing.Color.Transparent;
            this.extendedStatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.extendedStatusStrip.Location = new System.Drawing.Point(0, 326);
            this.extendedStatusStrip.Name = "extendedStatusStrip";
            this.extendedStatusStrip.Progressbar = false;
            this.extendedStatusStrip.Size = new System.Drawing.Size(779, 22);
            this.extendedStatusStrip.StatusValue = "Status:";
            this.extendedStatusStrip.TabIndex = 8;
            this.extendedStatusStrip.Timestamps = false;
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.ItemHeight = 12;
            this.listBoxMembers.Location = new System.Drawing.Point(0, 125);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.ShowScrollbar = true;
            this.listBoxMembers.Size = new System.Drawing.Size(107, 156);
            this.listBoxMembers.Sorted = true;
            this.listBoxMembers.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 348);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.extendedStatusStrip);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxLeague);
            this.Controls.Add(this.labelLeague);
            this.Controls.Add(this.tabControlAccounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Path of Exile Guild Status";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.tabControlAccounts.ResumeLayout(false);
            this.tabPageGuild.ResumeLayout(false);
            this.tabPageGuild.PerformLayout();
            this.tabPageAccounts.ResumeLayout(false);
            this.tabPageAccounts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLeague;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textBoxLeague;
        private System.Windows.Forms.TextBox textBoxAccounts;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnOnline;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastOnline;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnDead;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private ExtendedStatusStrip extendedStatusStrip;
        private System.ComponentModel.BackgroundWorker bgwJson;
        private System.Windows.Forms.TabControl tabControlAccounts;
        private System.Windows.Forms.TabPage tabPageGuild;
        private System.Windows.Forms.TabPage tabPageAccounts;
        private System.Windows.Forms.Label labelGuildName;
        private System.Windows.Forms.TextBox textBoxGuildId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelMemberCount;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Label labelGuildTag;
        private ListBoxScrollbar listBoxMembers;
        private System.ComponentModel.BackgroundWorker bgwGuild;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonSearchGuild;
    }
}

