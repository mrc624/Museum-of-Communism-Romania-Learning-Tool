namespace MOCR
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
            this.lblOpenFormsCountDisp = new System.Windows.Forms.Label();
            this.lblOpenFormsCount = new System.Windows.Forms.Label();
            this.tabText_Edit = new System.Windows.Forms.TabPage();
            this.btnReadCSV = new System.Windows.Forms.Button();
            this.btnGenerateTextCSV = new System.Windows.Forms.Button();
            this.btnEditTextApply = new System.Windows.Forms.Button();
            this.btnEditTextRefresh = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnExportFeedback = new System.Windows.Forms.Button();
            this.cbFeedback = new System.Windows.Forms.CheckBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.tbFadeIncrement = new System.Windows.Forms.TextBox();
            this.lblFadeIncrement = new System.Windows.Forms.Label();
            this.tbFadeInterval = new System.Windows.Forms.TextBox();
            this.lblFadeInterval = new System.Windows.Forms.Label();
            this.cbBtnBackVisible = new System.Windows.Forms.CheckBox();
            this.lblBtnBackVisible = new System.Windows.Forms.Label();
            this.tbTabDebounce = new System.Windows.Forms.TextBox();
            this.lblTabDebounce = new System.Windows.Forms.Label();
            this.tbTabTimeout = new System.Windows.Forms.TextBox();
            this.lblTabTimeout = new System.Windows.Forms.Label();
            this.btnApplyDevSettings = new System.Windows.Forms.Button();
            this.btnRefreshDevSettings = new System.Windows.Forms.Button();
            this.tbFontSizeOffset = new System.Windows.Forms.TextBox();
            this.lblFontSizeOffset = new System.Windows.Forms.Label();
            this.lblFontFamily = new System.Windows.Forms.Label();
            this.cbFontFamily = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelOpenForms = new MOCR.DoubleBufferedTableLayout(this.components);
            this.tableLayoutDevEditText = new MOCR.DoubleBufferedTableLayout(this.components);
            this.lblEditTextRomanian = new System.Windows.Forms.Label();
            this.lblEditTextEnglish = new System.Windows.Forms.Label();
            this.lblEditTextControlName = new System.Windows.Forms.Label();
            this.TabControlDevs.SuspendLayout();
            this.TabStastics.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOpenForms.SuspendLayout();
            this.tabText_Edit.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tableLayoutDevEditText.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlDevs
            // 
            this.TabControlDevs.Controls.Add(this.TabStastics);
            this.TabControlDevs.Controls.Add(this.tabText_Edit);
            this.TabControlDevs.Controls.Add(this.tabSettings);
            this.TabControlDevs.Location = new System.Drawing.Point(32, 29);
            this.TabControlDevs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TabControlDevs.Name = "TabControlDevs";
            this.TabControlDevs.SelectedIndex = 0;
            this.TabControlDevs.Size = new System.Drawing.Size(2085, 1536);
            this.TabControlDevs.TabIndex = 0;
            // 
            // TabStastics
            // 
            this.TabStastics.Controls.Add(this.panel1);
            this.TabStastics.Controls.Add(this.panelOpenForms);
            this.TabStastics.Location = new System.Drawing.Point(10, 48);
            this.TabStastics.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TabStastics.Name = "TabStastics";
            this.TabStastics.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TabStastics.Size = new System.Drawing.Size(2065, 1478);
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
            this.panel1.Location = new System.Drawing.Point(1077, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 565);
            this.panel1.TabIndex = 1;
            // 
            // btnRefreshGeneralStats
            // 
            this.btnRefreshGeneralStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefreshGeneralStats.Location = new System.Drawing.Point(763, 503);
            this.btnRefreshGeneralStats.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRefreshGeneralStats.Name = "btnRefreshGeneralStats";
            this.btnRefreshGeneralStats.Size = new System.Drawing.Size(200, 55);
            this.btnRefreshGeneralStats.TabIndex = 6;
            this.btnRefreshGeneralStats.Text = "Refresh";
            this.btnRefreshGeneralStats.UseVisualStyleBackColor = false;
            this.btnRefreshGeneralStats.Click += new System.EventHandler(this.btnRefreshGeneralStats_Click);
            // 
            // lblInteractionsDisp
            // 
            this.lblInteractionsDisp.AutoSize = true;
            this.lblInteractionsDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteractionsDisp.Location = new System.Drawing.Point(419, 227);
            this.lblInteractionsDisp.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblInteractionsDisp.Name = "lblInteractionsDisp";
            this.lblInteractionsDisp.Size = new System.Drawing.Size(187, 46);
            this.lblInteractionsDisp.TabIndex = 5;
            this.lblInteractionsDisp.Text = "Unknown";
            // 
            // lblInteractions
            // 
            this.lblInteractions.AutoSize = true;
            this.lblInteractions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteractions.Location = new System.Drawing.Point(8, 227);
            this.lblInteractions.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblInteractions.Name = "lblInteractions";
            this.lblInteractions.Size = new System.Drawing.Size(237, 46);
            this.lblInteractions.TabIndex = 4;
            this.lblInteractions.Text = "Interactions:";
            // 
            // lblUptimeDisp
            // 
            this.lblUptimeDisp.AutoSize = true;
            this.lblUptimeDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUptimeDisp.Location = new System.Drawing.Point(419, 179);
            this.lblUptimeDisp.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUptimeDisp.Name = "lblUptimeDisp";
            this.lblUptimeDisp.Size = new System.Drawing.Size(187, 46);
            this.lblUptimeDisp.TabIndex = 3;
            this.lblUptimeDisp.Text = "Unknown";
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUptime.Location = new System.Drawing.Point(8, 179);
            this.lblUptime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(157, 46);
            this.lblUptime.TabIndex = 2;
            this.lblUptime.Text = "Uptime:";
            // 
            // lblGeneralStats
            // 
            this.lblGeneralStats.AutoSize = true;
            this.lblGeneralStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralStats.Location = new System.Drawing.Point(8, 7);
            this.lblGeneralStats.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGeneralStats.Name = "lblGeneralStats";
            this.lblGeneralStats.Size = new System.Drawing.Size(274, 46);
            this.lblGeneralStats.TabIndex = 1;
            this.lblGeneralStats.Text = "General Stats:";
            // 
            // panelOpenForms
            // 
            this.panelOpenForms.Controls.Add(this.btnRefreshOpenForms);
            this.panelOpenForms.Controls.Add(this.tableLayoutPanelOpenForms);
            this.panelOpenForms.Controls.Add(this.lblOpenFormsCountDisp);
            this.panelOpenForms.Controls.Add(this.lblOpenFormsCount);
            this.panelOpenForms.Location = new System.Drawing.Point(16, 14);
            this.panelOpenForms.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelOpenForms.Name = "panelOpenForms";
            this.panelOpenForms.Size = new System.Drawing.Size(1045, 568);
            this.panelOpenForms.TabIndex = 0;
            // 
            // btnRefreshOpenForms
            // 
            this.btnRefreshOpenForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefreshOpenForms.Location = new System.Drawing.Point(837, 506);
            this.btnRefreshOpenForms.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRefreshOpenForms.Name = "btnRefreshOpenForms";
            this.btnRefreshOpenForms.Size = new System.Drawing.Size(200, 55);
            this.btnRefreshOpenForms.TabIndex = 3;
            this.btnRefreshOpenForms.Text = "Refresh";
            this.btnRefreshOpenForms.UseVisualStyleBackColor = false;
            this.btnRefreshOpenForms.Click += new System.EventHandler(this.btnRefreshOpenForms_Click);
            // 
            // lblOpenFormsCountDisp
            // 
            this.lblOpenFormsCountDisp.AutoSize = true;
            this.lblOpenFormsCountDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenFormsCountDisp.Location = new System.Drawing.Point(413, 2);
            this.lblOpenFormsCountDisp.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblOpenFormsCountDisp.Name = "lblOpenFormsCountDisp";
            this.lblOpenFormsCountDisp.Size = new System.Drawing.Size(187, 46);
            this.lblOpenFormsCountDisp.TabIndex = 1;
            this.lblOpenFormsCountDisp.Text = "Unknown";
            // 
            // lblOpenFormsCount
            // 
            this.lblOpenFormsCount.AutoSize = true;
            this.lblOpenFormsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenFormsCount.Location = new System.Drawing.Point(3, 2);
            this.lblOpenFormsCount.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblOpenFormsCount.Name = "lblOpenFormsCount";
            this.lblOpenFormsCount.Size = new System.Drawing.Size(370, 46);
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
            this.tabText_Edit.Location = new System.Drawing.Point(10, 48);
            this.tabText_Edit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabText_Edit.Name = "tabText_Edit";
            this.tabText_Edit.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabText_Edit.Size = new System.Drawing.Size(2065, 1478);
            this.tabText_Edit.TabIndex = 0;
            this.tabText_Edit.Text = "Edit Text";
            this.tabText_Edit.UseVisualStyleBackColor = true;
            // 
            // btnReadCSV
            // 
            this.btnReadCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReadCSV.Location = new System.Drawing.Point(291, 1419);
            this.btnReadCSV.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnReadCSV.Name = "btnReadCSV";
            this.btnReadCSV.Size = new System.Drawing.Size(267, 55);
            this.btnReadCSV.TabIndex = 4;
            this.btnReadCSV.Text = "Read CSV";
            this.btnReadCSV.UseVisualStyleBackColor = false;
            this.btnReadCSV.Click += new System.EventHandler(this.btnReadCSV_Click);
            // 
            // btnGenerateTextCSV
            // 
            this.btnGenerateTextCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerateTextCSV.Location = new System.Drawing.Point(8, 1416);
            this.btnGenerateTextCSV.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnGenerateTextCSV.Name = "btnGenerateTextCSV";
            this.btnGenerateTextCSV.Size = new System.Drawing.Size(267, 55);
            this.btnGenerateTextCSV.TabIndex = 3;
            this.btnGenerateTextCSV.Text = "Generate CSV";
            this.btnGenerateTextCSV.UseVisualStyleBackColor = false;
            this.btnGenerateTextCSV.Click += new System.EventHandler(this.btnGenerateTextCSV_Click);
            // 
            // btnEditTextApply
            // 
            this.btnEditTextApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditTextApply.Location = new System.Drawing.Point(1632, 1405);
            this.btnEditTextApply.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEditTextApply.Name = "btnEditTextApply";
            this.btnEditTextApply.Size = new System.Drawing.Size(200, 55);
            this.btnEditTextApply.TabIndex = 2;
            this.btnEditTextApply.Text = "Apply";
            this.btnEditTextApply.UseVisualStyleBackColor = false;
            this.btnEditTextApply.Click += new System.EventHandler(this.btnEditTextApply_Click);
            // 
            // btnEditTextRefresh
            // 
            this.btnEditTextRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditTextRefresh.Location = new System.Drawing.Point(1848, 1405);
            this.btnEditTextRefresh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEditTextRefresh.Name = "btnEditTextRefresh";
            this.btnEditTextRefresh.Size = new System.Drawing.Size(200, 55);
            this.btnEditTextRefresh.TabIndex = 1;
            this.btnEditTextRefresh.Text = "Refresh";
            this.btnEditTextRefresh.UseVisualStyleBackColor = false;
            this.btnEditTextRefresh.Click += new System.EventHandler(this.btnEditTextRefresh_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.cbFontFamily);
            this.tabSettings.Controls.Add(this.lblFontFamily);
            this.tabSettings.Controls.Add(this.btnExportFeedback);
            this.tabSettings.Controls.Add(this.cbFeedback);
            this.tabSettings.Controls.Add(this.lblFeedback);
            this.tabSettings.Controls.Add(this.btnDefault);
            this.tabSettings.Controls.Add(this.tbFadeIncrement);
            this.tabSettings.Controls.Add(this.lblFadeIncrement);
            this.tabSettings.Controls.Add(this.tbFadeInterval);
            this.tabSettings.Controls.Add(this.lblFadeInterval);
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
            this.tabSettings.Location = new System.Drawing.Point(10, 48);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(2065, 1478);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnExportFeedback
            // 
            this.btnExportFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExportFeedback.Location = new System.Drawing.Point(469, 384);
            this.btnExportFeedback.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnExportFeedback.Name = "btnExportFeedback";
            this.btnExportFeedback.Size = new System.Drawing.Size(267, 55);
            this.btnExportFeedback.TabIndex = 21;
            this.btnExportFeedback.Text = "Export Feedback";
            this.btnExportFeedback.UseVisualStyleBackColor = false;
            this.btnExportFeedback.Click += new System.EventHandler(this.btnExportFeedback_Click);
            // 
            // cbFeedback
            // 
            this.cbFeedback.AutoSize = true;
            this.cbFeedback.Checked = true;
            this.cbFeedback.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbFeedback.Location = new System.Drawing.Point(419, 396);
            this.cbFeedback.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbFeedback.Name = "cbFeedback";
            this.cbFeedback.Size = new System.Drawing.Size(34, 33);
            this.cbFeedback.TabIndex = 20;
            this.cbFeedback.UseVisualStyleBackColor = true;
            this.cbFeedback.CheckStateChanged += new System.EventHandler(this.cbFeedback_CheckStateChanged);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(8, 384);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(195, 46);
            this.lblFeedback.TabIndex = 19;
            this.lblFeedback.Text = "Feedback";
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDefault.Location = new System.Drawing.Point(8, 1412);
            this.btnDefault.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(200, 55);
            this.btnDefault.TabIndex = 18;
            this.btnDefault.Text = "Defaults";
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // tbFadeIncrement
            // 
            this.tbFadeIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFadeIncrement.Location = new System.Drawing.Point(419, 308);
            this.tbFadeIncrement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFadeIncrement.Name = "tbFadeIncrement";
            this.tbFadeIncrement.Size = new System.Drawing.Size(188, 50);
            this.tbFadeIncrement.TabIndex = 17;
            this.tbFadeIncrement.Text = "Unknown";
            this.tbFadeIncrement.TextChanged += new System.EventHandler(this.tbFadeIncrement_TextChanged);
            // 
            // lblFadeIncrement
            // 
            this.lblFadeIncrement.AutoSize = true;
            this.lblFadeIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFadeIncrement.Location = new System.Drawing.Point(8, 312);
            this.lblFadeIncrement.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFadeIncrement.Name = "lblFadeIncrement";
            this.lblFadeIncrement.Size = new System.Drawing.Size(297, 46);
            this.lblFadeIncrement.TabIndex = 16;
            this.lblFadeIncrement.Text = "Fade Increment";
            // 
            // tbFadeInterval
            // 
            this.tbFadeInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFadeInterval.Location = new System.Drawing.Point(419, 246);
            this.tbFadeInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFadeInterval.Name = "tbFadeInterval";
            this.tbFadeInterval.Size = new System.Drawing.Size(188, 50);
            this.tbFadeInterval.TabIndex = 15;
            this.tbFadeInterval.Text = "Unknown";
            this.tbFadeInterval.TextChanged += new System.EventHandler(this.tbFadeInterval_TextChanged);
            // 
            // lblFadeInterval
            // 
            this.lblFadeInterval.AutoSize = true;
            this.lblFadeInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFadeInterval.Location = new System.Drawing.Point(8, 250);
            this.lblFadeInterval.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFadeInterval.Name = "lblFadeInterval";
            this.lblFadeInterval.Size = new System.Drawing.Size(249, 46);
            this.lblFadeInterval.TabIndex = 14;
            this.lblFadeInterval.Text = "Fade Interval";
            // 
            // cbBtnBackVisible
            // 
            this.cbBtnBackVisible.AutoSize = true;
            this.cbBtnBackVisible.Checked = true;
            this.cbBtnBackVisible.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbBtnBackVisible.Location = new System.Drawing.Point(419, 203);
            this.cbBtnBackVisible.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbBtnBackVisible.Name = "cbBtnBackVisible";
            this.cbBtnBackVisible.Size = new System.Drawing.Size(34, 33);
            this.cbBtnBackVisible.TabIndex = 13;
            this.cbBtnBackVisible.UseVisualStyleBackColor = true;
            this.cbBtnBackVisible.CheckStateChanged += new System.EventHandler(this.cbBtnBackVisible_CheckStateChanged);
            // 
            // lblBtnBackVisible
            // 
            this.lblBtnBackVisible.AutoSize = true;
            this.lblBtnBackVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnBackVisible.Location = new System.Drawing.Point(8, 191);
            this.lblBtnBackVisible.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBtnBackVisible.Name = "lblBtnBackVisible";
            this.lblBtnBackVisible.Size = new System.Drawing.Size(237, 46);
            this.lblBtnBackVisible.TabIndex = 12;
            this.lblBtnBackVisible.Text = "Back Button";
            // 
            // tbTabDebounce
            // 
            this.tbTabDebounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTabDebounce.Location = new System.Drawing.Point(413, 124);
            this.tbTabDebounce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTabDebounce.Name = "tbTabDebounce";
            this.tbTabDebounce.Size = new System.Drawing.Size(188, 50);
            this.tbTabDebounce.TabIndex = 11;
            this.tbTabDebounce.Text = "Unknown";
            this.tbTabDebounce.TextChanged += new System.EventHandler(this.tbTabDebounce_TextChanged);
            // 
            // lblTabDebounce
            // 
            this.lblTabDebounce.AutoSize = true;
            this.lblTabDebounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabDebounce.Location = new System.Drawing.Point(3, 129);
            this.lblTabDebounce.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTabDebounce.Name = "lblTabDebounce";
            this.lblTabDebounce.Size = new System.Drawing.Size(282, 46);
            this.lblTabDebounce.TabIndex = 10;
            this.lblTabDebounce.Text = "Tab Debounce";
            // 
            // tbTabTimeout
            // 
            this.tbTabTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTabTimeout.Location = new System.Drawing.Point(419, 62);
            this.tbTabTimeout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTabTimeout.Name = "tbTabTimeout";
            this.tbTabTimeout.Size = new System.Drawing.Size(188, 50);
            this.tbTabTimeout.TabIndex = 9;
            this.tbTabTimeout.Text = "Unknown";
            this.tbTabTimeout.TextChanged += new System.EventHandler(this.tbTabTimeout_TextChanged);
            // 
            // lblTabTimeout
            // 
            this.lblTabTimeout.AutoSize = true;
            this.lblTabTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabTimeout.Location = new System.Drawing.Point(8, 64);
            this.lblTabTimeout.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTabTimeout.Name = "lblTabTimeout";
            this.lblTabTimeout.Size = new System.Drawing.Size(243, 46);
            this.lblTabTimeout.TabIndex = 8;
            this.lblTabTimeout.Text = "Tab Timeout";
            // 
            // btnApplyDevSettings
            // 
            this.btnApplyDevSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnApplyDevSettings.Location = new System.Drawing.Point(1640, 1412);
            this.btnApplyDevSettings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnApplyDevSettings.Name = "btnApplyDevSettings";
            this.btnApplyDevSettings.Size = new System.Drawing.Size(200, 55);
            this.btnApplyDevSettings.TabIndex = 7;
            this.btnApplyDevSettings.Text = "Apply";
            this.btnApplyDevSettings.UseVisualStyleBackColor = false;
            this.btnApplyDevSettings.Click += new System.EventHandler(this.btnApplyDevSettings_Click);
            // 
            // btnRefreshDevSettings
            // 
            this.btnRefreshDevSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefreshDevSettings.Location = new System.Drawing.Point(1856, 1412);
            this.btnRefreshDevSettings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRefreshDevSettings.Name = "btnRefreshDevSettings";
            this.btnRefreshDevSettings.Size = new System.Drawing.Size(200, 55);
            this.btnRefreshDevSettings.TabIndex = 6;
            this.btnRefreshDevSettings.Text = "Refresh";
            this.btnRefreshDevSettings.UseVisualStyleBackColor = false;
            this.btnRefreshDevSettings.Click += new System.EventHandler(this.btnRefreshDevSettings_Click);
            // 
            // tbFontSizeOffset
            // 
            this.tbFontSizeOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFontSizeOffset.Location = new System.Drawing.Point(413, 0);
            this.tbFontSizeOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFontSizeOffset.Name = "tbFontSizeOffset";
            this.tbFontSizeOffset.Size = new System.Drawing.Size(188, 50);
            this.tbFontSizeOffset.TabIndex = 5;
            this.tbFontSizeOffset.Text = "Unknown";
            this.tbFontSizeOffset.TextChanged += new System.EventHandler(this.tbFontSizeOffset_TextChanged);
            // 
            // lblFontSizeOffset
            // 
            this.lblFontSizeOffset.AutoSize = true;
            this.lblFontSizeOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSizeOffset.Location = new System.Drawing.Point(3, 2);
            this.lblFontSizeOffset.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFontSizeOffset.Name = "lblFontSizeOffset";
            this.lblFontSizeOffset.Size = new System.Drawing.Size(306, 46);
            this.lblFontSizeOffset.TabIndex = 4;
            this.lblFontSizeOffset.Text = "Font Size Offset";
            // 
            // lblFontFamily
            // 
            this.lblFontFamily.AutoSize = true;
            this.lblFontFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontFamily.Location = new System.Drawing.Point(2, 452);
            this.lblFontFamily.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFontFamily.Name = "lblFontFamily";
            this.lblFontFamily.Size = new System.Drawing.Size(228, 46);
            this.lblFontFamily.TabIndex = 22;
            this.lblFontFamily.Text = "Font Family";
            // 
            // cbFontFamily
            // 
            this.cbFontFamily.FormattingEnabled = true;
            this.cbFontFamily.Location = new System.Drawing.Point(413, 449);
            this.cbFontFamily.Name = "cbFontFamily";
            this.cbFontFamily.Size = new System.Drawing.Size(601, 39);
            this.cbFontFamily.TabIndex = 23;
            this.cbFontFamily.SelectedIndexChanged += new System.EventHandler(this.cbFontFamily_SelectedIndexChanged);
            // 
            // tableLayoutPanelOpenForms
            // 
            this.tableLayoutPanelOpenForms.AutoScroll = true;
            this.tableLayoutPanelOpenForms.ColumnCount = 1;
            this.tableLayoutPanelOpenForms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOpenForms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOpenForms.Location = new System.Drawing.Point(13, 57);
            this.tableLayoutPanelOpenForms.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanelOpenForms.Name = "tableLayoutPanelOpenForms";
            this.tableLayoutPanelOpenForms.RowCount = 1;
            this.tableLayoutPanelOpenForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanelOpenForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanelOpenForms.Size = new System.Drawing.Size(1024, 434);
            this.tableLayoutPanelOpenForms.TabIndex = 2;
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
            this.tableLayoutDevEditText.Location = new System.Drawing.Point(19, 7);
            this.tableLayoutDevEditText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutDevEditText.Name = "tableLayoutDevEditText";
            this.tableLayoutDevEditText.RowCount = 1;
            this.tableLayoutDevEditText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.801653F));
            this.tableLayoutDevEditText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.19835F));
            this.tableLayoutDevEditText.Size = new System.Drawing.Size(2029, 1374);
            this.tableLayoutDevEditText.TabIndex = 0;
            // 
            // lblEditTextRomanian
            // 
            this.lblEditTextRomanian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditTextRomanian.AutoSize = true;
            this.lblEditTextRomanian.Location = new System.Drawing.Point(1360, 0);
            this.lblEditTextRomanian.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEditTextRomanian.Name = "lblEditTextRomanian";
            this.lblEditTextRomanian.Size = new System.Drawing.Size(661, 32);
            this.lblEditTextRomanian.TabIndex = 2;
            this.lblEditTextRomanian.Text = "Romanian";
            this.lblEditTextRomanian.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEditTextEnglish
            // 
            this.lblEditTextEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditTextEnglish.AutoSize = true;
            this.lblEditTextEnglish.Location = new System.Drawing.Point(684, 0);
            this.lblEditTextEnglish.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEditTextEnglish.Name = "lblEditTextEnglish";
            this.lblEditTextEnglish.Size = new System.Drawing.Size(660, 32);
            this.lblEditTextEnglish.TabIndex = 1;
            this.lblEditTextEnglish.Text = "English";
            this.lblEditTextEnglish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEditTextControlName
            // 
            this.lblEditTextControlName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditTextControlName.AutoSize = true;
            this.lblEditTextControlName.Location = new System.Drawing.Point(8, 0);
            this.lblEditTextControlName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEditTextControlName.Name = "lblEditTextControlName";
            this.lblEditTextControlName.Size = new System.Drawing.Size(660, 32);
            this.lblEditTextControlName.TabIndex = 0;
            this.lblEditTextControlName.Text = "Control Name";
            this.lblEditTextControlName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dev_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2147, 1595);
            this.Controls.Add(this.TabControlDevs);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tableLayoutDevEditText.ResumeLayout(false);
            this.tableLayoutDevEditText.PerformLayout();
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
        private System.Windows.Forms.TextBox tbFadeIncrement;
        private System.Windows.Forms.Label lblFadeIncrement;
        private System.Windows.Forms.TextBox tbFadeInterval;
        private System.Windows.Forms.Label lblFadeInterval;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.CheckBox cbFeedback;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnExportFeedback;
        private System.Windows.Forms.Label lblFontFamily;
        private System.Windows.Forms.ComboBox cbFontFamily;
    }
}