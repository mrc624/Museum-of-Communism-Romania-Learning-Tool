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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            this.Show();
            this.TopMost = true;
            this.BringToFront();
        }

        public Loading(string text)
        {
            InitializeComponent();
            lblLoading.Text = text;
            this.Show();
            this.TopMost = true;
            this.BringToFront();
        }

        public void Update_Text(string text)
        {
            lblLoading.Text = text;
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
