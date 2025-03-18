namespace IQP_Tester
{
    partial class RegimeFall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegimeFall));
            this.btnLanguage = new System.Windows.Forms.Button();
            this.panelRevolutionQuestions = new System.Windows.Forms.Panel();
            this.lblRevolutionAns = new System.Windows.Forms.Label();
            this.lblRevolutionQ = new System.Windows.Forms.Label();
            this.pbRevolutionTank = new System.Windows.Forms.PictureBox();
            this.panelRevolutionQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevolutionTank)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(1820, 1040);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(93, 37);
            this.btnLanguage.TabIndex = 7;
            this.btnLanguage.Text = "English";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // panelRevolutionQuestions
            // 
            this.panelRevolutionQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRevolutionQuestions.Controls.Add(this.lblRevolutionAns);
            this.panelRevolutionQuestions.Controls.Add(this.lblRevolutionQ);
            this.panelRevolutionQuestions.Controls.Add(this.pbRevolutionTank);
            this.panelRevolutionQuestions.Location = new System.Drawing.Point(990, 88);
            this.panelRevolutionQuestions.Name = "panelRevolutionQuestions";
            this.panelRevolutionQuestions.Size = new System.Drawing.Size(507, 384);
            this.panelRevolutionQuestions.TabIndex = 8;
            // 
            // lblRevolutionAns
            // 
            this.lblRevolutionAns.AutoSize = true;
            this.lblRevolutionAns.Location = new System.Drawing.Point(106, 287);
            this.lblRevolutionAns.Name = "lblRevolutionAns";
            this.lblRevolutionAns.Size = new System.Drawing.Size(273, 78);
            this.lblRevolutionAns.TabIndex = 7;
            this.lblRevolutionAns.Text = resources.GetString("lblRevolutionAns.Text");
            this.lblRevolutionAns.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRevolutionQ
            // 
            this.lblRevolutionQ.AutoSize = true;
            this.lblRevolutionQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevolutionQ.Location = new System.Drawing.Point(78, 262);
            this.lblRevolutionQ.Name = "lblRevolutionQ";
            this.lblRevolutionQ.Size = new System.Drawing.Size(254, 25);
            this.lblRevolutionQ.TabIndex = 5;
            this.lblRevolutionQ.Text = "What was the revolution?";
            // 
            // pbRevolutionTank
            // 
            this.pbRevolutionTank.Image = ((System.Drawing.Image)(resources.GetObject("pbRevolutionTank.Image")));
            this.pbRevolutionTank.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbRevolutionTank.InitialImage")));
            this.pbRevolutionTank.Location = new System.Drawing.Point(60, 14);
            this.pbRevolutionTank.Name = "pbRevolutionTank";
            this.pbRevolutionTank.Size = new System.Drawing.Size(354, 245);
            this.pbRevolutionTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRevolutionTank.TabIndex = 0;
            this.pbRevolutionTank.TabStop = false;
            // 
            // RegimeFall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelRevolutionQuestions);
            this.Controls.Add(this.btnLanguage);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "RegimeFall";
            this.Text = "History";
            this.Shown += new System.EventHandler(this.History_Shown);
            this.Click += new System.EventHandler(this.History_Click);
            this.Resize += new System.EventHandler(this.History_Resize);
            this.panelRevolutionQuestions.ResumeLayout(false);
            this.panelRevolutionQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevolutionTank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Panel panelRevolutionQuestions;
        private System.Windows.Forms.Label lblRevolutionQ;
        private System.Windows.Forms.PictureBox pbRevolutionTank;
        private System.Windows.Forms.Label lblRevolutionAns;
    }
}