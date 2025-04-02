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
        Polaroid_Helper polaroid_Zoom_Helper = new Polaroid_Helper();
        Open_Close_Helper openClose = new Open_Close_Helper();

        public const int START_YEAR = 1947;
        public const int END_YEAR = 1989;
        public const int YEAR_RANGE = END_YEAR - START_YEAR;
        public const int LINE_WIDTH = 3;
        public const string LINE_NAME = "line";
        public int INVALID_Y_LINE = -1;

        List <Panel> Lines = new List <Panel> ();

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
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            polaroid_Zoom_Helper.Find_Polaroids(this);
            ThenAndNow_Resize(this, new EventArgs());
        }

        public void Place_Control_At_Year(Control control, int year, Position position, int vertical_offset)
        {
            Point point = Get_Point_From_Year(year, position);

            if (position == Position.Top)
            {
                Point bottom_mid = new Point(point.X, point.Y + vertical_offset);
                Point top_left = new Point(bottom_mid.X - (control.Width / 2), bottom_mid.Y + control.Height);
                Draw_Line(point, bottom_mid);
            }
            else if (position == Position.Bottom)
            {
                Point top_mid = new Point(point.X, point.Y - vertical_offset);
                Point top_left = new Point(top_mid.X - (control.Width / 2), top_mid.Y);
                Draw_Line(top_mid, point);
            }
        }

        private Point Get_Point_From_Year(int year, Position position)
        {
            Point point = new Point(0, 0);
            int pixels_per_year = pbTimeLine.Width / YEAR_RANGE;
            int x = pixels_per_year * year;
            if (position == Position.Top)
            {
                point = new Point(x, pbTimeLine.Location.Y);
            }
            else if (position == Position.Bottom)
            {
                point = new Point(x, pbTimeLine.Location.Y - pbTimeLine.Height);
            }
            return point;
        }

        private void Draw_Line(Point from, Point to) // assumes drawing in a straight line, not diagonal
        {
            Panel panel = new Panel();
            panel.Size = new System.Drawing.Size(LINE_WIDTH, Math.Abs(to.Y - from.Y));
            panel.Name = LINE_NAME + Lines.Count;
            panel.Tag = LINE_NAME;
            panel.BackColor = Color.Black;
            panel.TabIndex = Lines.Count;

            if (from.X == to.X)
            {
                int line_x =  from.X - (LINE_WIDTH / 2);
                Point line_point = new Point(line_x, INVALID_Y_LINE);
                if (from.Y > to.Y)
                {
                    line_point.Y = from.Y;
                }
                else if (from.Y < to.Y)
                {
                    line_point.Y = to.Y;
                }
                if (line_point.Y > INVALID_Y_LINE)
                {
                    panel.Location = line_point;
                    Lines.Add(panel);
                    this.Controls.Add(panel);
                    panel.BringToFront();
                }
            }
        }

        private void Delete_All_Lines()
        {
            for (int i = 0; i < Lines.Count; i++)
            {
                this.Controls.Remove(Lines[i]);
            }
        }




























        private void ThenAndNow_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);

            resize.Center_X_Y(pbTimeLine);
            resize.Reposition(panelTesting);

            Place_Control_At_Year(panelTesting, 1956, Position.Top, panelTesting.Location.Y - pbTimeLine.Location.Y);

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
