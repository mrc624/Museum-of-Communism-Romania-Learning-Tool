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
    public partial class Oppression : Form
    {
        TranslationManager translationManager;
        Resize_Helper resize = new Resize_Helper();
        Polaroid_Zoom_Helper polaroid_Zoom_Helper = new Polaroid_Zoom_Helper();
        Open_Close_Helper openClose = new Open_Close_Helper();

        public Oppression(TranslationManager translationMan, Open_Close_Helper open_close)
        {
            InitializeComponent();
            openClose = open_close;
            translationManager = translationMan;
            translationManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            resize.Find_Panels_With_PB_lblQ_lblAns(this);
            ThenAndNow_Resize(this, new EventArgs());
        }

        private void ThenAndNow_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);



            resize.Glue_to_Corner(btnLanguage, Resize_Helper.Corner.bottom_right);
        }

        private void ThenAndNow_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }

        private void ThenAndNow_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            translationManager.Increment_Language(this);
        }

        private void btnLanguage_TextChanged(object sender, EventArgs e)
        {
            ThenAndNow_Resize(this, new EventArgs());
        }
    }
}
