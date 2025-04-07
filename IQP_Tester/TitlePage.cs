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

        public TitlePage(TextManager textMan, Open_Close_Helper open_close)
        {
            InitializeComponent();
            textManager = textMan;
            openClose = open_close;
            resize.Fullscreen_Form(this);
            clickHelper.Assign_All_Children_To_Same_Click(this, TitlePage_Click);
        }

        private void TitlePage_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }
    }
}
