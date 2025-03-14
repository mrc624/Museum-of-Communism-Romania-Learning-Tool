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
    public partial class History : Form
    {
        TranslationManager translationManager;
        Resize_Helper resize = new Resize_Helper();

        public History(TranslationManager translationMan)
        {
            translationManager = translationMan;
            InitializeComponent();
            translationManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            History_Resize(this, new EventArgs());
        }

        private void History_Shown(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
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

            resize.Reposition(pbCeasescu);

            resize.Center_to_Other_Control(lblWhoCeausecu, pbCeasescu);

            resize.Center_to_Other_Control(lbllWhoCeausesescuAns, lblWhoCeausecu);

            resize.Glue_to_Corner(btnLanguage, Resize_Helper.Corner.bottom_right);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            translationManager.Increment_Language(this);
            History_Resize(this, new EventArgs());
        }
    }
}
