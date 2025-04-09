using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace IQP_Tester
{
    public class CSV
    {

        public const string COMMA = ",";
        public const char COMMA_CHAR = ',';
        public static string[] SPLIT_FILE = { ",\n", "\u000A" };
        public const string NEWLINE = "\n";
        public const string QUOTES = "\"";
        public const string DOUBLE_QUOTES = QUOTES + QUOTES;
        public const string DOUBLE_QUOTES_UNICODE = "\u0022";

        public string file_name;
        private List<string> text;

        public CSV(string name)
        {
            file_name = name;
            text = new List<string>();
        }

        public string[] Get_Line(int line_num)
        {
            string line = text[line_num];
            string[] words = line.Split(COMMA_CHAR);
            return Remove_Quotes(words); ;
        }

        private string[] Remove_Quotes(string[] strs)
        {
            string[] new_strs = strs;
            for (int i = 0; i < strs.Length; i++)
            {
                new_strs[i] = Remove_Start_End_Quotation(new_strs[i]);
                new_strs[i] = Remove_Double_Quotes(new_strs[i]);
            }
            return new_strs;
        }

        private string Remove_Start_End_Quotation(string str)
        {
            string new_str = str;
            new_str = new_str.Trim();
            if (new_str.StartsWith(QUOTES))
            {
                new_str = new_str.Substring(QUOTES.Length);
            }
            if (new_str.EndsWith(QUOTES))
            {
                new_str = new_str.Substring(0, new_str.Length - QUOTES.Length);
            }
            return new_str;
        }

        private string Remove_Double_Quotes(string str)
        {
            string new_str = str;
            for (int i = 0; i < new_str.Length - DOUBLE_QUOTES.Length; i++)
            {
                if (new_str.Substring(i, DOUBLE_QUOTES.Length) == DOUBLE_QUOTES)
                {
                    new_str = new_str.Substring(0, i) + new_str.Substring(i + QUOTES.Length);
                }
            }
            return new_str;
        }

        public int Get_Line_Count()
        {
            return text.Count;
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
                text_add += QUOTES + Preserve_Special_Characters(items[i]) + QUOTES + COMMA;
            }
            text_add += NEWLINE;
            return text_add;
        }

        private string Format_For_CSV(string[] items)
        {
            string text_add = "";
            for (int i = 0; i < items.Length; i++)
            {
                text_add += QUOTES + Preserve_Special_Characters(items[i]) + QUOTES + COMMA;
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

        public bool Update()
        {
            try
            {
                string text_read = File.ReadAllText(file_name);
                string[] lines = text_read.Split(SPLIT_FILE, StringSplitOptions.None);
                text.Clear();
                for (int i = 0; i < lines.Length; i++)
                {
                    text.Add(lines[i]);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
