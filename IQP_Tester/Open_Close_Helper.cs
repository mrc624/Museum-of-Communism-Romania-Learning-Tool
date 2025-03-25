using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace IQP_Tester
{
    public class Open_Close_Helper
    {

        delegate void VoidDelegate();
        delegate void FormDelegate(Form form, int interval, double incement);
        delegate void FormIntDelegate(Form form, double val);

        public const int DEFAULT_FADE_INTERVAL = 10;
        public const double DEFAULT_FADE_INCREMENT = 0.05;



        //Timeout things
        Form main;

        private System.Timers.Timer Timer;

        public const uint tabTimeout = 1000; // in 1/10 of seconds, 100 seconds
        public const uint tab_open_debounce = 1; // in 1/10 of seconds, 1/10 of a second
        static uint lastOpenTime = 0;
        public static uint seconds = 0; // not actually seconds, 1/10 of a second

        public void Set_Main(Form _main)
        {
            main = _main;
        }

        public void Start_Timer()
        {
            Timer = new System.Timers.Timer(100); //tick 10 times a second
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        public void Form_Opened()
        {
            lastOpenTime = seconds;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            seconds++;
            if (seconds == lastOpenTime + tabTimeout)
            {
                CloseAllForms();
            }
        }

        public void CloseAllForms()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] != main)
                {
                    Close(Application.OpenForms[i]);
                }
            }
        }


        // General open close things


        public void FadeIn(Form form, int interval = DEFAULT_FADE_INTERVAL, double increment = DEFAULT_FADE_INCREMENT)
        {
            form.Opacity = 0; // start fully transparent
            form.Show();
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = interval; // time in milliseconds between opacity updates
            fadeTimer.Tick += (s, e) =>
            {
                if (form.Opacity < 1.0)
                    form.Opacity += increment; // increase opacity gradually
                else
                    fadeTimer.Stop(); // stop when fully visible
            };
            Form_Opened();
            fadeTimer.Start();
        }

        private void FadeOut(Form form, int interval = DEFAULT_FADE_INTERVAL, double increment = DEFAULT_FADE_INCREMENT)
        {
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = interval; // time in milliseconds between opacity updates
            fadeTimer.Tick += (s, e) =>
            {
                if (form.Opacity > 0)
                    form.Opacity -= increment;
                else
                    fadeTimer.Stop(); // stop when invisible
            };
            fadeTimer.Start();

            if (form.Opacity <= 0)
            {
                form.Close();
            }
        }

        public void Close(Form form)
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new FormDelegate(FadeOut), form, DEFAULT_FADE_INTERVAL, DEFAULT_FADE_INCREMENT);
            }
            else
            {
                FadeOut(form);
            }
        }

    }
}
