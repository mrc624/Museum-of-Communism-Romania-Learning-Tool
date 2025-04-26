using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace IQP_Tester
{
    public class Image_Manager
    {

        public const string PICTURES_JSON_FILE_NAME = "pictures.json";

        private Dictionary<string, string> Images = new Dictionary<string, string>();

        private void Generate_Pictures_JSON()
        {
            if (File.Exists(PICTURES_JSON_FILE_NAME))
            {
                string json = File.ReadAllText(PICTURES_JSON_FILE_NAME);
                try
                {
                    Images = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
                }
                catch (Exception ex)
                {
                    DialogResult ans = MessageBox.Show("Invalid Pictures JSON FIle:\n" + ex);

                    if (ans != DialogResult.None)
                    {
                        System.Windows.Forms.Application.Exit();
                    }

                    Images = null;
                }
            }

            Add_Pictures();
            Check_Pictures();
            string updated = JsonSerializer.Serialize(Images, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(PICTURES_JSON_FILE_NAME, updated, Encoding.UTF8);
        }

        private void Check_Pictures()
        {
            List<string> names = Images.Keys.ToList();
            for (int i = 0; i < names.Count; i++)
            {
                if (!File.Exists(Images[names[i]]))
                {
                    Images[names[i]] = "";
                }
            }
        }

        public void Update_Ram_Saver()
        {
            if (Settings.Ram_Saver)
            {
                Generate_Pictures_JSON();
            }
            else
            {
                Images?.Clear();
            }
        }

        private void Add_Pictures()
        {
            for (int i = 0; i < Main.Forms.Count; i++)
            {
                Add_Form_Pictures(Main.Forms[i]);
            }
        }

        private void Add_Form_Pictures(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is PictureBox pb)
                {
                    if (!Images.ContainsKey(pb.Name))
                    {
                        Images[pb.Name] = "";
                    }
                }
                else if (control.Controls[i].HasChildren)
                {
                    Add_Form_Pictures(control.Controls[i]);
                }
            }
        }

        public void Dispose_Images(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is PictureBox)
                {
                    PictureBox pb = (PictureBox)control.Controls[i];
                    if (pb.Image != null)
                    {
                        pb.Image.Dispose();
                        pb.Image = null;
                    }
                }
                else if (control.Controls[i].HasChildren)
                {
                    Dispose_Images(control.Controls[i]);
                }
            }
        }

        public void Impose_Images(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is PictureBox)
                {
                    PictureBox pb = (PictureBox)control.Controls[i];

                    if (Images.ContainsKey(pb.Name))
                    {
                        if (Images[pb.Name].Length > 0)
                        {
                            try
                            {
                                pb.Image = System.Drawing.Image.FromFile(Images[pb.Name]);
                            }
                            catch
                            {
                                MessageBox.Show("Image:\n" + Images[pb.Name] + "\n Not Found");
                                pb.Image = null;
                            }
                        }
                        else
                        {
                            pb.Image = null;
                        }
                    }
                }
                else if (control.Controls[i].HasChildren)
                {
                    Impose_Images(control.Controls[i]);
                }
            }
        }

    }
}
