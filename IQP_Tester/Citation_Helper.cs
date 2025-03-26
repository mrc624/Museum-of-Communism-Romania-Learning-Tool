using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static IQP_Tester.Main;
using System.Windows.Forms;
using System.IO;
using static IQP_Tester.TranslationManager;

namespace IQP_Tester
{
    public class Citation_Helper
    {

        public const string CITATION_FILE_NAME = "citations.json";

        public enum Citation_Type
        {
            Team_Members,
            Collaborators,
            Proffesors,
            Interviewees,
            Institutions,
            Informative_Texts,
            Pictures,
            NUM_CITATION_TYPES
        }

        public string[] Citations_to_String =
        {
            "Team Members",
            "Collaborators",
            "Proffesors",
            "Interviewees",
            "Institutions",
            "Informative Texts",
            "Pictures",
            "ERROR"
        };

        public const uint INIT_MEM_NUM = 4;
        public const uint INIT_COLLAB_NUM = 2;
        public const uint INIT_PROF_NUM = 2;
        public const uint INIT_INTERVIEWEE_NUM = 20;
        public const uint INIT_INSTITUTE_NUM = 2;
        public const uint INIT_TEXT_NUM = 20;

        public string[] Get_Citation_Shortened =
        {
            "Member",
            "Collab",
            "Prof",
            "Interviewee",
            "Institute",
            "Text",
            "Pic",
            "ERR"
        };
            

        public Dictionary<string, Dictionary<string, string>> Citations;

        public void Generate_Citation_JSON(string file_name)
        {
            
            if (File.Exists(file_name))
            {
                string json = File.ReadAllText(file_name);
                Citations = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
            }
            else
            {
                Citations = new Dictionary<string, Dictionary<string, string>>
                {
                    { Citations_to_String[(int)Citation_Type.Team_Members], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Collaborators], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Proffesors], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Interviewees], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Institutions], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Informative_Texts], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Pictures], new Dictionary<string, string>() }
                };

                Init_Team_Mem();
                Init_Collab();
                Init_Prof();
                Init_Interviewee();
                Init_Institute();
                Init_Text();
            }

            for (int i = 0; i < Forms.Count; i++)
            {
                Add_Pictures(Forms[i]);
            }

            string updated = JsonSerializer.Serialize(Citations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(file_name, updated, Encoding.UTF8);
        }

        private void Add_Pictures(Form form)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                Add_Picture(form.Controls[i]);
            }
        }

        private void Add_Picture(Control control)
        {
            if (control is PictureBox)
            {
                PictureBox pb = (PictureBox)control;

                if (pb.Image != null)
                {
                    if (!Citations[Citations_to_String[(int)Citation_Type.Pictures]].ContainsKey(pb.Name))
                    {
                        Citations[Citations_to_String[(int)Citation_Type.Pictures]][pb.Name] = "NEED";
                    }
                }
            }

            if (control.HasChildren)
            {
                for (int i = 0; i < control.Controls.Count; i++)
                {
                    Add_Picture(control.Controls[i]);
                }
            }
        }

        private void Init_Team_Mem()
        { 
            for (int i = 0; i < INIT_MEM_NUM; i++)
            {
                Citations[Citations_to_String[(int)Citation_Type.Team_Members]][Get_Citation_Shortened[(int)Citation_Type.Team_Members] + i.ToString()] = "NEED";
            }
        }

        private void Init_Collab()
        {
            for (int i = 0; i < INIT_COLLAB_NUM; i++)
            {
                Citations[Citations_to_String[(int)Citation_Type.Collaborators]][Get_Citation_Shortened[(int)Citation_Type.Collaborators] + i.ToString()] = "NEED";
            }
        }

        private void Init_Prof()
        {
            for (int i = 0; i < INIT_PROF_NUM; i++)
            {
                Citations[Citations_to_String[(int)Citation_Type.Proffesors]][Get_Citation_Shortened[(int)Citation_Type.Proffesors] + i.ToString()] = "NEED";
            }
        }

        private void Init_Interviewee()
        {
            for (int i = 0; i < INIT_INTERVIEWEE_NUM; i++)
            {
                Citations[Citations_to_String[(int)Citation_Type.Interviewees]][Get_Citation_Shortened[(int)Citation_Type.Interviewees] + i.ToString()] = "NEED";
            }
        }

        private void Init_Institute()
        {
            for (int i = 0; i < INIT_INSTITUTE_NUM; i++)
            {
                Citations[Citations_to_String[(int)Citation_Type.Institutions]][Get_Citation_Shortened[(int)Citation_Type.Institutions] + i.ToString()] = "NEED";
            }
        }

        private void Init_Text()
        {
            for (int i = 0; i < INIT_TEXT_NUM; i++)
            {
                Citations[Citations_to_String[(int)Citation_Type.Informative_Texts]][Get_Citation_Shortened[(int)Citation_Type.Informative_Texts] + i.ToString()] = "NEED";
            }
        }

        public List<string> Get_Team_Members()
        {
            List<string> Names = new List<string>();
            for (int i = 0; i < Citations[Citations_to_String[(int)Citation_Type.Team_Members]].Count; i++)
            {
                Names.Add(Citations[Citations_to_String[(int)Citation_Type.Team_Members]][Get_Citation_Shortened[(int)Citation_Type.Team_Members] + i.ToString()]);
            }
            return Names;
        }
    }
}
