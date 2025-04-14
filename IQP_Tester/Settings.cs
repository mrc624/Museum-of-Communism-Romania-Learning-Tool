using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static IQP_Tester.TextManager;
using System.Windows.Forms;
using System.IO;

namespace IQP_Tester
{
    public class Settings
    {
        public enum Options
        {
            FontOffset
        }

        public string[] Options_To_String =
        {
            "FontOffset"
        };

        public const string FILE_NAME = "Settings.json";
        public const float DEFAULT_FONT_OFFSET = 0;

        Dictionary<string, string> settings;

        public void Generate_JSON(string file_name)
        {
            if (File.Exists(file_name))
            {
                string json = File.ReadAllText(file_name);
                try
                {
                    settings = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
                }
                catch (Exception ex)
                {
                    DialogResult ans = MessageBox.Show("Error reading Settings JSON\n" + ex);

                    if (ans != DialogResult.None)
                    {
                        Application.Exit();
                    }

                    settings = null;
                }
            }
            else
            {
                settings = new Dictionary<string, string>
                {
                    { Options_To_String[(int)Options.FontOffset], DEFAULT_FONT_OFFSET.ToString() }
                };
            }

            Overwrite_JSON(file_name);
        }

        private void Overwrite_JSON(string file_name)
        {
            string updated = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(file_name, updated, Encoding.UTF8);
        }

        private void Update_Settings(Dictionary<string, string> settings_new)
        {
            settings = settings_new;
        }

        public void Update_Overwrite(Dictionary<string, string> settings_new)
        {
            Update_Settings(settings_new);
            Overwrite_JSON(FILE_NAME);
        }

        public string Get_Option(Options option)
        {
            try
            {
                return settings[Options_To_String[(int)option]];
            }
            catch (Exception ex)
            {
                DialogResult ans = MessageBox.Show("Failed Getting Setting\n" + ex);

                if (ans != DialogResult.None)
                {
                    Application.Exit();
                }

                return null;
            }
        }

        public float Get_Font_Offset()
        {
            return float.Parse(Get_Option(Options.FontOffset));
        }

        public void Change_Font(float new_font)
        {
            settings[Options_To_String[(int)Options.FontOffset]] = new_font.ToString();
            Overwrite_JSON(FILE_NAME);
        }

    }
}
