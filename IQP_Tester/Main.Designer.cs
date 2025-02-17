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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.pictureBoxRomaniaFlag = new System.Windows.Forms.PictureBox();
            this.historyCeasecu = new System.Windows.Forms.Label();
            this.tabKidsLife = new System.Windows.Forms.TabPage();
            this.KidsLifeFood = new System.Windows.Forms.Label();
            this.KidsLifeToys = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.tabMainControl.SuspendLayout();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRomaniaFlag)).BeginInit();
            this.tabKidsLife.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabHistory);
            this.tabMainControl.Controls.Add(this.tabKidsLife);
            this.tabMainControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMainControl.ItemSize = new System.Drawing.Size(500, 50);
            this.tabMainControl.Location = new System.Drawing.Point(12, 82);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.Padding = new System.Drawing.Point(3, 3);
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(1880, 866);
            this.tabMainControl.TabIndex = 0;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.pictureBoxRomaniaFlag);
            this.tabHistory.Controls.Add(this.historyCeasecu);
            this.tabHistory.Location = new System.Drawing.Point(4, 54);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabHistory.Size = new System.Drawing.Size(1872, 808);
            this.tabHistory.TabIndex = 0;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRomaniaFlag
            // 
            this.pictureBoxRomaniaFlag.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRomaniaFlag.Image")));
            this.pictureBoxRomaniaFlag.Location = new System.Drawing.Point(737, 336);
            this.pictureBoxRomaniaFlag.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBoxRomaniaFlag.Name = "pictureBoxRomaniaFlag";
            this.pictureBoxRomaniaFlag.Size = new System.Drawing.Size(334, 206);
            this.pictureBoxRomaniaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRomaniaFlag.TabIndex = 1;
            this.pictureBoxRomaniaFlag.TabStop = false;
            // 
            // historyCeasecu
            // 
            this.historyCeasecu.AutoSize = true;
            this.historyCeasecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyCeasecu.Location = new System.Drawing.Point(29, 231);
            this.historyCeasecu.Name = "historyCeasecu";
            this.historyCeasecu.Size = new System.Drawing.Size(467, 39);
            this.historyCeasecu.TabIndex = 0;
            this.historyCeasecu.Text = "Who was Nicolae Ceaseșcu?";
            this.historyCeasecu.Click += new System.EventHandler(this.HistoryCeasecu_Click);
            // 
            // tabKidsLife
            // 
            this.tabKidsLife.Controls.Add(this.KidsLifeFood);
            this.tabKidsLife.Controls.Add(this.KidsLifeToys);
            this.tabKidsLife.Location = new System.Drawing.Point(4, 22);
            this.tabKidsLife.Name = "tabKidsLife";
            this.tabKidsLife.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabKidsLife.Size = new System.Drawing.Size(1872, 840);
            this.tabKidsLife.TabIndex = 1;
            this.tabKidsLife.Text = "Kid\'s Life";
            this.tabKidsLife.UseVisualStyleBackColor = true;
            // 
            // KidsLifeFood
            // 
            this.KidsLifeFood.AutoSize = true;
            this.KidsLifeFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KidsLifeFood.Location = new System.Drawing.Point(480, 137);
            this.KidsLifeFood.Name = "KidsLifeFood";
            this.KidsLifeFood.Size = new System.Drawing.Size(192, 25);
            this.KidsLifeFood.TabIndex = 1;
            this.KidsLifeFood.Text = "What did they eat?";
            this.KidsLifeFood.Click += new System.EventHandler(this.KidsLifeFood_Click);
            // 
            // KidsLifeToys
            // 
            this.KidsLifeToys.AutoSize = true;
            this.KidsLifeToys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KidsLifeToys.Location = new System.Drawing.Point(24, 137);
            this.KidsLifeToys.Name = "KidsLifeToys";
            this.KidsLifeToys.Size = new System.Drawing.Size(269, 25);
            this.KidsLifeToys.TabIndex = 0;
            this.KidsLifeToys.Text = "What Toys Did Kids Have?";
            this.KidsLifeToys.Click += new System.EventHandler(this.KidsLifeToys_Click);
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(13, 1016);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(80, 13);
            this.lblUptime.TabIndex = 1;
            this.lblUptime.Text = "UNAVAILABLE";
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(1608, 954);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(284, 75);
            this.btnLanguage.TabIndex = 2;
            this.btnLanguage.Text = "English";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Cooper Black", 45.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(24, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(1853, 70);
            this.lblMainTitle.TabIndex = 4;
            this.lblMainTitle.Text = "Answering Youth Questions About Romanian Communism";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.lblUptime);
            this.Controls.Add(this.tabMainControl);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Educating Romanian Children";
            this.tabMainControl.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRomaniaFlag)).EndInit();
            this.tabKidsLife.ResumeLayout(false);
            this.tabKidsLife.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabKidsLife;
        private System.Windows.Forms.Label KidsLifeToys;
        private System.Windows.Forms.Label KidsLifeFood;
        private System.Windows.Forms.Label historyCeasecu;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.PictureBox pictureBoxRomaniaFlag;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Label lblMainTitle;
    }
}

