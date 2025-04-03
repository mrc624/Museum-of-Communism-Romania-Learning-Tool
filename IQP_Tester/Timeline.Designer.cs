namespace IQP_Tester
{
    partial class Timeline
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
            this.btnLanguage = new System.Windows.Forms.Button();
            this.panelTesting = new System.Windows.Forms.Panel();
            this.pbTimeLine = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHowDidTheRegimeFall = new System.Windows.Forms.Label();
            this.pbRevolution = new System.Windows.Forms.PictureBox();
            this.panelRegimeFall = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevolution)).BeginInit();
            this.panelRegimeFall.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(1820, 1040);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(93, 37);
            this.btnLanguage.TabIndex = 8;
            this.btnLanguage.Text = "English";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.TextChanged += new System.EventHandler(this.btnLanguage_TextChanged);
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // panelTesting
            // 
            this.panelTesting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTesting.Location = new System.Drawing.Point(28, 189);
            this.panelTesting.Name = "panelTesting";
            this.panelTesting.Size = new System.Drawing.Size(188, 213);
            this.panelTesting.TabIndex = 10;
            // 
            // pbTimeLine
            // 
            this.pbTimeLine.Image = global::IQP_Tester.Properties.Resources.Nicolae_Ceasescu;
            this.pbTimeLine.Location = new System.Drawing.Point(264, 543);
            this.pbTimeLine.Name = "pbTimeLine";
            this.pbTimeLine.Size = new System.Drawing.Size(1512, 125);
            this.pbTimeLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTimeLine.TabIndex = 9;
            this.pbTimeLine.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(111, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 127);
            this.panel1.TabIndex = 11;
            // 
            // lblHowDidTheRegimeFall
            // 
            this.lblHowDidTheRegimeFall.AutoSize = true;
            this.lblHowDidTheRegimeFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowDidTheRegimeFall.Location = new System.Drawing.Point(15, 0);
            this.lblHowDidTheRegimeFall.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHowDidTheRegimeFall.Name = "lblHowDidTheRegimeFall";
            this.lblHowDidTheRegimeFall.Size = new System.Drawing.Size(214, 31);
            this.lblHowDidTheRegimeFall.TabIndex = 0;
            this.lblHowDidTheRegimeFall.Text = "How did the fall?";
            // 
            // pbRevolution
            // 
            this.pbRevolution.Image = global::IQP_Tester.Properties.Resources.Romanian_Revolution;
            this.pbRevolution.InitialImage = global::IQP_Tester.Properties.Resources.Romanian_Revolution;
            this.pbRevolution.Location = new System.Drawing.Point(6, 34);
            this.pbRevolution.Margin = new System.Windows.Forms.Padding(1);
            this.pbRevolution.Name = "pbRevolution";
            this.pbRevolution.Size = new System.Drawing.Size(337, 261);
            this.pbRevolution.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRevolution.TabIndex = 2;
            this.pbRevolution.TabStop = false;
            // 
            // panelRegimeFall
            // 
            this.panelRegimeFall.Controls.Add(this.pbRevolution);
            this.panelRegimeFall.Controls.Add(this.lblHowDidTheRegimeFall);
            this.panelRegimeFall.Location = new System.Drawing.Point(531, 67);
            this.panelRegimeFall.Margin = new System.Windows.Forms.Padding(1);
            this.panelRegimeFall.Name = "panelRegimeFall";
            this.panelRegimeFall.Size = new System.Drawing.Size(348, 309);
            this.panelRegimeFall.TabIndex = 12;
            this.panelRegimeFall.Click += new System.EventHandler(this.panelRegimeFall_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(701, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 127);
            this.panel2.TabIndex = 13;
            // 
            // Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelRegimeFall);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTesting);
            this.Controls.Add(this.pbTimeLine);
            this.Controls.Add(this.btnLanguage);
            this.Name = "Timeline";
            this.Text = "Then_And_Now";
            this.Shown += new System.EventHandler(this.ThenAndNow_Shown);
            this.Click += new System.EventHandler(this.ThenAndNow_Click);
            this.Resize += new System.EventHandler(this.ThenAndNow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevolution)).EndInit();
            this.panelRegimeFall.ResumeLayout(false);
            this.panelRegimeFall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.PictureBox pbTimeLine;
        private System.Windows.Forms.Panel panelTesting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHowDidTheRegimeFall;
        private System.Windows.Forms.PictureBox pbRevolution;
        private System.Windows.Forms.Panel panelRegimeFall;
        private System.Windows.Forms.Panel panel2;
    }
}