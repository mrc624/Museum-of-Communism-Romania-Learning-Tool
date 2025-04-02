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


        public int CONTROL_NAME_COLUMN = 0;
        public int ENGLISH_COLUMN = 1;
        public int ROMANIAN_COLUMN = 2;
        public int ROWS_TO_SKIP = 1;

        public string CONTROL_NAME = "control";
        public string ROMANIAN_NAME = "Rom";
        public string ENGLISH_NAME = "Eng";

        public TableLayoutPanelCellBorderStyle LOADING = TableLayoutPanelCellBorderStyle.None;
        public TableLayoutPanelCellBorderStyle LOADED = TableLayoutPanelCellBorderStyle.Single;

        private void Fill_EditText_Table()
        {
            Dictionary<string, Dictionary<string, string>> reformatted = Get_Reformatted_Dictionary();

            List<string> controls = reformatted.Keys.ToList();

            tableLayoutDevEditText.CellBorderStyle = LOADING;

            for (int i = 0; i < controls.Count; i++)
            {
                tableLayoutDevEditText.RowCount++;
                int row = i + ROWS_TO_SKIP;

                string control_name = controls[i];
                Label control = tableLayout_Helper.Get_Standard_Label(control_name, CONTROL_NAME + i.ToString());
                tableLayoutDevEditText.Controls.Add(control, CONTROL_NAME_COLUMN, row);
                
                string english_text = reformatted[control_name][textManager.language_to_string[(int)TextManager.Language.English]];
                int eng_width = tableLayoutDevEditText.GetColumnWidths()[ENGLISH_COLUMN];
                TextBox english = tableLayout_Helper.Get_Textbox(english_text, ENGLISH_NAME + i.ToString(), eng_width);
                tableLayoutDevEditText.Controls.Add(english, ENGLISH_COLUMN, row);

                string romanian_text = reformatted[control_name][textManager.language_to_string[(int)TextManager.Language.Romanian]];
                int rom_width = tableLayoutDevEditText.GetColumnWidths()[ROMANIAN_COLUMN];
                TextBox romanian = tableLayout_Helper.Get_Textbox(romanian_text, ROMANIAN_NAME + i.ToString(), rom_width);
                tableLayoutDevEditText.Controls.Add(romanian, ROMANIAN_COLUMN, row);
                
            }
            tableLayout_Helper.Set_Row_Heights(tableLayoutDevEditText);
            tableLayoutDevEditText.CellBorderStyle = LOADED;
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
                for (int j = 0; j < names.Count; j++)
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

        private void btnEditTextApply_Click(object sender, EventArgs e)
        {

        }

        private void btnEditTextRefresh_Click(object sender, EventArgs e)
        {
            textManager.Update_Text();
            Fill_EditText_Table();
        }
    }
}
