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
    public class TranslationManager
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

        public const string translation_file_name = "translations.json";

        public bool JSON_Generated_or_Updated = false;

        public void Generate_Translation_JSON(string file_name)
        {
            Dictionary<string, Dictionary<string, string>> translations;

            if (File.Exists(file_name))
            {
                string json = File.ReadAllText(file_name);
                translations = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
            }
            else
            {
                translations = new Dictionary<string, Dictionary<string, string>>
                {
                    { language_to_string[(int)Language.English], new Dictionary<string, string>() },
                    { language_to_string[(int)Language.Romanian], new Dictionary<string, string>() }
                };
            }

            JSON_Generated_or_Updated = true;

            for (int i = 0; i < Forms.Count; i++)
            {
                Add_Form_Translation(Forms[i], translations);
            }

            string updated = JsonSerializer.Serialize(translations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(file_name, updated, Encoding.UTF8);

        }

        private void Add_Form_Translation(Form form, Dictionary<string, Dictionary<string, string>> translations)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                Add_Control_Translation(form.Controls[i], translations);
            }
        }

        private void Add_Control_Translation(Control control, Dictionary<string, Dictionary<string, string>> translations)
        {
            if (!string.IsNullOrEmpty(control.Text))
            {
                if (!translations[language_to_string[(int)Language.English]].ContainsKey(control.Name))
                {
                    translations[language_to_string[(int)Language.English]][control.Name] = control.Text;
                }
                if (!translations[language_to_string[(int)Language.Romanian]].ContainsKey(control.Name))
                {
                    translations[language_to_string[(int)Language.Romanian]][control.Name] = "TRANSLATION NEEDED";
                }
            }

            // Add in long answers for polaroids
            if (control is Panel)
            {
                Panel panel = (Panel)control;
                if (polaroid_Zoom_Helper.Is_Polaroid(panel))
                {
                    string ans = polaroid_Zoom_Helper.Get_Ans_Name(panel);
                    string ansLong = ans + Polaroid_Zoom_Helper.LONG_POLAROID_ANS_FLAG;

                    if (!translations[language_to_string[(int)Language.English]].ContainsKey(ansLong))
                    {
                        translations[language_to_string[(int)Language.English]][ansLong] = Polaroid_Zoom_Helper.IGNORE_LONG_ANS_FLAG;
                    }
                    if (!translations[language_to_string[(int)Language.Romanian]].ContainsKey(ansLong))
                    {
                        translations[language_to_string[(int)Language.Romanian]][ansLong] = Polaroid_Zoom_Helper.IGNORE_LONG_ANS_FLAG;
                    }
                }
            }

            if (control.HasChildren)
            {
                for (int i = 0; i < control.Controls.Count; i++)
                {
                    Add_Control_Translation(control.Controls[i], translations);
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

        public void Update_Translations()
        {
            Dictionary<string, Dictionary<string, string>> translations = new Dictionary<string, Dictionary<string, string>>();

            if (File.Exists(translation_file_name))
            {
                string json = File.ReadAllText(translation_file_name);
                translations = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
            }

            if (language < Language.num_supported_languages && language > Language.Invalid_Language)
            {
                Dictionary<string, string> translated = translations[language_to_string[(int)language]];

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
            if (File.Exists(translation_file_name) && JSON_Generated_or_Updated)
            {
                Dictionary<string, Dictionary<string, string>> translations = new Dictionary<string, Dictionary<string, string>>();
                string json = File.ReadAllText(translation_file_name);
                translations = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
                Dictionary<string, string> translated = translations[language_to_string[(int)language]];
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

        public string Get_Translation(Control control, Dictionary<string, string> translated)
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

        public Dictionary<string, string> Get_Translated_Dictionary()
        {
            if (File.Exists(translation_file_name) && JSON_Generated_or_Updated)
            {
                Dictionary<string, Dictionary<string, string>> translations = new Dictionary<string, Dictionary<string, string>>();
                string json = File.ReadAllText(translation_file_name);
                translations = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
                return translations[language_to_string[(int)language]];
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

        public string Get_Translation(string name)
        {
            Dictionary<string, string> translations = Get_Translated_Dictionary();

            if (translations.ContainsKey(name))
            {
                return translations[name];
            }
            else
            {
                return null;
            }
        }

        // LANGUAGE MANAGEMENT END
    }
}
