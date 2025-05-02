using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOCR
{
    public partial class Picture_Zoom : Form
    {
        Open_Close_Helper openClose;
        Resize_Helper resize;
        TextManager textManager;
        Seconday_Form_Helper secondary_Helper = new Seconday_Form_Helper();

        public Picture_Zoom(Open_Close_Helper openClose, Resize_Helper resize, TextManager textManager, PictureBox picture)
        {
            InitializeComponent();
            this.openClose = openClose;
            this.resize = resize;
            this.textManager = textManager;
            Update_After_Gen(picture);
        }

        public void Update_After_Gen(PictureBox picture)
        {
            pbPictureZoom.Image = picture.Image;
            pbPictureZoom.SizeMode = picture.SizeMode;
            Form parent = secondary_Helper.Get_Form(picture);
            this.BackgroundImage = parent.BackgroundImage;
            this.BackgroundImageLayout = parent.BackgroundImageLayout;
            btnBack.Visible = Settings.btn_back_state;
            textManager.Update_One_Form(this);
            if (resize != null)
            {
                resize.Resize_Fonts(btnBack);
            }
        }


        private void Picture_Zoom_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }

        private void pbPictureZoom_Click(object sender, EventArgs e)
        {
            Picture_Zoom_Click(sender, e);
        }

        private void TableLayoutPictureZoomMain_Click(object sender, EventArgs e)
        {
            Picture_Zoom_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Picture_Zoom_Click(sender, e);
        }

        private void TableLayoutbtnBackAlignPictureZoom_Paint(object sender, PaintEventArgs e)
        {
            Picture_Zoom_Click(sender, e);
        }

        private void Picture_Zoom_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
        }
    }
}
