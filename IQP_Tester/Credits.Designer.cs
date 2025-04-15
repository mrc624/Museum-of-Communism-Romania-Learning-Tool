namespace IQP_Tester
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.CreditsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutCreditsMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutCreditsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreditsTableLayoutPanel
            // 
            this.CreditsTableLayoutPanel.AutoScroll = true;
            this.CreditsTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CreditsTableLayoutPanel.ColumnCount = 1;
            this.CreditsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CreditsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreditsTableLayoutPanel.Location = new System.Drawing.Point(477, 261);
            this.CreditsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.CreditsTableLayoutPanel.Name = "CreditsTableLayoutPanel";
            this.CreditsTableLayoutPanel.RowCount = 1;
            this.CreditsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.14973F));
            this.CreditsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.85027F));
            this.CreditsTableLayoutPanel.Size = new System.Drawing.Size(950, 518);
            this.CreditsTableLayoutPanel.TabIndex = 0;
            this.CreditsTableLayoutPanel.VisibleChanged += new System.EventHandler(this.CreditsTableLayoutPanel_VisibleChanged);
            // 
            // tableLayoutCreditsMain
            // 
            this.tableLayoutCreditsMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutCreditsMain.ColumnCount = 3;
            this.tableLayoutCreditsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutCreditsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCreditsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutCreditsMain.Controls.Add(this.CreditsTableLayoutPanel, 1, 1);
            this.tableLayoutCreditsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutCreditsMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutCreditsMain.Name = "tableLayoutCreditsMain";
            this.tableLayoutCreditsMain.RowCount = 3;
            this.tableLayoutCreditsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutCreditsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCreditsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutCreditsMain.Size = new System.Drawing.Size(1904, 1041);
            this.tableLayoutCreditsMain.TabIndex = 2;
            this.tableLayoutCreditsMain.Click += new System.EventHandler(this.tableLayoutCreditsMain_Click);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::IQP_Tester.Properties.Resources.WallpaperBackgroundMain1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutCreditsMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Credits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Credits_FormClosing);
            this.Load += new System.EventHandler(this.Credits_Load);
            this.Shown += new System.EventHandler(this.Credits_Shown);
            this.VisibleChanged += new System.EventHandler(this.Credits_VisibleChanged);
            this.tableLayoutCreditsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CreditsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCreditsMain;
    }
}