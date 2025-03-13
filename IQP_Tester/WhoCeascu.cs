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
    public partial class WhoCeascu : Form
    {
        public WhoCeascu()
        {
            InitializeComponent();
        }

        private void WhoCeascu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string [] CaescuWhoAnsLang = { "Answer", "Answer ROM", "ERROR" };

        private void WhoCeascu_Shown(object sender, EventArgs e)
        {
            //CaescuWhoAns.Text = CaescuWhoAnsLang[(int)Main.language];

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}
