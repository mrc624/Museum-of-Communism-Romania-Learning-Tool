namespace IQP_Tester
{
    partial class Polaroid_Zoom
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
            this.tableLayoutPanelQuestionAndAnswer = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.tableLayoutPolaroidZoomContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPolaroidZoomMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutLanguagePolaroidZoomBtnAlign = new System.Windows.Forms.TableLayoutPanel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelQuestionAndAnswer.SuspendLayout();
            this.tableLayoutPolaroidZoomContainer.SuspendLayout();
            this.tableLayoutPolaroidZoomMain.SuspendLayout();
            this.tableLayoutLanguagePolaroidZoomBtnAlign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelQuestionAndAnswer
            // 
            this.tableLayoutPanelQuestionAndAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelQuestionAndAnswer.ColumnCount = 1;
            this.tableLayoutPanelQuestionAndAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQuestionAndAnswer.Controls.Add(this.lblQuestion, 0, 0);
            this.tableLayoutPanelQuestionAndAnswer.Controls.Add(this.lblAnswer, 0, 1);
            this.tableLayoutPanelQuestionAndAnswer.Location = new System.Drawing.Point(952, 3);
            this.tableLayoutPanelQuestionAndAnswer.Name = "tableLayoutPanelQuestionAndAnswer";
            this.tableLayoutPanelQuestionAndAnswer.RowCount = 1;
            this.tableLayoutPanelQuestionAndAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQuestionAndAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQuestionAndAnswer.Size = new System.Drawing.Size(943, 820);
            this.tableLayoutPanelQuestionAndAnswer.TabIndex = 2;
            this.tableLayoutPanelQuestionAndAnswer.Click += new System.EventHandler(this.tableLayoutPanelQuestionAndAnswer_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(3, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(937, 39);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "EXAMPLE QUESTION FOR SIZING";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(3, 39);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(937, 31);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "EXAMPLE ANSWER FOR SIZING";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(1787, 59);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(93, 35);
            this.btnLanguage.TabIndex = 8;
            this.btnLanguage.Text = "English";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // tableLayoutPolaroidZoomContainer
            // 
            this.tableLayoutPolaroidZoomContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPolaroidZoomContainer.ColumnCount = 2;
            this.tableLayoutPolaroidZoomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPolaroidZoomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPolaroidZoomContainer.Controls.Add(this.pbPicture, 0, 0);
            this.tableLayoutPolaroidZoomContainer.Controls.Add(this.tableLayoutPanelQuestionAndAnswer, 1, 0);
            this.tableLayoutPolaroidZoomContainer.Location = new System.Drawing.Point(3, 107);
            this.tableLayoutPolaroidZoomContainer.Name = "tableLayoutPolaroidZoomContainer";
            this.tableLayoutPolaroidZoomContainer.RowCount = 1;
            this.tableLayoutPolaroidZoomContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPolaroidZoomContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPolaroidZoomContainer.Size = new System.Drawing.Size(1898, 826);
            this.tableLayoutPolaroidZoomContainer.TabIndex = 9;
            // 
            // tableLayoutPolaroidZoomMain
            // 
            this.tableLayoutPolaroidZoomMain.ColumnCount = 1;
            this.tableLayoutPolaroidZoomMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPolaroidZoomMain.Controls.Add(this.tableLayoutLanguagePolaroidZoomBtnAlign, 0, 2);
            this.tableLayoutPolaroidZoomMain.Controls.Add(this.tableLayoutPolaroidZoomContainer, 0, 1);
            this.tableLayoutPolaroidZoomMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPolaroidZoomMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPolaroidZoomMain.Name = "tableLayoutPolaroidZoomMain";
            this.tableLayoutPolaroidZoomMain.RowCount = 3;
            this.tableLayoutPolaroidZoomMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPolaroidZoomMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPolaroidZoomMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPolaroidZoomMain.Size = new System.Drawing.Size(1904, 1041);
            this.tableLayoutPolaroidZoomMain.TabIndex = 10;
            // 
            // tableLayoutLanguagePolaroidZoomBtnAlign
            // 
            this.tableLayoutLanguagePolaroidZoomBtnAlign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutLanguagePolaroidZoomBtnAlign.ColumnCount = 3;
            this.tableLayoutLanguagePolaroidZoomBtnAlign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutLanguagePolaroidZoomBtnAlign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.25F));
            this.tableLayoutLanguagePolaroidZoomBtnAlign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.75F));
            this.tableLayoutLanguagePolaroidZoomBtnAlign.Controls.Add(this.btnLanguage, 1, 1);
            this.tableLayoutLanguagePolaroidZoomBtnAlign.Location = new System.Drawing.Point(3, 939);
            this.tableLayoutLanguagePolaroidZoomBtnAlign.Name = "tableLayoutLanguagePolaroidZoomBtnAlign";
            this.tableLayoutLanguagePolaroidZoomBtnAlign.RowCount = 3;
            this.tableLayoutLanguagePolaroidZoomBtnAlign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutLanguagePolaroidZoomBtnAlign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.25F));
            this.tableLayoutLanguagePolaroidZoomBtnAlign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.75F));
            this.tableLayoutLanguagePolaroidZoomBtnAlign.Size = new System.Drawing.Size(1898, 99);
            this.tableLayoutLanguagePolaroidZoomBtnAlign.TabIndex = 32;
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture.Location = new System.Drawing.Point(3, 3);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(943, 820);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            // 
            // Polaroid_Zoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPolaroidZoomMain);
            this.Name = "Polaroid_Zoom";
            this.Text = "Polaroid_Zoom";
            this.Click += new System.EventHandler(this.Polaroid_Zoom_Click);
            this.Resize += new System.EventHandler(this.Polaroid_Zoom_Resize);
            this.tableLayoutPanelQuestionAndAnswer.ResumeLayout(false);
            this.tableLayoutPanelQuestionAndAnswer.PerformLayout();
            this.tableLayoutPolaroidZoomContainer.ResumeLayout(false);
            this.tableLayoutPolaroidZoomMain.ResumeLayout(false);
            this.tableLayoutLanguagePolaroidZoomBtnAlign.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuestionAndAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPolaroidZoomContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPolaroidZoomMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLanguagePolaroidZoomBtnAlign;
    }
}