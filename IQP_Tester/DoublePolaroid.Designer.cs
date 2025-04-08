namespace IQP_Tester
{
    partial class DoublePolaroid
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
            this.tableLayoutDPPictures = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutDPMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblDPTitle = new System.Windows.Forms.Label();
            this.lblDPText = new System.Windows.Forms.Label();
            this.pbDPNow = new System.Windows.Forms.PictureBox();
            this.pbDPThen = new System.Windows.Forms.PictureBox();
            this.tableLayoutDPPictures.SuspendLayout();
            this.tableLayoutDPMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDPNow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDPThen)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutDPPictures
            // 
            this.tableLayoutDPPictures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutDPPictures.ColumnCount = 2;
            this.tableLayoutDPPictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutDPPictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutDPPictures.Controls.Add(this.pbDPNow, 1, 0);
            this.tableLayoutDPPictures.Controls.Add(this.pbDPThen, 0, 0);
            this.tableLayoutDPPictures.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutDPPictures.Name = "tableLayoutDPPictures";
            this.tableLayoutDPPictures.RowCount = 1;
            this.tableLayoutDPPictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutDPPictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutDPPictures.Size = new System.Drawing.Size(1850, 744);
            this.tableLayoutDPPictures.TabIndex = 0;
            // 
            // tableLayoutDPMain
            // 
            this.tableLayoutDPMain.ColumnCount = 1;
            this.tableLayoutDPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutDPMain.Controls.Add(this.lblDPText, 0, 2);
            this.tableLayoutDPMain.Controls.Add(this.tableLayoutDPPictures, 0, 0);
            this.tableLayoutDPMain.Controls.Add(this.lblDPTitle, 0, 1);
            this.tableLayoutDPMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutDPMain.Name = "tableLayoutDPMain";
            this.tableLayoutDPMain.RowCount = 4;
            this.tableLayoutDPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutDPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutDPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutDPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutDPMain.Size = new System.Drawing.Size(1856, 958);
            this.tableLayoutDPMain.TabIndex = 1;
            // 
            // lblDPTitle
            // 
            this.lblDPTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDPTitle.AutoSize = true;
            this.lblDPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblDPTitle.Location = new System.Drawing.Point(3, 750);
            this.lblDPTitle.Name = "lblDPTitle";
            this.lblDPTitle.Size = new System.Drawing.Size(1850, 39);
            this.lblDPTitle.TabIndex = 1;
            this.lblDPTitle.Text = "Unknown";
            this.lblDPTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDPText
            // 
            this.lblDPText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDPText.AutoSize = true;
            this.lblDPText.Location = new System.Drawing.Point(3, 843);
            this.lblDPText.Name = "lblDPText";
            this.lblDPText.Size = new System.Drawing.Size(1850, 13);
            this.lblDPText.TabIndex = 2;
            this.lblDPText.Text = "Unknown";
            this.lblDPText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbDPNow
            // 
            this.pbDPNow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDPNow.Location = new System.Drawing.Point(928, 3);
            this.pbDPNow.Name = "pbDPNow";
            this.pbDPNow.Size = new System.Drawing.Size(919, 738);
            this.pbDPNow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDPNow.TabIndex = 1;
            this.pbDPNow.TabStop = false;
            // 
            // pbDPThen
            // 
            this.pbDPThen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDPThen.Location = new System.Drawing.Point(3, 3);
            this.pbDPThen.Name = "pbDPThen";
            this.pbDPThen.Size = new System.Drawing.Size(919, 738);
            this.pbDPThen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDPThen.TabIndex = 0;
            this.pbDPThen.TabStop = false;
            // 
            // DoublePolaroid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1880, 982);
            this.Controls.Add(this.tableLayoutDPMain);
            this.Name = "DoublePolaroid";
            this.Text = "DoublePolaroid";
            this.Shown += new System.EventHandler(this.DoublePolaroid_Shown);
            this.Click += new System.EventHandler(this.DoublePolaroid_Click);
            this.Resize += new System.EventHandler(this.DoublePolaroid_Resize);
            this.tableLayoutDPPictures.ResumeLayout(false);
            this.tableLayoutDPMain.ResumeLayout(false);
            this.tableLayoutDPMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDPNow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDPThen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutDPPictures;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDPMain;
        private System.Windows.Forms.PictureBox pbDPNow;
        private System.Windows.Forms.PictureBox pbDPThen;
        private System.Windows.Forms.Label lblDPText;
        private System.Windows.Forms.Label lblDPTitle;
    }
}