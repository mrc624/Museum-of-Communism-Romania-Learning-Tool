using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        bool kidsToysShow = false;
        bool foodShow = false;
        bool whoCeascuShow = false;

        private System.Timers.Timer Timer;
        static uint tabTimeout = 10;
        uint lastOpenTime = 0;
        uint seconds = 0;

        public Main()
        {
            InitializeComponent();
            SetTimer();
        }

        private void SetTimer()
        {
            Timer = new System.Timers.Timer(1000);
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            seconds++;
            Invoke(new VoidDelegate(Second_Trigger));
            if (seconds == lastOpenTime + tabTimeout)
            {
                 Invoke(new VoidDelegate(CloseAllTabs));
            }
        }

        private void Second_Trigger()
        {
            lblUptime.Text = seconds.ToString();
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
            lastOpenTime = seconds;
            whoCeascu = new WhoCeascu();
            whoCeascu.Show();
            whoCeascuShow = true;
        }

        // HISTORY TAB END


        // KIDS LIFE TAB BEGIN

        string[] tabKidsLifeLang = { "Kid's Life", "Kid's Life Rom" };

        private void KidsLifeToys_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
            lastOpenTime = seconds;
            kidsToys = new KidsToys();
            kidsToys.Show();
            kidsToysShow = true;
        }

        private void KidsLifeFood_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
            lastOpenTime = seconds;
            food = new Food();
            food.Show();
            foodShow = true;
        }

        // KIDS LIFE TAB END


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
