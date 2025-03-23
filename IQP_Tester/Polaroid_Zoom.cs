using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    public partial class Polaroid_Zoom : Form
    {

        Resize_Helper resize = new Resize_Helper();
        TranslationManager translationManager;
        Open_Close_Helper openClose = new Open_Close_Helper();

        PictureBox pb;
        Label lblQ;
        Label lblAns;

        public Polaroid_Zoom(Panel panel, TranslationManager translationMan)
        {
            InitializeComponent();

            if (resize.Panel_Has_PB_lblQ_lblAns(panel))
            {
                for (int i = 0; i < panel.Controls.Count; i++)
                {
                    string control_name = panel.Controls[i].Name;

                    if (panel.Controls[i] is PictureBox)
                    {
                        pb = (PictureBox)panel.Controls[i];
                    }
                    else if (control_name.EndsWith(Resize_Helper.END_QUESTION_FLAG) && panel.Controls[i] is Label)
                    {
                        lblQ = (Label)panel.Controls[i];
                    }
                    else if (control_name.EndsWith(Resize_Helper.END_ANSWER_FLAG) && panel.Controls[i] is Label)
                    {
                        lblAns = (Label)panel.Controls[i];
                    }
                }
                translationManager = translationMan;
                Update_Controls(pb.Image, lblQ.Text, lblAns.Text);
                resize.CaptureAspectRatios(this);
                resize.Fullscreen_Form(this);

                Polaroid_Zoom_Resize(this, new EventArgs());
            }
        }

        private void Update_Controls(Image image, string question, string answer)
        {
            pbPicture.Image = image;
            lblQuestion.Text = question;
            lblAnswer.Text = answer;
        }

        private void Polaroid_Zoom_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }

        private void Polaroid_Zoom_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);

            resize.Reposition(pbPicture);
            resize.Reposition(tableLayoutPanelQuestionAndAnswer);
            resize.Reposition(lblQuestion);
            resize.Reposition(lblAnswer);

            resize.Center_Y(pbPicture);

            resize.Glue_to_Corner(btnLanguage, Resize_Helper.Corner.bottom_right);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            translationManager.Increment_Language(this);
            Polaroid_Zoom_Resize(this, new EventArgs());
            Translate_Polaroid();
        }

        private void Translate_Polaroid()
        {
            lblQuestion.Text = translationManager.Get_Translation(lblQ, translationManager.Get_Translated_Dictionary());
            lblAnswer.Text = translationManager.Get_Translation(lblAns, translationManager.Get_Translated_Dictionary());
        }

        private void pbPicture_Click(object sender, EventArgs e)
        {
            Polaroid_Zoom_Click(this, new EventArgs());
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {
            Polaroid_Zoom_Click(this, new EventArgs());
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
            Polaroid_Zoom_Click(this, new EventArgs());
        }

        private void tableLayoutPanelQuestionAndAnswer_Click(object sender, EventArgs e)
        {
            Polaroid_Zoom_Click(this, new EventArgs());
        }
    }
}
