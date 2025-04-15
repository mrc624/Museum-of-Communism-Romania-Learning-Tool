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
        Resize_Helper resize;
        Open_Close_Helper openClose;

        public Settings(Resize_Helper resize, Open_Close_Helper openClose)
        {
            this.resize = resize;
            this.openClose = openClose;
        }

        public enum Options
        {
            FontOffset,
            TabTimeout,
            TabDebounce
        }

        public string[] Options_To_String =
        {
            "FontOffset",
            "TabTimeout",
            "TabDebounce"
        };

        public const string FILE_NAME = "Settings.json";
        public const float DEFAULT_FONT_OFFSET = 0;
        public const uint DEFAULT_TAB_TIMEOUT = 1000; // in 1/10 of seconds, 100 seconds
        public const uint DEFAULT_TAB_DEBOUNCE = 5; // in 1/10 of seconds, 0.5 second
        public const uint NUM_TICKS_IN_SECOND = 10;

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
                    { Options_To_String[(int)Options.FontOffset], DEFAULT_FONT_OFFSET.ToString() },
                    { Options_To_String[(int)Options.TabTimeout], DEFAULT_TAB_TIMEOUT.ToString() },
                    { Options_To_String[(int)Options.TabDebounce], DEFAULT_TAB_DEBOUNCE.ToString() }
                };
            }

            Add_Settings();

            Overwrite_JSON();
            Update_All();
        }

        private void Add_Settings()
        {
            // font offset
            if (!settings.ContainsKey(Options_To_String[(int)Options.FontOffset]))
            {
                settings[Options_To_String[(int)Options.FontOffset]] = DEFAULT_FONT_OFFSET.ToString();
            }

            // tab timeout
            if (!settings.ContainsKey(Options_To_String[(int)Options.TabTimeout]))
            {
                settings[Options_To_String[(int)Options.TabTimeout]] = DEFAULT_TAB_TIMEOUT.ToString();
            }

            // tab debounce
            if (!settings.ContainsKey(Options_To_String[(int)Options.TabDebounce]))
            {
                settings[Options_To_String[(int)Options.TabDebounce]] = DEFAULT_TAB_DEBOUNCE.ToString();
            }
        }

        public void Overwrite_JSON()
        {
            string updated = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FILE_NAME, updated, Encoding.UTF8);
        }

        private void Update_Settings(Dictionary<string, string> settings_new)
        {
            settings = settings_new;
            Update_All();
        }

        public void Update_Overwrite(Dictionary<string, string> settings_new)
        {
            Update_Settings(settings_new);
            Overwrite_JSON();
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

        private void Update_All()
        {
            resize.Update_Font_Offset(Get_Font_Offset());
            openClose.Update_Tab_Timeout(Get_Tab_Timeout());
            openClose.Update_Tab_Debounce(Get_Tab_Debounce());
        }

        public float Get_Font_Offset()
        {
            return float.Parse(Get_Option(Options.FontOffset));
        }

        public void Change_Font(float new_font)
        {
            settings[Options_To_String[(int)Options.FontOffset]] = new_font.ToString();
            resize.Update_Font_Offset(new_font);
        }

        public uint Get_Tab_Timeout()
        {
            return uint.Parse(Get_Option(Options.TabTimeout));
        }

        public void Change_Tab_Timeout(uint timeout)
        {
            settings[Options_To_String[(int)Options.TabTimeout]] = timeout.ToString();
            openClose.Update_Tab_Timeout(timeout);
        }

        public uint Get_Tab_Debounce()
        {
            return uint.Parse(Get_Option(Options.TabDebounce));
        }

        public void Change_Tab_Debounce(uint debounce)
        {
            settings[Options_To_String[(int)Options.TabDebounce]] = debounce.ToString();
            openClose.Update_Tab_Debounce(debounce);
        }
    }
}
