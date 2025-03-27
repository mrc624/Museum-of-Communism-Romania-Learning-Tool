namespace IQP_Tester
{
    partial class ThenAndNow
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
            // ThenAndNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnLanguage);
            this.Name = "ThenAndNow";
            this.Text = "Then_And_Now";
            this.Shown += new System.EventHandler(this.ThenAndNow_Shown);
            this.Click += new System.EventHandler(this.ThenAndNow_Click);
            this.Resize += new System.EventHandler(this.ThenAndNow_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLanguage;
    }
}