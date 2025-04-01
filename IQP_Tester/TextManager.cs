using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static IQP_Tester.Main;
using System.Windows.Forms;
using System.IO;

namespace IQP_Tester
{
    public class TextManager
    {
        Polaroid_Zoom_Helper polaroid_Zoom_Helper = new Polaroid_Zoom_Helper();

        public enum Language
        {
            Invalid_Language,
            English,
            Romanian,
            num_supported_languages
        }

        public const Language default_language = Language.English;

        public string[] language_to_string = { "ERROR", "English", "Romanian", "ERROR" };

        public Language language = default_language;

        public const string TEXT_MANAGER_FILE_NAME = "text_manager.json";

        public bool JSON_Generated_or_Updated = false;

        public void Generate_Text_JSON(string file_name)
        {
            Dictionary<string, Dictionary<string, string>> text;

            if (File.Exists(file_name))
            {
                string json = File.ReadAllText(file_name);
                text = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
            }
            else
            {
                text = new Dictionary<string, Dictionary<string, string>>
                {
                    { language_to_string[(int)Language.English], new Dictionary<string, string>() },
                    { language_to_string[(int)Language.Romanian], new Dictionary<string, string>() }
                };
            }

            JSON_Generated_or_Updated = true;

            for (int i = 0; i < Forms.Count; i++)
            {
                Add_Form_Text(Forms[i], text);
            }

            string updated = JsonSerializer.Serialize(text, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(file_name, updated, Encoding.UTF8);

        }

        private void Add_Form_Text(Form form, Dictionary<string, Dictionary<string, string>> text)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                Add_Control_Text(form.Controls[i], text);
            }
        }

        private void Add_Control_Text(Control control, Dictionary<string, Dictionary<string, string>> text)
        {
            if (!string.IsNullOrEmpty(control.Text))
            {
                if (!text[language_to_string[(int)Language.English]].ContainsKey(control.Name))
                {
                    text[language_to_string[(int)Language.English]][control.Name] = control.Text;
                }
                if (!text[language_to_string[(int)Language.Romanian]].ContainsKey(control.Name))
                {
                    text[language_to_string[(int)Language.Romanian]][control.Name] = "TRANSLATION NEEDED";
                }
            }

            // Add in long answers for polaroids
            if (polaroid_Zoom_Helper.Is_Polaroid(control))
            {
                Panel panel = (Panel)control;
                string name = panel.Name;
                string ans = polaroid_Zoom_Helper.Get_Ans_Name(panel);
                string ansLong = ans + Polaroid_Zoom_Helper.LONG_POLAROID_ANS_FLAG;

                if (!text[language_to_string[(int)Language.English]].ContainsKey(ansLong))
                {
                    text[language_to_string[(int)Language.English]][ansLong] = Polaroid_Zoom_Helper.IGNORE_LONG_ANS_FLAG;
                }
                if (!text[language_to_string[(int)Language.Romanian]].ContainsKey(ansLong))
                {
                    text[language_to_string[(int)Language.Romanian]][ansLong] = Polaroid_Zoom_Helper.IGNORE_LONG_ANS_FLAG;
                }
            }

            if (control.HasChildren)
            {
                for (int i = 0; i < control.Controls.Count; i++)
                {
                    Add_Control_Text(control.Controls[i], text);
                }
            }
        }

        // the forms resize function must be called after incremementing the language
        public void Increment_Language(Form form)
        {
            language = language + 1; // go to the next language
            if (language == Language.num_supported_languages)
            {
                language = Language.English; // if we went past last supported language go back to english
            }

            Update_All_Forms();
        }

        public void Update_Text()
        {
            Dictionary<string, Dictionary<string, string>> text = new Dictionary<string, Dictionary<string, string>>();

            if (File.Exists(TEXT_MANAGER_FILE_NAME))
            {
                string json = File.ReadAllText(TEXT_MANAGER_FILE_NAME);
                text = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
            }

            if (language < Language.num_supported_languages && language > Language.Invalid_Language)
            {
                Dictionary<string, string> translated = text[language_to_string[(int)language]];

                for (int i = 0; i < Forms.Count; i++)
                {
                    Translate_Form(Forms[i], translated);
                }

            }
        }

        public void Update_All_Forms()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Update_One_Form(Application.OpenForms[i]);      
            }
        }

        public void Update_One_Form(Form form)
        {
            if (File.Exists(TEXT_MANAGER_FILE_NAME) && JSON_Generated_or_Updated)
            {
                Dictionary<string, Dictionary<string, string>> text = new Dictionary<string, Dictionary<string, string>>();
                string json = File.ReadAllText(TEXT_MANAGER_FILE_NAME);
                text = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
                Dictionary<string, string> translated = text[language_to_string[(int)language]];
                Translate_Form(form, translated);
            }
        }


        private void Translate_Form(Form form, Dictionary<string, string> translated)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (translated.ContainsKey(form.Controls[i].Name))
                {
                    form.Controls[i].Text = translated[form.Controls[i].Name];
                }

                if (form.Controls[i].HasChildren)
                {
                    Translate_Control(form.Controls[i], translated);
                }
            }
        }

        public string Get_Text(Control control, Dictionary<string, string> translated)
        {
            if (control.Text != null)
            {
                return translated[control.Name];
            }
            else
            {
                return null;
            }
        }

        public string Get_Text(string name)
        {
            Dictionary<string, string> text = Get_Translated_Dictionary();

            if (text.ContainsKey(name))
            {
                return text[name];
            }
            else
            {
                return null;
            }
        }

        public Dictionary<string, string> Get_Translated_Dictionary()
        {
            if (File.Exists(TEXT_MANAGER_FILE_NAME) && JSON_Generated_or_Updated)
            {
                Dictionary<string, Dictionary<string, string>> text = new Dictionary<string, Dictionary<string, string>>();
                string json = File.ReadAllText(TEXT_MANAGER_FILE_NAME);
                text = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
                return text[language_to_string[(int)language]];
            }
            else
            {
                return null;
            }
        }

        public Dictionary<string, Dictionary<string, string>> Get_Text_Dictionary()
        {
            if (File.Exists(TEXT_MANAGER_FILE_NAME) && JSON_Generated_or_Updated)
            {
                Dictionary<string, Dictionary<string, string>> text = new Dictionary<string, Dictionary<string, string>>();
                string json = File.ReadAllText(TEXT_MANAGER_FILE_NAME);
                text = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
                return text;
            }
            else
            {
                return null;
            }
        }

        public void Translate_Control(Control control, Dictionary<string, string> translated)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (translated.ContainsKey(control.Controls[i].Name))
                {
                    control.Controls[i].Text = translated[control.Controls[i].Name];
                }

                if (control.Controls[i].HasChildren)
                {
                    Translate_Control(control.Controls[i], translated);
                }
            }
        }

        // LANGUAGE MANAGEMENT END
    }
}
