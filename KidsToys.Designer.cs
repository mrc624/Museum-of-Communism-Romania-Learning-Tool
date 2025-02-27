namespace IQP_Tester
{
    partial class KidsToys
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
            this.KidsToysAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KidsToysAns
            // 
            this.KidsToysAns.AutoSize = true;
            this.KidsToysAns.Location = new System.Drawing.Point(520, 289);
            this.KidsToysAns.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.KidsToysAns.Name = "KidsToysAns";
            this.KidsToysAns.Size = new System.Drawing.Size(137, 32);
            this.KidsToysAns.TabIndex = 0;
            this.KidsToysAns.Text = "ANSWER";
            // 
            // KidsToys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.ControlBox = false;
            this.Controls.Add(this.KidsToysAns);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "KidsToys";
            this.Text = "KidsToys";
            this.Shown += new System.EventHandler(this.KidsToys_Shown);
            this.Click += new System.EventHandler(this.KidsToys_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KidsToysAns;
    }
}