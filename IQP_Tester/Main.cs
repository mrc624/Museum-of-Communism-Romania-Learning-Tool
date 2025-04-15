using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace IQP_Tester
{
    public partial class Main : Form
    {
        delegate void VoidDelegate();

        TextManager textManager = new TextManager();
        Resize_Helper resize;
        Open_Close_Helper openClose;
        Click_Helper click_helper = new Click_Helper();
        Citation_Helper citation_Helper;
        Settings settings = new Settings();

        public static List<Form> Forms = new List<Form>();

        ThenAndNow thenAndNow;
        Oppression oppression;
        Stories stories;
        LifeUnder lifeUnder;
        Timeline timeline;

        RegimeFall regimeFall;
        CeausescusRise ceausescusRise;
        SovietEra sovietEra;

        Credits credits;
        Dev_Tools dev_Tools;

        TitlePage titlePage;

        public const int TABLE_LAYOUT_MAIN_EDGE_MARGIN = 50;

        public Main()
        {
            InitializeComponent();
            settings.Generate_JSON(Settings.FILE_NAME);
            resize = new Resize_Helper(settings);
            openClose = new Open_Close_Helper(this);
            Add_Forms();
            citation_Helper = new Citation_Helper(titlePage);
            resize.CaptureAspectRatios(this);
            textManager.Generate_Text_JSON(TextManager.TEXT_MANAGER_FILE_NAME);
            citation_Helper.Generate_Citation_JSON(Citation_Helper.CITATION_FILE_NAME);
            credits = new Credits(citation_Helper, openClose, resize, this);
            textManager.Update_One_Form(this);
            Set_Panel_Clicks();
            Main_Resize(this, new EventArgs());
            openClose.Start_Timer();
            this.BringToFront();
            Open_Title_Page();
        }

        private void Set_Panel_Clicks()
        {
            click_helper.Assign_All_Children_To_Same_Click(panelThenAndNow, panelThenAndNow_Click);
            click_helper.Assign_All_Children_To_Same_Click(panelOppression, panelOppression_Click);
            click_helper.Assign_All_Children_To_Same_Click(panelStories, panelStories_Click);
            click_helper.Assign_All_Children_To_Same_Click(panelLifeUnder, panelLifeUnder_Click);
            click_helper.Assign_All_Children_To_Same_Click(panelTimeline, panelTimeline_Click);
        }

        private void Add_Forms()
        {
            Forms.Add(this);
            thenAndNow = new ThenAndNow(textManager, openClose, resize);
            openClose.Show_Hide(thenAndNow);
            Forms.Add(thenAndNow);
            oppression = new Oppression(textManager, openClose, resize);
            openClose.Show_Hide(oppression);
            Forms.Add(oppression);
            stories = new Stories(textManager, openClose, resize);
            openClose.Show_Hide(stories);
            Forms.Add(stories);
            lifeUnder = new LifeUnder(textManager, openClose, resize);
            openClose.Show_Hide(lifeUnder);
            Forms.Add(lifeUnder);
            regimeFall = new RegimeFall(textManager, openClose, resize);
            openClose.Show_Hide(regimeFall);
            Forms.Add(regimeFall);
            ceausescusRise = new CeausescusRise(textManager, openClose, resize);
            openClose.Show_Hide(ceausescusRise);
            Forms.Add(ceausescusRise);
            sovietEra = new SovietEra(textManager, openClose, resize);
            openClose.Show_Hide(sovietEra);
            Forms.Add(sovietEra);
            timeline = new Timeline(textManager, openClose, resize, regimeFall, ceausescusRise, sovietEra);
            openClose.Show_Hide(timeline);
            Forms.Add(timeline);
            titlePage = new TitlePage(textManager, openClose, resize);
            openClose.Show_Hide(titlePage);
            Forms.Add(titlePage);
        }

        private void Clear_Forms()
        {
            for (int i = 0; i < Forms.Count; i++)
            {
                if (Forms[i] != this)
                {
                    Forms[i].Dispose();
                }
            }
        }

        public void Open_Title_Page()
        {
            openClose.Interaction();
            if (!openClose.IsOpened(titlePage))
            {
                if (titlePage == null)
                {
                    titlePage = new TitlePage(textManager, openClose, resize);
                }
                openClose.FadeIn(titlePage);
                openClose.Hide_All_Forms(this, titlePage);
            }
            else
            {
                titlePage.Rotate_Pictures();
            }
        }

        private void panelThenAndNow_Click(object sender, EventArgs e)
        {
            if (!openClose.block)
            {
                if (thenAndNow == null)
                {
                    thenAndNow = new ThenAndNow(textManager, openClose, resize);
                }
                openClose.Interaction();
                openClose.FadeIn(thenAndNow);
            }
        }

        private void panelOppression_Click(object sender, EventArgs e)
        {
            if (!openClose.block)
            {
                if (oppression == null)
                {
                    oppression = new Oppression(textManager, openClose, resize);
                }
                openClose.Interaction();
                openClose.FadeIn(oppression);
            }
        }

        private void panelLifeUnder_Click(object sender, EventArgs e)
        {
            if (!openClose.block)
            {
                if (lifeUnder == null)
                {
                    lifeUnder = new LifeUnder(textManager, openClose, resize);
                }
                openClose.Interaction();
                openClose.FadeIn(lifeUnder);
            }
        }

        private void panelStories_Click(object sender, EventArgs e)
        {
            if (!openClose.block)
            {
                if (stories == null)
                {
                    stories = new Stories(textManager, openClose, resize);
                }
                openClose.Interaction();
                openClose.FadeIn(stories);
            }
        }

        private void panelTimeline_Click(object sender, EventArgs e)
        {
            if (!openClose.block)
            {
                if (timeline == null)
                {
                    timeline = new Timeline(textManager, openClose, resize, regimeFall, ceausescusRise, sovietEra);
                }
                openClose.Interaction();
                openClose.FadeIn(timeline);
            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            textManager.Increment_Language(this);
            Main_Resize(this, new EventArgs());
            openClose.Interaction();
        }

        private void btnLanguage_TextChanged(object sender, EventArgs e)
        {
            Main_Resize(this, new EventArgs());
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            if (!openClose.block)
            {
                if (credits == null)
                {
                    credits = new Credits(citation_Helper, openClose, resize, this);
                }
                openClose.Interaction();
                openClose.FadeIn(credits);
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (resize != null)
            {
                resize.Resize_Fonts(this);
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
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
            else if (keyData == Keys.F12)
            {
                if (dev_Tools == null)
                {
                    dev_Tools = new Dev_Tools(textManager, openClose, settings);
                }
                openClose.FadeIn(dev_Tools);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
