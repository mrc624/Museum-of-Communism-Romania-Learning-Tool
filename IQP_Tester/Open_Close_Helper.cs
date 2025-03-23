using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    internal class Open_Close_Helper
    {
        public void FadeIn(Form form, int interval = 10, double increment = 0.05)
        {
            form.Opacity = 0; // Start fully transparent
            form.Show();
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = interval; // Time in milliseconds between opacity updates
            fadeTimer.Tick += (s, e) =>
            {
                if (form.Opacity < 1.0)
                    form.Opacity += increment; // Increase opacity gradually
                else
                    fadeTimer.Stop(); // Stop when fully visible
            };
            fadeTimer.Start();
        }

        public void Close(Form form)
        {
            if (form.Opacity == 1.0)
            {
                form.Close();
            }
        }

    }
}
