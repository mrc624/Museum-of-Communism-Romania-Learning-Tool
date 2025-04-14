using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace IQP_Tester
{
    public partial class CeausescusRise : Form
    {
        TextManager textManager;
        Resize_Helper resize;
        Polaroid_Helper polaroid_Helper = new Polaroid_Helper();
        Open_Close_Helper openClose;
        Click_Helper click_Helper;


        public CeausescusRise(TextManager textMan, Open_Close_Helper open_close, Resize_Helper resize)
        {
            InitializeComponent();
            openClose = open_close;
            textManager = textMan;
            this.resize = resize;
            click_Helper = new Click_Helper(polaroid_Helper);
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            polaroid_Helper.Find_Polaroids(this);

            polaroid_Helper.Assign_Click_Handler_To_Valid(this, textMan,resize, openClose);
            click_Helper.Assign_Children_To_Same_Click_Avoid_Polaroids(this, CeausescusRise_Click);
        }

        private void CeausescusRise_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
            textManager.Update_One_Form(this);
            CeausescusRise_Resize(this, new EventArgs());
        }

        private void CeausescusRise_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            openClose.Close(this);
        }
        
        private void CeausescusRise_Resize(object sender, EventArgs e)
        {
            resize.Resize_Fonts(this);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            textManager.Increment_Language(this);
        }

        private void btnLanguage_TextChanged(object sender, EventArgs e)
        {
            CeausescusRise_Resize(this, new EventArgs());
        }

        private void CeausescusRise_VisibleChanged(object sender, EventArgs e)
        {
            textManager.Update_One_Form(this);
            CeausescusRise_Resize(this, new EventArgs());
        }
    }
}
