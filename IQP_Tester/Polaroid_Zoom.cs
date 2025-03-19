using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    public partial class Polaroid_Zoom : Form
    {

        Resize_Helper resize = new Resize_Helper();
        TranslationManager translationManager;

        PictureBox pb;
        Label lblQ;
        Label lblAns;

        public Polaroid_Zoom(PictureBox pb, Label lblQ, Label lblAns, TranslationManager translationMan)
        {
            InitializeComponent();
            this.pb = pb;
            this.lblQ = lblQ;
            this.lblAns = lblAns;
            translationManager = translationMan;
            Update_Controls(pb.Image, lblQ.Text, lblAns.Text);
            resize.CaptureAspectRatios(this);
            resize.Fullscreen_Form(this);
        }

        private void Update_Controls(Image image, string question, string answer)
        {
            pbPicture.Image = image;
            lblQuestion.Text = question;
            lblAnswer.Text = answer;
        }

        private void Polaroid_Zoom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Polaroid_Zoom_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);

            resize.Reposition(pbPicture);
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
