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
            this.CreditsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // CreditsTableLayoutPanel
            // 
            this.CreditsTableLayoutPanel.AutoScroll = true;
            this.CreditsTableLayoutPanel.ColumnCount = 1;
            this.CreditsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CreditsTableLayoutPanel.Location = new System.Drawing.Point(-2, -1);
            this.CreditsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.CreditsTableLayoutPanel.Name = "CreditsTableLayoutPanel";
            this.CreditsTableLayoutPanel.RowCount = 1;
            this.CreditsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.14973F));
            this.CreditsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.85027F));
            this.CreditsTableLayoutPanel.Size = new System.Drawing.Size(813, 678);
            this.CreditsTableLayoutPanel.TabIndex = 0;
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 668);
            this.Controls.Add(this.CreditsTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Credits";
            this.Text = "Credits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Credits_FormClosing);
            this.Load += new System.EventHandler(this.Credits_Load);
            this.Shown += new System.EventHandler(this.Credits_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CreditsTableLayoutPanel;
    }
}