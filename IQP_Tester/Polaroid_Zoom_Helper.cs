using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    internal class Polaroid_Zoom_Helper
    {
        Resize_Helper resize = new Resize_Helper();

        TranslationManager translationManager;

        public void Polaroid_Zoom_Click_Handler(object sender, EventArgs e)
        {
            Panel panel = null;

            if (sender is Panel)
            {
                panel = (Panel)sender;
            }
            else if (sender is Label)
            {
                panel = (Panel)((Label)sender).Parent;
            }
            else if (sender is PictureBox)
            {
                panel = (Panel)((PictureBox)sender).Parent;
            }

            Polaroid_Zoom polaroid_zoom = new Polaroid_Zoom(panel, translationManager);
            resize.FadeIn(polaroid_zoom);
        }

        public const int num_controls = 3;

        public void Assign_Click_Handler_To_Valid(Form form, TranslationManager translationMan)
        {
            translationManager = translationMan;
            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (form.Controls[i] is Panel && form.Controls[i].Controls.Count == num_controls)
                {
                    Panel panel = (Panel)form.Controls[i];
                    if (resize.Panel_Has_PB_lblQ_lblAns(panel))
                    {
                        panel.Click += Polaroid_Zoom_Click_Handler;

                        for (int j = 0; j < panel.Controls.Count; j++)
                        {
                            string control_name = panel.Controls[j].Name;
                            if (panel.Controls[j] is PictureBox)
                            {
                                panel.Controls[j].Click += Polaroid_Zoom_Click_Handler;
                            }
                            else if (control_name.EndsWith(Resize_Helper.END_QUESTION_FLAG) && panel.Controls[j] is Label)
                            {
                                panel.Controls[j].Click += Polaroid_Zoom_Click_Handler;
                            }
                            else if (control_name.EndsWith(Resize_Helper.END_ANSWER_FLAG) && panel.Controls[j] is Label)
                            {
                                panel.Controls[j].Click += Polaroid_Zoom_Click_Handler;
                            }
                        }
                    }
                }
            }
        }


    }
}
