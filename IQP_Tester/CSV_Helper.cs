using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
        public List<CSV> cSVs = new List<CSV>();

        public void Create_CSV_From_Reformatted(Dictionary<string, Dictionary<string, string>> reformatted)
        {
            List<string> controls = reformatted.Keys.ToList();

            CSV csv = new CSV(CSV_REFORMATTED_NAME);

            for (int i = 0; i < controls.Count; i++)
            {
                List<string> items = new List<string>();
                items.Add(controls[i]);

                items.Add(reformatted[controls[i]][textManager.language_to_string[(int)TextManager.Language.English]]);

                items.Add(reformatted[controls[i]][textManager.language_to_string[(int)TextManager.Language.Romanian]]);

                csv.Add(items);
            }
            csv.Generate();
        }
    }
}
