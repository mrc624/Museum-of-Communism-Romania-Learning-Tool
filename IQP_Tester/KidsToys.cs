using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    public partial class KidsToys : Form
    {
        public KidsToys()
        {
            InitializeComponent();
        }

        private void KidsToys_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string[] kidsToysAnsLang = { "Answer", "Answer ROM", "ERROR" };

        private void KidsToys_Shown(object sender, EventArgs e)
        {
            //KidsToysAns.Text = kidsToysAnsLang[(int)Main.language];

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}
