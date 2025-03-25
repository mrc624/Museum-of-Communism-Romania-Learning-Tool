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

        TranslationManager translationManager = new TranslationManager();
        Resize_Helper resize = new Resize_Helper();
        Open_Close_Helper openClose = new Open_Close_Helper();
        Click_Helper click_helper = new Click_Helper();

        public static List<Form> Forms = new List<Form>();

        RegimeFall regimeFall;

        Credits credits;

        private System.Timers.Timer Timer;
        public const uint tabTimeout = 10; //in seconds
        uint lastOpenTime = 0;
        public static uint seconds = 0;

        public Main()
        {
            InitializeComponent();
            Add_Forms();
            resize.CaptureAspectRatios(this);
            translationManager.Generate_Translation_JSON(TranslationManager.translation_file_name);
            translationManager.Update_One_Form(this);
            Set_Panel_Clicks();
            Main_Resize(this, new EventArgs());
            SetTimer();
        }

        private void Set_Panel_Clicks()
        {
            click_helper.Assign_All_Children_To_Same_Click(panelRegimeFall, panelRegimeFall_Click);
        }

        private void Add_Forms()
        {
            Forms.Add(this);

            regimeFall = new RegimeFall(translationManager);
            Forms.Add(regimeFall);
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

        // MAIN PAGE END   (NOT PANELS)

        // HISTORY PANEL BEGIN

        private void panelRegimeFall_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            lastOpenTime = seconds;
            regimeFall = new RegimeFall(translationManager);
            openClose.FadeIn(regimeFall);
        }

        // HISTORY PANEL END


        // LIFE PANEL BEGIN



        // LIFE PANEL END

        // PROPOGANDA PANEL BEGIN



        // PROPOGANDA PANEL END

        // PRESENT DAY PANEL BEGIN
        


        // PRESENT DAY PANEL END

        // TAB MANAGEMENT BEGIN

        private void CloseAllForms()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] != this)
                {
                    openClose.Close(Application.OpenForms[i]);
                }
            }
        }

        // TAB MANAGEMENT END

        // LANGUAGE MANAGEMENT BEGIN

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            translationManager.Increment_Language(this);
            Main_Resize(this, new EventArgs());
        }

        // LANGUAGE MANAGEMENT END

        // CREDITS MANAGEMENT BEGIN

        private void btnCredits_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            credits = new Credits();
            openClose.FadeIn(credits);
        }

        // CREDITS MANAGEMENT END

        // HANDLING RESIZE BEGIN

        private void Main_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);

            resize.Reposition(panelRegimeFall);
            resize.Reposition(panelCeausescu);
            resize.Reposition(panelLifeUnder);
            resize.Reposition(panelPresentDay);

            resize.Reposition(lblHowDidTheRegimeFall);
            resize.Center_X(lblHowDidTheRegimeFall);
            resize.Reposition(lblWhoWasCeausescu);
            resize.Center_X(lblWhoWasCeausescu);
            resize.Reposition(lblHowWasLifeUnderRegime);
            resize.Center_X(lblHowWasLifeUnderRegime);
            resize.Reposition(lblWhatWasEducationLike);
            resize.Center_X(lblWhatWasEducationLike);

            resize.Reposition(lblMainTitle);
            resize.Center_X(lblMainTitle);

            resize.Reposition(pbCeasescu);
            resize.Reposition(pbRevolution);
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
