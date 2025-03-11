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

        private Dictionary<Control, (double width_ratio, double height_ratio)> ratios = new Dictionary<Control, (double width_ratio, double height_ratio)>();
        

        static double panelWhoCeausescu_width_ratio;
        static double panelWhoCeausescu_height_ratio;

        private void History_Resize(object sender, EventArgs e)
        {
            Resize_Panel(panelWhoCeausescu);

            Resize_PB(pbCeasescu);
        }

        private void CaptureRatios()
        {
            place_ratios_in_dictionary(panelWhoCeausescu);
            place_ratios_in_dictionary(pbCeasescu);
            place_ratios_in_dictionary(lblWhoCeausecu);
        }

        private void place_ratios_in_dictionary(Control control)
        {
            ratios[control] = (
                (double)control.Width / control.Parent.Width,
                (double)control.Height / control.Parent.Height
            );
        }

        private void Resize_Panel(Panel panel)
        {
            var items = ratios[panel];
            double width_ratio = items.Item1;
            double height_ratio = items.Item2;

            panel.Height = (int)(height_ratio * this.Height);
            panel.Width = (int)(width_ratio * this.Width);
        }

        private void Resize_PB(PictureBox pb, bool moveDown = true)
        {
            double aspect_ratio = (double)pb.Image.Width / (double)pb.Image.Height;

            int heightPrev = pb.Height;

            var items = ratios[pb];
            double width_ratio = items.Item1;

            pb.Width = (int)(pb.Parent.Width * width_ratio);
            pb.Height = (int)((1 / aspect_ratio) * pb.Width);

            if (moveDown)
            {
                pb.Location = new Point(pb.Location.X, pb.Location.Y - (heightPrev - pb.Height));
            }
        }
    }
}
