namespace IQP_Tester
{
    partial class Feedback
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            this.tableLayoutFeedbackMain = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.TableLayoutbtnBackAlignFeedback = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutQuestions = new System.Windows.Forms.TableLayoutPanel();
            this.lblConsent = new System.Windows.Forms.Label();
            this.tableLayoutFeedbackMain.SuspendLayout();
            this.TableLayoutbtnBackAlignFeedback.SuspendLayout();
            this.tableLayoutQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutFeedbackMain
            // 
            this.tableLayoutFeedbackMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutFeedbackMain.ColumnCount = 3;
            this.tableLayoutFeedbackMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFeedbackMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFeedbackMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFeedbackMain.Controls.Add(this.TableLayoutbtnBackAlignFeedback, 2, 0);
            this.tableLayoutFeedbackMain.Controls.Add(this.tableLayoutQuestions, 1, 2);
            this.tableLayoutFeedbackMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFeedbackMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutFeedbackMain.Name = "tableLayoutFeedbackMain";
            this.tableLayoutFeedbackMain.RowCount = 4;
            this.tableLayoutFeedbackMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFeedbackMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutFeedbackMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutFeedbackMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutFeedbackMain.Size = new System.Drawing.Size(1888, 992);
            this.tableLayoutFeedbackMain.TabIndex = 2;
            this.tableLayoutFeedbackMain.Click += new System.EventHandler(this.tableLayoutFeedbackMain_Click);
            // 
            // TableLayoutbtnBackAlignFeedback
            // 
            this.TableLayoutbtnBackAlignFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutbtnBackAlignFeedback.ColumnCount = 3;
            this.TableLayoutbtnBackAlignFeedback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.TableLayoutbtnBackAlignFeedback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.TableLayoutbtnBackAlignFeedback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.TableLayoutbtnBackAlignFeedback.Controls.Add(this.btnBack, 1, 1);
            this.TableLayoutbtnBackAlignFeedback.Location = new System.Drawing.Point(1419, 3);
            this.TableLayoutbtnBackAlignFeedback.Name = "TableLayoutbtnBackAlignFeedback";
            this.TableLayoutbtnBackAlignFeedback.RowCount = 3;
            this.TableLayoutbtnBackAlignFeedback.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.75F));
            this.TableLayoutbtnBackAlignFeedback.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.25F));
            this.TableLayoutbtnBackAlignFeedback.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.TableLayoutbtnBackAlignFeedback.Size = new System.Drawing.Size(466, 93);
            this.TableLayoutbtnBackAlignFeedback.TabIndex = 35;
            this.TableLayoutbtnBackAlignFeedback.Click += new System.EventHandler(this.TableLayoutbtnBackAlignFeedback_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(357, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 33);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutQuestions
            // 
            this.tableLayoutQuestions.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutQuestions.ColumnCount = 1;
            this.tableLayoutQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutQuestions.Controls.Add(this.lblConsent, 0, 0);
            this.tableLayoutQuestions.Location = new System.Drawing.Point(475, 126);
            this.tableLayoutQuestions.Name = "tableLayoutQuestions";
            this.tableLayoutQuestions.RowCount = 5;
            this.tableLayoutQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutQuestions.Size = new System.Drawing.Size(922, 524);
            this.tableLayoutQuestions.TabIndex = 36;
            // 
            // lblConsent
            // 
            this.lblConsent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConsent.AutoSize = true;
            this.lblConsent.Location = new System.Drawing.Point(3, 0);
            this.lblConsent.Name = "lblConsent";
            this.lblConsent.Size = new System.Drawing.Size(916, 13);
            this.lblConsent.TabIndex = 0;
            this.lblConsent.Text = "lblConsent";
            this.lblConsent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::IQP_Tester.Properties.Resources.WallpaperBackgroundMain1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutFeedbackMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Feedback_FormClosing);
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.Shown += new System.EventHandler(this.Feedback_Shown);
            this.VisibleChanged += new System.EventHandler(this.Feedback_VisibleChanged);
            this.Click += new System.EventHandler(this.Feedback_Click);
            this.tableLayoutFeedbackMain.ResumeLayout(false);
            this.TableLayoutbtnBackAlignFeedback.ResumeLayout(false);
            this.tableLayoutQuestions.ResumeLayout(false);
            this.tableLayoutQuestions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DoubleBufferedTableLayout tableLayoutFeedbackMain;
        private DoubleBufferedTableLayout TableLayoutbtnBackAlignFeedback;
        public System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutQuestions;
        private System.Windows.Forms.Label lblConsent;
    }
}