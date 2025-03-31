using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    internal class Polaroid_Zoom_Helper
    {
        Open_Close_Helper openClose;
        Click_Helper click_helper = new Click_Helper();

        TextManager textManager;

        public const string LONG_POLAROID_ANS_FLAG = "PolLong";
        public const int NUM_CONTROLS_IN_POLAROID = 3;
        public const int NUM_CONTROLS_IN_POLAROID_WITH_TABLE_LAYOUT = NUM_CONTROLS_IN_POLAROID - 1;
        public const string BEGIN_PICTUREBOX_FLAG = "pb";
        public const string END_ANSWER_FLAG = "Ans";
        public const string END_QUESTION_FLAG = "Q";
        public const string IGNORE_LONG_ANS_FLAG = "EMPTY, USING OTHER ANS";
        public const int TABLE_LAYOUT_QUESTION_INDEX = 0;
        public const int TABLE_LAYOUT_ANS_INDEX = 1;

        public List<Panel> Polaroids = new List<Panel>();

        public Polaroid_Zoom_Helper()
        {

        }

        public void Polaroid_Zoom_Click_Handler(object sender, EventArgs e)
        {
            Panel panel = null;

            if (sender is Panel)
            {
                panel = (Panel)sender;
            }
            else if (sender is Label)
            {
                panel = (Panel)((TableLayoutPanel)((Label)sender).Parent).Parent;
            }
            else if (sender is PictureBox)
            {
                panel = (Panel)((PictureBox)sender).Parent;
            }
            else if (sender is TableLayoutPanel)
            {
                panel = (Panel)((TableLayoutPanel)sender).Parent;
            }

            Polaroid_Zoom polaroid_zoom = new Polaroid_Zoom(panel, textManager, openClose);
            openClose.FadeIn(polaroid_zoom);
        }

        public const int num_controls = 3;

        public void Assign_Click_Handler_To_Valid(Form form, TextManager textMan, Open_Close_Helper open_close)
        {
            textManager = textMan;
            openClose = open_close;
            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (Is_Polaroid(form.Controls[i]))
                {
                    click_helper.Assign_All_Children_To_Same_Click(form.Controls[i], Polaroid_Zoom_Click_Handler);
                }
            }
        }

        public void Find_Polaroids(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (Is_Polaroid(control))
                {
                    Polaroids.Add((Panel)control);
                }

                if (control.Controls[i].HasChildren)
                {
                    Find_Polaroids(control.Controls[i]);
                }
            }
        }

        public bool Is_Polaroid(Control panel)
        {
            if (panel is Panel && (panel.Controls.Count == NUM_CONTROLS_IN_POLAROID || panel.Controls.Count == NUM_CONTROLS_IN_POLAROID_WITH_TABLE_LAYOUT))
            {
                bool found_PB = false;
                bool found_Q = false;
                bool found_Ans = false;

                for (int i = 0; i < panel.Controls.Count; i++)
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
                    else if (panel.Controls[i] is TableLayoutPanel)
                    {
                        TableLayoutPanel table = (TableLayoutPanel)panel.Controls[i];
                        if (table.Controls[TABLE_LAYOUT_QUESTION_INDEX].Name.EndsWith(END_QUESTION_FLAG) && table.Controls[TABLE_LAYOUT_QUESTION_INDEX] is Label)
                        {
                            found_Q = true;
                        }
                        if (table.Controls[TABLE_LAYOUT_ANS_INDEX].Name.EndsWith(END_ANSWER_FLAG) && table.Controls[TABLE_LAYOUT_ANS_INDEX] is Label)
                        {
                            found_Ans = true;
                        }
                    }
                }

                return found_PB && found_Q & found_Ans;
            }
            else
            {
                return false;
            }
        }

        public string Get_Ans_Name(Panel panel)
        {
            string ans = "";
            if (Is_Polaroid(panel))
            {
                for (int i = 0; i < panel.Controls.Count; i++)
                {
                    string control_name = panel.Controls[i].Name;
                    if (control_name.EndsWith(END_ANSWER_FLAG) && panel.Controls[i] is Label)
                    {
                        ans = control_name;
                    }
                }
            }
            return ans;
        }

        public string Get_Long_Ans_Name(Label label)
        {
            return label.Name + LONG_POLAROID_ANS_FLAG;
        }

        public void Check_Add_Polaroid(Control control)
        {
            if (control is Panel)
            {
                Panel panel = (Panel)control;
                if (Is_Polaroid(panel))
                {
                    Polaroids.Add(panel);
                }
            }
        }
    }
}
