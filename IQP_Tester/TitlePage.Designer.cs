namespace IQP_Tester
{
    partial class TitlePage
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
            this.tableLayoutTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.tableLayoutTitleMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutTitle.SuspendLayout();
            this.tableLayoutTitleMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutTitle
            // 
            this.tableLayoutTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutTitle.ColumnCount = 1;
            this.tableLayoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1880F));
            this.tableLayoutTitle.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutTitle.Controls.Add(this.lblSubtitle, 0, 1);
            this.tableLayoutTitle.Location = new System.Drawing.Point(3, 283);
            this.tableLayoutTitle.Name = "tableLayoutTitle";
            this.tableLayoutTitle.RowCount = 2;
            this.tableLayoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTitle.Size = new System.Drawing.Size(1874, 134);
            this.tableLayoutTitle.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1874, 55);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Unknown";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(3, 55);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(1874, 24);
            this.lblSubtitle.TabIndex = 7;
            this.lblSubtitle.Text = "Unknown";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutTitleMain
            // 
            this.tableLayoutTitleMain.ColumnCount = 1;
            this.tableLayoutTitleMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTitleMain.Controls.Add(this.tableLayoutTitle, 0, 1);
            this.tableLayoutTitleMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutTitleMain.Name = "tableLayoutTitleMain";
            this.tableLayoutTitleMain.RowCount = 3;
            this.tableLayoutTitleMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutTitleMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutTitleMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutTitleMain.Size = new System.Drawing.Size(1880, 701);
            this.tableLayoutTitleMain.TabIndex = 12;
            // 
            // TitlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 725);
            this.Controls.Add(this.tableLayoutTitleMain);
            this.Name = "TitlePage";
            this.Text = "TitlePage";
            this.Shown += new System.EventHandler(this.TitlePage_Shown);
            this.Click += new System.EventHandler(this.TitlePage_Click);
            this.Resize += new System.EventHandler(this.TitlePage_Resize);
            this.tableLayoutTitle.ResumeLayout(false);
            this.tableLayoutTitle.PerformLayout();
            this.tableLayoutTitleMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTitleMain;
    }
}