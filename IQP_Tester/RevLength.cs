using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace IQP_Tester
{
    public partial class RevLength : Form
    {
        public RevLength()
        {
            InitializeComponent();
            //this.Opacity = 0;
        }

        private void RevLength_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string[] revLengthAnsLang = { "Answer", "Answer ROM", "ERROR" };

        private void RevLength_Shown(object sender, EventArgs e)
        {
            //revLengthAns.Text = revLengthAnsLang[(int)Main.language];

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            //FadeIn();
        }
/*
        System.Timers.Timer fade;

        private void FadeIn()
        {
            fade = new System.Timers.Timer(1);
            fade.Elapsed += OnTimedEvent;
            fade.AutoReset = true;
            fade.Enabled = true;

        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.01;
            }
            else
            {
                fade.Enabled = false;
            }
        }
*/
    }
}
