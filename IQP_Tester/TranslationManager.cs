using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static IQP_Tester.Main;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace IQP_Tester
{
    public class TranslationManager
    {
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

            Update_One_Form(form);
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


        private void Translate_Control(Control control, Dictionary<string, string> translated)
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
