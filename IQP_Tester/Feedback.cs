using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MOCR.Citation_Helper;
using static System.Net.Mime.MediaTypeNames;

namespace MOCR
{
    public partial class Feedback : Form
    {
        Resize_Helper resize;
        Open_Close_Helper openClose;
        TextManager textManager;
        CSV csv;

        public const string FEEDBACK_FILE_NAME = "feedback.csv";
        public const string AGE_HEADER = "Age";
        public const string NAVIATION_HEADER = "Ease of Navigation";
        public const string HISTORICAL_HEADER = "Questions Helping Understand Narratives";
        public const string RECOMMEND_HEADER = "Would You Recommend?";
        public const string NO_ANSWER = "Null";
        public const string ANS_1 = "1";
        public const string ANS_2 = "2";
        public const string ANS_3 = "3";
        public const string ANS_4 = "4";
        public const string ANS_5 = "5";
        public const string ANS_NO = "No";
        public const string ANS_YES = "Yes";
        public const int NO_ANSWER_COMBO_BOX_INDEX = 0;

        public Feedback(TextManager textManager, Open_Close_Helper openClose, Resize_Helper resize)
        {
            InitializeComponent();
            this.openClose = openClose;
            this.resize = resize;
            this.textManager = textManager;
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            csv = new CSV(FEEDBACK_FILE_NAME);
            if(!csv.Update())
            { // set header
                List <string> header = new List<string>();
                header.Add(AGE_HEADER);
                header.Add(NAVIATION_HEADER);
                header.Add(HISTORICAL_HEADER);
                header.Add(RECOMMEND_HEADER);
                csv.Add(header);
            }

            btnBack.Visible = Settings.btn_back_state;
        }

        private List<string> Add_Answers_To_List()
        {
            List<string> ans = new List<string>();

            // age
            if (comboBoxAge.SelectedIndex > NO_ANSWER_COMBO_BOX_INDEX)
            {
                ans.Add(comboBoxAge.Text);
            }
            else
            {
                ans.Add(NO_ANSWER);
            }

            // navigation
            if (rbNavigate1.Checked)
            {
                ans.Add(ANS_1);
            }
            else if (rbNavigate2.Checked)
            {
                ans.Add(ANS_2);
            }
            else if (rbNavigate3.Checked)
            {
                ans.Add(ANS_3);
            }
            else if (rbNavigate4.Checked)
            {
                ans.Add(ANS_4);
            }
            else if (rbNavigate5.Checked)
            {
                ans.Add(ANS_5);
            }
            else
            {
                ans.Add(NO_ANSWER);
            }

            // historical
            if (rbHistorical1.Checked)
            {
                ans.Add(ANS_1);
            }
            else if (rbHistorical2.Checked)
            {
                ans.Add(ANS_2);
            }
            else if (rbHistorical3.Checked)
            {
                ans.Add(ANS_3);
            }
            else if (rbHistorical4.Checked)
            {
                ans.Add(ANS_4);
            }
            else if (rbHistorical5.Checked)
            {
                ans.Add(ANS_5);
            }
            else
            {
                ans.Add(NO_ANSWER);
            }

            // recommend
            if (rbRecommendYes.Checked)
            {
                ans.Add(ANS_YES);
            }
            else if (rbRecommendNo.Checked)
            {
                ans.Add(ANS_NO);
            }
            else
            {
                ans.Add(NO_ANSWER);
            }

            return ans;
        }

        private bool Something_Done()
        {
            return comboBoxAge.SelectedIndex > NO_ANSWER_COMBO_BOX_INDEX || rbNavigate1.Checked || rbNavigate2.Checked || rbNavigate3.Checked || rbNavigate4.Checked || rbNavigate5.Checked || rbHistorical1.Checked || rbHistorical2.Checked || rbHistorical3.Checked || rbHistorical4.Checked || rbHistorical5.Checked || rbRecommendYes.Checked || rbRecommendNo.Checked;
        }

        private void Feedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            openClose.Close(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Feedback_Click(sender, e);
        }

        private void tableLayoutFeedbackMain_Click(object sender, EventArgs e)
        {
            Feedback_Click(sender, e);
        }

        private void Feedback_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
            textManager.Update_One_Form(this);
        }

        private void Feedback_VisibleChanged(object sender, EventArgs e)
        {
            btnBack.Visible = Settings.btn_back_state;
            textManager.Update_One_Form(this);
            Feedback_Resize(sender, e);
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }

        private void TableLayoutbtnBackAlignFeedback_Click(object sender, EventArgs e)
        {
            Feedback_Click(sender, e);
        }

        private void btnFeedbackClear_Click(object sender, EventArgs e)
        {
            comboBoxAge.SelectedIndex = NO_ANSWER_COMBO_BOX_INDEX;
            rbHistorical1.Checked = false;
            rbHistorical2.Checked = false;
            rbHistorical3.Checked = false;
            rbHistorical4.Checked = false;
            rbHistorical5.Checked = false;
            rbNavigate1.Checked = false;
            rbNavigate2.Checked = false;
            rbNavigate3.Checked = false;
            rbNavigate4.Checked = false;
            rbNavigate5.Checked = false;
            rbRecommendYes.Checked = false;
            rbRecommendNo.Checked = false;
        }

        private void btnFeedbackSubmit_Click(object sender, EventArgs e)
        {
            if (Something_Done())
            {
                List<string> ans = Add_Answers_To_List();
                csv.Add(ans);
                csv.Generate();
                btnFeedbackClear_Click(sender, e);
            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            textManager.Increment_Language(this);
            Feedback_Resize(sender, e);
        }

        private void Feedback_Resize(object sender, EventArgs e)
        {
            if (resize != null)
            {
                resize.Resize_Fonts(this);
            }
        }

        private void btnLanguage_TextChanged(object sender, EventArgs e)
        {
            Feedback_Resize(sender, e);
        }
    }
}
