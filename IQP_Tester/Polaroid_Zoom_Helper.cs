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
        Open_Close_Helper openClose = new Open_Close_Helper();
        Click_Helper click_helper = new Click_Helper();

        TranslationManager translationManager;

        public Polaroid_Zoom_Helper()
        {

        }

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
            openClose.FadeIn(polaroid_zoom);
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
                        click_helper.Assign_All_Children_To_Same_Click(panel, Polaroid_Zoom_Click_Handler);
                    }
                }
            }
        }


    }
}
