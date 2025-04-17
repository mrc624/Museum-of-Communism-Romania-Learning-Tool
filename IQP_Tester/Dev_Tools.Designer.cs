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
            this.components = new System.ComponentModel.Container();
            this.TabControlDevs = new System.Windows.Forms.TabControl();
            this.TabStastics = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefreshGeneralStats = new System.Windows.Forms.Button();
            this.lblInteractionsDisp = new System.Windows.Forms.Label();
            this.lblInteractions = new System.Windows.Forms.Label();
            this.lblUptimeDisp = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.lblGeneralStats = new System.Windows.Forms.Label();
            this.panelOpenForms = new System.Windows.Forms.Panel();
            this.btnRefreshOpenForms = new System.Windows.Forms.Button();
            this.tableLayoutPanelOpenForms = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.lblOpenFormsCountDisp = new System.Windows.Forms.Label();
            this.lblOpenFormsCount = new System.Windows.Forms.Label();
            this.tabText_Edit = new System.Windows.Forms.TabPage();
            this.btnReadCSV = new System.Windows.Forms.Button();
            this.btnGenerateTextCSV = new System.Windows.Forms.Button();
            this.btnEditTextApply = new System.Windows.Forms.Button();
            this.btnEditTextRefresh = new System.Windows.Forms.Button();
            this.tableLayoutDevEditText = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.lblEditTextRomanian = new System.Windows.Forms.Label();
            this.lblEditTextEnglish = new System.Windows.Forms.Label();
            this.lblEditTextControlName = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tbTabDebounce = new System.Windows.Forms.TextBox();
            this.lblTabDebounce = new System.Windows.Forms.Label();
            this.tbTabTimeout = new System.Windows.Forms.TextBox();
            this.lblTabTimeout = new System.Windows.Forms.Label();
            this.btnApplyDevSettings = new System.Windows.Forms.Button();
            this.btnRefreshDevSettings = new System.Windows.Forms.Button();
            this.tbFontSizeOffset = new System.Windows.Forms.TextBox();
            this.lblFontSizeOffset = new System.Windows.Forms.Label();
            this.lblBtnBackVisible = new System.Windows.Forms.Label();
            this.cbBtnBackVisible = new System.Windows.Forms.CheckBox();
            this.TabControlDevs.SuspendLayout();
            this.TabStastics.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOpenForms.SuspendLayout();
            this.tabText_Edit.SuspendLayout();
            this.tableLayoutDevEditText.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlDevs
            // 
            this.TabControlDevs.Controls.Add(this.TabStastics);
            this.TabControlDevs.Controls.Add(this.tabText_Edit);
            this.TabControlDevs.Controls.Add(this.tabSettings);
            this.TabControlDevs.Location = new System.Drawing.Point(12, 12);
            this.TabControlDevs.Name = "TabControlDevs";
            this.TabControlDevs.SelectedIndex = 0;
            this.TabControlDevs.Size = new System.Drawing.Size(782, 644);
            this.TabControlDevs.TabIndex = 0;
            // 
            // TabStastics
            // 
            this.TabStastics.Controls.Add(this.panel1);
            this.TabStastics.Controls.Add(this.panelOpenForms);
            this.TabStastics.Location = new System.Drawing.Point(4, 22);
            this.TabStastics.Name = "TabStastics";
            this.TabStastics.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabStastics.Size = new System.Drawing.Size(774, 618);
            this.TabStastics.TabIndex = 1;
            this.TabStastics.Text = "Statistics";
            this.TabStastics.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefreshGeneralStats);
            this.panel1.Controls.Add(this.lblInteractionsDisp);
            this.panel1.Controls.Add(this.lblInteractions);
            this.panel1.Controls.Add(this.lblUptimeDisp);
            this.panel1.Controls.Add(this.lblUptime);
            this.panel1.Controls.Add(this.lblGeneralStats);
            this.panel1.Location = new System.Drawing.Point(404, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 237);
            this.panel1.TabIndex = 1;
            // 
            // btnRefreshGeneralStats
            // 
            this.btnRefreshGeneralStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefreshGeneralStats.Location = new System.Drawing.Point(286, 211);
            this.btnRefreshGeneralStats.Name = "btnRefreshGeneralStats";
            this.btnRefreshGeneralStats.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshGeneralStats.TabIndex = 6;
            this.btnRefreshGeneralStats.Text = "Refresh";
            this.btnRefreshGeneralStats.UseVisualStyleBackColor = false;
            this.btnRefreshGeneralStats.Click += new System.EventHandler(this.btnRefreshGeneralStats_Click);
            // 
            // lblInteractionsDisp
            // 
            this.lblInteractionsDisp.AutoSize = true;
            this.lblInteractionsDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteractionsDisp.Location = new System.Drawing.Point(157, 95);
            this.lblInteractionsDisp.Name = "lblInteractionsDisp";
            this.lblInteractionsDisp.Size = new System.Drawing.Size(76, 20);
            this.lblInteractionsDisp.TabIndex = 5;
            this.lblInteractionsDisp.Text = "Unknown";
            // 
            // lblInteractions
            // 
            this.lblInteractions.AutoSize = true;
            this.lblInteractions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteractions.Location = new System.Drawing.Point(3, 95);
            this.lblInteractions.Name = "lblInteractions";
            this.lblInteractions.Size = new System.Drawing.Size(97, 20);
            this.lblInteractions.TabIndex = 4;
            this.lblInteractions.Text = "Interactions:";
            // 
            // lblUptimeDisp
            // 
            this.lblUptimeDisp.AutoSize = true;
            this.lblUptimeDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUptimeDisp.Location = new System.Drawing.Point(157, 75);
            this.lblUptimeDisp.Name = "lblUptimeDisp";
            this.lblUptimeDisp.Size = new System.Drawing.Size(76, 20);
            this.lblUptimeDisp.TabIndex = 3;
            this.lblUptimeDisp.Text = "Unknown";
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUptime.Location = new System.Drawing.Point(3, 75);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(64, 20);
            this.lblUptime.TabIndex = 2;
            this.lblUptime.Text = "Uptime:";
            // 
            // lblGeneralStats
            // 
            this.lblGeneralStats.AutoSize = true;
            this.lblGeneralStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralStats.Location = new System.Drawing.Point(3, 3);
            this.lblGeneralStats.Name = "lblGeneralStats";
            this.lblGeneralStats.Size = new System.Drawing.Size(112, 20);
            this.lblGeneralStats.TabIndex = 1;
            this.lblGeneralStats.Text = "General Stats:";
            // 
            // panelOpenForms
            // 
            this.panelOpenForms.Controls.Add(this.btnRefreshOpenForms);
            this.panelOpenForms.Controls.Add(this.tableLayoutPanelOpenForms);
            this.panelOpenForms.Controls.Add(this.lblOpenFormsCountDisp);
            this.panelOpenForms.Controls.Add(this.lblOpenFormsCount);
            this.panelOpenForms.Location = new System.Drawing.Point(6, 6);
            this.panelOpenForms.Name = "panelOpenForms";
            this.panelOpenForms.Size = new System.Drawing.Size(392, 238);
            this.panelOpenForms.TabIndex = 0;
            // 
            // btnRefreshOpenForms
            // 
            this.btnRefreshOpenForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefreshOpenForms.Location = new System.Drawing.Point(314, 212);
            this.btnRefreshOpenForms.Name = "btnRefreshOpenForms";
            this.btnRefreshOpenForms.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshOpenForms.TabIndex = 3;
            this.btnRefreshOpenForms.Text = "Refresh";
            this.btnRefreshOpenForms.UseVisualStyleBackColor = false;
            this.btnRefreshOpenForms.Click += new System.EventHandler(this.btnRefreshOpenForms_Click);
            // 
            // tableLayoutPanelOpenForms
            // 
            this.tableLayoutPanelOpenForms.AutoScroll = true;
            this.tableLayoutPanelOpenForms.ColumnCount = 1;
            this.tableLayoutPanelOpenForms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOpenForms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOpenForms.Location = new System.Drawing.Point(5, 24);
            this.tableLayoutPanelOpenForms.Name = "tableLayoutPanelOpenForms";
            this.tableLayoutPanelOpenForms.RowCount = 1;
            this.tableLayoutPanelOpenForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanelOpenForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanelOpenForms.Size = new System.Drawing.Size(384, 182);
            this.tableLayoutPanelOpenForms.TabIndex = 2;
            // 
            // lblOpenFormsCountDisp
            // 
            this.lblOpenFormsCountDisp.AutoSize = true;
            this.lblOpenFormsCountDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenFormsCountDisp.Location = new System.Drawing.Point(155, 1);
            this.lblOpenFormsCountDisp.Name = "lblOpenFormsCountDisp";
            this.lblOpenFormsCountDisp.Size = new System.Drawing.Size(76, 20);
            this.lblOpenFormsCountDisp.TabIndex = 1;
            this.lblOpenFormsCountDisp.Text = "Unknown";
            // 
            // lblOpenFormsCount
            // 
            this.lblOpenFormsCount.AutoSize = true;
            this.lblOpenFormsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenFormsCount.Location = new System.Drawing.Point(1, 1);
            this.lblOpenFormsCount.Name = "lblOpenFormsCount";
            this.lblOpenFormsCount.Size = new System.Drawing.Size(148, 20);
            this.lblOpenFormsCount.TabIndex = 0;
            this.lblOpenFormsCount.Text = "Open Forms Count:";
            // 
            // tabText_Edit
            // 
            this.tabText_Edit.Controls.Add(this.btnReadCSV);
            this.tabText_Edit.Controls.Add(this.btnGenerateTextCSV);
            this.tabText_Edit.Controls.Add(this.btnEditTextApply);
            this.tabText_Edit.Controls.Add(this.btnEditTextRefresh);
            this.tabText_Edit.Controls.Add(this.tableLayoutDevEditText);
            this.tabText_Edit.Location = new System.Drawing.Point(4, 22);
            this.tabText_Edit.Name = "tabText_Edit";
            this.tabText_Edit.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabText_Edit.Size = new System.Drawing.Size(774, 618);
            this.tabText_Edit.TabIndex = 0;
            this.tabText_Edit.Text = "Edit Text";
            this.tabText_Edit.UseVisualStyleBackColor = true;
            // 
            // btnReadCSV
            // 
            this.btnReadCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReadCSV.Location = new System.Drawing.Point(109, 595);
            this.btnReadCSV.Name = "btnReadCSV";
            this.btnReadCSV.Size = new System.Drawing.Size(100, 23);
            this.btnReadCSV.TabIndex = 4;
            this.btnReadCSV.Text = "Read CSV";
            this.btnReadCSV.UseVisualStyleBackColor = false;
            this.btnReadCSV.Click += new System.EventHandler(this.btnReadCSV_Click);
            // 
            // btnGenerateTextCSV
            // 
            this.btnGenerateTextCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerateTextCSV.Location = new System.Drawing.Point(3, 594);
            this.btnGenerateTextCSV.Name = "btnGenerateTextCSV";
            this.btnGenerateTextCSV.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateTextCSV.TabIndex = 3;
            this.btnGenerateTextCSV.Text = "Generate CSV";
            this.btnGenerateTextCSV.UseVisualStyleBackColor = false;
            this.btnGenerateTextCSV.Click += new System.EventHandler(this.btnGenerateTextCSV_Click);
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
            this.tableLayoutDevEditText.Location = new System.Drawing.Point(7, 3);
            this.tableLayoutDevEditText.Name = "tableLayoutDevEditText";
            this.tableLayoutDevEditText.RowCount = 1;
            this.tableLayoutDevEditText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.801653F));
            this.tableLayoutDevEditText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.19835F));
            this.tableLayoutDevEditText.Size = new System.Drawing.Size(761, 576);
            this.tableLayoutDevEditText.TabIndex = 0;
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
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.cbBtnBackVisible);
            this.tabSettings.Controls.Add(this.lblBtnBackVisible);
            this.tabSettings.Controls.Add(this.tbTabDebounce);
            this.tabSettings.Controls.Add(this.lblTabDebounce);
            this.tabSettings.Controls.Add(this.tbTabTimeout);
            this.tabSettings.Controls.Add(this.lblTabTimeout);
            this.tabSettings.Controls.Add(this.btnApplyDevSettings);
            this.tabSettings.Controls.Add(this.btnRefreshDevSettings);
            this.tabSettings.Controls.Add(this.tbFontSizeOffset);
            this.tabSettings.Controls.Add(this.lblFontSizeOffset);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(774, 618);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tbTabDebounce
            // 
            this.tbTabDebounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTabDebounce.Location = new System.Drawing.Point(155, 52);
            this.tbTabDebounce.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbTabDebounce.Name = "tbTabDebounce";
            this.tbTabDebounce.Size = new System.Drawing.Size(73, 24);
            this.tbTabDebounce.TabIndex = 11;
            this.tbTabDebounce.Text = "Unknown";
            this.tbTabDebounce.TextChanged += new System.EventHandler(this.tbTabDebounce_TextChanged);
            // 
            // lblTabDebounce
            // 
            this.lblTabDebounce.AutoSize = true;
            this.lblTabDebounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabDebounce.Location = new System.Drawing.Point(1, 54);
            this.lblTabDebounce.Name = "lblTabDebounce";
            this.lblTabDebounce.Size = new System.Drawing.Size(114, 20);
            this.lblTabDebounce.TabIndex = 10;
            this.lblTabDebounce.Text = "Tab Debounce";
            // 
            // tbTabTimeout
            // 
            this.tbTabTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTabTimeout.Location = new System.Drawing.Point(157, 26);
            this.tbTabTimeout.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbTabTimeout.Name = "tbTabTimeout";
            this.tbTabTimeout.Size = new System.Drawing.Size(73, 24);
            this.tbTabTimeout.TabIndex = 9;
            this.tbTabTimeout.Text = "Unknown";
            this.tbTabTimeout.TextChanged += new System.EventHandler(this.tbTabTimeout_TextChanged);
            // 
            // lblTabTimeout
            // 
            this.lblTabTimeout.AutoSize = true;
            this.lblTabTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabTimeout.Location = new System.Drawing.Point(3, 27);
            this.lblTabTimeout.Name = "lblTabTimeout";
            this.lblTabTimeout.Size = new System.Drawing.Size(97, 20);
            this.lblTabTimeout.TabIndex = 8;
            this.lblTabTimeout.Text = "Tab Timeout";
            // 
            // btnApplyDevSettings
            // 
            this.btnApplyDevSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnApplyDevSettings.Location = new System.Drawing.Point(615, 592);
            this.btnApplyDevSettings.Name = "btnApplyDevSettings";
            this.btnApplyDevSettings.Size = new System.Drawing.Size(75, 23);
            this.btnApplyDevSettings.TabIndex = 7;
            this.btnApplyDevSettings.Text = "Apply";
            this.btnApplyDevSettings.UseVisualStyleBackColor = false;
            this.btnApplyDevSettings.Click += new System.EventHandler(this.btnApplyDevSettings_Click);
            // 
            // btnRefreshDevSettings
            // 
            this.btnRefreshDevSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefreshDevSettings.Location = new System.Drawing.Point(696, 592);
            this.btnRefreshDevSettings.Name = "btnRefreshDevSettings";
            this.btnRefreshDevSettings.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshDevSettings.TabIndex = 6;
            this.btnRefreshDevSettings.Text = "Refresh";
            this.btnRefreshDevSettings.UseVisualStyleBackColor = false;
            this.btnRefreshDevSettings.Click += new System.EventHandler(this.btnRefreshDevSettings_Click);
            // 
            // tbFontSizeOffset
            // 
            this.tbFontSizeOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFontSizeOffset.Location = new System.Drawing.Point(155, 0);
            this.tbFontSizeOffset.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbFontSizeOffset.Name = "tbFontSizeOffset";
            this.tbFontSizeOffset.Size = new System.Drawing.Size(73, 24);
            this.tbFontSizeOffset.TabIndex = 5;
            this.tbFontSizeOffset.Text = "Unknown";
            this.tbFontSizeOffset.TextChanged += new System.EventHandler(this.tbFontSizeOffset_TextChanged);
            // 
            // lblFontSizeOffset
            // 
            this.lblFontSizeOffset.AutoSize = true;
            this.lblFontSizeOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSizeOffset.Location = new System.Drawing.Point(1, 1);
            this.lblFontSizeOffset.Name = "lblFontSizeOffset";
            this.lblFontSizeOffset.Size = new System.Drawing.Size(129, 20);
            this.lblFontSizeOffset.TabIndex = 4;
            this.lblFontSizeOffset.Text = "Font Size Offset:";
            // 
            // lblBtnBackVisible
            // 
            this.lblBtnBackVisible.AutoSize = true;
            this.lblBtnBackVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnBackVisible.Location = new System.Drawing.Point(3, 80);
            this.lblBtnBackVisible.Name = "lblBtnBackVisible";
            this.lblBtnBackVisible.Size = new System.Drawing.Size(97, 20);
            this.lblBtnBackVisible.TabIndex = 12;
            this.lblBtnBackVisible.Text = "Back Button";
            // 
            // cbBtnBackVisible
            // 
            this.cbBtnBackVisible.AutoSize = true;
            this.cbBtnBackVisible.Checked = true;
            this.cbBtnBackVisible.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbBtnBackVisible.Location = new System.Drawing.Point(157, 85);
            this.cbBtnBackVisible.Name = "cbBtnBackVisible";
            this.cbBtnBackVisible.Size = new System.Drawing.Size(15, 14);
            this.cbBtnBackVisible.TabIndex = 13;
            this.cbBtnBackVisible.UseVisualStyleBackColor = true;
            // 
            // Dev_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 669);
            this.Controls.Add(this.TabControlDevs);
            this.Name = "Dev_Tools";
            this.Text = "Dev_Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dev_Tools_FormClosing);
            this.TabControlDevs.ResumeLayout(false);
            this.TabStastics.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOpenForms.ResumeLayout(false);
            this.panelOpenForms.PerformLayout();
            this.tabText_Edit.ResumeLayout(false);
            this.tableLayoutDevEditText.ResumeLayout(false);
            this.tableLayoutDevEditText.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlDevs;
        private System.Windows.Forms.TabPage tabText_Edit;
        private System.Windows.Forms.TabPage TabStastics;
        private DoubleBufferedTableLayout tableLayoutDevEditText;
        private System.Windows.Forms.Label lblEditTextRomanian;
        private System.Windows.Forms.Label lblEditTextEnglish;
        private System.Windows.Forms.Label lblEditTextControlName;
        private System.Windows.Forms.Button btnEditTextRefresh;
        private System.Windows.Forms.Button btnEditTextApply;
        private System.Windows.Forms.Button btnGenerateTextCSV;
        private System.Windows.Forms.Button btnReadCSV;
        private System.Windows.Forms.Panel panelOpenForms;
        private System.Windows.Forms.Label lblOpenFormsCountDisp;
        private System.Windows.Forms.Label lblOpenFormsCount;
        private DoubleBufferedTableLayout tableLayoutPanelOpenForms;
        private System.Windows.Forms.Button btnRefreshOpenForms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGeneralStats;
        private System.Windows.Forms.Button btnRefreshGeneralStats;
        private System.Windows.Forms.Label lblInteractionsDisp;
        private System.Windows.Forms.Label lblInteractions;
        private System.Windows.Forms.Label lblUptimeDisp;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label lblFontSizeOffset;
        private System.Windows.Forms.TextBox tbFontSizeOffset;
        private System.Windows.Forms.Button btnApplyDevSettings;
        private System.Windows.Forms.Button btnRefreshDevSettings;
        private System.Windows.Forms.TextBox tbTabDebounce;
        private System.Windows.Forms.Label lblTabDebounce;
        private System.Windows.Forms.TextBox tbTabTimeout;
        private System.Windows.Forms.Label lblTabTimeout;
        private System.Windows.Forms.Label lblBtnBackVisible;
        private System.Windows.Forms.CheckBox cbBtnBackVisible;
    }
}