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

        public Polaroid_Zoom(PictureBox pb, Label lblQ, Label lblAns)
        {
            InitializeComponent();
            Update_Controls(pb.Image, lblQ.Text, lblAns.Text);
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
