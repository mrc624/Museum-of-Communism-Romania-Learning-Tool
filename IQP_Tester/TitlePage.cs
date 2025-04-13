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
    public partial class TitlePage : Form
    {
        TextManager textManager;
        Open_Close_Helper openClose;
        Click_Helper clickHelper = new Click_Helper();
        Resize_Helper resize = new Resize_Helper();

        public const int TABLE_LAYOUT_MAIN_EDGE_MARGIN = 50;

        List <PictureBox> pictures = new List<PictureBox>();
        int curr_pic_ind = 0;

        public TitlePage(TextManager textMan, Open_Close_Helper open_close)
        {
            InitializeComponent();
            textManager = textMan;
            openClose = open_close;
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            clickHelper.Assign_All_Children_To_Same_Click(this, TitlePage_Click);
            Add_Pictures(this);
            Rotate_Pictures();
        }

        public void Rotate_Pictures()
        {
            curr_pic_ind++;

            if (curr_pic_ind >= pictures.Count)
            {
                curr_pic_ind = 0;
            }

            this.BackgroundImage = pictures[curr_pic_ind].Image;
        }

        private void Add_Pictures(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is PictureBox)
                {
                    pictures.Add((PictureBox)control.Controls[i]);
                }

                if (control.Controls[i].HasChildren)
                {
                    Add_Pictures((Control)control.Controls[i]);
                }
            }
        }

        private void TitlePage_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            this.BackgroundImage = null;
            openClose.Close(this);
        }

        private void TitlePage_Resize(object sender, EventArgs e)
        {
            resize.Resize_Fonts(this);
        }

        private void TitlePage_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
            textManager.Update_One_Form(this);
            TitlePage_Resize(this, new EventArgs());
        }
    }
}
