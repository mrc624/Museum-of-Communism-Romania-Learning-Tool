namespace IQP_Tester
{
    partial class History
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
            this.lblWhoCeausecu = new System.Windows.Forms.Label();
            this.pbCeasescu = new System.Windows.Forms.PictureBox();
            this.panelWhoCeausescu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCeasescu)).BeginInit();
            this.panelWhoCeausescu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWhoCeausecu
            // 
            this.lblWhoCeausecu.AutoSize = true;
            this.lblWhoCeausecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoCeausecu.Location = new System.Drawing.Point(16, 241);
            this.lblWhoCeausecu.Name = "lblWhoCeausecu";
            this.lblWhoCeausecu.Size = new System.Drawing.Size(327, 25);
            this.lblWhoCeausecu.TabIndex = 4;
            this.lblWhoCeausecu.Text = "Who was Nicolae Ceauseșescu?";
            // 
            // pbCeasescu
            // 
            this.pbCeasescu.Image = global::IQP_Tester.Properties.Resources.Nicolae_Ceasescu;
            this.pbCeasescu.InitialImage = global::IQP_Tester.Properties.Resources.Nicolae_Ceasescu;
            this.pbCeasescu.Location = new System.Drawing.Point(77, 33);
            this.pbCeasescu.Margin = new System.Windows.Forms.Padding(1);
            this.pbCeasescu.Name = "pbCeasescu";
            this.pbCeasescu.Size = new System.Drawing.Size(209, 207);
            this.pbCeasescu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCeasescu.TabIndex = 5;
            this.pbCeasescu.TabStop = false;
            // 
            // panelWhoCeausescu
            // 
            this.panelWhoCeausescu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhoCeausescu.Controls.Add(this.pbCeasescu);
            this.panelWhoCeausescu.Controls.Add(this.lblWhoCeausecu);
            this.panelWhoCeausescu.Location = new System.Drawing.Point(12, 12);
            this.panelWhoCeausescu.Name = "panelWhoCeausescu";
            this.panelWhoCeausescu.Size = new System.Drawing.Size(604, 424);
            this.panelWhoCeausescu.TabIndex = 6;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelWhoCeausescu);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "History";
            this.Text = "History";
            this.Shown += new System.EventHandler(this.History_Shown);
            this.Click += new System.EventHandler(this.History_Click);
            this.Resize += new System.EventHandler(this.History_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbCeasescu)).EndInit();
            this.panelWhoCeausescu.ResumeLayout(false);
            this.panelWhoCeausescu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWhoCeausecu;
        private System.Windows.Forms.PictureBox pbCeasescu;
        private System.Windows.Forms.Panel panelWhoCeausescu;
    }
}