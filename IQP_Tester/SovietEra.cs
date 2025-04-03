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
    public partial class SovietEra : Form
    {
        TextManager textManager;
        Resize_Helper resize = new Resize_Helper();
        Polaroid_Helper polaroid_Helper = new Polaroid_Helper();
        Open_Close_Helper openClose = new Open_Close_Helper();


        public SovietEra(TextManager textMan, Open_Close_Helper open_close)
        {
            InitializeComponent();
            openClose = open_close;
            textManager = textMan;
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            polaroid_Helper.Find_Polaroids(this);
            Soviet_Era_Resize(this, new EventArgs());

            polaroid_Helper.Assign_Click_Handler_To_Valid(this, textMan, openClose);
        }

        private void Soviet_Era_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
        }

        private void Soviet_Era_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }
        
        private void Soviet_Era_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);

            polaroid_Helper.Reposition_Polaroids(polaroid_Helper.Polaroids);
            resize.Center_X_Y(panelPostWW2, Resize_Helper.QUARTER, Resize_Helper.CENTER);
            resize.Center_X_Y(panelMarxism, Resize_Helper.CENTER, Resize_Helper.CENTER);
            resize.Center_X_Y(panelGheorghe, Resize_Helper.THREE_QUARTERS, Resize_Helper.CENTER);

            resize.Glue_to_Corner(btnLanguage, Resize_Helper.Corner.bottom_right);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            textManager.Increment_Language(this);
        }

        private void btnLanguage_TextChanged(object sender, EventArgs e)
        {
            Soviet_Era_Resize(this, new EventArgs());
        }
    }
}
