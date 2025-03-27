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

        TranslationManager translationManager = new TranslationManager();
        Resize_Helper resize = new Resize_Helper();
        Open_Close_Helper openClose = new Open_Close_Helper();
        Click_Helper click_helper = new Click_Helper();
        Citation_Helper citation_Helper = new Citation_Helper();

        public static List<Form> Forms = new List<Form>();

        RegimeFall regimeFall;
        ThenAndNow thenAndNow;
        Oppression oppression;
        Stories stories;
        LifeUnder lifeUnder;
        Timeline timeline;

        Credits credits;

        public Main()
        {
            InitializeComponent();
            Add_Forms();
            resize.CaptureAspectRatios(this);
            translationManager.Generate_Translation_JSON(TranslationManager.translation_file_name);
            citation_Helper.Generate_Citation_JSON(Citation_Helper.CITATION_FILE_NAME);
            translationManager.Update_One_Form(this);
            Set_Panel_Clicks();
            Main_Resize(this, new EventArgs());
            openClose.Start_Timer();
            openClose.Set_Main(this);
        }

        private void Set_Panel_Clicks()
        {
            click_helper.Assign_All_Children_To_Same_Click(panelRegimeFall, panelRegimeFall_Click);
            click_helper.Assign_All_Children_To_Same_Click(panelThenAndNow, panelThenAndNow_Click);
            click_helper.Assign_All_Children_To_Same_Click(panelOppression, panelOppression_Click);
            click_helper.Assign_All_Children_To_Same_Click(panelStories, panelStories_Click);
            click_helper.Assign_All_Children_To_Same_Click(panelLifeUnder, panelLifeUnder_Click);
            click_helper.Assign_All_Children_To_Same_Click(panelTimeline, panelTimeline_Click);
        }

        private void Add_Forms()
        {
            Forms.Add(this);
            regimeFall = new RegimeFall(translationManager, openClose);
            Forms.Add(regimeFall);
            thenAndNow = new ThenAndNow(translationManager, openClose);
            Forms.Add(thenAndNow);
            oppression = new Oppression(translationManager, openClose);
            Forms.Add(oppression);
            stories = new Stories(translationManager, openClose);
            Forms.Add(stories);
            lifeUnder = new LifeUnder(translationManager, openClose);
            Forms.Add(lifeUnder);
            timeline = new Timeline(translationManager, openClose);
            Forms.Add(timeline);

        }

        // MAIN PAGE BEGIN (NOT PANELS)

        // MAIN PAGE END   (NOT PANELS)

        // THEN AND NOW BEGIN

        private void panelThenAndNow_Click(object sender, EventArgs e)
        {
            openClose.CloseAllForms();
            thenAndNow = new ThenAndNow(translationManager, openClose);
            openClose.FadeIn(thenAndNow);
        }

        // THEN AND NOW END

        // REGIME FALL BEGIN

        private void panelRegimeFall_Click(object sender, EventArgs e)
        {
            openClose.CloseAllForms();
            regimeFall = new RegimeFall(translationManager, openClose);
            openClose.FadeIn(regimeFall);
        }

        // REGIME FALL END

        // OPPRESSION START

        private void panelOppression_Click(object sender, EventArgs e)
        {
            openClose.CloseAllForms();
            oppression = new Oppression(translationManager, openClose);
            openClose.FadeIn(oppression);
        }

        // OPPRESSION END

        // LIFE UNDER PANEL BEGIN

        private void panelLifeUnder_Click(object sender, EventArgs e)
        {
            openClose.CloseAllForms();
            lifeUnder = new LifeUnder(translationManager, openClose);
            openClose.FadeIn(lifeUnder);
        }

        // LIFE PANEL UNDER END

        // STORIES BEGIN

        private void panelStories_Click(object sender, EventArgs e)
        {
            openClose.CloseAllForms();
            stories = new Stories(translationManager, openClose);
            openClose.FadeIn(stories);
        }

        // STORIES END

        // TIMELINE BEGIN

        private void panelTimeline_Click(object sender, EventArgs e)
        {
            openClose.CloseAllForms();
            timeline = new Timeline(translationManager, openClose);
            openClose.FadeIn(timeline);
        }

        // TIMELINE END

        // LANGUAGE MANAGEMENT BEGIN

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            translationManager.Increment_Language(this);
            Main_Resize(this, new EventArgs());
        }

        private void btnLanguage_TextChanged(object sender, EventArgs e)
        {
            Main_Resize(this, new EventArgs());
        }

        // LANGUAGE MANAGEMENT END

        // CREDITS MANAGEMENT BEGIN

        private void btnCredits_Click(object sender, EventArgs e)
        {
            openClose.CloseAllForms();
            credits = new Credits(citation_Helper);
            openClose.FadeIn(credits);
        }

        // CREDITS MANAGEMENT END

        // HANDLING RESIZE BEGIN

        private void Main_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);

            resize.Repostition_All_Main_Panels(this);

            resize.Center_to_Other_Control(lblHowDidTheRegimeFall, pbRevolution, Resize_Helper.Centering_Options.to_top);

            resize.Glue_to_Corner(btnLanguage, Resize_Helper.Corner.bottom_right);
            resize.Center_to_Other_Control(btnCredits, btnLanguage, Resize_Helper.Centering_Options.to_left);
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
