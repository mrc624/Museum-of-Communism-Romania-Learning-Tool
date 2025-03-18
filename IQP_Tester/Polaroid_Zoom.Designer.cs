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
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelQuestionAndAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelQuestionAndAnswer
            // 
            this.tableLayoutPanelQuestionAndAnswer.ColumnCount = 1;
            this.tableLayoutPanelQuestionAndAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelQuestionAndAnswer.Controls.Add(this.lblQuestion, 0, 0);
            this.tableLayoutPanelQuestionAndAnswer.Controls.Add(this.lblAnswer, 0, 1);
            this.tableLayoutPanelQuestionAndAnswer.Location = new System.Drawing.Point(969, 12);
            this.tableLayoutPanelQuestionAndAnswer.Name = "tableLayoutPanelQuestionAndAnswer";
            this.tableLayoutPanelQuestionAndAnswer.RowCount = 2;
            this.tableLayoutPanelQuestionAndAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.242871F));
            this.tableLayoutPanelQuestionAndAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.75713F));
            this.tableLayoutPanelQuestionAndAnswer.Size = new System.Drawing.Size(923, 1017);
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
            this.lblQuestion.Size = new System.Drawing.Size(917, 39);
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
            this.lblAnswer.Location = new System.Drawing.Point(3, 94);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(917, 31);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "EXAMPLE ANSWER FOR SIZING";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(12, 12);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(950, 1017);
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
            this.Controls.Add(this.tableLayoutPanelQuestionAndAnswer);
            this.Controls.Add(this.pbPicture);
            this.Name = "Polaroid_Zoom";
            this.Text = "Polaroid_Zoom";
            this.Click += new System.EventHandler(this.Polaroid_Zoom_Click);
            this.tableLayoutPanelQuestionAndAnswer.ResumeLayout(false);
            this.tableLayoutPanelQuestionAndAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuestionAndAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
    }
}