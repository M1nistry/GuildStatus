namespace Guild_Status
{
    public partial class ExtendedStatusStrip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripExpandButton = new System.Windows.Forms.ToolStripSplitButton();
            this.listStatusBox = new System.Windows.Forms.ListBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusValue,
            this.progressBar,
            this.toolStripExpandButton});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(658, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Status:";
            // 
            // toolStripStatusValue
            // 
            this.toolStripStatusValue.AutoSize = false;
            this.toolStripStatusValue.Name = "toolStripStatusValue";
            this.toolStripStatusValue.Size = new System.Drawing.Size(471, 17);
            this.toolStripStatusValue.Spring = true;
            this.toolStripStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(110, 16);
            // 
            // toolStripExpandButton
            // 
            this.toolStripExpandButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripExpandButton.DropDownButtonWidth = 0;
            this.toolStripExpandButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExpandButton.Name = "toolStripExpandButton";
            this.toolStripExpandButton.Size = new System.Drawing.Size(18, 20);
            this.toolStripExpandButton.Text = "↑";
            this.toolStripExpandButton.ButtonClick += new System.EventHandler(this.toolStripExpandButton_ButtonClick);
            // 
            // listStatusBox
            // 
            this.listStatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStatusBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listStatusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listStatusBox.FormattingEnabled = true;
            this.listStatusBox.Location = new System.Drawing.Point(0, 0);
            this.listStatusBox.Name = "listStatusBox";
            this.listStatusBox.Size = new System.Drawing.Size(660, 15);
            this.listStatusBox.TabIndex = 1;
            this.listStatusBox.Visible = false;
            this.listStatusBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listStatusBox_MouseMove);
            // 
            // ExtendedStatusStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.listStatusBox);
            this.Name = "ExtendedStatusStrip";
            this.Size = new System.Drawing.Size(658, 22);
            this.Resize += new System.EventHandler(this.ExtendedStatusStrip_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusValue;
        private System.Windows.Forms.ToolStripSplitButton toolStripExpandButton;
        private System.Windows.Forms.ListBox listStatusBox;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripProgressBar progressBar;
    }
}
