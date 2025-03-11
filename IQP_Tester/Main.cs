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
                 Invoke(new VoidDelegate(CloseAllForms));
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


        private void Main_Resize(object sender, EventArgs e)
        {
            Handle_Non_Panel_Resize();

            Resize_Panels();

            Resize_History_Panel_Objects();
            Center_History_Panel_Objects();
            
            Center_Text();
        }

        private void Handle_Non_Panel_Resize()
        {
            Resize_Font(lblMainTitle, default_title_font_size);
            center_x(lblMainTitle, this.Width);

            btnLanguage.Location = new Point((this.Width - btnLanguage.Size.Width - btnLanguageOffsetx), (this.Height - btnLanguage.Size.Height - btnLanguageOffsety));
        }

        private void Resize_Panels()
        {
            int newWidth = (this.Width / num_panels) - panelxoffset;
            int newHeight = this.Height - panel_start_height - btnLanguage.Height - btnLanguageOffsety * 2;

            panelHistory.Width = newWidth;
            panelLife.Width = newWidth;
            panelPropoganda.Width = newWidth;
            panelPost1989.Width = newWidth;

            panelHistory.Height = newHeight;
            panelLife.Height = newHeight;
            panelPropoganda.Height = newHeight;
            panelPost1989.Height = newHeight;

            panelHistory.Location = new Point(panelxoffset, 150);
            panelLife.Location = new Point(newWidth + panelxoffset, 150);
            panelPropoganda.Location = new Point (newWidth * 2 + panelxoffset, 150);
            panelPost1989.Location = new Point (newWidth * 3 + panelxoffset, 150);
        }

        private void Resize_History_Panel_Objects()
        {
            Resize_PB(pbCeasescu, panelHistory,0.5, false);
            Resize_PB(pbRevolution, panelHistory, 0.75);

            Resize_Font(lblCeausecu);
            Resize_Font(lblRevolution);
        }

        private void Center_History_Panel_Objects()
        {
            int width = panelHistory.Width;
            int height = panelHistory.Height;

            center_x(lblHistory, width);

            center_x(pbCeasescu, width);
            center_label_to_pb(lblCeausecu, pbCeasescu);

            center_x(pbRevolution, width, 0.8);
            center_label_to_pb(lblRevolution, pbRevolution);
        }

        private void Center_Text()
        {
            int halfPanelWidth = panelHistory.Width / 2;

            lblKidsLife.Location = new Point(halfPanelWidth - (lblKidsLife.Width / 2), lblKidsLife.Location.Y);
            lblPropoganda.Location = new Point(halfPanelWidth - (lblPropoganda.Width / 2), lblPropoganda.Location.Y);
            lblPresentDay.Location = new Point(halfPanelWidth - (lblPresentDay.Width / 2), lblPresentDay.Location.Y);
        }

        // Resizing helpers

        private void center_x(Control control, int width, double percent = 0.5)
        {
            int center = (int)(width * percent);
            int center_control = (int)(control.Width * percent);
            int center_x = center - center_control;

            control.Location = new Point(center_x, control.Location.Y);
        }

        private void center_label_to_pb(Control control, Control pb, int height_offset = 0, double percent = 0.5)
        {
            int center = (int)(pb.Width * percent);
            int center_control = (int)(control.Width * percent);
            int location_x = center - center_control + pb.Location.X;

            int location_y = pb.Location.Y + pb.Height + height_offset;

            control.Location = new Point(location_x, location_y);
        }

        // if the PB is the first PB in the panel then moveDown should be false
        private void Resize_PB(PictureBox pb, Panel parent, double parent_width_ratio = 0.5, bool moveDown = true)
        {
            double aspect_ratio = (double)pb.Image.Width / (double)pb.Image.Height;

            int heightPrev = pb.Height;

            pb.Width = (int)(parent.Width * parent_width_ratio);
            pb.Height = (int)((1 / aspect_ratio) * pb.Width);

            if (moveDown)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - (heightPrev - pb.Height));
            }
        }


        const float default_title_font_size = 27.9f;
        const float default_standard_font_size = 15.75f;
        const float default_subtitle_font_size = 23f;
        const int default_width = 1920;

        private void Resize_Font(Control control, float originalFont = default_standard_font_size, int originalWidth = default_width)
        {
            float newFontSize = originalFont * ((float)(this.Width) / (float)(originalWidth));

            control.Font = new Font(control.Font.FontFamily, (float)(newFontSize));
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
