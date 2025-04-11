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

        public TitlePage(TextManager textMan, Open_Close_Helper open_close)
        {
            InitializeComponent();
            textManager = textMan;
            openClose = open_close;
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            clickHelper.Assign_All_Children_To_Same_Click(this, TitlePage_Click);
        }

        private void TitlePage_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            openClose.Close(this);
        }

        private void TitlePage_Resize(object sender, EventArgs e)
        {
            resize.Glue_to_Corner(tableLayoutTitleMain, Resize_Helper.Corner.all, TABLE_LAYOUT_MAIN_EDGE_MARGIN);
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
