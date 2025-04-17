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

        Resize_Helper resize;
        TextManager textManager;
        Open_Close_Helper openClose;
        Polaroid_Helper polaroid_Zoom_Helper = new Polaroid_Helper();

        PictureBox pb;
        Label lblQ;
        Label lblAns;

        public Polaroid_Zoom(Control polaroid, TextManager textMan, Open_Close_Helper open_close, Resize_Helper resize, Form parent)
        {
            InitializeComponent();
            textManager = textMan;
            openClose = open_close;
            this.resize = resize;
            this.BackgroundImage = parent.BackgroundImage;
            this.BackgroundImageLayout = parent.BackgroundImageLayout;

            if (polaroid_Zoom_Helper.Is_Polaroid(polaroid))
            {
                pb = polaroid_Zoom_Helper.Find_PB(polaroid);
                lblQ = polaroid_Zoom_Helper.Find_Q(polaroid);
                lblAns = polaroid_Zoom_Helper.Find_Ans(polaroid);

                Update_Controls(pb.Image, lblQ.Text, lblAns.Text);
                textManager.Update_One_Form(this);
                Translate_Polaroid();
                resize.CaptureAspectRatios(this);
                resize.Fullscreen_Form(this);
                Polaroid_Zoom_Resize(this, new EventArgs());
                Set_Clicks();
            }
        }

        private void Set_Clicks()
        {
            tableLayoutLanguagePolaroidZoomBtnAlign.Click += Polaroid_Zoom_Click;
            tableLayoutPanelQuestionAndAnswer.Click += Polaroid_Zoom_Click;
            tableLayoutPolaroidZoomContainer.Click += Polaroid_Zoom_Click;
            tableLayoutPolaroidZoomMain.Click += Polaroid_Zoom_Click;
            pbPicture.Click += Polaroid_Zoom_Click;
            lblAnswer.Click += Polaroid_Zoom_Click;
            lblQuestion.Click += Polaroid_Zoom_Click;
        }

        private void PbPicture_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Update_Controls(Image image, string question, string answer)
        {
            pbPicture.Image = image;
            lblQuestion.Text = question;
            lblAnswer.Text = answer;
        }

        public void Update_After_Gen(Control polaroid)
        {
            pb = polaroid_Zoom_Helper.Find_PB(polaroid);
            lblQ = polaroid_Zoom_Helper.Find_Q(polaroid);
            lblAns = polaroid_Zoom_Helper.Find_Ans(polaroid);

            Update_Controls(pb.Image, lblQ.Text, lblAns.Text);
            textManager.Update_One_Form(this);
            Translate_Polaroid();
            Polaroid_Zoom_Resize(this, new EventArgs());
        }

        private void Handle_Long_Ans()
        {
            string name = textManager.Get_Text(polaroid_Zoom_Helper.Get_Long_Ans_Name(lblAns));
            if (name != null && name != Polaroid_Helper.IGNORE_LONG_ANS_FLAG)
            {
                lblAnswer.Text = name;
            }
        }

        private void Polaroid_Zoom_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            openClose.Close(this);
        }

        private void Polaroid_Zoom_Resize(object sender, EventArgs e)
        {
            if (resize != null)
            {
                resize.Resize_Fonts(this);
            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            textManager.Increment_Language(this);
            Polaroid_Zoom_Resize(this, new EventArgs());
            Translate_Polaroid();
        }

        private void Translate_Polaroid()
        {
            lblQuestion.Text = textManager.Get_Text(lblQ, textManager.Get_Translated_Dictionary());
            lblAnswer.Text = textManager.Get_Text(lblAns, textManager.Get_Translated_Dictionary());
            btnLanguage.Text = textManager.Get_Text(btnLanguage, textManager.Get_Translated_Dictionary());
            Handle_Long_Ans();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Polaroid_Zoom_Click(sender, e);
        }
    }
}
