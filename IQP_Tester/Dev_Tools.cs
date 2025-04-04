﻿using System;
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

namespace IQP_Tester
{
    public partial class Dev_Tools : Form
    {
        TextManager textManager;
        TableLayout_Helper tableLayout_Helper = new TableLayout_Helper();
        public Dev_Tools(TextManager textManager)
        {
            InitializeComponent();
            this.textManager = textManager;
        }

        Dictionary<string, Dictionary<string, string>> Reformatted;

        public int CONTROL_NAME_COLUMN = 0;
        public int ENGLISH_COLUMN = 1;
        public int ROMANIAN_COLUMN = 2;
        public int ROWS_TO_SKIP = 1;
        public int HEADER_ROW = 0;

        public string CONTROL_NAME = "control";
        public string ROMANIAN_NAME = "Rom";
        public string ENGLISH_NAME = "Eng";

        public string HEADER_CONTROL_TEXT = "Control Name";
        public string HEADER_ENGLISH_TEXT = "English";
        public string HEADER_ROMANIAN_TEXT = "Romanian";

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
                TextBox english = tableLayout_Helper.Get_Textbox(english_text, ENGLISH_NAME + i.ToString(), eng_width);
                tableLayoutDevEditText.Controls.Add(english, ENGLISH_COLUMN, row);
                english.TextChanged += EditText_TextChanged;

                string romanian_text = reformatted[control_name][textManager.language_to_string[(int)TextManager.Language.Romanian]];
                int rom_width = tableLayoutDevEditText.GetColumnWidths()[ROMANIAN_COLUMN];
                TextBox romanian = tableLayout_Helper.Get_Textbox(romanian_text, ROMANIAN_NAME + i.ToString(), rom_width);
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
            Dictionary<string, Dictionary<string, string>> reformatted = Put_Table_Into_Reformatted_Dictionary();
            Dictionary<string, Dictionary<string, string>> text = Convert_Reformatted(reformatted);
            if (text != null)
            {
                textManager.Overwrite_JSON(text, TextManager.TEXT_MANAGER_FILE_NAME);
            }
            btnEditTextRefresh_Click(this, new EventArgs());
        }

        private void btnEditTextRefresh_Click(object sender, EventArgs e)
        {
            textManager.Update_Text();
            Empty_EditText_Table();
            Fill_EditText_Table();
        }
    }
}
