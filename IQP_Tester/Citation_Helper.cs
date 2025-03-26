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

        private Dictionary<string, Dictionary<string, string>> Citations;

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
            }

            string updated = JsonSerializer.Serialize(Citations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(file_name, updated, Encoding.UTF8);
        }

        public void Read_Citation_JSON(string file_name)
        {

        }
    }
}
