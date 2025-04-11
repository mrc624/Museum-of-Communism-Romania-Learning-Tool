using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    internal class Polaroid_Helper
    {
        Open_Close_Helper openClose;
        Click_Helper click_helper = new Click_Helper();
        Resize_Helper resize = new Resize_Helper();
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
        public const int MIN_NUM_OF_CHILDREN = 2;

        public List<Control> Polaroids = new List<Control>();
        Polaroid_Zoom polaroid_zoom;

        public void Polaroid_Zoom_Click_Handler(object sender, EventArgs e)
        {
            Control Polaroid = null;
            if (!(Polaroids.Contains(sender)))
                {
                Control send = (Control)sender;

                while (Polaroid == null)
                {
                    send = send.Parent;
                    if (Polaroids.Contains(send))
                    {
                        Polaroid = Polaroids[Polaroids.IndexOf(send)];
                    }
                }
            }
            else
            {
                Polaroid = (Control)sender;
            }
            if (polaroid_zoom == null)
            {
                polaroid_zoom = new Polaroid_Zoom(Polaroid, textManager, openClose);
            }
            openClose.Interaction();
            polaroid_zoom.Update_After_Gen(Polaroid);
            openClose.FadeIn(polaroid_zoom);
        }

        private Form Get_Form(Control control)
        {
            while(!(control is Form))
            {
                control = control.Parent;
            }
            return (Form)control;
        }

        public const int num_controls = 3;

        public void Assign_Click_Handler_To_Valid(Form form, TextManager textMan, Open_Close_Helper open_close) // maybe this should be looking through children of the form too, in case polaroids are grouped in panels
        {
            if (Polaroids.Count == 0)
            {
                return;
            }

            textManager = textMan;
            openClose = open_close;
            
            for (int i = 0; i < Polaroids.Count; i++)
            {
                Polaroids[i].Click += Polaroid_Zoom_Click_Handler;
                click_helper.Assign_All_Children_To_Same_Click(Polaroids[i], Polaroid_Zoom_Click_Handler);
            }
        }

        public void Find_Polaroids(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                Check_Add_Polaroid(control.Controls[i]);

                if (control.Controls[i].HasChildren)
                {
                    Find_Polaroids(control.Controls[i]);
                }
            }
        }

        public bool Is_Polaroid(Control control)
        {
            return control is Panel && control.HasChildren && Find_PB(control) != null && Find_Ans(control) != null && Find_Q(control) != null;
        }

        public string Get_Ans_Name(Control control)
        {
            Label ans = Find_Ans(control);
            if (ans != null)
            {
                return ans.Name;
            }
            else
            {
                return null;
            }
        }

        public string Get_Long_Ans_Name(Label label)
        {
            return label.Name + LONG_POLAROID_ANS_FLAG;
        }

        public void Check_Add_Polaroid(Control control)
        {
            if (Is_Polaroid(control))
            {
                Polaroids.Add(control);
            }
        }

        public bool Is_Ans(Label label)
        {
            return label.Name.EndsWith(END_ANSWER_FLAG);
        }

        public bool Is_Q(Label label)
        {
            return label.Name.EndsWith(END_QUESTION_FLAG);
        }

        public Label Find_Ans(Control container)
        {
            Label ans = null;
            for (int i = 0; i < container.Controls.Count; i++)
            {
                if (container.Controls[i].HasChildren)
                {
                    ans = Find_Ans(container.Controls[i]);
                }
                if (ans == null)
                {
                    if (container.Controls[i]  is Label)
                    {
                        if (Is_Ans((Label)container.Controls[i]))
                        {
                           return (Label)container.Controls[i];
                        }
                    }
                }
                else
                {
                    return ans;
                }
            }
            return ans;
        }

        public Label Find_Q(Control container)
        {
            Label Q = null;
            for (int i = 0; i < container.Controls.Count; i++)
            {
                if (container.Controls[i].HasChildren)
                {
                    return Find_Q(container.Controls[i]);
                }
                if (Q == null)
                {
                    if (container.Controls[i] is Label)
                    {
                        if (Is_Q((Label)container.Controls[i]))
                        {
                            return (Label)container.Controls[i];
                        }
                    }
                }
                else
                {
                    return Q;
                }
            }
            return Q;
        }

        public PictureBox Find_PB(Control container)
        {
            PictureBox PB = null;
            for (int i = 0; i < container.Controls.Count; i++)
            {
                if (container.Controls[i].HasChildren)
                {
                    PB = Find_PB(container.Controls[i]);
                }
                if (PB == null)
                {
                    if (container.Controls[i] is PictureBox)
                    {
                        return (PictureBox)container.Controls[i];
                    }
                }
                else
                {
                    return PB;
                }
            }
            return PB;
        }

        public void Reposition_Polaroids(List<Control> polaroids)
        {
            for (int i = 0; i < polaroids.Count; i++)
            {
                Reposition_Polaroid(polaroids[i]);
            }
        }

        private void Reposition_Polaroid(Control polaroid)
        {
            if (polaroid is Panel)
            {
                if (polaroid.Controls.Count > 1)
                {
                    resize.Reposition(polaroid);
                    for (int i = 0; i < polaroid.Controls.Count; i++)
                    {
                        if (i == 0)
                        {
                            resize.Reposition(polaroid.Controls[i]);
                            resize.Center_X(polaroid.Controls[i]);
                        }
                        else
                        {
                            resize.Center_to_Other_Control(polaroid.Controls[i - 1], polaroid.Controls[i]); //goes from bottom up on the polaroid
                        }
                    }
                }
                else
                { // panel is just there for the border
                    polaroid.Controls[0].Dock = DockStyle.None;
                    resize.Reposition(polaroid);
                    polaroid.Controls[0].Dock = DockStyle.Fill;
                }
            }
        }
    }
}
