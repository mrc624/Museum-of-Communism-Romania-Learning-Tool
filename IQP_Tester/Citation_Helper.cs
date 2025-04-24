using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static IQP_Tester.Main;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms.VisualStyles;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;

namespace IQP_Tester
{
    public class Citation_Helper
    {

        public Citation_Helper(TitlePage titlepage)
        {
            this.titlepage = titlepage;
        }

        public const string CITATION_FILE_NAME = "citations.json";
        public const string BIBLIOGRAPH_TXT_FILE_NAME = "bibliography.txt";
        public const string INDENT = "\n        ";
        public const char SPACE = ' ';
        public const char HYPHEN = '-';
        public const int INDENT_EVERY_CHAR = 100;
        public const int INDENT_SEARCH_FOR_SPACE_CHAR_RANGE = 15;

        TitlePage titlepage;

        public enum Citation_Type
        {
            Team_Members,
            Collaborators,
            Professors,
            Institutions,
            Informative_Texts,
            Pictures,
            NUM_CITATION_TYPES
        }

        public string[] Citations_to_String =
        {
            "Team Members",
            "Collaborators",
            "Professors",
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
            "Institute",
            "Text",
            "Pic",
            "ERR"
        };


        public string[] Valid_Image_Types =
        {
            ".png",
            ".jpg",
            ".jpeg",
            ".bmp",
            ".pdf",
            ".svg"
        };

        public Dictionary<string, Dictionary<string, string>> Citations;
        public List<PictureBox> Pictures = new List<PictureBox>();

        public void Generate_Citation_JSON(string file_name)
        {
            if (File.Exists(file_name))
            {
                string json = File.ReadAllText(file_name);
                try
                {
                    Citations = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
                }
                catch (Exception ex)
                {
                    DialogResult ans = MessageBox.Show("Invalid Citations JSON FIle:\n" + ex);

                    if (ans != DialogResult.None)
                    {
                        System.Windows.Forms.Application.Exit();
                    }

                    Citations = null;
                }
            }
            else
            {
                Citations = new Dictionary<string, Dictionary<string, string>>
                {
                    { Citations_to_String[(int)Citation_Type.Team_Members], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Collaborators], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Professors], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Institutions], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Informative_Texts], new Dictionary<string, string>() },
                    { Citations_to_String[(int)Citation_Type.Pictures], new Dictionary<string, string>() }
                };

                Init_Team_Mem();
                Init_Collab();
                Init_Prof();
                Init_Institute();
            }

            Init_Text();
            Add_Pictures();

            string updated = JsonSerializer.Serialize(Citations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(file_name, updated, Encoding.UTF8);
        }

        public void Add_Pictures()
        {
            Pictures.Clear();

            for (int j = 0; j < Forms.Count; j++)
            {
                if (Forms[j].BackgroundImage != null && Forms[j] != titlepage) 
                {
                    PictureBox copy = new PictureBox();
                    copy.Image = Forms[j].BackgroundImage;
                    copy.Name = Forms[j].Name;
                    Add_Picture(copy);
                }
                for (int i = 0; i < Forms[j].Controls.Count; i++)
                {
                    Add_Picture(Forms[j].Controls[i]);
                }
            }
        }

        private void Add_Picture(Control control) // same picture is put into citations multiple times
        {
            if (control is PictureBox)
            {
                PictureBox pb = (PictureBox)control;
                if (pb.Image != null)
                {
                    string name = pb.Name;
                    Pictures.Add(Copy_Picturebox(pb));
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

        private PictureBox Copy_Picturebox(PictureBox og)
        {
            PictureBox copy = new PictureBox();

            copy.Image = og.Image;
            copy.InitialImage = og.Image;
            copy.Location = new System.Drawing.Point(0, 0);
            copy.Margin = og.Margin;
            copy.Name = og.Name;
            copy.Size = new System.Drawing.Size(247, 247);
            copy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            copy.TabIndex = 1;
            copy.TabStop = false;

            return copy;
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
                Citations[Citations_to_String[(int)Citation_Type.Professors]][Get_Citation_Shortened[(int)Citation_Type.Professors] + i.ToString()] = "NEED";
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
            if (File.Exists(BIBLIOGRAPH_TXT_FILE_NAME))
            {
                string[] lines = File.ReadAllLines(BIBLIOGRAPH_TXT_FILE_NAME);
                for (int i = 0; i < lines.Length; i++)
                {
                    string cite = Format_Hanging_Indentation(lines[i]);
                    Citations[Citations_to_String[(int)Citation_Type.Informative_Texts]][Get_Citation_Shortened[(int)Citation_Type.Informative_Texts] + i.ToString()] = cite;
                }
            }
            else
            {
                for (int i = 0; i < INIT_TEXT_NUM; i++)
                {
                    Citations[Citations_to_String[(int)Citation_Type.Informative_Texts]][Get_Citation_Shortened[(int)Citation_Type.Informative_Texts] + i.ToString()] = "NEED";
                }
            }
        }

        public string Format_Hanging_Indentation(string citation, int indent_every = INDENT_EVERY_CHAR)
        {
            if (citation.Length > indent_every)
            {
                for (int i = INDENT_EVERY_CHAR; i < citation.Length; i += INDENT_EVERY_CHAR)
                {
                    int indent_ind = Find_Space_Index(citation, i);
                    if (indent_ind > 0)
                    {
                        citation = citation.Substring(0, indent_ind) + INDENT + citation.Substring(indent_ind);
                    }
                    else
                    {
                        citation = citation.Substring(0, i) + HYPHEN + INDENT + citation.Substring(i);
                    }
                }
            }
            return citation;
        }

        public int Find_Space_Index(string citation, int ind)
        {
            // searching for space to the right
            for (int i = ind; i < citation.Length && i <= ind + INDENT_SEARCH_FOR_SPACE_CHAR_RANGE; i++)
            {
                if (citation[i] == SPACE)
                {
                    return i;
                }
            }
            // searching for space to the left
            for (int i = ind; i >= 0 && i >= ind - INDENT_SEARCH_FOR_SPACE_CHAR_RANGE; i--)
            {
                if (citation[i] == SPACE)
                {
                    return i;
                }
            }
            // no space found case
            return -1;
        }

        public List<string> Get_Citations_Except_Pictures(Citation_Type type)
        {
            List<string> list = new List<string>();
            if (type != Citation_Type.Pictures)
            {
                for (int i = 0; i < Citations[Citations_to_String[(int)type]].Count; i++)
                {
                    list.Add(Citations[Citations_to_String[(int)type]][Get_Citation_Shortened[(int)type] + i.ToString()]);
                }
            }
            return list;
        }

        public List<PictureBox> Get_Pictures_List()
        {
            return Pictures;
        }
    }
}
