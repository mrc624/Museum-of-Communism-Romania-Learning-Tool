using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IQP_Tester.Timeline;

namespace IQP_Tester
{
    public partial class Timeline : Form
    {
        TextManager textManager;
        Open_Close_Helper openClose;
        Resize_Helper resize;
        Polaroid_Helper polaroid_Helper = new Polaroid_Helper();
        Click_Helper click_Helper;
        TableLayout_Helper tableLayoutHelper = new TableLayout_Helper();

        public RegimeFall regimeFall;
        public CeausescusRise ceausescusRise;
        public SovietEra sovietEra;

        public const int START_YEAR = 1941;
        public const int END_YEAR = 1989;
        public const int TICKS_EVERY = 10;
        public const int YEAR_RANGE = END_YEAR - START_YEAR;
        public const int LINE_WIDTH = 3;
        public const int DEFAULT_LINE_HEIGHT = 0;
        public const int DEFAULT_LINE_X = 0;
        public const int DEFAULT_LINE_Y = 0;
        public const string LINE_NAME = "line";
        public const string YEAR_LABEL_NAME = "year";
        public int INVALID_LINE = -1;
        private static readonly Color Line_Color = Color.Black;

        Dictionary<Control, Panel> Lines_Assignments = new Dictionary<Control, Panel>();
        Dictionary<Control, Rectangle> Originals = new Dictionary<Control, Rectangle>();
        List<Label> Year_Labels = new List<Label>();

        public enum Position
        {
            Top,
            Bottom,
            Left,
            Right,
            Center,
            Num_Positions
        }

        public Timeline(TextManager textMan, Open_Close_Helper open_close, Resize_Helper resize, RegimeFall regime, CeausescusRise ceausescus, SovietEra soviet)
        {
            InitializeComponent();

            regimeFall = regime;
            ceausescusRise = ceausescus;
            sovietEra = soviet;
            this.resize = resize;
            click_Helper = new Click_Helper(polaroid_Helper);

            Make_Year_Lables(this);
            Make_Assign_Lines(this);
            openClose = open_close;
            textManager = textMan;
            Capture_Original_Size_Location(this);
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            polaroid_Helper.Find_Polaroids(this);
            Set_Panel_Clicks();
            polaroid_Helper.Assign_Click_Handler_To_Valid(this, textMan, resize, open_close);
            click_Helper.Assign_Children_To_Same_Click_Avoid_Polaroids(this, Timeline_Click);
        }

        private void Set_Panel_Clicks()
        {
            click_Helper.Assign_All_Children_To_Same_Click(panelRegimeFall, panelRegimeFall_Click);
            click_Helper.Assign_All_Children_To_Same_Click(panelCeausescusRise, panelCeausescusRise_Click);
            click_Helper.Assign_All_Children_To_Same_Click(panelSoviet, panelSoviet_Click);
        }

        private void Make_Assign_Lines(Control parent)
        {
            for (int i = 0; i < parent.Controls.Count; i++)
            {
                if (parent.Controls[i].HasChildren)
                {
                    Make_Assign_Lines(parent.Controls[i]);
                }

                Control control = parent.Controls[i];
                if ((control is Panel || control is Label) && !Is_Line(control))
                {
                    Panel line = Get_Line(LINE_NAME + i.ToString());
                    this.Controls.Add(line);
                    Lines_Assignments[control] = line;
                }
            }
        }

        private bool Is_Line(Control control)
        {
            return control is Panel && control.Name.StartsWith(LINE_NAME);
        }

        private void Make_Year_Lables(Form form)
        {
            int start_ticks = Get_Start_ticks();

            int ticks = ((Get_End_Ticks() - start_ticks) / TICKS_EVERY) + 1;

            for (int i = 0; i < ticks; i++)
            {
                int year = start_ticks + (i * TICKS_EVERY);
                Label label = tableLayoutHelper.Get_Label(year.ToString(), YEAR_LABEL_NAME + i.ToString(), TableLayout_Helper.STANDARD_FONT_SIZE, TableLayout_Helper.STANDARD_ANCHOR, TableLayout_Helper.STANDARD_ALIGN);
                label.ForeColor = Color.White;
                label.BackColor = Color.Transparent;
                Year_Labels.Add(label);
                this.Controls.Add(label);
            }
        }

        private bool Year_Is_Valid(int year)
        {
            return (year >= START_YEAR) && (year <= END_YEAR);
        }

        private int Get_Start_ticks()
        {
            int remainder_start = START_YEAR % TICKS_EVERY;
            int add_to_start = TICKS_EVERY - remainder_start;
            if (remainder_start <= 0)
            {
                add_to_start = 0;
            }
            return START_YEAR + add_to_start;
        }

        private int Get_End_Ticks()
        {
            int remainder_end = END_YEAR % TICKS_EVERY;
            int subtract_from_end = TICKS_EVERY - remainder_end;
            if (remainder_end <= 0)
            {
                subtract_from_end = 0;
            }
            return END_YEAR - subtract_from_end;
        }

        private Panel Get_Line(string name, int x = DEFAULT_LINE_X, int y = DEFAULT_LINE_Y, int width = LINE_WIDTH, int height = DEFAULT_LINE_HEIGHT)
        {
            Panel panel = new Panel();

            panel.Location = new System.Drawing.Point(x, y);
            panel.Name = name;
            panel.Size = new System.Drawing.Size(width, height);
            panel.TabIndex = this.Controls.Count;
            panel.BackColor = Line_Color;

            return panel;
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
                Lines_Assignments[panel].Visible = false;
            }
            else if (year > END_YEAR)
            {
                resize.Center_to_Other_Control(panel, pbTimeLine, Resize_Helper.Centering_Options.to_right);
                Lines_Assignments[panel].Visible = false;
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
                    Resize_Reposition_Line(bottom_mid, point, Lines_Assignments[panel]);
                }
                else if (position == Position.Bottom)
                {
                    Point top_mid = new Point(point.X, point.Y + vertical_offset);
                    Point top_left = new Point(top_mid.X - (panel.Width / 2), top_mid.Y);
                    panel.Location = top_left;
                    Resize_Reposition_Line(top_mid, point, Lines_Assignments[panel]);
                }
            }
        }

        // this function does not work properly
        /*
        private void TableLayout_Adjust_Position_Draw_Line(Panel panel, int year, Position position)
        {
            if ((position == Position.Top || position == Position.Bottom) && Year_Is_Valid(year))
            {
                TableLayout_Adjust_Position(panel, year, position);
                Point time_point = Get_Point_From_Year(year, position);
                Resize_Reposition_Line(panel.Location, time_point, Lines_Assignments[panel]);
            }
        }
        */
        // this function does not work properly
        /*
        private void TableLayout_Adjust_Position(Panel panel, int year, Position position) // for this to work the panels must already be in the right order from left to right and the function must be called on the panels from left to right
        {
            if (panel != null && Year_Is_Valid(year) && panel.Parent is TableLayoutPanel && pbTimeLine.Parent is TableLayoutPanel && (position == Position.Top || position == Position.Bottom))
            {
                Point timeline_point = Get_Point_From_Year(year, position);
                double time_point_percent = (double)timeline_point.X / (double)pbTimeLine.Width;
                int panel_column = tableLayoutTimelineTop.GetColumn(panel);
                double panel_percent = 0;
                if (position == Position.Top)
                {
                    panel_percent = Get_Percent_Up_To(tableLayoutTimelineTop, panel_column);
                }
                else if (position == Position.Bottom)
                {
                    panel_percent = Get_Percent_Up_To(tableLayoutTimelineBottom, panel_column);
                }
                int column_to_change = panel_column - 1; // we're going to change the size of the column before it to adjust it's position
                if (time_point_percent > panel_percent) // we need to move the panel to the right
                {
                    double diff = time_point_percent - panel_percent;
                    if (position == Position.Top)
                    {
                        Change_Column_Percent(tableLayoutTimelineTop, column_to_change, (float)diff);
                    }
                    else if (position == Position.Bottom)
                    {
                        Change_Column_Percent(tableLayoutTimelineBottom, column_to_change, (float)diff);
                    }
                }
                else if (time_point_percent < panel_percent) // we need to move the panel to the left
                {
                    double diff = panel_percent - time_point_percent;
                    if (position == Position.Top)
                    {
                        Change_Column_Percent(tableLayoutTimelineTop, column_to_change, (float)diff);
                    }
                    else if (position == Position.Bottom)
                    {
                        Change_Column_Percent(tableLayoutTimelineBottom, column_to_change, (float)diff);
                    }
                }
            }
        }
        */

        private double Get_Percent_Up_To(TableLayoutPanel tableLayoutPanel, int column)
        {
            double percent = 0;
            TableLayoutColumnStyleCollection column_styles = tableLayoutPanel.ColumnStyles;
            for (int i = 0; i < column; i++)
            {
                percent += column_styles[i].Width;
            }
            return percent;
        }

        private void Change_Column_Percent(TableLayoutPanel tableLayoutPanel, int column, float percent)
        {
            tableLayoutPanel.ColumnStyles[column].Width = percent;
        }


        private void Place_Labels_And_Ticks()
        {
            int start_ticks = Get_Start_ticks();
            for (int i = 0; i < Year_Labels.Count; i++)
            {
                Place_Label_With_Tick_At_Year(Year_Labels[i], start_ticks + (i * TICKS_EVERY));
            }
        }

        private void Place_Label_With_Tick_At_Year(Label label, int year)
        {
            if (year < START_YEAR)
            {
                label.Location = new Point(0, 0);
                label.Visible = false;
            }
            else if (year > END_YEAR)
            {
                label.Location = new Point(0, 0);
                label.Visible = false;
            }
            else
            {
                Point point_top = Get_Point_From_Year(year, Position.Top);
                Point point_bottom = Get_Point_From_Year(year, Position.Bottom);
                int middle_y = (point_top.Y + point_bottom.Y) / 2;
                label.Location = new Point(point_top.X - (label.Width / 2), middle_y - (label.Height / 2));
                Resize_Reposition_Line(point_top, point_bottom, Lines_Assignments[label]);
                Lines_Assignments[label].BringToFront();
                label.BringToFront();
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
                Rectangle rectange = control.Controls[i].Bounds;
                Originals[control.Controls[i]] = rectange;
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
                    line.BringToFront();
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
                    line.BringToFront();
                }
            } // if all if statements fail the line is not a straight line
        }

        private void Reposition_Line_From_Middle_To_Timeline(Panel panel, Position position)
        {
            Point from = new Point();
            Point to = new Point();

            if (position == Position.Top)
            {
                from.X = panel.PointToScreen(Point.Empty).X + (panel.Width / 2);
                from.Y = panel.PointToScreen(Point.Empty).Y + panel.Height;
                to.Y = pbTimeLine.PointToScreen(Point.Empty).Y + (pbTimeLine.Height / 2);
                to.X = from.X;
            }
            else if (position == Position.Bottom)
            {
                to.X = panel.PointToScreen(Point.Empty).X + (panel.Width / 2);
                to.Y = panel.PointToScreen(Point.Empty).Y;
                from.Y = pbTimeLine.PointToScreen(Point.Empty).Y + (pbTimeLine.Height / 2);
                from.X = to.X;
            }
            else
            {
                return; // invalid position
            }
            Resize_Reposition_Line(from, to, Lines_Assignments[panel]);
        }

        private void Timeline_Resize(object sender, EventArgs e)
        {
            resize.Resize_Fonts(this);
            Reposition_Line_From_Middle_To_Timeline(panelAna, Position.Top);
            Reposition_Line_From_Middle_To_Timeline(panelCeausescusRise, Position.Top);
            Reposition_Line_From_Middle_To_Timeline(panelJuly, Position.Top);
            Reposition_Line_From_Middle_To_Timeline(panelRegimeFall, Position.Top);
            Reposition_Line_From_Middle_To_Timeline(panelSoviet, Position.Bottom);
            Reposition_Line_From_Middle_To_Timeline(panelWarsaw, Position.Bottom);
            Reposition_Line_From_Middle_To_Timeline(panelHousePeople, Position.Bottom);
            Place_Labels_And_Ticks();
        }

        private void Timeline_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            openClose.Close(this);
        }

        private void Timeline_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
            textManager.Update_One_Form(this);
            Timeline_Resize(this, new EventArgs());
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            textManager.Increment_Language(this);
        }

        private void btnLanguage_TextChanged(object sender, EventArgs e)
        {
            Timeline_Resize(this, new EventArgs());
        }

        // Regime Fall

        private void panelRegimeFall_Click(object sender, EventArgs e)
        {
            if (!openClose.block)
            {
                if (regimeFall == null)
                {
                    regimeFall = new RegimeFall(textManager, openClose, resize);
                }
                openClose.Interaction();
                openClose.FadeIn(regimeFall);
            }
        }

        // Rise Ceausescus

        private void panelCeausescusRise_Click(object sender, EventArgs e)
        {
            if (!openClose.block)
            {
                if (ceausescusRise == null)
                {
                    ceausescusRise = new CeausescusRise(textManager, openClose, resize);
                }
                openClose.Interaction();
                openClose.FadeIn(ceausescusRise);
            }
        }

        // Soviet Era

        private void panelSoviet_Click(object sender, EventArgs e)
        {
            if (!openClose.block)
            {
                if (sovietEra == null)
                {
                    sovietEra = new SovietEra(textManager, openClose, resize);
                }
                openClose.Interaction();
                openClose.FadeIn(sovietEra);
            }
        }

        private void pbTimeLine_Click(object sender, EventArgs e)
        {
            Timeline_Click(sender, e);
        }

        private void Timeline_VisibleChanged(object sender, EventArgs e)
        {
            textManager.Update_One_Form(this);
            Timeline_Resize(this, new EventArgs());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Timeline_Click(sender, e);
        }
    }
}
