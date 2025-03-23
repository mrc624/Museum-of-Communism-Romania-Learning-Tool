using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    public class Resize_Helper
    {

        private Dictionary<Control, (double width_ratio, double height_ratio, double percent_right, double percent_down, float fontRatio)> ratios = new Dictionary<Control, (double width_ratio, double height_ratio, double percent_right, double percent_down, float fontRatio)>();

        bool Dictionary_Updated = false;

        public void CaptureAspectRatios(Control parent)
        {
            for (int i = 0; i < parent.Controls.Count; i++)
            {
                Place_Ratios_in_Dictionary(parent.Controls[i]);

                if (parent.Controls[i].HasChildren)
                {
                    CaptureAspectRatios(parent.Controls[i]);
                }
            }

            Dictionary_Updated = true;
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

        public void Handle_Resize(Control control)
        {
            if (Dictionary_Updated)
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

                        if (curr is Button)
                        {
                            Resize_Control(curr);
                        }
                    }

                    if (curr.HasChildren)
                    {
                        Handle_Resize(curr);
                    }
                }
            }
        }

        private void Resize_Panel(Panel panel)
        {
            var items = ratios[panel];
            double width_ratio = items.width_ratio;
            double height_ratio = items.height_ratio;

            panel.Height = (int)(height_ratio * panel.Parent.Height);
            panel.Width = (int)(width_ratio * panel.Parent.Width);
        }

        public void Reposition(Control control)
        {
            if (Dictionary_Updated)
            {
                var items = ratios[control];
                control.Location = new Point((int)(items.percent_right * control.Parent.Width), (int)(items.percent_down * control.Parent.Height));
            }
        }

        public void Center_X(Control control, double percent = 0.5)
        {
            int center = (int)(control.Parent.Width * percent);
            int center_control = (int)(control.Width * percent);
            int center_x = center - center_control;

            control.Location = new Point(center_x, control.Location.Y);
        }

        public void Center_Y(Control control, double percent = 0.5)
        {
            int center = (int)(control.Parent.Height * percent);
            int center_control = (int)(control.Height * percent);
            int center_y = center - center_control;

            control.Location = new Point(control.Location.X, center_y);
        }

        public void Center_X_Y(Control control, double percent_x = 0.5, double percent_y = 0.5)
        {
            Center_X(control, percent_x);
            Center_Y(control, percent_y);
        }

        public enum Centering_Options
        {
            to_left,
            to_bottom,
            to_right,
            to_top,
            num_centering_options
        }

        public void Center_to_Other_Control(Control control, Control other, Centering_Options option = Centering_Options.to_bottom, int offset = 0, double percent = 0.5)
        {
            int control_centering = 0;
            int other_centering = 0;

            if (option == Centering_Options.to_bottom || option == Centering_Options.to_top)
            {
                control_centering = control.Width;
                other_centering = other.Width;
            }
            else if (option == Centering_Options.to_left || option == Centering_Options.to_right)
            {
                control_centering = control.Height;
                other_centering = other.Height;
            }

            int center_control = (int)(control_centering * percent);
            int other_center = (int)(other_centering * percent);

            int location_x = 0;
            int location_y = 0;

            if (option == Centering_Options.to_bottom)
            {
                location_x = other_center - center_control + other.Location.X;
                location_y = other.Location.Y + other.Height + offset;
            }
            else if (option == Centering_Options.to_top)
            {
                location_x = other_center - center_control + other.Location.X;
                location_y = other.Location.Y - offset - control.Height;
            }
            else if (option == Centering_Options.to_left)
            {
                location_x = other.Location.X - offset - control.Width;
                location_y = other_center - center_control + other.Location.Y;
            }
            else if (option == Centering_Options.to_right)
            {
                location_x = other.Location.X + offset + control.Width + other.Width;
                location_y = other_center - center_control + other.Location.Y;
            }

            control.Location = new Point(location_x, location_y);
        }

        private void Resize_PB(PictureBox pb)
        {
            if (Dictionary_Updated)
            {
                double aspect_ratio = (double)pb.Image.Width / (double)pb.Image.Height;

                var items = ratios[pb];
                double width_ratio = items.width_ratio;

                pb.Width = (int)(pb.Parent.Width * width_ratio);
                pb.Height = (int)((1 / aspect_ratio) * pb.Width);
            }
        }

        private void Resize_Font(Control control)
        {
            if (Dictionary_Updated)
            {
                var items = ratios[control];
                float font_ratio = items.fontRatio;

                float newFontSize = (float)control.Parent.Width * font_ratio;

                control.Font = new Font(control.Font.FontFamily, (float)(newFontSize));
            }
        }


        private void Resize_Control(Control control)
        {
            if (Dictionary_Updated)
            {
                var items = ratios[control];
                double width_ratio = items.width_ratio;
                double height_ratio = items.height_ratio;

                control.Width = (int)(control.Parent.Width * width_ratio);
                control.Height = (int)(control.Parent.Height * height_ratio);
            }
        }

        public enum Corner
        {
            top_left,
            top_right,
            bottom_left,
            bottom_right,
            num_corners
        }

        public void Glue_to_Corner(Control control, Corner corner, int margin = 10)
        {
            int parent_width = control.Parent.Width;
            int parent_height = control.Parent.Height;

            switch (corner)
            {
                case Corner.top_left:

                    break;
                case Corner.top_right:

                    break;
                case Corner.bottom_left:

                    break;
                case Corner.bottom_right:
                    control.Location = new Point(parent_width - control.Width - margin, parent_height - control.Height - margin);
                    break;
            }
        }

        public void Expand_to_Top_of_Other(Control control, Control other, int margin = 10) // control must be above other
        {
            int height = other.Location.Y - control.Location.Y - margin;

            control.Height = height;
        }

        public void Fullscreen_Form(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private const int NUM_CONTROLS_IN_PANEL_WITH_PB_LBLQ_LBLANS = 3;
        private const string BEGIN_PICTUREBOX_FLAG = "pb";
        public const string END_ANSWER_FLAG = "Ans";
        public const string END_QUESTION_FLAG = "Q";

        List<Panel> Panels_With_PB_lblQ_lblAns = new List<Panel>();

        public void Find_Panels_With_PB_lblQ_lblAns (Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (Panel_Has_PB_lblQ_lblAns(control))
                {
                    Panels_With_PB_lblQ_lblAns.Add((Panel)control);
                }

                if (control.Controls[i].HasChildren)
                {
                    Find_Panels_With_PB_lblQ_lblAns(control.Controls[i]);
                }
            }
        }

        public void Reposition_Panels_With_PB_lblQ_lblAns()
        {
            for (int i = 0; i < Panels_With_PB_lblQ_lblAns.Count; i++)
            {
                Reposition_Panel_With_PB_lblQ_lblAns(Panels_With_PB_lblQ_lblAns[i]);
            }
        }

        public bool Panel_Has_PB_lblQ_lblAns(Control panel)
        {
            if (panel is Panel && panel.Controls.Count == NUM_CONTROLS_IN_PANEL_WITH_PB_LBLQ_LBLANS)
            {
                bool found_PB = false;
                bool found_Q = false;
                bool found_Ans = false;

                for (int i = 0; i < NUM_CONTROLS_IN_PANEL_WITH_PB_LBLQ_LBLANS; i++)
                {
                    string control_name = panel.Controls[i].Name;
                    if (panel.Controls[i] is PictureBox)
                    {
                        found_PB = true;
                    }
                    else if (control_name.EndsWith(END_QUESTION_FLAG) && panel.Controls[i] is Label)
                    {
                        found_Q = true;
                    }
                    else if (control_name.EndsWith(END_ANSWER_FLAG) && panel.Controls[i] is Label)
                    {
                        found_Ans = true;
                    }
                }

                return found_PB && found_Q & found_Ans;
            }
            else
            {
                return false;
            }
        }

        private void Reposition_Panel_With_PB_lblQ_lblAns(Panel panel)
        {
            if (panel.Controls.Count != NUM_CONTROLS_IN_PANEL_WITH_PB_LBLQ_LBLANS)
            {
                MessageBox.Show("Invalid Amount of Controls in Panel " + panel.Name + "\nCount of: " + panel.Controls.Count + "\n Must be a Count of: " + NUM_CONTROLS_IN_PANEL_WITH_PB_LBLQ_LBLANS);
            }
            else
            {
                Reposition(panel);

                PictureBox picturebox = null;
                Label question = null;
                Label answer = null;

                for (int i = 0; i < NUM_CONTROLS_IN_PANEL_WITH_PB_LBLQ_LBLANS; i++)
                {
                    string control_name = panel.Controls[i].Name;
                    if (panel.Controls[i] is PictureBox)
                    {
                        picturebox = (PictureBox)panel.Controls[i];   
                    }
                    else if (control_name.EndsWith(END_QUESTION_FLAG) && panel.Controls[i] is Label)
                    {
                       question = (Label)panel.Controls[i];
                    }
                    else if (control_name.EndsWith(END_ANSWER_FLAG) && panel.Controls[i] is Label)
                    {
                        answer = (Label)panel.Controls[i];
                    }
                }

                if (picturebox != null && question != null && answer != null)
                {
                    Reposition(picturebox);
                    Center_X(picturebox); // centering x as well, may not be needed becuase calling reposition
                    Center_to_Other_Control(question, picturebox);
                    Center_to_Other_Control(answer, question);
                }
            }
        }
    }
}
