using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
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

        public static Language default_language = Language.English;

        public string[] language_to_string = { "English", "Romanian", "ERROR" };

        public static Language language = default_language;
        
        

        KidsToys kidsToys;
        Food food;
        WhoCeascu whoCeascu;
        RevLength revLength;

        History history;

        private System.Timers.Timer Timer;
        static uint tabTimeout = 10; //in seconds
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
        static int tabXOffset = 20;
        static int tabYOffsetTop = 150;
        static int tabYOffsetBottom = tabXOffset;

        // panel
        static int panelxoffset = 10;
        static int num_panels = 4;

        // language button
        static int btnLanguageOffsetx = tabXOffset;
        static int btnLanguageOffsety = btnLanguageOffsetx;




        private void Main_Resize(object sender, EventArgs e)
        {
            lblMainTitle.Location = new Point((this.Width / 2) - (lblMainTitle.Width / 2), lblMainTitle.Location.Y);

            btnLanguage.Location = new Point((this.Width - btnLanguage.Size.Width - btnLanguageOffsetx), (this.Height - btnLanguage.Size.Height - btnLanguageOffsety*2));

            Resize_Panels();

            Center_Text();
        }

        private void Resize_Panels()
        {
            int newWidth = (this.Width / num_panels) - panelxoffset;

            panelHistory.Width = newWidth;
            panelLife.Width = newWidth;
            panelPropoganda.Width = newWidth;
            panelPost1989.Width = newWidth;

            panelHistory.Location = new Point(panelxoffset, 150);
            panelLife.Location = new Point(newWidth + panelxoffset, 150);
            panelPropoganda.Location = new Point (newWidth * 2 + panelxoffset, 150);
            panelPost1989.Location = new Point (newWidth * 3 + panelxoffset, 150);
        }

        // font size ratios, ratios are font size / width
        static float fontRatio = (1f) / (75);

        private void Resize_Text()
        {
            float newFontSize = (float)(fontRatio * this.Width);

            if (newFontSize < 1)
            {
                newFontSize = 1;
            }

            //history

            //kidslife

        }

        private void Center_Text()
        {
            int halfPanelWidth = panelHistory.Width / 2;

            lblHistory.Location = new Point (halfPanelWidth - (lblHistory.Width / 2), lblHistory.Location.Y);
            lblKidsLife.Location = new Point(halfPanelWidth - (lblKidsLife.Width / 2), lblKidsLife.Location.Y);
            lblPropoganda.Location = new Point(halfPanelWidth - (lblPropoganda.Width / 2), lblPropoganda.Location.Y);
            lblPresentDay.Location = new Point(halfPanelWidth - (lblPresentDay.Width / 2), lblPresentDay.Location.Y);
        }

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
