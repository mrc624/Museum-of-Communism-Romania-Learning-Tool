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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelQuestionAndAnswer = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.tableLayoutPolaroidZoomContainer = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPolaroidZoomMain = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.tableLayoutLanguagePolaroidZoomBtnAlign = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.tableLayoutPanelQuestionAndAnswer.SuspendLayout();
            this.tableLayoutPolaroidZoomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.tableLayoutPolaroidZoomMain.SuspendLayout();
            this.tableLayoutLanguagePolaroidZoomBtnAlign.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelQuestionAndAnswer
            // 
            this.tableLayoutPanelQuestionAndAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelQuestionAndAnswer.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelQuestionAndAnswer.ColumnCount = 1;
            this.tableLayoutPanelQuestionAndAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQuestionAndAnswer.Controls.Add(this.lblQuestion, 0, 0);
            this.tableLayoutPanelQuestionAndAnswer.Controls.Add(this.lblAnswer, 0, 1);
            this.tableLayoutPanelQuestionAndAnswer.Location = new System.Drawing.Point(2538, 7);
            this.tableLayoutPanelQuestionAndAnswer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanelQuestionAndAnswer.Name = "tableLayoutPanelQuestionAndAnswer";
            this.tableLayoutPanelQuestionAndAnswer.RowCount = 1;
            this.tableLayoutPanelQuestionAndAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQuestionAndAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQuestionAndAnswer.Size = new System.Drawing.Size(2515, 1552);
            this.tableLayoutPanelQuestionAndAnswer.TabIndex = 2;
            this.tableLayoutPanelQuestionAndAnswer.Click += new System.EventHandler(this.tableLayoutPanelQuestionAndAnswer_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestion.Location = new System.Drawing.Point(8, 0);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(2499, 39);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "EXAMPLE QUESTION FOR SIZING";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAnswer.Location = new System.Drawing.Point(8, 39);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(2499, 1513);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "EXAMPLE ANSWER FOR SIZING";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(4765, 112);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(249, 64);
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
            this.tableLayoutPolaroidZoomContainer.Location = new System.Drawing.Point(8, 204);
            this.tableLayoutPolaroidZoomContainer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPolaroidZoomContainer.Name = "tableLayoutPolaroidZoomContainer";
            this.tableLayoutPolaroidZoomContainer.RowCount = 1;
            this.tableLayoutPolaroidZoomContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPolaroidZoomContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPolaroidZoomContainer.Size = new System.Drawing.Size(5061, 1566);
            this.tableLayoutPolaroidZoomContainer.TabIndex = 9;
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture.Location = new System.Drawing.Point(8, 7);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(2514, 1552);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            // 
            // tableLayoutPolaroidZoomMain
            // 
            this.tableLayoutPolaroidZoomMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPolaroidZoomMain.ColumnCount = 1;
            this.tableLayoutPolaroidZoomMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPolaroidZoomMain.Controls.Add(this.tableLayoutLanguagePolaroidZoomBtnAlign, 0, 2);
            this.tableLayoutPolaroidZoomMain.Controls.Add(this.tableLayoutPolaroidZoomContainer, 0, 1);
            this.tableLayoutPolaroidZoomMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPolaroidZoomMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPolaroidZoomMain.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPolaroidZoomMain.Name = "tableLayoutPolaroidZoomMain";
            this.tableLayoutPolaroidZoomMain.RowCount = 3;
            this.tableLayoutPolaroidZoomMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPolaroidZoomMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPolaroidZoomMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPolaroidZoomMain.Size = new System.Drawing.Size(5077, 1976);
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
            this.tableLayoutLanguagePolaroidZoomBtnAlign.Location = new System.Drawing.Point(8, 1784);
            this.tableLayoutLanguagePolaroidZoomBtnAlign.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutLanguagePolaroidZoomBtnAlign.Name = "tableLayoutLanguagePolaroidZoomBtnAlign";
            this.tableLayoutLanguagePolaroidZoomBtnAlign.RowCount = 3;
            this.tableLayoutLanguagePolaroidZoomBtnAlign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutLanguagePolaroidZoomBtnAlign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.25F));
            this.tableLayoutLanguagePolaroidZoomBtnAlign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.75F));
            this.tableLayoutLanguagePolaroidZoomBtnAlign.Size = new System.Drawing.Size(5061, 185);
            this.tableLayoutLanguagePolaroidZoomBtnAlign.TabIndex = 32;
            // 
            // Polaroid_Zoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(5077, 1976);
            this.Controls.Add(this.tableLayoutPolaroidZoomMain);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Polaroid_Zoom";
            this.Text = "Polaroid_Zoom";
            this.Click += new System.EventHandler(this.Polaroid_Zoom_Click);
            this.Resize += new System.EventHandler(this.Polaroid_Zoom_Resize);
            this.tableLayoutPanelQuestionAndAnswer.ResumeLayout(false);
            this.tableLayoutPanelQuestionAndAnswer.PerformLayout();
            this.tableLayoutPolaroidZoomContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.tableLayoutPolaroidZoomMain.ResumeLayout(false);
            this.tableLayoutLanguagePolaroidZoomBtnAlign.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private DoubleBufferedTableLayout tableLayoutPanelQuestionAndAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnLanguage;
        private DoubleBufferedTableLayout tableLayoutPolaroidZoomContainer;
        private DoubleBufferedTableLayout tableLayoutPolaroidZoomMain;
        private DoubleBufferedTableLayout tableLayoutLanguagePolaroidZoomBtnAlign;
    }
}