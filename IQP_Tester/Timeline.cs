using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    public partial class Timeline : Form
    {
        TextManager textManager;
        Open_Close_Helper openClose;
        Resize_Helper resize = new Resize_Helper();
        Polaroid_Helper polaroid_Helper = new Polaroid_Helper();
        Click_Helper click_Helper = new Click_Helper();

        RegimeFall regimeFall;

        public const int START_YEAR = 1947;
        public const int END_YEAR = 1989;
        public const int YEAR_RANGE = END_YEAR - START_YEAR;
        public const int LINE_WIDTH = 3;
        public const string LINE_NAME = "line";
        public int INVALID_LINE = -1;
        public static Color Line_Color = Color.Black;

        Dictionary<Panel, Panel> Panel_Lines = new Dictionary<Panel, Panel>();
        Dictionary<Control, Rectangle> Originals = new Dictionary<Control, Rectangle>();

        public enum Position
        {
            Top,
            Bottom,
            Left,
            Right,
            Center,
            Num_Positions
        }

        public Timeline(TextManager textMan, Open_Close_Helper open_close)
        {
            InitializeComponent();
            openClose = open_close;
            textManager = textMan;
            Capture_Original_Size_Location(this);
            Assign_Lines_To_Panels();
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            polaroid_Helper.Find_Polaroids(this);
            ThenAndNow_Resize(this, new EventArgs());
            Set_Panel_Clicks();
            polaroid_Helper.Assign_Click_Handler_To_Valid(this, textMan, open_close);
        }

        private void Set_Panel_Clicks()
        {
            click_Helper.Assign_All_Children_To_Same_Click(panelRegimeFall, panelRegimeFall_Click);
        }

        private void Assign_Lines_To_Panels()
        {
            List<Panel> lines = new List<Panel>();
            List<Panel> panels = new List<Panel>();
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Panel)
                {
                    Panel panel = (Panel)this.Controls[i];
                    if (Panel_Is_Line(panel))
                    {
                        lines.Add(panel);
                    }
                    else
                    {
                        panels.Add(panel);
                    }
                }
            }

            for (int i = 0; i < Math.Min(panels.Count, lines.Count); i++)
            {
                Panel_Lines[panels[i]] = lines[i];
            }
        }

        private bool Panel_Is_Line(Panel line)
        {
            return line.BackColor == Line_Color;
        }

        private void Place_Panel_With_Line_At_Year(Panel panel, int year, Position position)
        {
            if (year < START_YEAR)
            {
                resize.Center_to_Other_Control(panel, pbTimeLine, Resize_Helper.Centering_Options.to_left);
                Panel_Lines[panel].Visible = false;
            }
            else if (year > END_YEAR)
            {
                resize.Center_to_Other_Control(panel, pbTimeLine, Resize_Helper.Centering_Options.to_right);
                Panel_Lines[panel].Visible = false;
            }
            else
            {
                Point point = Get_Point_From_Year(year, position);
                int vertical_offset = Get_Vertical_Offset(pbTimeLine, panel);
                if (vertical_offset < 0)
                {
                    return;
                }
                if (position == Position.Top)
                {
                    Point bottom_mid = new Point(point.X, point.Y - vertical_offset);
                    Point top_left = new Point(bottom_mid.X - (panel.Width / 2), bottom_mid.Y - panel.Height);
                    panel.Location = top_left;
                    Resize_Reposition_Line(bottom_mid, point, Panel_Lines[panel]);
                }
                else if (position == Position.Bottom)
                {
                    Point top_mid = new Point(point.X, point.Y + vertical_offset);
                    Point top_left = new Point(top_mid.X - (panel.Width / 2), top_mid.Y);
                    panel.Location = top_left;
                    Resize_Reposition_Line(top_mid, point, Panel_Lines[panel]);
                }
            }
        }

        private int Get_Vertical_Offset(Control timeline, Panel panel)
        {
            int original_offset = 0;
            if (Originals[timeline].Location.Y > Originals[panel].Location.Y)
            {
                original_offset = Originals[timeline].Location.Y - (Originals[panel].Location.Y + Originals[panel].Height);
            }
            else if (Originals[timeline].Location.Y + Originals[timeline].Height < Originals[panel].Location.Y)
            {
                original_offset = Originals[panel].Location.Y - (Originals[timeline].Location.Y + Originals[timeline].Height);
            }
            else
            {
                return 0;
            }

            if (timeline.Location.Y > panel.Location.Y)
            {
                int height_change = panel.Height - Originals[panel].Height;
                int offset = original_offset - height_change;
                if (offset < 0)
                {
                    return 0;
                }
                else
                {
                    return offset;
                }
            }
            else if (timeline.Location.Y + timeline.Height < panel.Location.Y)
            {
                int height_change = timeline.Height - Originals[timeline].Height;
                int offset = original_offset - height_change;
                if (offset < 0)
                {
                    return 0;
                }
                else
                {
                    return offset;
                }
            }
            else
            {
                return 0;
            }
        }

        private void Capture_Original_Size_Location(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is Panel || control.Controls[i] is PictureBox)
                {
                    Rectangle rectange = control.Controls[i].Bounds;
                    Originals[control.Controls[i]] = rectange;
                    string name = control.Controls[i].Name; // debug
                }
                if (control.Controls[i].HasChildren)
                {
                    Capture_Original_Size_Location(Controls[i]);
                }
            }
        }

        private Point Get_Point_From_Year(int year, Position position)
        {
            Point point = new Point(0, 0);
            int pixels_per_year = pbTimeLine.Width / YEAR_RANGE;
            int x = pixels_per_year * (year - START_YEAR) + pbTimeLine.Location.X;
            if (position == Position.Top)
            {
                point = new Point(x, pbTimeLine.Location.Y);
            }
            else if (position == Position.Bottom)
            {
                point = new Point(x, pbTimeLine.Location.Y + pbTimeLine.Height);
            }
            return point;
        }

        private void Resize_Reposition_Line(Point from, Point to, Panel line) // assumes drawing in a straight line, not diagonal
        {
            if (!Panel_Is_Line(line))
            {
                return;
            }
            else if (from.X == to.X)
            {
                line.Size = new System.Drawing.Size(LINE_WIDTH, Math.Abs(to.Y - from.Y));
                int line_x =  from.X - (LINE_WIDTH / 2);
                Point line_point = new Point(line_x, INVALID_LINE);
                if (from.Y < to.Y)
                {
                    line_point.Y = from.Y;
                }
                else if (from.Y > to.Y)
                {
                    line_point.Y = to.Y;
                }
                if (line_point.Y > INVALID_LINE)
                {
                    line.Location = line_point;
                }
            }
            else if (from.Y == to.Y)
            {
                line.Size = new System.Drawing.Size(Math.Abs(to.X - from.X), LINE_WIDTH);
                int line_y = from.Y - (LINE_WIDTH / 2);
                Point line_point = new Point(INVALID_LINE, line_y);
                if (from.X > to.X)
                {
                    line_point.X = from.X;
                }
                else if (from.X < to.X)
                {
                    line_point.X = to.X;
                }
                if (line_point.X > INVALID_LINE)
                {
                    line.Location = line_point;
                }
            } // if all if statements fail the line is not a straight line
        }

        private void ThenAndNow_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);

            resize.Center_X_Y(pbTimeLine);


            polaroid_Helper.Reposition_Polaroids(polaroid_Helper.Polaroids);

            Place_Panel_With_Line_At_Year(panelAna, 1947, Position.Top);
            Place_Panel_With_Line_At_Year(panelWarsaw, 1969, Position.Bottom);
            Place_Panel_With_Line_At_Year(panelJuly, 1971, Position.Top);
            Place_Panel_With_Line_At_Year(panelHousePeople, 1984, Position.Bottom);
            Place_Panel_With_Line_At_Year(panelRegimeFall, 1989, Position.Top);

            resize.Center_X(pbRevolution);
            resize.Center_to_Other_Control(lblHowDidTheRegimeFall, pbRevolution, Resize_Helper.Centering_Options.to_top);

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
            textManager.Increment_Language(this);
        }

        private void btnLanguage_TextChanged(object sender, EventArgs e)
        {
            ThenAndNow_Resize(this, new EventArgs());
        }

        // Regime Fall

        private void panelRegimeFall_Click(object sender, EventArgs e)
        {
            regimeFall = new RegimeFall(textManager, openClose);
            openClose.FadeIn(regimeFall);
        }
    }
}
