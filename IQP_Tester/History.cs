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
        public History()
        {
            InitializeComponent();
        }

        private void History_Shown(object sender, EventArgs e)
        {
            CaptureAspectRatios(this);
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
        

        static double panelWhoCeausescu_width_ratio;
        static double panelWhoCeausescu_height_ratio;

        private void History_Resize(object sender, EventArgs e)
        {
            Handle_Resize(this);

            Reposition(pbCeasescu);

            Center_to_Other_Control(lblWhoCeausecu, pbCeasescu);
        }

        private void Handle_Resize(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                Control curr = control.Controls[i];
                if (curr is Panel)
                {
                    Resize_Panel((Panel)curr);
                }
                else if (curr is PictureBox)
                {
                    Resize_PB((PictureBox)curr);
                }
                else
                {
                    if (curr.Font != null)
                    {
                        Resize_Font(curr);
                    }
                }

                if (curr.HasChildren)
                {
                    Handle_Resize(curr);
                }
            }
        }

        private void CaptureAspectRatios(Control parent)
        {
            for (int i = 0; i < parent.Controls.Count; i++)
            {
                Place_Ratios_in_Dictionary(parent.Controls[i]);

                if (parent.Controls[i].HasChildren)
                {
                    CaptureAspectRatios(parent.Controls[i]);
                }
            }
        }

        private void Place_Ratios_in_Dictionary(Control control)
        {
            if (control.Font != null)
            {
                ratios[control] = (
                    (double)control.Width / control.Parent.Width,
                    (double)control.Height / control.Parent.Height,
                    (double)control.Location.X / control.Parent.Width,
                    (double)control.Location.Y / control.Parent.Height,
                    control.Font.Size / (float)control.Parent.Width
                );
            }
            else
            {
                ratios[control] = (
                    (double)control.Width / control.Parent.Width,
                    (double)control.Height / control.Parent.Height,
                    (double)control.Location.X / control.Parent.Width,
                    (double)control.Location.Y / control.Parent.Height,
                    0
                );
            }
        }

        private void Resize_Panel(Panel panel)
        {
            var items = ratios[panel];
            double width_ratio = items.width_ratio;
            double height_ratio = items.height_ratio;

            panel.Height = (int)(height_ratio * this.Height);
            panel.Width = (int)(width_ratio * this.Width);
        }

        private void Resize_PB(PictureBox pb)
        {
            double aspect_ratio = (double)pb.Image.Width / (double)pb.Image.Height;

            var items = ratios[pb];
            double width_ratio = items.width_ratio;

            pb.Width = (int)(pb.Parent.Width * width_ratio);
            pb.Height = (int)((1 / aspect_ratio) * pb.Width);
        }

        private void Center_to_Other_Control(Control control, Control other, int height_offset = 0, double percent = 0.5)
        {
            int center = (int)(other.Width * percent);
            int center_control = (int)(control.Width * percent);
            int location_x = center - center_control + other.Location.X;

            int location_y = other.Location.Y + other.Height + height_offset;

            control.Location = new Point(location_x, location_y);
        }

        private void Resize_Font(Control control)
        {
            var items = ratios[control];
            float font_ratio = items.fontRatio;

            float newFontSize = (float)control.Parent.Width * font_ratio;

            control.Font = new Font(control.Font.FontFamily, (float)(newFontSize));
        }
        
        private void Reposition(Control control)
        {
            var items = ratios[control];

            control.Location = new Point((int)(items.percent_right * control.Parent.Width), (int)(items.percent_down * control.Parent.Height));
        }
    }
}
