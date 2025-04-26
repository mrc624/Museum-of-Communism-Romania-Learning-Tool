using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static IQP_Tester.TextManager;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Drawing;

namespace IQP_Tester
{
    public class Settings
    {
        Resize_Helper resize;
        Open_Close_Helper openClose;
        Main main;

        public Settings(Resize_Helper resize, Open_Close_Helper openClose, Main main)
        {
            this.resize = resize;
            this.openClose = openClose;
            this.main = main;
        }

        public enum Options
        {
            FontOffset,
            TabTimeout,
            TabDebounce,
            btnBack,
            fadeInterval,
            fadeIncrement,
            feedback,
            fontFamily
        }

        public string[] Options_To_String =
        {
            "FontOffset",
            "TabTimeout",
            "TabDebounce",
            "btnBack",
            "fadeInterval",
            "fadeIncrement",
            "feedback",
            "fontFamily"
        };

        public const string FILE_NAME = "Settings.json";
        public const float DEFAULT_FONT_OFFSET = 0;
        public const uint DEFAULT_TAB_TIMEOUT = 1000; // in 1/10 of seconds, 100 seconds
        public const uint DEFAULT_TAB_DEBOUNCE = 5; // in 1/10 of seconds, 0.5 second
        public const uint NUM_TICKS_IN_SECOND = 10;
        public const bool DEFAULT_BTN_BACK = false;
        public const int DEFAULT_FADE_INTERVAL = 10;
        public const double DEFAULT_FADE_INCREMENT = 0.05;
        public const bool DEFAULT_FEEDBACK_BTN = true;
        public static FontFamily DEFAULT_FONT_FAMILY { get; protected set; } = new FontFamily("Microsoft Sans Serif");
        public const bool DEFAULT_RAM_SAVER = true;

        public static bool btn_back_state = DEFAULT_BTN_BACK;
        public static float Font_Offset = DEFAULT_FONT_OFFSET;
        public static FontFamily Font_Family = DEFAULT_FONT_FAMILY;
        public static bool Ram_Saver = DEFAULT_RAM_SAVER;

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
                    { Options_To_String[(int)Options.TabDebounce], DEFAULT_TAB_DEBOUNCE.ToString() },
                    { Options_To_String[(int)Options.btnBack], DEFAULT_BTN_BACK.ToString() },
                    { Options_To_String[(int)Options.fadeInterval], DEFAULT_FADE_INTERVAL.ToString() },
                    { Options_To_String[(int)Options.fadeIncrement], DEFAULT_FADE_INCREMENT.ToString() },
                    { Options_To_String[(int)Options.feedback], DEFAULT_FEEDBACK_BTN.ToString() },
                    { Options_To_String[(int)Options.fontFamily], DEFAULT_FONT_FAMILY.ToString() }
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

            // btn back
            if (!settings.ContainsKey(Options_To_String[(int)Options.btnBack]))
            {
                settings[Options_To_String[(int)Options.btnBack]] = DEFAULT_BTN_BACK.ToString();
            }

            // fade interval
            if (!settings.ContainsKey(Options_To_String[(int)Options.fadeInterval]))
            {
                settings[Options_To_String[(int)Options.fadeInterval]] = DEFAULT_FADE_INTERVAL.ToString();
            }

            // fade increment
            if (!settings.ContainsKey(Options_To_String[(int)Options.fadeIncrement]))
            {
                settings[Options_To_String[(int)Options.fadeIncrement]] = DEFAULT_FADE_INCREMENT.ToString();
            }

            // feedback
            if (!settings.ContainsKey(Options_To_String[(int)Options.feedback]))
            {
                settings[Options_To_String[(int)Options.feedback]] = DEFAULT_FEEDBACK_BTN.ToString();
            }

            // font family
            if (!settings.ContainsKey(Options_To_String[(int)Options.fontFamily]))
            {
                settings[Options_To_String[(int)Options.fontFamily]] = DEFAULT_FONT_FAMILY.ToString();
            }
        }

        public void Reset_To_Defaults()
        {
            settings[Options_To_String[(int)Options.FontOffset]] = DEFAULT_FONT_OFFSET.ToString();
            settings[Options_To_String[(int)Options.TabTimeout]] = DEFAULT_TAB_TIMEOUT.ToString();
            settings[Options_To_String[(int)Options.TabDebounce]] = DEFAULT_TAB_DEBOUNCE.ToString();
            settings[Options_To_String[(int)Options.btnBack]] = DEFAULT_BTN_BACK.ToString();
            settings[Options_To_String[(int)Options.fadeInterval]] = DEFAULT_FADE_INTERVAL.ToString();
            settings[Options_To_String[(int)Options.fadeIncrement]] = DEFAULT_FADE_INCREMENT.ToString();
            settings[Options_To_String[(int)Options.feedback]] = DEFAULT_FEEDBACK_BTN.ToString();
            settings[Options_To_String[(int)Options.fontFamily]] = DEFAULT_FONT_FAMILY.ToString();
            Overwrite_JSON();
        }

        public void Overwrite_JSON()
        {
            string updated = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FILE_NAME, updated, Encoding.UTF8);
            Update_All();
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
            Font_Offset = Get_Font_Offset();
            Open_Close_Helper.tabTimeout = Get_Tab_Timeout();
            Open_Close_Helper.tab_open_debounce = Get_Tab_Debounce();
            Update_Btn_Backs(Get_Btn_Back());
            Open_Close_Helper.fade_interval = Get_Fade_Interval();
            Open_Close_Helper.fade_increment = Get_Fade_Increment();
            main.Update_Feedback_Btn(Get_Feedback());
            Font_Family = Get_Font_Family();
        }

        public float Get_Font_Offset()
        {
            return float.Parse(Get_Option(Options.FontOffset));
        }

        public void Change_Font(float new_font)
        {
            settings[Options_To_String[(int)Options.FontOffset]] = new_font.ToString();
            Font_Offset = new_font;
        }

        public uint Get_Tab_Timeout()
        {
            return uint.Parse(Get_Option(Options.TabTimeout));
        }

        public void Change_Tab_Timeout(uint timeout)
        {
            settings[Options_To_String[(int)Options.TabTimeout]] = timeout.ToString();
            Open_Close_Helper.tabTimeout = timeout;
        }

        public uint Get_Tab_Debounce()
        {
            return uint.Parse(Get_Option(Options.TabDebounce));
        }

        public void Change_Tab_Debounce(uint debounce)
        {
            settings[Options_To_String[(int)Options.TabDebounce]] = debounce.ToString();
            Open_Close_Helper.tab_open_debounce = debounce;
        }

        public bool Get_Btn_Back()
        {
            return bool.Parse(Get_Option(Options.btnBack));
        }

        public void Change_Btn_Back(bool state)
        {
            settings[Options_To_String[(int)Options.btnBack]] = state.ToString();
            Update_Btn_Backs(state);
        }

        private void Update_Btn_Backs(bool state)
        {
            btn_back_state = state;
            main.oppression.btnBack.Visible = state;
            main.thenAndNow.btnBack.Visible = state;
            main.timeline.btnBack.Visible = state;
            main.timeline.regimeFall.btnBack.Visible = state;
            main.timeline.ceausescusRise.btnBack.Visible = state;
            main.timeline.sovietEra.btnBack.Visible = state;
            main.stories.btnBack.Visible = state;
            main.lifeUnder.btnBack.Visible = state;
        }

        public int Get_Fade_Interval()
        {
            return int.Parse(Get_Option(Options.fadeInterval));
        }

        public void Change_Fade_Interval(int interval)
        {
            settings[Options_To_String[(int)Options.fadeInterval]] = interval.ToString();
            Open_Close_Helper.fade_interval = interval;
        }

        public double Get_Fade_Increment()
        {
            return double.Parse(Get_Option(Options.fadeIncrement));
        }

        public void Change_Fade_Increment(double inc)
        {
            settings[Options_To_String[(int)Options.fadeIncrement]] = inc.ToString();
            Open_Close_Helper.fade_increment = inc;
        }

        public bool Get_Feedback()
        {
            return bool.Parse(Get_Option(Options.feedback));
        }

        public void Change_Feedback(bool state)
        {
            settings[Options_To_String[(int)Options.feedback]] = state.ToString();
            main.Update_Feedback_Btn(state);
        }

        public FontFamily Get_Font_Family()
        {
            bool found = false;
            int ind = 0;
            string stored_font_name = settings[Options_To_String[(int)Options.fontFamily]];
            while (!found && ind < FontFamily.Families.Count())
            {
                if (FontFamily.Families[ind].ToString() == stored_font_name)
                {
                    return FontFamily.Families[ind];
                }
                ind++;
            }
            return null;
        }

        public void Change_Font_Family(FontFamily new_font_family)
        {
            settings[Options_To_String[(int)Options.fontFamily]] = new_font_family.ToString();
            Font_Family = new_font_family;
        }
    }
}
