using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace IQP_Tester
{
    public class CSV
    {

        public const string COMMA = ",";
        public const string NEWLINE = "\n";
        public const string DOUBLE_QUOTES = "\"";
        public const string DOUBLE_QUOTES_UNICODE = "\u0022";

        public string file_name;
        private List<string> text;

        public CSV(string name)
        {
            file_name = name;
            text = new List<string>();
        }

        public void Add(string[] items)
        {
            text.Add(Format_For_CSV(items));
        }

        public void Add(List<string> items)
        {
            text.Add(Format_For_CSV(items));
        }

        public const int NUM_COPIES = 2;

        public void Add(List<string> items, int row)
        {
            text.Insert(row, Format_For_CSV(items));
        }

        public void Add(string[] items, int row)
        {
            text.Insert(row, Format_For_CSV(items));
        }

        private string Format_For_CSV(List<string> items)
        {
            string text_add = "";
            for (int i = 0; i < items.Count; i++)
            {
                text_add += DOUBLE_QUOTES + Preserve_Special_Characters(items[i]) + DOUBLE_QUOTES + COMMA;
            }
            text_add += NEWLINE;
            return text_add;
        }

        private string Format_For_CSV(string[] items)
        {
            string text_add = "";
            for (int i = 0; i < items.Length; i++)
            {
                text_add += DOUBLE_QUOTES + Preserve_Special_Characters(items[i]) + DOUBLE_QUOTES + COMMA;
            }
            text_add += NEWLINE;
            return text_add;
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
            for (int i = 0; i < text.Count; i++)
            {
                text_write += text[i];
            }
            try
            {
                File.WriteAllText(file_name, text_write, System.Text.Encoding.UTF8);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writting to CSV file\nFile may be open by another application\n\n\n" + e);
            }
        }
    }
}
