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
            this.labelLeague = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxLeague = new System.Windows.Forms.TextBox();
            this.labelAccounts = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
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
            // textBoxLeague
            // 
            this.textBoxLeague.Location = new System.Drawing.Point(170, 6);
            this.textBoxLeague.Name = "textBoxLeague";
            this.textBoxLeague.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeague.TabIndex = 1;
            // 
            // labelAccounts
            // 
            this.labelAccounts.AutoSize = true;
            this.labelAccounts.Location = new System.Drawing.Point(37, 15);
            this.labelAccounts.Name = "labelAccounts";
            this.labelAccounts.Size = new System.Drawing.Size(52, 13);
            this.labelAccounts.TabIndex = 2;
            this.labelAccounts.Text = "Accounts";
            // 
            // textBoxAccounts
            // 
            this.textBoxAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAccounts.Location = new System.Drawing.Point(12, 31);
            this.textBoxAccounts.Multiline = true;
            this.textBoxAccounts.Name = "textBoxAccounts";
            this.textBoxAccounts.Size = new System.Drawing.Size(100, 210);
            this.textBoxAccounts.TabIndex = 3;
            this.textBoxAccounts.Leave += new System.EventHandler(this.textBoxAccounts_Leave);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(414, 9);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(44, 13);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(464, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(114, 20);
            this.textBoxSearch.TabIndex = 5;
            // 
            // dgvDetails
            // 
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
            this.dgvDetails.Size = new System.Drawing.Size(457, 210);
            this.dgvDetails.TabIndex = 6;
            // 
            // columnOnline
            // 
            this.columnOnline.DataPropertyName = "online";
            this.columnOnline.HeaderText = "Online";
            this.columnOnline.Name = "columnOnline";
            this.columnOnline.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnOnline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnRank
            // 
            this.columnRank.DataPropertyName = "rank";
            this.columnRank.HeaderText = "Rank";
            this.columnRank.MaxInputLength = 40;
            this.columnRank.Name = "columnRank";
            // 
            // columnAccount
            // 
            this.columnAccount.DataPropertyName = "account";
            this.columnAccount.HeaderText = "Account";
            this.columnAccount.MaxInputLength = 40;
            this.columnAccount.Name = "columnAccount";
            // 
            // columnName
            // 
            this.columnName.DataPropertyName = "name";
            this.columnName.HeaderText = "Name";
            this.columnName.MaxInputLength = 80;
            this.columnName.Name = "columnName";
            // 
            // columnClass
            // 
            this.columnClass.DataPropertyName = "class";
            this.columnClass.HeaderText = "Class";
            this.columnClass.Name = "columnClass";
            // 
            // columnLevel
            // 
            this.columnLevel.DataPropertyName = "level";
            this.columnLevel.HeaderText = "Level";
            this.columnLevel.Name = "columnLevel";
            // 
            // columnExperience
            // 
            this.columnExperience.DataPropertyName = "experience";
            this.columnExperience.HeaderText = "Experience";
            this.columnExperience.MaxInputLength = 50;
            this.columnExperience.Name = "columnExperience";
            // 
            // columnLastOnline
            // 
            this.columnLastOnline.DataPropertyName = "last_online";
            this.columnLastOnline.HeaderText = "Last Online";
            this.columnLastOnline.MaxInputLength = 80;
            this.columnLastOnline.Name = "columnLastOnline";
            // 
            // columnDead
            // 
            this.columnDead.DataPropertyName = "dead";
            this.columnDead.HeaderText = "Dead";
            this.columnDead.Name = "columnDead";
            this.columnDead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnDead.Visible = false;
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "id";
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(275, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(20, 20);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "↻";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 253);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxAccounts);
            this.Controls.Add(this.labelAccounts);
            this.Controls.Add(this.textBoxLeague);
            this.Controls.Add(this.labelLeague);
            this.Name = "Main";
            this.Text = "Path of Exile Guild Status";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLeague;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textBoxLeague;
        private System.Windows.Forms.Label labelAccounts;
        private System.Windows.Forms.TextBox textBoxAccounts;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dgvDetails;
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
        private System.Windows.Forms.Button buttonSearch;
    }
}

