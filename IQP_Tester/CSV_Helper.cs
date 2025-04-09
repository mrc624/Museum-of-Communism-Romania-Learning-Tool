using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    public class CSV_Helper
    {

        TextManager textManager;

        public CSV_Helper(TextManager textManager)
        {
            this.textManager = textManager;
        }

        public const string CSV_REFORMATTED_NAME = "text_manager.csv";
        public const int NUM_CONTROL_COLS = 1;
        public const int CONTROL_POSITION = 0;
        public const int ENGLISH_POSITION = 1;
        public const int ROMANIAN_POSITION = 2;
        public const int ADJUST_FOR_HEADER = 1;
        public const int INVALID_LENGTH = 0;
        public const int NUM_ITEMS_IN_TEXT_CSV = 3;

        public List<CSV> cSVs = new List<CSV>();

        public CSV Create_CSV_From_Reformatted(Dictionary<string, Dictionary<string, string>> reformatted, List<string> header)
        {
            List<string> controls = reformatted.Keys.ToList();

            CSV csv = new CSV(CSV_REFORMATTED_NAME);
            csv.Add(header);
            for (int i = 0; i < controls.Count; i++)
            {
                List<string> items = new List<string>();
                items.Add(controls[i]);
                items.Add(reformatted[controls[i]][textManager.language_to_string[(int)TextManager.Language.English]]);
                items.Add(reformatted[controls[i]][textManager.language_to_string[(int)TextManager.Language.Romanian]]);
                csv.Add(items);
            }
            csv.Generate();
            return csv;
        }

        public Dictionary<string, Dictionary<string, string>> Get_Reformatted_From_CSV(CSV csv)
        {
            Dictionary<string, Dictionary<string, string>> reformatted = new Dictionary<string, Dictionary<string, string>>();

            for (int i = ADJUST_FOR_HEADER; i < csv.Get_Line_Count(); i++)
            {
                string[] line = csv.Get_Line(i);
                if (line[CONTROL_POSITION].Length > INVALID_LENGTH && line.Length >= NUM_ITEMS_IN_TEXT_CSV)
                {
                    reformatted[line[CONTROL_POSITION]] = new Dictionary<string, string>();
                    reformatted[line[CONTROL_POSITION]][textManager.language_to_string[(int)TextManager.Language.English]] = line[ENGLISH_POSITION];
                    reformatted[line[CONTROL_POSITION]][textManager.language_to_string[(int)TextManager.Language.Romanian]] = line[ROMANIAN_POSITION];
                }
            }
            return reformatted;
        }

        public CSV Get_CSV(string file_name)
        {
            CSV csv = new CSV(file_name);
            if(csv.Update())
            {
                return csv;
            }
            else
            {
                return null;
            }
        }
    }
}
