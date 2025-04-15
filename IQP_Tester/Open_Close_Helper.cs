using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
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
        delegate void FormDelegate(Form form);
        delegate void FormIntDoubleDelegate(Form form, int interval, double incement);
        delegate void FormIntDelegate(Form form, double val);

        public Open_Close_Helper(Main _main)
        {
            main = _main;
        }


        //Timeout things
        Main main;

        private System.Timers.Timer Timer;

        public const int DEFAULT_FADE_INTERVAL = 10;
        public const double DEFAULT_FADE_INCREMENT = 0.05;
        public const uint tabTimeout = 1000; // in 1/10 of seconds, 100 seconds
        public const uint tab_open_debounce = 5; // in 1/10 of seconds, 0.5 second
        static uint lastInteraction = 0;
        static uint lastFormOpened = 0;
        public const int TIMER_TICK = 100; // tick 10 times a second
        public const uint NUM_REAL_SECONDS_IN_SECONDS = 10;
        public static uint seconds = 0; // not actually seconds, 1/10 of a second
        public static uint interaction_count = 0;

        public bool block = false;

        public void Start_Timer()
        {
            Timer = new System.Timers.Timer(TIMER_TICK);
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        public void Interaction()
        {
            lastInteraction = seconds;
            interaction_count++;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            seconds++;
            if (seconds == lastInteraction + tabTimeout)
            {
                main.Invoke(new VoidDelegate(main.Open_Title_Page));
            }
        }

        public uint Get_Seconds()
        {
            return seconds / NUM_REAL_SECONDS_IN_SECONDS;
        }

        public uint Get_Interactions()
        {
            return interaction_count;
        }

        public void CloseAllForms(Form keep_open0 = null, Form keep_open1 = null)
        {
            FormCollection forms = Application.OpenForms;
            for (int i = 0; i < forms.Count; i++)
            {
                if (forms[i] != main && forms[i] != keep_open0 && forms[i] != keep_open1)
                {
                    Close(forms[i]);
                }
            }
        }

        public void Hide_All_Forms(Form keep1 = null, Form keep2 = null)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] != keep1 && Application.OpenForms[i] != keep2)
                {
                    Application.OpenForms[i].Hide();
                }
            }
        }

        public void Hard_Close_Invisibles()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (!Application.OpenForms[i].Visible)
                {
                    Dispose_Images(Application.OpenForms[i]);
                    Application.OpenForms[i].Close();
                }
            }
        }

        public bool IsOpened(Form form)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] == form)
                {
                    return form.Visible;
                }
            }
            return false;
        }

        // General open close things

        public void FadeIn(Form form, int interval = DEFAULT_FADE_INTERVAL, double increment = DEFAULT_FADE_INCREMENT)
        {
            if (form != null && !form.IsDisposed && !block && !form.Visible)
            {
                block = true;
                form.Opacity = 0; // start fully transparent
                form.Show();
                form.TopMost = true;
                System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
                fadeTimer.Interval = interval; // time in milliseconds between opacity updates
                fadeTimer.Tick += (s, e) =>
                {
                    if (form.Opacity < 1.0)
                    {
                        form.Opacity += increment; // increase opacity gradually
                        form.BringToFront();
                    }
                    else
                    {
                        fadeTimer.Stop(); // stop when fully visible
                        block = false;
                    }
                };
                fadeTimer.Start();
            }
        }

        private void FadeOut(Form form, int interval = DEFAULT_FADE_INTERVAL, double increment = DEFAULT_FADE_INCREMENT)
        {
            if (!form.IsDisposed && !block && form.Visible)
            {
                block = true;
                System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
                fadeTimer.Interval = interval; // time in milliseconds between opacity updates
                fadeTimer.Tick += (s, e) =>
                {
                    if (form.Opacity > 0)
                    {
                        form.Opacity -= increment;
                        form.BringToFront();
                    }
                    else
                    {
                        fadeTimer.Stop(); // stop when invisible
                        form.Hide();
                        block = false;
                    }

                };
                fadeTimer.Start();
            }
        }

        public void Suspend_Layout(Control control)
        {
            control.SuspendLayout();
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].HasChildren)
                {
                    Suspend_Layout(control.Controls[i]);
                }
                else
                {
                    control.Controls[i].SuspendLayout();
                }
            }
        }

        public void Resume_Layout(Control control)
        {
            control.ResumeLayout();
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i].HasChildren)
                {
                    Resume_Layout(control.Controls[i]);
                }
                else
                {
                    control.Controls[i].ResumeLayout();
                }
            }
        }

        public void Dispose_Images(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is PictureBox)
                {
                    PictureBox pb = (PictureBox)control.Controls[i];
                    if (pb.Image != null)
                    {
                        pb.Image.Dispose();
                        pb.Image = null;
                    }
                }
                else if (control.Controls[i].HasChildren)
                {
                    Dispose_Images(control.Controls[i]);
                }
            }
        }

        public void Close(Form form)
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new FormIntDoubleDelegate(FadeOut), form, DEFAULT_FADE_INTERVAL, DEFAULT_FADE_INCREMENT);
            }
            else
            {
                FadeOut(form);
            }
        }

        public void Show_Hide(Form form)
        {
            form.Opacity = 0;
            form.Show();
            form.Hide();
            form.Opacity = 1;
        }
    }
}
