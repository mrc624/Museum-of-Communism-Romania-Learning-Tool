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

        private System.Timers.Timer Timer;
        static uint tabTimeout = 1000; //in milliseconds
        uint lastOpenTime = 0;
        public static uint millis = 0;

        public Main()
        {
            InitializeComponent();
            SetTimer();
        }

        private void SetTimer()
        {
            Timer = new System.Timers.Timer(1); //tick every millisecond
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            millis++;
            Invoke(new VoidDelegate(Millis_Trigger));
            if (millis == lastOpenTime + tabTimeout)
            {
                 Invoke(new VoidDelegate(CloseAllTabs));
            }
        }

        private void Millis_Trigger()
        {
            lblUptime.Text = millis.ToString();
        }

        // MAIN PAGE BEGIN (NOT TAB CONTROL)
        string[] lblMainTitleLang = {"Answering Youth Questions About Romanian Communism", "Answering Youth Questions About Romanian Communism Rom"};


        // MAIN PAGE END   (NOT TAB CONTROL)

        // HISTORY TAB BEGIN

        string[] tabHistoryLang = { "History", "History Rom" };

        string[] whoCeausecuLang = { "Who was Nicolae Ceau\u0219escu?", "Who was Nicolae Ceau\u0219escu? Rom" };

        private void HistoryCeasecu_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
            lastOpenTime = millis;
            whoCeascu = new WhoCeascu();
            FadeIn(whoCeascu);

        }

        string[] revLengthLang = { "How long was the revolution?", "How long was the revolution Rom" };

        private void historyRevLong_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
            lastOpenTime = millis;
            revLength = new RevLength();
            FadeIn(revLength);
        }

        // HISTORY TAB END


        // KIDS LIFE TAB BEGIN

        string[] tabKidsLifeLang = { "Kid's Life", "Kid's Life Rom" };

        private void KidsLifeToys_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
            lastOpenTime = millis;
            kidsToys = new KidsToys();
            FadeIn(kidsToys);
        }

        private void KidsLifeFood_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
            lastOpenTime =  millis;
            food = new Food();
            FadeIn(food);
        }

        // KIDS LIFE TAB END

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

        private void CloseAllTabs()
        {
            if (kidsToys != null)
            {
                kidsToys.Close();
            }
            
            if (food != null)
            {
                food.Close();
            }

            if (whoCeascu != null)
            {
                whoCeascu.Close();
            }

            if (revLength != null)
            {
                revLength.Close();
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

            // update tabs
            tabHistory.Text = tabHistoryLang[(uint)language];
            tabKidsLife.Text = tabKidsLifeLang[(uint)language];

            // update questions
            // History
            historyCeasecu.Text = whoCeausecuLang[(uint)language];
            historyRevLength.Text = revLengthLang[(uint)language];

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

        // language button
        static int btnLanguageOffset = tabXOffset;




        private void Main_Resize(object sender, EventArgs e)
        {
            lblMainTitle.Location = new Point((this.Width / 2) - (lblMainTitle.Width / 2), lblMainTitle.Location.Y);

            btnLanguage.Location = new Point(this.Width - btnLanguage.Width - btnLanguageOffset, this.Height - btnLanguage.Height - btnLanguageOffset);
            
            tabMainControl.Width = this.Width - tabXOffset;
            tabMainControl.Height = btnLanguage.Location.Y - tabMainControl.Location.Y - tabYOffsetBottom;

            Resize__Text();
        }

        // font size ratios, ratios are font size / width
        static float fontRatio = (1f) / (75);

        private void Resize__Text()
        {
            float newFontSize = (float)(fontRatio * this.Width);

            if (newFontSize < 1)
            {
                newFontSize = 1;
            }

            //history
            historyCeasecu.Font = new Font(historyCeasecu.Font.FontFamily, newFontSize);
            historyRevLength.Font = new Font(historyRevLength.Font.FontFamily, newFontSize);

            //kidslife
            KidsLifeFood.Font = new Font(KidsLifeFood.Font.FontFamily, newFontSize);
            KidsLifeToys.Font = new Font(KidsLifeToys.Font.FontFamily, newFontSize);

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
