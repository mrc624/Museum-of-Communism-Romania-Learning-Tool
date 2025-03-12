using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace IQP_Tester
{
    public partial class Main : Form
    {
        delegate void VoidDelegate();

        public enum Language
        {
            English,
            Romanian,
            num_supported_languages
        }

        public const Language default_language = Language.English;

        public string[] language_to_string = { "English", "Romanian", "ERROR" };

        public static Language language = default_language;
        
        

        KidsToys kidsToys;
        Food food;
        WhoCeascu whoCeascu;
        RevLength revLength;

        History history;

        private System.Timers.Timer Timer;
        public const uint tabTimeout = 10; //in seconds
        uint lastOpenTime = 0;
        public static uint seconds = 0;

        public Main()
        {
            InitializeComponent();
            SetTimer();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            CaptureAspectRatios(this);
        }

        private void SetTimer()
        {
            Timer = new System.Timers.Timer(1000); //tick every second
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            seconds++;
            Invoke(new VoidDelegate(Seconds_Trigger));
            if (seconds == lastOpenTime + tabTimeout)
            {
                 //Invoke(new VoidDelegate(CloseAllForms));
            }
        }

        private void Seconds_Trigger()
        {
            lblUptime.Text = seconds.ToString();
        }

        // MAIN PAGE BEGIN (NOT PANELS)
        string[] lblMainTitleLang = {"Answering Youth Questions About Romanian Communism", "Answering Youth Questions About Romanian Communism Rom"};


        // MAIN PAGE END   (NOT PANELS)

        // HISTORY PANEL BEGIN

        string[] panelHistoryTitleLang = { "History", "History Rom" };

        private void panelHistory_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            lastOpenTime = seconds;
            history = new History();
            FadeIn(history);
        }

        // HISTORY PANEL END


        // LIFE PANEL BEGIN

        string[] panelLifeTitleLang = { "Life", "Life Rom" };


        // LIFE PANEL END

        // PROPOGANDA PANEL BEGIN

        string[] panelPropogandaTitleLang = { "Propoganda", "Propoganda Rom" };

        // PROPOGANDA PANEL END

        // PRESENT DAY PANEL BEGIN

        string[] panelPresentDayTitleLang = { "Present Day", "Present Day Rom" };

        // PRESENT DAY PANEL END

        // MISC FORM FUNCTIONS BEGIN

        public static void FadeIn(Form form, int interval = 10, double increment = 0.05)
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

        // MISC FORM FUNCTIONS END

        // TAB MANAGEMENT BEGIN

        private void CloseAllForms()
        {
            if (history != null)
            {
                history.Close();
            }

        }

        // TAB MANAGEMENT END

        // LANGUAGE MANAGEMENT BEGIN

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            language = language + 1; // go to the next language
            if (language == Language.num_supported_languages)
            {
                language = Language.English; // if we went past last supported language go back to english
            }

            btnLanguage.Text = language_to_string[(uint)language]; // update language on button
            update_languages_on_main();
        }

        private void update_languages_on_main()
        {
            // update main page (non tab)
            lblMainTitle.Text = lblMainTitleLang[(uint)language];

            // update questions
            // History

            //resize with the new lenghts
            Main_Resize(this, new EventArgs());

        }

        // LANGUAGE MANAGEMENT END

        // HANDLING RESIZE BEGIN

        // sizing before any resize constants

        // tab control
        const int tabXOffset = 20;
        const int tabYOffsetTop = 150;
        const int tabYOffsetBottom = tabXOffset;

        // panel
        const int panelxoffset = 10;
        const int num_panels = 4;
        const int panel_start_height = 150;

        // language button
        const int btnLanguageOffsetx = tabXOffset;
        const int btnLanguageOffsety = btnLanguageOffsetx;

        private Dictionary<Control, (double width_ratio, double height_ratio, double percent_right, double percent_down, float fontRatio)> ratios = new Dictionary<Control, (double width_ratio, double height_ratio, double percent_right, double percent_down, float fontRatio)>();

        private void CaptureAspectRatios(Control parent)
        {
            for (int i = 0; i < parent.Controls.Count; i++)
            {
                Place_Ratios_in_Dictionary(parent.Controls[i]);

                if (parent.Controls[i].HasChildren)
                {
                    CaptureAspectRatios(parent.Controls[i]);
                }
            }
        }

        private void Place_Ratios_in_Dictionary(Control control)
        {
            if (control.Font != null)
            {
                ratios[control] = (
                    (double)control.Width / control.Parent.Width,
                    (double)control.Height / control.Parent.Height,
                    (double)control.Location.X / control.Parent.Width,
                    (double)control.Location.Y / control.Parent.Height,
                    control.Font.Size / (float)control.Parent.Width
                );
            }
            else
            {
                ratios[control] = (
                    (double)control.Width / control.Parent.Width,
                    (double)control.Height / control.Parent.Height,
                    (double)control.Location.X / control.Parent.Width,
                    (double)control.Location.Y / control.Parent.Height,
                    0
                );
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            Handle_Resize(this);

            Reposition(panelHistory);
            Reposition(panelLife);
            Reposition(panelPropoganda);
            Reposition(panelPost1989);

            Reposition(lblHistory);
            Reposition(lblKidsLife);
            Reposition(lblPropoganda);
            Reposition(lblPresentDay);

            Reposition(lblMainTitle);

            Reposition(pbCeasescu);
            Reposition(pbRevolution);
            Center_to_Other_Control(lblCeausecu, pbCeasescu);
            Center_to_Other_Control(lblRevolution, pbRevolution);

            Glue_to_Corner(btnLanguage, Corner.bottom_right);

            Expand_to_Top_of_Other(panelHistory, btnLanguage);
            Expand_to_Top_of_Other(panelLife, btnLanguage);
            Expand_to_Top_of_Other(panelPropoganda, btnLanguage);
            Expand_to_Top_of_Other(panelPost1989, btnLanguage);
        }

        private void Handle_Resize(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                Control curr = control.Controls[i];
                if (curr is Panel)
                {
                    Resize_Panel((Panel)curr);
                }
                else if (curr is PictureBox)
                {
                    Resize_PB((PictureBox)curr);
                }
                else
                {
                    if (curr.Font != null)
                    {
                        Resize_Font(curr);
                    }

                    if (curr is Button)
                    {
                        Resize_Control(curr);
                    }
                }

                if (curr.HasChildren)
                {
                    Handle_Resize(curr);
                }
            }
        }

        private void Handle_Non_Panel_Resize()
        {
            //Resize_Font(lblMainTitle, default_title_font_size);
            center_x(lblMainTitle, this.Width);

            btnLanguage.Location = new Point((this.Width - btnLanguage.Size.Width - btnLanguageOffsetx), (this.Height - btnLanguage.Size.Height - btnLanguageOffsety));
        }

        private void Resize_Panel(Panel panel)
        {
            var items = ratios[panel];
            double width_ratio = items.width_ratio;
            double height_ratio = items.height_ratio;

            panel.Height = (int)(height_ratio * this.Height);
            panel.Width = (int)(width_ratio * this.Width);
        }

        private void Reposition(Control control)
        {
            var items = ratios[control];

            control.Location = new Point((int)(items.percent_right * control.Parent.Width), (int)(items.percent_down * control.Parent.Height));
        }

        private void center_x(Control control, int width, double percent = 0.5)
        {
            int center = (int)(width * percent);
            int center_control = (int)(control.Width * percent);
            int center_x = center - center_control;

            control.Location = new Point(center_x, control.Location.Y);
        }

        private void Center_to_Other_Control(Control control, Control other, int height_offset = 0, double percent = 0.5)
        {
            int center = (int)(other.Width * percent);
            int center_control = (int)(control.Width * percent);
            int location_x = center - center_control + other.Location.X;

            int location_y = other.Location.Y + other.Height + height_offset;

            control.Location = new Point(location_x, location_y);
        }

        private void Resize_PB(PictureBox pb)
        {
            double aspect_ratio = (double)pb.Image.Width / (double)pb.Image.Height;

            var items = ratios[pb];
            double width_ratio = items.width_ratio;

            pb.Width = (int)(pb.Parent.Width * width_ratio);
            pb.Height = (int)((1 / aspect_ratio) * pb.Width);
        }

        private void Resize_Font(Control control)
        {
            var items = ratios[control];
            float font_ratio = items.fontRatio;

            float newFontSize = (float)control.Parent.Width * font_ratio;

            control.Font = new Font(control.Font.FontFamily, (float)(newFontSize));
        }


        private void Resize_Control(Control control)
        {
            var items = ratios[control];
            double width_ratio = items.width_ratio;
            double height_ratio = items.height_ratio;

            control.Width = (int)(control.Parent.Width * width_ratio);
            control.Height = (int)(control.Parent.Height * height_ratio);

        }

        public enum Corner
        {
            top_left,
            top_right,
            bottom_left,
            bottom_right,
            num_corners
        }

        private void Glue_to_Corner(Control control, Corner corner, int margin = 10)
        {
            int parent_width = control.Parent.Width;
            int parent_height = control.Parent.Height;

            switch (corner)
            {
                case Corner.top_left:

                    break;
                case Corner.top_right:

                    break;
                case Corner.bottom_left:

                    break;
                case Corner.bottom_right:
                    control.Location = new Point(parent_width - control.Width - margin, parent_height - control.Height - margin);
                    break;
            }
        }

        private void Expand_to_Top_of_Other(Control control, Control other, int margin = 10) // control must be above other
        {
            int height = other.Location.Y - control.Location.Y - margin;

            control.Height = height;
        }

        // key overides

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.Bounds = Screen.PrimaryScreen.WorkingArea;
                return true;
            }
            else if (keyData == Keys.F11)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                return true;
            }
            else
            {
                return false;
            }
        }

        // HANDLING RESIZE END




    }
}
