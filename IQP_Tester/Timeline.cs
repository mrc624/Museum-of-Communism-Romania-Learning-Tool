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
        Resize_Helper resize = new Resize_Helper();
        Polaroid_Helper polaroid_Helper = new Polaroid_Helper();
        Open_Close_Helper openClose = new Open_Close_Helper();

        public const int START_YEAR = 1947;
        public const int END_YEAR = 1989;
        public const int YEAR_RANGE = END_YEAR - START_YEAR;
        public const int LINE_WIDTH = 3;
        public const string LINE_NAME = "line";
        public int INVALID_LINE = -1;
        public static Color Line_Color = Color.Black;

        Dictionary<Panel, Panel> Panel_Lines = new Dictionary<Panel, Panel>();

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
            Assign_Lines_To_Panels();
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            polaroid_Helper.Find_Polaroids(this);
            ThenAndNow_Resize(this, new EventArgs());
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

        private void Place_Panel_At_Year(Panel panel, int year, Position position, int vertical_offset)
        {
            Point point = Get_Point_From_Year(year, position);

            if (position == Position.Top)
            {
                Point bottom_mid = new Point(point.X, point.Y - vertical_offset);
                Point top_left = new Point(bottom_mid.X - (panel.Width / 2), bottom_mid.Y - panel.Height);
                panel.Location = top_left;
                Resize_Reposition_Line(bottom_mid, point, Panel_Lines[panel]);
                label2.Text = "Panel: " + panel.Location.X.ToString() + ", " + panel.Location.Y.ToString();
            }
            else if (position == Position.Bottom)
            {
                Point top_mid = new Point(point.X, point.Y + vertical_offset);
                Point top_left = new Point(top_mid.X - (panel.Width / 2), top_mid.Y);
                panel.Location = top_left;
                Resize_Reposition_Line(top_mid, point, Panel_Lines[panel]);
                label2.Text = "Panel: " + panel.Location.X.ToString() + ", " + panel.Location.Y.ToString();
            }
            label1.Text = "Line: " + Panel_Lines[panel].Location.X.ToString() + ", " + Panel_Lines[panel].Location.Y.ToString();
        }

        private Point Get_Point_From_Year(int year, Position position)
        {
            Point point = new Point(0, 0);
            int pixels_per_year = pbTimeLine.Width / YEAR_RANGE;
            int x = pixels_per_year * (year - START_YEAR);
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
            resize.Reposition(panelTesting);

            Place_Panel_At_Year(panelTesting, 1956, Position.Top, panelTesting.Location.Y - pbTimeLine.Location.Y);

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
    }
}
