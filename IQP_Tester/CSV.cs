using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IQP_Tester
{
    public class CSV
    {

        public const string COMMA = ",";
        public const string NEWLINE = "\n";
        public const string DOUBLE_QUOTES = "\"";
        public const string DOUBLE_QUOTES_UNICODE = "\u0022";

        public string file_name;
        private int lines = 0;
        private Dictionary<int, string> text;

        public CSV(string name)
        {
            file_name = name;
            text = new Dictionary<int, string>();
        }

        public void Add(string[] items)
        {
            string text_add = "";
            for (int i = 0; i < items.Length; i++)
            {
                text_add += DOUBLE_QUOTES + Preserve_Special_Characters(items[i]) + DOUBLE_QUOTES + COMMA;
            }
            text_add += NEWLINE;
            text[lines] = text_add;
            lines++;
        }

        public void Add(List<string> items)
        {
            string text_add = "";
            for (int i = 0; i < items.Count; i++)
            {
                text_add += DOUBLE_QUOTES + Preserve_Special_Characters(items[i]) + DOUBLE_QUOTES + COMMA;
            }
            text_add += NEWLINE;
            text[lines] = text_add;
            lines++;
        }

        private string Preserve_Special_Characters(string str)
        {
            if (str.Contains("\""))
            {
                string new_str = str.Replace("\"", "\"\"");
                return new_str;
            }
            return str;
        }


        public void Generate()
        {
            string text_write = "";
            for (int i = 0; i < lines; i++)
            {
                text_write += text[i];
            }
            File.WriteAllText(file_name, text_write);
        }
    }
}
