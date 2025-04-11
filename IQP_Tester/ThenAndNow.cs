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
    public partial class ThenAndNow : Form
    {
        TextManager textManager;
        Resize_Helper resize = new Resize_Helper();
        DoublePolaroid_Helper doublePolaroid_Helper;
        Open_Close_Helper openClose;

        public const int TABLE_LAYOUT_MAIN_EDGE_MARGIN = 50;

        public ThenAndNow(TextManager textMan, Open_Close_Helper open_close)
        {
            InitializeComponent();
            openClose = open_close;
            textManager = textMan;
            doublePolaroid_Helper = new DoublePolaroid_Helper(textMan, open_close);
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            doublePolaroid_Helper.Find_DoublePolaroids(this);
            doublePolaroid_Helper.Assign_Click_Handers(doublePolaroid_Helper.DoublePolaroids);
            Set_Clicks();
        }

        public void Set_Clicks()
        {
            tableLayoutTNMain.Click += ThenAndNow_Click;
            tableLayoutTN.Click += ThenAndNow_Click;
            lblThenAndNowTitle.Click += ThenAndNow_Click;
        }

        private void ThenAndNow_Resize(object sender, EventArgs e)
        {
            resize.Glue_to_Corner(tableLayoutTNMain, Resize_Helper.Corner.all, TABLE_LAYOUT_MAIN_EDGE_MARGIN);
            resize.Resize_Fonts(this);

            resize.Glue_to_Corner(btnLanguage, Resize_Helper.Corner.bottom_right);
        }

        private void ThenAndNow_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            openClose.Close(this);
        }

        private void ThenAndNow_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
            textManager.Update_One_Form(this);
            ThenAndNow_Resize(this, new EventArgs());
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            textManager.Increment_Language(this);
        }

        private void btnLanguage_TextChanged(object sender, EventArgs e)
        {
            ThenAndNow_Resize(this, new EventArgs());
        }
    }
}
