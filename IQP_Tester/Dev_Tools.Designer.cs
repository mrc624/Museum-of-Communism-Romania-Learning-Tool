namespace IQP_Tester
{
    partial class Dev_Tools
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
            this.TabControlDevs = new System.Windows.Forms.TabControl();
            this.tabText_Edit = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutDevEditText = new System.Windows.Forms.TableLayoutPanel();
            this.lblEditTextControlName = new System.Windows.Forms.Label();
            this.lblEditTextEnglish = new System.Windows.Forms.Label();
            this.lblEditTextRomanian = new System.Windows.Forms.Label();
            this.btnEditTextRefresh = new System.Windows.Forms.Button();
            this.btnEditTextApply = new System.Windows.Forms.Button();
            this.TabControlDevs.SuspendLayout();
            this.tabText_Edit.SuspendLayout();
            this.tableLayoutDevEditText.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlDevs
            // 
            this.TabControlDevs.Controls.Add(this.tabText_Edit);
            this.TabControlDevs.Controls.Add(this.tabPage2);
            this.TabControlDevs.Location = new System.Drawing.Point(12, 12);
            this.TabControlDevs.Name = "TabControlDevs";
            this.TabControlDevs.SelectedIndex = 0;
            this.TabControlDevs.Size = new System.Drawing.Size(782, 644);
            this.TabControlDevs.TabIndex = 0;
            // 
            // tabText_Edit
            // 
            this.tabText_Edit.Controls.Add(this.btnEditTextApply);
            this.tabText_Edit.Controls.Add(this.btnEditTextRefresh);
            this.tabText_Edit.Controls.Add(this.tableLayoutDevEditText);
            this.tabText_Edit.Location = new System.Drawing.Point(4, 22);
            this.tabText_Edit.Name = "tabText_Edit";
            this.tabText_Edit.Padding = new System.Windows.Forms.Padding(3);
            this.tabText_Edit.Size = new System.Drawing.Size(774, 618);
            this.tabText_Edit.TabIndex = 0;
            this.tabText_Edit.Text = "Edit Text";
            this.tabText_Edit.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutDevEditText
            // 
            this.tableLayoutDevEditText.AutoScroll = true;
            this.tableLayoutDevEditText.ColumnCount = 3;
            this.tableLayoutDevEditText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutDevEditText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutDevEditText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutDevEditText.Controls.Add(this.lblEditTextRomanian, 2, 0);
            this.tableLayoutDevEditText.Controls.Add(this.lblEditTextEnglish, 1, 0);
            this.tableLayoutDevEditText.Controls.Add(this.lblEditTextControlName, 0, 0);
            this.tableLayoutDevEditText.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutDevEditText.Name = "tableLayoutDevEditText";
            this.tableLayoutDevEditText.RowCount = 2;
            this.tableLayoutDevEditText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.801653F));
            this.tableLayoutDevEditText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.19835F));
            this.tableLayoutDevEditText.Size = new System.Drawing.Size(761, 576);
            this.tableLayoutDevEditText.TabIndex = 0;
            // 
            // lblEditTextControlName
            // 
            this.lblEditTextControlName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditTextControlName.AutoSize = true;
            this.lblEditTextControlName.Location = new System.Drawing.Point(3, 0);
            this.lblEditTextControlName.Name = "lblEditTextControlName";
            this.lblEditTextControlName.Size = new System.Drawing.Size(247, 13);
            this.lblEditTextControlName.TabIndex = 0;
            this.lblEditTextControlName.Text = "Control Name";
            this.lblEditTextControlName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEditTextEnglish
            // 
            this.lblEditTextEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditTextEnglish.AutoSize = true;
            this.lblEditTextEnglish.Location = new System.Drawing.Point(256, 0);
            this.lblEditTextEnglish.Name = "lblEditTextEnglish";
            this.lblEditTextEnglish.Size = new System.Drawing.Size(247, 13);
            this.lblEditTextEnglish.TabIndex = 1;
            this.lblEditTextEnglish.Text = "English";
            this.lblEditTextEnglish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEditTextRomanian
            // 
            this.lblEditTextRomanian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditTextRomanian.AutoSize = true;
            this.lblEditTextRomanian.Location = new System.Drawing.Point(509, 0);
            this.lblEditTextRomanian.Name = "lblEditTextRomanian";
            this.lblEditTextRomanian.Size = new System.Drawing.Size(249, 13);
            this.lblEditTextRomanian.TabIndex = 2;
            this.lblEditTextRomanian.Text = "Romanian";
            this.lblEditTextRomanian.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditTextRefresh
            // 
            this.btnEditTextRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditTextRefresh.Location = new System.Drawing.Point(693, 589);
            this.btnEditTextRefresh.Name = "btnEditTextRefresh";
            this.btnEditTextRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnEditTextRefresh.TabIndex = 1;
            this.btnEditTextRefresh.Text = "Refresh";
            this.btnEditTextRefresh.UseVisualStyleBackColor = false;
            this.btnEditTextRefresh.Click += new System.EventHandler(this.btnEditTextRefresh_Click);
            // 
            // btnEditTextApply
            // 
            this.btnEditTextApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditTextApply.Location = new System.Drawing.Point(612, 589);
            this.btnEditTextApply.Name = "btnEditTextApply";
            this.btnEditTextApply.Size = new System.Drawing.Size(75, 23);
            this.btnEditTextApply.TabIndex = 2;
            this.btnEditTextApply.Text = "Apply";
            this.btnEditTextApply.UseVisualStyleBackColor = false;
            this.btnEditTextApply.Click += new System.EventHandler(this.btnEditTextApply_Click);
            // 
            // Dev_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 668);
            this.Controls.Add(this.TabControlDevs);
            this.Name = "Dev_Tools";
            this.Text = "Dev_Tools";
            this.TabControlDevs.ResumeLayout(false);
            this.tabText_Edit.ResumeLayout(false);
            this.tableLayoutDevEditText.ResumeLayout(false);
            this.tableLayoutDevEditText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlDevs;
        private System.Windows.Forms.TabPage tabText_Edit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDevEditText;
        private System.Windows.Forms.Label lblEditTextRomanian;
        private System.Windows.Forms.Label lblEditTextEnglish;
        private System.Windows.Forms.Label lblEditTextControlName;
        private System.Windows.Forms.Button btnEditTextRefresh;
        private System.Windows.Forms.Button btnEditTextApply;
    }
}