namespace IQP_Tester
{
    partial class RevLength
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
            this.revLengthAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // revLengthAns
            // 
            this.revLengthAns.AutoSize = true;
            this.revLengthAns.Location = new System.Drawing.Point(582, 210);
            this.revLengthAns.Name = "revLengthAns";
            this.revLengthAns.Size = new System.Drawing.Size(108, 32);
            this.revLengthAns.TabIndex = 0;
            this.revLengthAns.Text = "Answer";
            // 
            // RevLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1936, 1029);
            this.ControlBox = false;
            this.Controls.Add(this.revLengthAns);
            this.Name = "RevLength";
            this.Text = "RevLength";
            this.Shown += new System.EventHandler(this.RevLength_Shown);
            this.Click += new System.EventHandler(this.RevLength_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label revLengthAns;
    }
}