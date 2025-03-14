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

        public static List<Form> Forms = new List<Form>();

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
            Add_Forms();
            translationManager.Generate_Translation_JSON(TranslationManager.translation_file_name);
            translationManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            Main_Resize(this, new EventArgs());
            SetTimer();
        }

        private void Add_Forms()
        {
            Forms.Add(this);

            history = new History(translationManager);
            Forms.Add(history);
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

        private void panelHistory_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            lastOpenTime = seconds;
            history = new History(translationManager);
            FadeIn(history);
        }

        // HISTORY PANEL END


        // LIFE PANEL BEGIN



        // LIFE PANEL END

        // PROPOGANDA PANEL BEGIN



        // PROPOGANDA PANEL END

        // PRESENT DAY PANEL BEGIN



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
            translationManager.Increment_Language(this);
            Main_Resize(this, new EventArgs());
        }

        // LANGUAGE MANAGEMENT END

        // HANDLING RESIZE BEGIN

        private void Main_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);

            resize.Reposition(panelHistory);
            resize.Reposition(panelLife);
            resize.Reposition(panelPropoganda);
            resize.Reposition(panelPost1989);

            resize.Reposition(lblHistory);
            resize.Center_X(lblHistory);
            resize.Reposition(lblKidsLife);
            resize.Center_X(lblKidsLife);
            resize.Reposition(lblPropoganda);
            resize.Center_X(lblPropoganda);
            resize.Reposition(lblPresentDay);
            resize.Center_X(lblPresentDay);

            resize.Reposition(lblMainTitle);
            resize.Center_X(lblMainTitle);

            resize.Reposition(pbCeasescu);
            resize.Reposition(pbRevolution);
            resize.Center_to_Other_Control(lblCeausecu, pbCeasescu);
            resize.Center_to_Other_Control(lblRevolution, pbRevolution);

            resize.Glue_to_Corner(btnLanguage, Resize_Helper.Corner.bottom_right);

            resize.Expand_to_Top_of_Other(panelHistory, btnLanguage);
            resize.Expand_to_Top_of_Other(panelLife, btnLanguage);
            resize.Expand_to_Top_of_Other(panelPropoganda, btnLanguage);
            resize.Expand_to_Top_of_Other(panelPost1989, btnLanguage);
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
