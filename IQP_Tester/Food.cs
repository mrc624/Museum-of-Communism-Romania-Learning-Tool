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
    public partial class Food : Form
    {

        public Food()
        {
            InitializeComponent();
        }

        private void Food_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string[] foodAnsLang = { "Answer", "Answer ROM", "ERROR" };

        private void Food_Shown(object sender, EventArgs e)
        {
            //label1.Text = foodAnsLang[(int)Main.language];

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}
