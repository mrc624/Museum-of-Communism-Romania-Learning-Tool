using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    public partial class DoublePolaroid : Form
    {
        Resize_Helper resize;
        Click_Helper click = new Click_Helper();
        DoublePolaroid_Helper doublePolaroid_Helper;
        Open_Close_Helper openClose;
        TextManager textManager;

        public const int GLUE_TO_CORNER_MARGIN = 50;

        Control doublepolaroid;

        Label labelText;

        public DoublePolaroid(Open_Close_Helper open_close, TextManager textMan, Resize_Helper resize, Control DP)
        {
            InitializeComponent();
            openClose = open_close;
            textManager = textMan;
            this.resize = resize;
            doublePolaroid_Helper = new DoublePolaroid_Helper(textMan, open_close, resize);
            doublepolaroid = DP;
            Update_Controls();
            Translate_DoublePolaroid();
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            Set_Clicks();
            resize.Fullscreen_Form(this);
            DoublePolaroid_Resize(this, new EventArgs());
        }

        private void Set_Clicks()
        {
            pbDPNow.Click += DoublePolaroid_Click;
            pbDPThen.Click += DoublePolaroid_Click;
            lblDPText.Click += DoublePolaroid_Click;
            lblDPTitle.Click += DoublePolaroid_Click;
            tableLayoutDPMain.Click += DoublePolaroid_Click;
            tableLayoutDPPictures.Click += DoublePolaroid_Click;
            tableLayoutLanguageDoublePolaroidZoomBtnAlign.Click += DoublePolaroid_Click;
        }

        private void Update_Controls()
        {
            List<PictureBox> pictures = doublePolaroid_Helper.Find_Pb(doublepolaroid);
            labelText = doublePolaroid_Helper.Find_Label(doublepolaroid)[DoublePolaroid_Helper.FIRST_ITEM];
            pbDPThen.Image = pictures[DoublePolaroid_Helper.THEN_INDEX].Image;
            pbDPNow.Image = pictures[DoublePolaroid_Helper.NOW_INDEX].Image;
        }

        public void Update_After_Gen(Control DP)
        {
            doublepolaroid = DP;
            Update_Controls();
            Translate_DoublePolaroid();
            DoublePolaroid_Resize(this, new EventArgs());
        }

        private void Translate_DoublePolaroid()
        {
            lblDPText.Text = textManager.Get_Text(labelText, textManager.Get_Translated_Dictionary());
            btnLanguage.Text = textManager.Get_Text(btnLanguage, textManager.Get_Translated_Dictionary());
            Handle_Long_Text();
            Handle_Title();

        }

        public void Handle_Long_Text()
        {
            string text = textManager.Get_Text(doublePolaroid_Helper.Get_Long_Text_Name(labelText));
            if (text != null && text != DoublePolaroid_Helper.IGNORE_LONG_ANS_FLAG)
            {
                lblDPText.Text = text;
            }
        }

        public void Handle_Title()
        {
            string text = textManager.Get_Text(doublePolaroid_Helper.Get_Title_Name(doublepolaroid));
            if (text != null && text != DoublePolaroid_Helper.IGNORE_TITLE_FLAG)
            {
                lblDPTitle.Text = text;
            }
            else
            {
                lblDPTitle.Text = null;
            }
        }

        private void DoublePolaroid_Resize(object sender, EventArgs e)
        {
            if (resize != null)
            {
                resize.Resize_Fonts(this);
            }
        }

        private void DoublePolaroid_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }

        private void DoublePolaroid_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            textManager.Increment_Language(this);
            DoublePolaroid_Resize(this, new EventArgs());
            Translate_DoublePolaroid();
        }
    }
}
