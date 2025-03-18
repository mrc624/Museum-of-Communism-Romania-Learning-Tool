using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace IQP_Tester
{
    public partial class RegimeFall : Form
    {
        TranslationManager translationManager;
        Resize_Helper resize = new Resize_Helper();
        
        public RegimeFall(TranslationManager translationMan)
        {
            translationManager = translationMan;
            InitializeComponent();
            translationManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            resize.Find_Panels_With_PB_lblQ_lblAns(this);
            History_Resize(this, new EventArgs());
        }

        private void History_Shown(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void History_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Resize

        private Dictionary<Control, (double width_ratio, double height_ratio, double percent_right, double percent_down, float fontRatio)> ratios = new Dictionary<Control, (double width_ratio, double height_ratio, double percent_right, double percent_down, float fontRatio)>();
        
        private void History_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);

            resize.Reposition_Panels_With_PB_lblQ_lblAns();

            /*
            resize.Reposition(panelWhatWasRevolution);
            resize.Reposition(pbWhatWasRevolution);
            resize.Center_to_Other_Control(lblWhatWasRevolutionQ, pbWhatWasRevolution);
            resize.Center_to_Other_Control(lblWhatWasRevolutionAns, lblWhatWasRevolutionQ);
            */

            resize.Glue_to_Corner(btnLanguage, Resize_Helper.Corner.bottom_right);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            translationManager.Increment_Language(this);
            History_Resize(this, new EventArgs());
        }
    }
}
