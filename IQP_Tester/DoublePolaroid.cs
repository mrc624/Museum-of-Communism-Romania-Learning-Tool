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
    public partial class DoublePolaroid : Form
    {
        Resize_Helper resize = new Resize_Helper();
        Click_Helper click = new Click_Helper();
        DoublePolaroid_Helper doublePolaroid_Helper;
        Open_Close_Helper openClose;
        TextManager textManager;

        public const int GLUE_TO_CORNER_MARGIN = 50;

        Control doublepolaroid;

        public DoublePolaroid(Open_Close_Helper open_close, TextManager textMan, Control DP)
        {
            InitializeComponent();
            openClose = open_close;
            textManager = textMan;
            doublePolaroid_Helper = new DoublePolaroid_Helper(textMan, open_close);
            doublepolaroid = DP;
            Update_Controls();
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            DoublePolaroid_Resize(this, new EventArgs());
            click.Assign_All_Children_To_Same_Click(this, DoublePolaroid_Click);
        }

        private void Update_Controls()
        {
            List<PictureBox> pictures = doublePolaroid_Helper.Find_Pb(doublepolaroid);
            string text = doublePolaroid_Helper.Find_Label(doublepolaroid)[DoublePolaroid_Helper.FIRST_ITEM].Text;
            pbDPThen.Image = pictures[DoublePolaroid_Helper.THEN_INDEX].Image;
            pbDPNow.Image = pictures[DoublePolaroid_Helper.NOW_INDEX].Image;
        }

        private void DoublePolaroid_Resize(object sender, EventArgs e)
        {
            resize.Glue_to_Corner(tableLayoutDPMain, Resize_Helper.Corner.all, GLUE_TO_CORNER_MARGIN);
            resize.Resize_Fonts(tableLayoutDPMain);

            // glue translate btn
        }

        private void DoublePolaroid_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }

        private void DoublePolaroid_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
        }
    }
}
