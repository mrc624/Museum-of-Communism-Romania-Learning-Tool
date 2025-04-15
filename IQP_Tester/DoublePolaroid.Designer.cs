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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutDPPictures = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.pbDPNow = new System.Windows.Forms.PictureBox();
            this.pbDPThen = new System.Windows.Forms.PictureBox();
            this.tableLayoutDPMain = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.btnLanguage = new System.Windows.Forms.Button();
            this.lblDPText = new System.Windows.Forms.Label();
            this.lblDPTitle = new System.Windows.Forms.Label();
            this.tableLayoutDPPictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDPNow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDPThen)).BeginInit();
            this.tableLayoutDPMain.SuspendLayout();
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.SuspendLayout();
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
            this.tableLayoutDPPictures.Location = new System.Drawing.Point(8, 204);
            this.tableLayoutDPPictures.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutDPPictures.Name = "tableLayoutDPPictures";
            this.tableLayoutDPPictures.RowCount = 1;
            this.tableLayoutDPPictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutDPPictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutDPPictures.Size = new System.Drawing.Size(5061, 1171);
            this.tableLayoutDPPictures.TabIndex = 0;
            // 
            // pbDPNow
            // 
            this.pbDPNow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDPNow.Location = new System.Drawing.Point(2538, 7);
            this.pbDPNow.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pbDPNow.Name = "pbDPNow";
            this.pbDPNow.Size = new System.Drawing.Size(2515, 1157);
            this.pbDPNow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDPNow.TabIndex = 1;
            this.pbDPNow.TabStop = false;
            // 
            // pbDPThen
            // 
            this.pbDPThen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDPThen.Location = new System.Drawing.Point(8, 7);
            this.pbDPThen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pbDPThen.Name = "pbDPThen";
            this.pbDPThen.Size = new System.Drawing.Size(2514, 1157);
            this.pbDPThen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDPThen.TabIndex = 0;
            this.pbDPThen.TabStop = false;
            // 
            // tableLayoutDPMain
            // 
            this.tableLayoutDPMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutDPMain.ColumnCount = 1;
            this.tableLayoutDPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutDPMain.Controls.Add(this.tableLayoutLanguageDoublePolaroidZoomBtnAlign, 0, 4);
            this.tableLayoutDPMain.Controls.Add(this.lblDPText, 0, 3);
            this.tableLayoutDPMain.Controls.Add(this.tableLayoutDPPictures, 0, 1);
            this.tableLayoutDPMain.Controls.Add(this.lblDPTitle, 0, 2);
            this.tableLayoutDPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutDPMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutDPMain.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutDPMain.Name = "tableLayoutDPMain";
            this.tableLayoutDPMain.RowCount = 5;
            this.tableLayoutDPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutDPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutDPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutDPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutDPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutDPMain.Size = new System.Drawing.Size(5077, 1976);
            this.tableLayoutDPMain.TabIndex = 1;
            // 
            // tableLayoutLanguageDoublePolaroidZoomBtnAlign
            // 
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.ColumnCount = 3;
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.25F));
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.75F));
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.Controls.Add(this.btnLanguage, 1, 1);
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.Location = new System.Drawing.Point(8, 1783);
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.Name = "tableLayoutLanguageDoublePolaroidZoomBtnAlign";
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.RowCount = 3;
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.25F));
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.75F));
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.Size = new System.Drawing.Size(5061, 186);
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.TabIndex = 33;
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(4765, 113);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(249, 64);
            this.btnLanguage.TabIndex = 9;
            this.btnLanguage.Text = "English";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // lblDPText
            // 
            this.lblDPText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDPText.AutoSize = true;
            this.lblDPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDPText.Location = new System.Drawing.Point(8, 1579);
            this.lblDPText.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDPText.Name = "lblDPText";
            this.lblDPText.Size = new System.Drawing.Size(5061, 29);
            this.lblDPText.TabIndex = 2;
            this.lblDPText.Text = "Unknown";
            this.lblDPText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDPTitle
            // 
            this.lblDPTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDPTitle.AutoSize = true;
            this.lblDPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblDPTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDPTitle.Location = new System.Drawing.Point(8, 1382);
            this.lblDPTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDPTitle.Name = "lblDPTitle";
            this.lblDPTitle.Size = new System.Drawing.Size(5061, 39);
            this.lblDPTitle.TabIndex = 1;
            this.lblDPTitle.Text = "Unknown";
            this.lblDPTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DoublePolaroid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(5077, 1976);
            this.Controls.Add(this.tableLayoutDPMain);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DoublePolaroid";
            this.Text = "DoublePolaroid";
            this.Shown += new System.EventHandler(this.DoublePolaroid_Shown);
            this.Click += new System.EventHandler(this.DoublePolaroid_Click);
            this.Resize += new System.EventHandler(this.DoublePolaroid_Resize);
            this.tableLayoutDPPictures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDPNow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDPThen)).EndInit();
            this.tableLayoutDPMain.ResumeLayout(false);
            this.tableLayoutDPMain.PerformLayout();
            this.tableLayoutLanguageDoublePolaroidZoomBtnAlign.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferedTableLayout tableLayoutDPPictures;
        private DoubleBufferedTableLayout tableLayoutDPMain;
        private System.Windows.Forms.PictureBox pbDPNow;
        private System.Windows.Forms.PictureBox pbDPThen;
        private System.Windows.Forms.Label lblDPText;
        private System.Windows.Forms.Label lblDPTitle;
        private System.Windows.Forms.Button btnLanguage;
        private DoubleBufferedTableLayout tableLayoutLanguageDoublePolaroidZoomBtnAlign;
    }
}