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
            CaptureRatios();
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
            Resize_Panel(panelWhoCeausescu);

            Resize_PB(pbCeasescu);
            center_label_to_pb(lblWhoCeausecu, pbCeasescu);

            Resize_Font(lblWhoCeausecu);
            Reposition(pbCeasescu);
        }

        private void CaptureRatios()
        {
            place_ratios_in_dictionary(panelWhoCeausescu);
            place_ratios_in_dictionary(pbCeasescu);
            place_ratios_in_dictionary(lblWhoCeausecu);
        }

        private void place_ratios_in_dictionary(Control control)
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

        private void center_label_to_pb(Control control, Control pb, int height_offset = 0, double percent = 0.5)
        {
            int center = (int)(pb.Width * percent);
            int center_control = (int)(control.Width * percent);
            int location_x = center - center_control + pb.Location.X;

            int location_y = pb.Location.Y + pb.Height + height_offset;

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
