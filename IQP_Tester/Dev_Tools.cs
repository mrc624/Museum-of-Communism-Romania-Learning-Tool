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
            Dictionary<string, Dictionary<string, string>>  reformatted = Get_Reformatted_Dictionary();
            Update_Global_Reformatted(reformatted);

            List<string> controls = reformatted.Keys.ToList();

            tableLayoutDevEditText.CellBorderStyle = LOADING;

            for (int i = 0; i < controls.Count; i++)
            {
                tableLayoutDevEditText.RowCount++;
                int row = i + ROWS_TO_SKIP;
                string control_name = controls[i];
                Label control = tableLayout_Helper.Get_Standard_Label(control_name, control_name);
                tableLayoutDevEditText.Controls.Add(control, CONTROL_NAME_COLUMN, row);
                
                string english_text = reformatted[control_name][textManager.language_to_string[(int)TextManager.Language.English]];
                int eng_width = tableLayoutDevEditText.GetColumnWidths()[ENGLISH_COLUMN];
                TextBox english = tableLayout_Helper.Get_Textbox(english_text, ENGLISH_NAME + i.ToString(), eng_width, AUTO_SIZE);
                tableLayoutDevEditText.Controls.Add(english, ENGLISH_COLUMN, row);
                english.TextChanged += EditText_TextChanged;

                string romanian_text = reformatted[control_name][textManager.language_to_string[(int)TextManager.Language.Romanian]];
                int rom_width = tableLayoutDevEditText.GetColumnWidths()[ROMANIAN_COLUMN];
                TextBox romanian = tableLayout_Helper.Get_Textbox(romanian_text, ROMANIAN_NAME + i.ToString(), rom_width, AUTO_SIZE);
                tableLayoutDevEditText.Controls.Add(romanian, ROMANIAN_COLUMN, row);
                romanian.TextChanged += EditText_TextChanged;
                
            }
            tableLayout_Helper.Set_Row_Heights(tableLayoutDevEditText);
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
            tableLayoutDevEditText.CellBorderStyle = LOADING;
            while (tableLayoutDevEditText.Controls.Count > 0)
            {
                tableLayoutDevEditText.Controls[0].Dispose();
            }
            tableLayoutDevEditText.RowCount = 0;
            Add_Headers();
        }

        private void Add_Headers()
        {
            Label control = tableLayout_Helper.Get_Title_Label(HEADER_CONTROL_TEXT, HEADER_CONTROL_TEXT);
            tableLayoutDevEditText.Controls.Add(control, CONTROL_NAME_COLUMN, HEADER_ROW);

            int eng_width = tableLayoutDevEditText.GetColumnWidths()[ENGLISH_COLUMN];
            Label english = tableLayout_Helper.Get_Title_Label(HEADER_ENGLISH_TEXT, HEADER_ENGLISH_TEXT);
            tableLayoutDevEditText.Controls.Add(english, ENGLISH_COLUMN, HEADER_ROW);

            int rom_width = tableLayoutDevEditText.GetColumnWidths()[ROMANIAN_COLUMN];
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
            Loading load = new Loading("Refreshing Edit Text Table");
            textManager.Update_Text();
            Empty_EditText_Table();
            Fill_EditText_Table();
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
            Add_Headers();
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

        private void Dev_Tools_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            openClose.Close(this);
        }

        private void Fill_Settings()
        {
            tbFontSizeOffset.Text = settings.Get_Font_Offset().ToString();
            tbTabTimeout.Text = settings.Get_Tab_Timeout().ToString();
            tbTabDebounce.Text = settings.Get_Tab_Debounce().ToString();
            cbBtnBackVisible.CheckState = settings.Get_Btn_Back() ? CheckState.Checked : CheckState.Unchecked;
            tbFadeInterval.Text = settings.Get_Fade_Interval().ToString();
            tbFadeIncrement.Text = settings.Get_Fade_Increment().ToString();
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
            if (cbBtnBackVisible.Checked != settings.Get_Btn_Back())
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
    }
}
