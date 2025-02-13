namespace IQP_Tester
{
    partial class Main
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
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.HistoryCeasecu = new System.Windows.Forms.Label();
            this.tabKidsLife = new System.Windows.Forms.TabPage();
            this.KidsLifeFood = new System.Windows.Forms.Label();
            this.KidsLifeToys = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabMainControl.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.tabKidsLife.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabHistory);
            this.tabMainControl.Controls.Add(this.tabKidsLife);
            this.tabMainControl.Controls.Add(this.tabPage1);
            this.tabMainControl.Location = new System.Drawing.Point(32, 29);
            this.tabMainControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(2016, 1128);
            this.tabMainControl.TabIndex = 0;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.pictureBox1);
            this.tabHistory.Controls.Add(this.HistoryCeasecu);
            this.tabHistory.Location = new System.Drawing.Point(10, 48);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabHistory.Size = new System.Drawing.Size(1996, 1070);
            this.tabHistory.TabIndex = 0;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // HistoryCeasecu
            // 
            this.HistoryCeasecu.AutoSize = true;
            this.HistoryCeasecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryCeasecu.Location = new System.Drawing.Point(29, 412);
            this.HistoryCeasecu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.HistoryCeasecu.Name = "HistoryCeasecu";
            this.HistoryCeasecu.Size = new System.Drawing.Size(521, 61);
            this.HistoryCeasecu.TabIndex = 0;
            this.HistoryCeasecu.Text = "Who was Ceasescu?";
            this.HistoryCeasecu.Click += new System.EventHandler(this.HistoryCeasecu_Click);
            // 
            // tabKidsLife
            // 
            this.tabKidsLife.Controls.Add(this.KidsLifeFood);
            this.tabKidsLife.Controls.Add(this.KidsLifeToys);
            this.tabKidsLife.Location = new System.Drawing.Point(10, 48);
            this.tabKidsLife.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabKidsLife.Name = "tabKidsLife";
            this.tabKidsLife.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabKidsLife.Size = new System.Drawing.Size(1996, 1070);
            this.tabKidsLife.TabIndex = 1;
            this.tabKidsLife.Text = "Kid\'s Life";
            this.tabKidsLife.UseVisualStyleBackColor = true;
            // 
            // KidsLifeFood
            // 
            this.KidsLifeFood.AutoSize = true;
            this.KidsLifeFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KidsLifeFood.Location = new System.Drawing.Point(1280, 327);
            this.KidsLifeFood.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.KidsLifeFood.Name = "KidsLifeFood";
            this.KidsLifeFood.Size = new System.Drawing.Size(465, 61);
            this.KidsLifeFood.TabIndex = 1;
            this.KidsLifeFood.Text = "What did they eat?";
            this.KidsLifeFood.Click += new System.EventHandler(this.KidsLifeFood_Click);
            // 
            // KidsLifeToys
            // 
            this.KidsLifeToys.AutoSize = true;
            this.KidsLifeToys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KidsLifeToys.Location = new System.Drawing.Point(64, 327);
            this.KidsLifeToys.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.KidsLifeToys.Name = "KidsLifeToys";
            this.KidsLifeToys.Size = new System.Drawing.Size(657, 61);
            this.KidsLifeToys.TabIndex = 0;
            this.KidsLifeToys.Text = "What Toys Did Kids Have?";
            this.KidsLifeToys.Click += new System.EventHandler(this.KidsLifeToys_Click);
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(1437, 21);
            this.lblUptime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(207, 32);
            this.lblUptime.TabIndex = 1;
            this.lblUptime.Text = "UNAVAILABLE";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1996, 1070);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabFood";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IQP_Tester.Properties.Resources.Communist_Flag_Romania;
            this.pictureBox1.Location = new System.Drawing.Point(584, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 616);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2088, 1219);
            this.ControlBox = false;
            this.Controls.Add(this.lblUptime);
            this.Controls.Add(this.tabMainControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Educating Romanian Children";
            this.tabMainControl.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            this.tabKidsLife.ResumeLayout(false);
            this.tabKidsLife.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabKidsLife;
        private System.Windows.Forms.Label KidsLifeToys;
        private System.Windows.Forms.Label KidsLifeFood;
        private System.Windows.Forms.Label HistoryCeasecu;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

