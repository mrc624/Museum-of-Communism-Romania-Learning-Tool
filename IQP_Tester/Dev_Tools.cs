using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IQP_Tester.TextManager;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace IQP_Tester
{
    public partial class Dev_Tools : Form
    {
        TextManager textManager;
        TableLayout_Helper tableLayout_Helper = new TableLayout_Helper();
        CSV_Helper csv_Helper;
        CSV text_csv;
        Open_Close_Helper openClose;
        Settings settings;

        public Dev_Tools(TextManager textManager, Open_Close_Helper openClose, Settings settings)
        {
            InitializeComponent();
            this.textManager = textManager;
            this.openClose = openClose;
            this.settings = settings;
            csv_Helper = new CSV_Helper(textManager);

            btnEditTextApply.Enabled = false;
            btnGenerateTextCSV.Enabled = false;
            btnReadCSV.Enabled = false;

            btnApplyDevSettings.Enabled = false;
        }

        Dictionary<string, Dictionary<string, string>> Reformatted;

        public const int CONTROL_NAME_COLUMN = 0;
        public const int ENGLISH_COLUMN = 1;
        public const int ROMANIAN_COLUMN = 2;
        public const int ROWS_TO_SKIP = 1;
        public const int HEADER_ROW = 0;
        private bool AUTO_SIZE = true;

        public const string CONTROL_NAME = "control";
        public const string ROMANIAN_NAME = "Rom";
        public const string ENGLISH_NAME = "Eng";

        public const string HEADER_CONTROL_TEXT = "Control Name";
        public const string HEADER_ENGLISH_TEXT = "English";
        public const string HEADER_ROMANIAN_TEXT = "Romanian";

        public TableLayoutPanelCellBorderStyle LOADING = TableLayoutPanelCellBorderStyle.None;
        public TableLayoutPanelCellBorderStyle LOADED = TableLayoutPanelCellBorderStyle.Single;

        public const int PICTURE_NAME_COLUMN = 0;
        public const int PICTURE_IMAGE_COLUMN = 1;
        public const int PICTURE_PATH_COLUMN = 2;
        public const int PICTURE_IMPORT_COLUMN = 3;

        public const string PICTURE_NAME_HEADER = "Picture Box Name";
        public const string PICTURE_IMAGE_HEADER = "Image";
        public const string PICTURE_PATH_HEADER = "Image File Path";
        public const string PICTURE_IMPORT_HEADER = "Import Picture";

        public const string PICTURE_NO_IMAGE = "NO IMAGE FOUND";
        public const string IMAGE_FLAG = "img";
        public const string PATH_FLAG = "path";

        // Edit Text Tab

        private void Update_Global_Reformatted(Dictionary<string, Dictionary<string, string>> reformatted)
        {
            if (reformatted != null)
            {
                Reformatted = reformatted;
            }
        }

        private void Fill_EditText_Table()
        {
            tableLayoutDevEditText.Visible = false;
            tableLayoutDevEditText.SuspendLayout();
            Dictionary<string, Dictionary<string, string>>  reformatted = Get_Reformatted_Dictionary();
            Update_Global_Reformatted(reformatted);

            List<string> controls = reformatted.Keys.ToList();

            tableLayoutDevEditText.CellBorderStyle = LOADING;

            string english_key = textManager.language_to_string[(int)TextManager.Language.English];
            string romanian_key = textManager.language_to_string[(int)TextManager.Language.Romanian];
            int eng_width = tableLayoutDevEditText.GetColumnWidths()[ENGLISH_COLUMN];
            int rom_width = tableLayoutDevEditText.GetColumnWidths()[ROMANIAN_COLUMN];
            string control_name = null;
            string english_text = null;
            string romanian_text = null;

            for (int i = 0; i < controls.Count; i++)
            {
                tableLayoutDevEditText.RowCount++;
                int row = i + ROWS_TO_SKIP;
                control_name = controls[i];
                Label control = tableLayout_Helper.Get_Standard_Label(control_name, control_name);
                tableLayoutDevEditText.Controls.Add(control, CONTROL_NAME_COLUMN, row);
                
                english_text = reformatted[control_name][english_key];
                TextBox english = tableLayout_Helper.Get_Textbox(english_text, ENGLISH_NAME + i.ToString(), eng_width, AUTO_SIZE);
                tableLayoutDevEditText.Controls.Add(english, ENGLISH_COLUMN, row);
                english.TextChanged += EditText_TextChanged;

                romanian_text = reformatted[control_name][romanian_key];
                TextBox romanian = tableLayout_Helper.Get_Textbox(romanian_text, ROMANIAN_NAME + i.ToString(), rom_width, AUTO_SIZE);
                tableLayoutDevEditText.Controls.Add(romanian, ROMANIAN_COLUMN, row);
                romanian.TextChanged += EditText_TextChanged;
                
            }
            tableLayout_Helper.Set_Row_Heights(tableLayoutDevEditText);
            tableLayoutDevEditText.ResumeLayout();
            tableLayoutDevEditText.CellBorderStyle = LOADED;
            tableLayoutDevEditText.Visible = true;
        }

        private void EditText_TextChanged(object sender, EventArgs e)
        {
            if (tableLayoutDevEditText.Visible)
            {
                TextBox textBox = (TextBox)sender;
                TableLayoutPanelCellPosition position = tableLayoutDevEditText.GetCellPosition(textBox);

                string control_name = tableLayoutDevEditText.GetControlFromPosition(CONTROL_NAME_COLUMN, position.Row).Name;
                string lang_key = null;
                if (position.Column == ENGLISH_COLUMN)
                {
                    lang_key = textManager.language_to_string[(int)TextManager.Language.English];
                }
                else if (position.Column == ROMANIAN_COLUMN)
                {
                    lang_key = textManager.language_to_string[(int)TextManager.Language.Romanian];
                }
                else
                {
                    return;
                }
                string old_text = Reformatted[control_name][lang_key];

                if (old_text != textBox.Text)
                {
                    textBox.BackColor = Color.Yellow;
                }
                else
                {
                    textBox.BackColor = SystemColors.Window;
                }
            }
        }

        private int Get_Textbox_Name_Number(TableLayoutPanelCellPosition position)
        {
            return position.Column + ROWS_TO_SKIP;
        }

        private void Empty_EditText_Table()
        {
            tableLayoutDevEditText.Visible = false;
            tableLayoutDevEditText.SuspendLayout();
            tableLayoutDevEditText.CellBorderStyle = LOADING;
            while (tableLayoutDevEditText.Controls.Count > 0)
            {
                tableLayoutDevEditText.Controls[0].Dispose();
            }
            tableLayoutDevEditText.RowCount = 0;
            Add_EditText_Headers();
            tableLayoutDevEditText.ResumeLayout();
        }

        private void Add_EditText_Headers()
        {
            Label control = tableLayout_Helper.Get_Title_Label(HEADER_CONTROL_TEXT, HEADER_CONTROL_TEXT);
            tableLayoutDevEditText.Controls.Add(control, CONTROL_NAME_COLUMN, HEADER_ROW);

            Label english = tableLayout_Helper.Get_Title_Label(HEADER_ENGLISH_TEXT, HEADER_ENGLISH_TEXT);
            tableLayoutDevEditText.Controls.Add(english, ENGLISH_COLUMN, HEADER_ROW);

            Label romanian = tableLayout_Helper.Get_Title_Label(HEADER_ROMANIAN_TEXT, HEADER_ROMANIAN_TEXT);
            tableLayoutDevEditText.Controls.Add(romanian, ROMANIAN_COLUMN, HEADER_ROW);
        }

        private Dictionary<string, Dictionary<string, string>> Get_Reformatted_Dictionary()
        {
            Dictionary<string, Dictionary<string, string>> text = textManager.Get_Text_Dictionary();

            Dictionary<string, Dictionary<string, string>> reformatted = new Dictionary<string, Dictionary<string, string>>();

            List<string> languages = text.Keys.ToList();
            for (int i = 0; i < text.Count; i++)
            {
                Dictionary<string, string> controls = text[languages[i]];
                List<string> names = controls.Keys.ToList();
                for (int j = 0; j < names.Count; j++) // count is amount of keys that have dictionaries corresponding with them
                {
                    string control_name = names[j];
                    string control_text = controls[control_name];

                    if (!reformatted.ContainsKey(control_name))
                    {
                        reformatted[control_name] = new Dictionary<string, string>();
                    }

                    reformatted[control_name][languages[i]] = control_text;
                }
            }
            return reformatted;
        }

        private Dictionary<string, Dictionary<string, string>> Convert_Reformatted(Dictionary<string, Dictionary<string, string>> reformatted)
        {
            Dictionary<string, Dictionary<string, string>> text = new Dictionary<string, Dictionary<string, string>>();

            List<string> control_names = reformatted.Keys.ToList();
            for (int i = 0; i < control_names.Count; i++)
            {
                Dictionary<string, string> languages = reformatted[control_names[i]];
                List<string> language = languages.Keys.ToList();
                for (int j = 0; j < language.Count; j++) // count is amount of keys that have dictionaries corresponding with them
                {
                    string lang = language[j];
                    string control_text = languages[lang];

                    if (!text.ContainsKey(lang))
                    {
                        text[lang] = new Dictionary<string, string>();
                    }

                    text[lang][control_names[i]] = control_text;
                }
            }
            return text;
        }

        private Dictionary<string, Dictionary<string, string>> Put_Table_Into_Reformatted_Dictionary()
        {
            Dictionary<string, Dictionary<string, string>> reformatted = new Dictionary<string, Dictionary<string, string>>();

            for (int i = ROWS_TO_SKIP; i < tableLayoutDevEditText.RowCount; i++)
            {
                Control control = tableLayoutDevEditText.GetControlFromPosition(CONTROL_NAME_COLUMN, i);
                Control english = tableLayoutDevEditText.GetControlFromPosition(ENGLISH_COLUMN, i);
                Control romanian = tableLayoutDevEditText.GetControlFromPosition(ROMANIAN_COLUMN, i);
                reformatted[control.Name] = new Dictionary<string, string>();
                reformatted[control.Name][textManager.language_to_string[(int)TextManager.Language.English]] = english.Text;
                reformatted[control.Name][textManager.language_to_string[(int)TextManager.Language.Romanian]] = romanian.Text;
            }
            return reformatted;
        }

        private void btnEditTextApply_Click(object sender, EventArgs e)
        {
            Loading load = new Loading("Applying Text");
            Dictionary<string, Dictionary<string, string>> reformatted = Put_Table_Into_Reformatted_Dictionary();
            Dictionary<string, Dictionary<string, string>> text = Convert_Reformatted(reformatted);
            if (text != null)
            {
                textManager.Overwrite_JSON(text, TextManager.TEXT_MANAGER_FILE_NAME);
            }
            load.Close();
            btnEditTextRefresh_Click(this, new EventArgs());
        }

        private void btnEditTextRefresh_Click(object sender, EventArgs e)
        {
            Loading load = new Loading("Refreshing Text Manager");
            textManager.Update_Text();
            load.Update_Text("Emptying Text Table");
            Empty_EditText_Table();
            load.Update_Text("Filling Text Table");
            Fill_EditText_Table();
            load.Update_Text("Enabling Buttons");
            btnEditTextApply.Enabled = true;
            btnGenerateTextCSV.Enabled = true;
            btnReadCSV.Enabled = true;
            load.Close();
        }

        private void btnGenerateTextCSV_Click(object sender, EventArgs e)
        {
            Loading load = new Loading("Generating CSV File");
            Dictionary<string, Dictionary<string, string>> reformatted = Get_Reformatted_Dictionary();
            List<string> header = new List<string> { HEADER_CONTROL_TEXT, HEADER_ENGLISH_TEXT, HEADER_ROMANIAN_TEXT };
            text_csv = csv_Helper.Create_CSV_From_Reformatted(reformatted, header);
            text_csv.Generate();
            load.Update_Text("Getting Location");
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export Text Manager";
            save.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            save.DefaultExt = "csv";
            save.FileName = "text_manager.csv";
            load.Update_Text("Exporing to Location");
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(text_csv.file_name, save.FileName, true);
                    MessageBox.Show("File Exported!\nFile at " + save.FileName);
                    load.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Exporting File\nError:\n" + ex);
                    load.Close();
                }
            }
            else if (save.ShowDialog() != DialogResult.None)
            {
                load.Close();
            }
        }

        private void btnReadCSV_Click(object sender, EventArgs e)
        {
            Loading load = new Loading("Generating CSV File");
            if (text_csv == null)
            {
                text_csv = csv_Helper.Get_CSV(CSV_Helper.CSV_REFORMATTED_NAME);
                if (text_csv == null) // CSV has not yet been created
                {
                    Dictionary<string, Dictionary<string, string>> reff = Get_Reformatted_Dictionary();
                    List<string> head = new List<string> { HEADER_CONTROL_TEXT, HEADER_ENGLISH_TEXT, HEADER_ROMANIAN_TEXT };
                    text_csv = csv_Helper.Create_CSV_From_Reformatted(reff, head);
                }
            }
            load.Update_Text("Getting File");
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Upload Text Manager";
            open.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    load.Update_Text("Saving File");
                    File.Copy(open.FileName, text_csv.file_name, true);
                    text_csv.Update();
                    Dictionary<string, Dictionary<string, string>> reformatted = csv_Helper.Get_Reformatted_From_CSV(text_csv);
                    Dictionary<string, Dictionary<string, string>> text = Convert_Reformatted(reformatted);
                    textManager.Overwrite_JSON(text, TextManager.TEXT_MANAGER_FILE_NAME);
                    load.Close();
                    btnEditTextRefresh_Click(this, new EventArgs());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Saving File\nError:\n" + ex);
                    load.Close();
                }
            }
            else if (open.ShowDialog() != DialogResult.None)
            {
                load.Close();
            }
        }

        // Stats Tab

        private void btnRefreshOpenForms_Click(object sender, EventArgs e)
        {
            lblOpenFormsCountDisp.Text = System.Windows.Forms.Application.OpenForms.Count.ToString();
            Empty_OpenForms_Table();
            Fill_OpenForms_Table();
        }

        private void Fill_OpenForms_Table()
        {
            tableLayoutPanelOpenForms.Visible = false;

            for (int i = 0; i < System.Windows.Forms.Application.OpenForms.Count; i++)
            {
                tableLayoutPanelOpenForms.RowCount++;
                string control_name = System.Windows.Forms.Application.OpenForms[i].Name;
                Label control = tableLayout_Helper.Get_Standard_Label(control_name, control_name + i.ToString());
                tableLayoutPanelOpenForms.Controls.Add(control, CONTROL_NAME_COLUMN, i);
            }
            tableLayout_Helper.Set_Row_Heights(tableLayoutPanelOpenForms);
            tableLayoutPanelOpenForms.CellBorderStyle = LOADED;
            tableLayoutPanelOpenForms.Visible = true;
        }

        private void Empty_OpenForms_Table()
        {
            tableLayoutPanelOpenForms.Visible = false;
            tableLayoutPanelOpenForms.CellBorderStyle = LOADING;
            while (tableLayoutPanelOpenForms.Controls.Count > 0)
            {
                tableLayoutPanelOpenForms.Controls[0].Dispose();
            }
            tableLayoutPanelOpenForms.RowCount = 0;
        }

        private void Fill_General_Stats()
        {
            lblUptimeDisp.Text = openClose.Get_Seconds().ToString();
            lblInteractionsDisp.Text = openClose.Get_Interactions().ToString();
        }

        private void btnRefreshGeneralStats_Click(object sender, EventArgs e)
        {
            Fill_General_Stats();
        }

        // Settings Tab

        private void Fill_Settings()
        {
            tbFontSizeOffset.Text = settings.Get_Font_Offset().ToString();
            tbTabTimeout.Text = settings.Get_Tab_Timeout().ToString();
            tbTabDebounce.Text = settings.Get_Tab_Debounce().ToString();
            cbBtnBackVisible.CheckState = Settings.btn_back_state ? CheckState.Checked : CheckState.Unchecked;
            tbFadeInterval.Text = settings.Get_Fade_Interval().ToString();
            tbFadeIncrement.Text = settings.Get_Fade_Increment().ToString();
            cbFeedback.CheckState = settings.Get_Feedback() ? CheckState.Checked : CheckState.Unchecked;
            cbFontFamily.Items.Clear();
            for (int i = 0; i < FontFamily.Families.Count(); i++)
            {
                cbFontFamily.Items.Add(FontFamily.Families[i].Name);
            }
            cbFontFamily.SelectedIndex = cbFontFamily.Items.IndexOf(Settings.Font_Family.Name);
        }

        private void Apply_Settings()
        {
            if (tbFontSizeOffset.BackColor == Color.Yellow)
            {
                settings.Change_Font(float.Parse(tbFontSizeOffset.Text));
                tbFontSizeOffset.BackColor = SystemColors.Control;
            }
            if (tbTabTimeout.BackColor == Color.Yellow)
            {
                settings.Change_Tab_Timeout(uint.Parse(tbTabTimeout.Text));
                tbTabTimeout.BackColor = SystemColors.Control;
            }
            if (tbTabDebounce.BackColor == Color.Yellow)
            {
                settings.Change_Tab_Debounce(uint.Parse(tbTabDebounce.Text));
                tbTabDebounce.BackColor = SystemColors.Control;
            }
            if (cbBtnBackVisible.BackColor == Color.Yellow)
            {
                settings.Change_Btn_Back(cbBtnBackVisible.Checked);
                cbBtnBackVisible.BackColor = SystemColors.Control;
            }
            if (tbFadeInterval.BackColor == Color.Yellow)
            {
                settings.Change_Fade_Interval(int.Parse(tbFadeInterval.Text));
                tbFadeInterval.BackColor = SystemColors.Control;
            }
            if (tbFadeIncrement.BackColor == Color.Yellow)
            {
                settings.Change_Fade_Increment(double.Parse(tbFadeIncrement.Text));
                tbFadeIncrement.BackColor = SystemColors.Control;
            }
            if (cbFeedback.BackColor == Color.Yellow)
            {
                settings.Change_Feedback(cbFeedback.Checked);
                cbFeedback.BackColor = SystemColors.Control;
            }
            if (cbFontFamily.BackColor == Color.Yellow)
            {
                settings.Change_Font_Family(FontFamily.Families[cbFontFamily.SelectedIndex]);
                cbFontFamily.BackColor = SystemColors.Control;
            }

            settings.Overwrite_JSON();
        }

        private void tbFontSizeOffset_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(tbFontSizeOffset.Text, out float value))
            {
                if (value != settings.Get_Font_Offset())
                {
                    tbFontSizeOffset.BackColor = Color.Yellow;
                }
                else
                {
                    tbFontSizeOffset.BackColor = SystemColors.Control;
                }
            }
            else
            {
                tbFontSizeOffset.BackColor = Color.Red;
            }
        }

        private void tbTabTimeout_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(tbTabTimeout.Text, out uint value))
            {   
                if (value != settings.Get_Tab_Timeout())
                {
                    tbTabTimeout.BackColor = Color.Yellow;
                }   
                else
                {
                    tbTabTimeout.BackColor = SystemColors.Control;
                }
            }
            else
            {
                tbTabTimeout.BackColor = Color.Red;
            }
        }

        private void tbTabDebounce_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(tbTabDebounce.Text, out uint value))
            {
                if (value != settings.Get_Tab_Debounce())
                {
                    tbTabDebounce.BackColor = Color.Yellow;
                }
                else
                {
                    tbTabDebounce.BackColor = SystemColors.Control;
                }
            }
            else
            {
                tbTabDebounce.BackColor = Color.Red;
            }
        }

        private void cbBtnBackVisible_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbBtnBackVisible.Checked != Settings.btn_back_state)
            {
                cbBtnBackVisible.BackColor = Color.Yellow;
            }
            else
            {
                cbBtnBackVisible.BackColor= SystemColors.Control;
            }
        }

        private void tbFadeInterval_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbFadeInterval.Text, out int value))
            {
                if (value != settings.Get_Fade_Interval())
                {
                    tbFadeInterval.BackColor = Color.Yellow;
                }
                else
                {
                    tbFadeInterval.BackColor = SystemColors.Control;
                }
            }
            else
            {
                tbFadeInterval.BackColor = Color.Red;
            }
        }

        private void tbFadeIncrement_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbFadeIncrement.Text, out double value))
            {
                if (value != settings.Get_Fade_Increment())
                {
                    tbFadeIncrement.BackColor = Color.Yellow;
                }
                else
                {
                    tbFadeIncrement.BackColor = SystemColors.Control;
                }
            }
            else
            {
                tbFadeIncrement.BackColor = Color.Red;
            }
        }

        private void cbFeedback_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbFeedback.Checked != settings.Get_Feedback())
            {
                cbFeedback.BackColor = Color.Yellow;
            }
            else
            {
                cbFeedback.BackColor = SystemColors.Control;
            }
        }

        private void btnApplyDevSettings_Click(object sender, EventArgs e)
        {
            Apply_Settings();
            Fill_Settings();
        }

        private void btnRefreshDevSettings_Click(object sender, EventArgs e)
        {
            Fill_Settings();
            if (!btnApplyDevSettings.Enabled)
            {
                btnApplyDevSettings.Enabled = true;
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            settings.Reset_To_Defaults();
            Fill_Settings();
        }

        private void btnExportFeedback_Click(object sender, EventArgs e)
        {
            Loading load = new Loading("Generating CSV File");
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export Feedback";
            save.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            save.DefaultExt = "csv";
            save.FileName = "feedback.csv";
            load.Update_Text("Exporing to Location");
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(Feedback.FEEDBACK_FILE_NAME, save.FileName, true);
                    MessageBox.Show("File Exported!\nFile at " + save.FileName);
                    load.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Exporting File\nError:\n" + ex);
                    load.Close();
                }
            }
            else if (save.ShowDialog() != DialogResult.None)
            {
                load.Close();
            }
        }

        private void cbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily font = FontFamily.Families[cbFontFamily.SelectedIndex];
            if (FontFamily.Families[cbFontFamily.SelectedIndex].Name == Settings.Font_Family.Name)
            {
                cbFontFamily.BackColor = SystemColors.Control;
            }
            else
            {
                cbFontFamily.BackColor = Color.Yellow;
            }
        }

        // Picture Management Tab

        private void btnRefreshImageManagement_Click(object sender, EventArgs e)
        {
            Loading load = new Loading("Refreshing Picture Table");

            load.Update_Text("Emptying Image Table");
            Empty_Image_Management_Table();
            tableLayoutImageManagement.Visible = true;
            load.Update_Text("Filling Image Table");
            Fill_Image_Management_Table();
            load.Update_Text("Enabling Buttons");
            btnEditTextApply.Enabled = true;
            btnGenerateTextCSV.Enabled = true;
            btnReadCSV.Enabled = true;
            load.Close();
        }

        private void btnApplyImageManagement_Click(object sender, EventArgs e)
        {
            Dictionary < string, string> New_Images = Main.image_Manager.Images;
            for (int i = ROWS_TO_SKIP; i < tableLayoutImageManagement.RowCount; i++)
            {
                Control control = tableLayoutImageManagement.GetControlFromPosition(PICTURE_PATH_COLUMN, i);
                if (control is TextBox)
                { 
                    if (control.BackColor == Color.Yellow)
                    {
                        TextBox tb = (TextBox)control;
                        string name = tableLayoutImageManagement.GetControlFromPosition(PICTURE_NAME_COLUMN, i).Text;
                        New_Images[name] = tb.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Error: TextBox Expected\nNo Textbox at Row " + i + "\nIn Image Management Table");
                }
            }
            Main.image_Manager.Overwrite_Images(New_Images);
            btnRefreshImageManagement_Click(sender, e);
        }

        private void Empty_Image_Management_Table()
        {
            tableLayoutImageManagement.Visible = false;
            tableLayoutImageManagement.SuspendLayout();
            tableLayoutImageManagement.CellBorderStyle = LOADING;
            while (tableLayoutImageManagement.Controls.Count > 0)
            {
                if (tableLayoutImageManagement.Controls[0] is PictureBox pb)
                {
                    pb.Image.Dispose();
                    pb.Image = null;
                }
                tableLayoutImageManagement.Controls[0].Dispose();
            }
            tableLayoutImageManagement.RowCount = 0;
            Add_Image_Management_Headers();
            tableLayoutImageManagement.ResumeLayout();
        }

        private void Add_Image_Management_Headers()
        {
            Label pb_name = tableLayout_Helper.Get_Title_Label(PICTURE_NAME_HEADER, PICTURE_NAME_HEADER);
            tableLayoutImageManagement.Controls.Add(pb_name, PICTURE_NAME_COLUMN, HEADER_ROW);
            
            Label image = tableLayout_Helper.Get_Title_Label(PICTURE_IMAGE_HEADER, PICTURE_IMAGE_HEADER);
            tableLayoutImageManagement.Controls.Add(image, PICTURE_IMAGE_COLUMN, HEADER_ROW);

            Label path = tableLayout_Helper.Get_Title_Label(PICTURE_PATH_HEADER, PICTURE_PATH_HEADER);
            tableLayoutImageManagement.Controls.Add(path, PICTURE_PATH_COLUMN, HEADER_ROW);

            Label import = tableLayout_Helper.Get_Title_Label(PICTURE_IMPORT_HEADER, PICTURE_IMPORT_HEADER);
            tableLayoutImageManagement.Controls.Add(import, PICTURE_IMPORT_COLUMN, HEADER_ROW);
        }


        private void Fill_Image_Management_Table()
        {
            tableLayoutImageManagement.Visible = false;
            tableLayoutImageManagement.SuspendLayout();

            List<string> pb_names = Main.image_Manager.Images.Keys.ToList();

            tableLayoutImageManagement.CellBorderStyle = LOADING;

            string pb_name = null;
            int path_width = tableLayoutImageManagement.GetColumnWidths()[PICTURE_PATH_COLUMN];
            Label name;
            PictureBox pb;
            TextBox path;
            Label no_image;

            for (int i = 0; i < pb_names.Count; i++)
            {
                tableLayoutImageManagement.RowCount++;
                int row = i + ROWS_TO_SKIP;

                pb_name = pb_names[i];
                name = tableLayout_Helper.Get_Standard_Label(pb_name, pb_name);
                tableLayoutImageManagement.Controls.Add(name, PICTURE_NAME_COLUMN, row);

                if (File.Exists(Main.image_Manager.Images[pb_name]))
                {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(Main.image_Manager.Images[pb_name]);
                    pb = tableLayout_Helper.Get_PictureBox(image, IMAGE_FLAG + pb_names[i]);
                    tableLayoutImageManagement.Controls.Add(pb, PICTURE_IMAGE_COLUMN, row);

                    path = tableLayout_Helper.Get_Textbox(Main.image_Manager.Images[pb_name], PATH_FLAG + pb_names[i], path_width, AUTO_SIZE);
                    path.TextChanged += Image_Management_Path_TextChanged;
                    path.BackColor = SystemColors.Window;
                    tableLayoutImageManagement.Controls.Add(path, PICTURE_PATH_COLUMN, row);
                }
                else
                {
                    no_image = tableLayout_Helper.Get_Standard_Label(PICTURE_NO_IMAGE, PICTURE_NO_IMAGE);
                    tableLayoutImageManagement.Controls.Add(no_image, PICTURE_IMAGE_COLUMN, row);

                    path = tableLayout_Helper.Get_Textbox(PICTURE_NO_IMAGE, PATH_FLAG + pb_names[i], path_width, AUTO_SIZE);
                    path.TextChanged += Image_Management_Path_TextChanged;
                    path.BackColor = Color.Red;
                    tableLayoutImageManagement.Controls.Add(path, PICTURE_PATH_COLUMN, row);
                }
            }
            tableLayout_Helper.Set_Row_Heights(tableLayoutImageManagement);
            tableLayoutImageManagement.ResumeLayout();
            tableLayoutImageManagement.CellBorderStyle = LOADED;
            tableLayoutImageManagement.Visible = true;
        }

        private void Image_Management_Path_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox tb = (TextBox)sender;

                if (File.Exists(tb.Text) && System.Drawing.Image.FromFile(tb.Text) != null)
                {
                    string name = tableLayoutImageManagement.GetControlFromPosition(PICTURE_NAME_COLUMN, tableLayoutImageManagement.GetCellPosition(tb).Row).Text;

                    if (Main.image_Manager.Images[name] != tb.Text)
                    {
                        tb.BackColor = Color.Yellow;
                    }
                    else
                    {
                        tb.BackColor = SystemColors.Window;
                    }
                }
                else
                {
                    tb.BackColor = Color.Red;
                }
            }
        }

        // General Page Things

        private void Dev_Tools_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            openClose.Close(this);
        }
    }
}
