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
            }
            else if (position == Position.Bottom)
            {
                Point top_mid = new Point(point.X, point.Y - vertical_offset);
                Point top_left = new Point(top_mid.X - (control.Width / 2), top_mid.Y);
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

        private void Draw_Line(Point from, Point to)
        {
            
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
