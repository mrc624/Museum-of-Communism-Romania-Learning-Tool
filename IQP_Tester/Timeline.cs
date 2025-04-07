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
        Resize_Helper resize = new Resize_Helper();
        Polaroid_Helper polaroid_Helper = new Polaroid_Helper();
        Click_Helper click_Helper = new Click_Helper();
        TableLayout_Helper tableLayoutHelper = new TableLayout_Helper();

        RegimeFall regimeFall;
        CeausescusRise ceausescusRise;
        SovietEra sovietEra;

        public const int START_YEAR = 1940;
        public const int END_YEAR = 1990;
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

        public Timeline(TextManager textMan, Open_Close_Helper open_close)
        {
            InitializeComponent();
            Make_Year_Lables(this);
            Make_Assign_Lines(this);
            openClose = open_close;
            textManager = textMan;
            Capture_Original_Size_Location(this);
            textManager.Update_One_Form(this);
            resize.CaptureAspectRatios(this);
            polaroid_Helper.Find_Polaroids(this);
            Timeline_Resize(this, new EventArgs());
            Set_Panel_Clicks();
            polaroid_Helper.Assign_Click_Handler_To_Valid(this, textMan, open_close);
        }

        private void Set_Panel_Clicks()
        {
            click_Helper.Assign_All_Children_To_Same_Click(panelRegimeFall, panelRegimeFall_Click);
            click_Helper.Assign_All_Children_To_Same_Click(panelCeausescusRise, panelCeausescusRise_Click);
            click_Helper.Assign_All_Children_To_Same_Click(panelSoviet, panelSoviet_Click);
        }

        private void Make_Assign_Lines(Form form)
        {
            List<Panel> panels = new List<Panel>();
            List<Label> labels = new List<Label>();
            int control_count = form.Controls.Count;
            for (int i = 0; i < control_count; i++)
            {
                Control control = form.Controls[i];
                if (control is Panel || control is Label)
                {
                    Panel line = Get_Line(LINE_NAME + i.ToString());
                    this.Controls.Add(line);
                    Lines_Assignments[control] = line;
                }
            }
        }

        private void Make_Year_Lables(Form form)
        {
            int start_ticks = Get_Start_ticks();

            int ticks = ((Get_End_Ticks() - start_ticks) / TICKS_EVERY) + 1;

            for (int i = 0; i < ticks; i++)
            {
                int year = start_ticks + (i * TICKS_EVERY);
                Label label = tableLayoutHelper.Get_Label(year.ToString(), YEAR_LABEL_NAME + i.ToString(), TableLayout_Helper.STANDARD_FONT_SIZE, TableLayout_Helper.STANDARD_ANCHOR, TableLayout_Helper.STANDARD_ALIGN);
                Year_Labels.Add(label);
                this.Controls.Add(label);
            }
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

        private void Timeline_Resize(object sender, EventArgs e)
        {
            resize.Handle_Resize(this);

            resize.Center_X_Y(pbTimeLine);


            polaroid_Helper.Reposition_Polaroids(polaroid_Helper.Polaroids);

            Place_Panel_With_Line_At_Year(panelAna, 1947, Position.Top);
            Place_Panel_With_Line_At_Year(panelWarsaw, 1969, Position.Bottom);
            Place_Panel_With_Line_At_Year(panelJuly, 1971, Position.Top);
            Place_Panel_With_Line_At_Year(panelHousePeople, 1984, Position.Bottom);
            Place_Panel_With_Line_At_Year(panelRegimeFall, 1989, Position.Top);
            Place_Panel_With_Line_At_Year(panelSoviet, 1952, Position.Bottom);
            Place_Panel_With_Line_At_Year(panelCeausescusRise, 1965, Position.Top);
            Place_Labels_And_Ticks();

            resize.Center_X(pbRevolution);
            resize.Center_to_Other_Control(lblHowDidTheRegimeFall, pbRevolution, Resize_Helper.Centering_Options.to_top);
            resize.Center_X(pbSoviet);
            resize.Center_to_Other_Control(lblSoviet, pbSoviet, Resize_Helper.Centering_Options.to_top);
            resize.Center_X(pbCeausescusRise);
            resize.Center_to_Other_Control(lblCeausescusRise, pbCeausescusRise, Resize_Helper.Centering_Options.to_top);

            resize.Glue_to_Corner(btnLanguage, Resize_Helper.Corner.bottom_right);
        }

        private void Timeline_Click(object sender, EventArgs e)
        {
            openClose.Interaction();
            openClose.Close(this);
        }

        private void Timeline_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
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
            regimeFall = new RegimeFall(textManager, openClose);
            openClose.FadeIn(regimeFall);
        }

        // Rise Ceausescus

        private void panelCeausescusRise_Click(object sender, EventArgs e)
        {
            ceausescusRise = new CeausescusRise(textManager, openClose);
            openClose.FadeIn(ceausescusRise);
        }

        // Soviet Era

        private void panelSoviet_Click(object sender, EventArgs e)
        {
            sovietEra = new SovietEra(textManager, openClose);
            openClose.FadeIn(sovietEra);
        }
    }
}
