namespace IQP_Tester
{
    partial class WhoCeascu
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
            this.CaescuWhoAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CaescuWhoAns
            // 
            this.CaescuWhoAns.AutoSize = true;
            this.CaescuWhoAns.Location = new System.Drawing.Point(312, 153);
            this.CaescuWhoAns.Name = "CaescuWhoAns";
            this.CaescuWhoAns.Size = new System.Drawing.Size(55, 13);
            this.CaescuWhoAns.TabIndex = 0;
            this.CaescuWhoAns.Text = "ANSWER";
            // 
            // WhoCeascu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1125);
            this.ControlBox = false;
            this.Controls.Add(this.CaescuWhoAns);
            this.Name = "WhoCeascu";
            this.Text = "WhoCeascu";
            this.Click += new System.EventHandler(this.WhoCeascu_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CaescuWhoAns;
    }
}