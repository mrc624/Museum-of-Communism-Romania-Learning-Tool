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
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabMainControl.Location = new System.Drawing.Point(20, 150);
            this.tabMainControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.Padding = new System.Drawing.Point(3, 3);
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(2785, 1360);
            this.tabMainControl.TabIndex = 0;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.pictureBoxRomaniaFlag);
            this.tabHistory.Controls.Add(this.historyCeasecu);
            this.tabHistory.Location = new System.Drawing.Point(10, 60);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabHistory.Size = new System.Drawing.Size(2765, 1290);
            this.tabHistory.TabIndex = 0;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRomaniaFlag
            // 
            this.pictureBoxRomaniaFlag.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRomaniaFlag.Image")));
            this.pictureBoxRomaniaFlag.Location = new System.Drawing.Point(1040, 495);
            this.pictureBoxRomaniaFlag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxRomaniaFlag.Name = "pictureBoxRomaniaFlag";
            this.pictureBoxRomaniaFlag.Size = new System.Drawing.Size(891, 491);
            this.pictureBoxRomaniaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRomaniaFlag.TabIndex = 1;
            this.pictureBoxRomaniaFlag.TabStop = false;
            // 
            // historyCeasecu
            // 
            this.historyCeasecu.AutoSize = true;
            this.historyCeasecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyCeasecu.Location = new System.Drawing.Point(16, 317);
            this.historyCeasecu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.historyCeasecu.Name = "historyCeasecu";
            this.historyCeasecu.Size = new System.Drawing.Size(1186, 101);
            this.historyCeasecu.TabIndex = 0;
            this.historyCeasecu.Text = "Who was Nicolae Ceașescu?";
            this.historyCeasecu.Click += new System.EventHandler(this.HistoryCeasecu_Click);
            // 
            // tabKidsLife
            // 
            this.tabKidsLife.Controls.Add(this.KidsLifeFood);
            this.tabKidsLife.Controls.Add(this.KidsLifeToys);
            this.tabKidsLife.Location = new System.Drawing.Point(10, 60);
            this.tabKidsLife.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabKidsLife.Name = "tabKidsLife";
            this.tabKidsLife.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabKidsLife.Size = new System.Drawing.Size(2708, 1356);
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
            this.lblUptime.Location = new System.Drawing.Point(35, 2423);
            this.lblUptime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(207, 32);
            this.lblUptime.TabIndex = 1;
            this.lblUptime.Text = "UNAVAILABLE";
            // 
            // btnLanguage
            // 
            this.btnLanguage.AutoSize = true;
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(2353, 1554);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(450, 120);
            this.btnLanguage.TabIndex = 2;
            this.btnLanguage.Text = "English";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Cooper Black", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(64, 21);
            this.lblMainTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(2638, 100);
            this.lblMainTitle.TabIndex = 4;
            this.lblMainTitle.Text = "Answering Youth Questions About Romanian Communism";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1702, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2823, 1696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.lblUptime);
            this.Controls.Add(this.tabMainControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Educating Romanian Children";
            this.Resize += new System.EventHandler(this.Main_Resize);
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
        private System.Windows.Forms.Label label1;
    }
}

