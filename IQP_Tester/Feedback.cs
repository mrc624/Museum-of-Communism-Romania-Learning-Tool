using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IQP_Tester.Citation_Helper;
using static System.Net.Mime.MediaTypeNames;

namespace IQP_Tester
{
    public partial class Feedback : Form
    {
        TableLayout_Helper tableLayout_Helper = new TableLayout_Helper();
        Resize_Helper resize;
        Open_Close_Helper openClose;
        Citation_Helper citation_Helper;

        public const uint ROW_VERTICAL_OFFSET = 10;

        Main main;

        public Feedback(Open_Close_Helper openClose, Resize_Helper resize)
        {
            InitializeComponent();
            this.openClose = openClose;
            this.resize = resize;

            btnBack.Visible = Settings.btn_back_state;
        }

        private void Feedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            openClose.Close(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Feedback_Click(sender, e);
        }

        private void tableLayoutFeedbackMain_Click(object sender, EventArgs e)
        {
            Feedback_Click(sender, e);
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void Feedback_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
        }

        private void Feedback_VisibleChanged(object sender, EventArgs e)
        {
            btnBack.Visible = Settings.btn_back_state;
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }

        private void TableLayoutbtnBackAlignFeedback_Click(object sender, EventArgs e)
        {
            Feedback_Click(sender, e);
        }
    }
}
