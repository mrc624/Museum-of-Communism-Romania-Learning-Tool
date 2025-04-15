using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    public class DoublePolaroid_Helper
    {
        TextManager textManager;
        Open_Close_Helper openClose;
        Resize_Helper resize;
        Click_Helper clickHelper = new Click_Helper();

        public DoublePolaroid_Helper(TextManager textMan, Open_Close_Helper open_close, Resize_Helper resize)
        {
            textManager = textMan;
            openClose = open_close;
            this.resize = resize;
        }

        public DoublePolaroid_Helper()
        {
            textManager = null;
            openClose = null;
        }

        public const int NUM_PICTURES = 2;
        public const int NUM_TEXT = 1;

        public const string THEN_KEYWORD = "Then";
        public const string NOW_KEYWORD = "Now";
        public const string LONG_ANS_FLAG = Polaroid_Helper.LONG_POLAROID_ANS_FLAG;
        public const string IGNORE_LONG_ANS_FLAG = Polaroid_Helper.IGNORE_LONG_ANS_FLAG;
        public const string TITLE_FLAG = "Title";
        public const string IGNORE_TITLE_FLAG = "No Title";
        public const string DOUBLE_POLAROID_END_WITH_FLAG = "DP";

        public const int FIRST_ITEM = 0;
        public const int THEN_INDEX = 1;
        public const int NOW_INDEX = 0;

        public List<Control> DoublePolaroids = new List<Control>();

        DoublePolaroid doublePolaroid;

        public static int check_count = 0;

        public bool Is_DoublePolaroid(Control control)
        {
            check_count++;
            if (control.Name.EndsWith(DOUBLE_POLAROID_END_WITH_FLAG))
            {
                return (Find_Pb(control).Count == NUM_PICTURES) && (Find_Label(control).Count == NUM_TEXT);
            }
            else
            {
                return false;
            }
        }

        public List<PictureBox> Find_Pb(Control control)
        {
            List<PictureBox> list = new List<PictureBox>();
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is PictureBox)
                {
                    list.Add((PictureBox)control.Controls[i]);
                }
                else if (control.Controls[i].HasChildren)
                {
                    List<PictureBox> newList = Find_Pb(control.Controls[i]);
                    for (int j = 0; j < newList.Count; j++)
                    {
                        list.Add(newList[j]);
                    }
                }
            }
            return list;
        }

        public List<System.Windows.Forms.Label> Find_Label(Control control)
        {
            List<System.Windows.Forms.Label> list = new List<System.Windows.Forms.Label>();
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is System.Windows.Forms.Label)
                {
                    list.Add((System.Windows.Forms.Label)control.Controls[i]);
                }
                else if (control.Controls[i].HasChildren)
                {
                    List<System.Windows.Forms.Label> newList = Find_Label(control.Controls[i]);
                    for (int j = 0; j < newList.Count; j++)
                    {
                        list.Add(newList[j]);
                    }
                }
            }
            return list;
        }

        public void Find_DoublePolaroids(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                Check_Add_DoublePolaroids(control.Controls[i]);
                if (control.Controls[i].HasChildren)
                {
                    Find_DoublePolaroids(control.Controls[i]);
                }
            }
        }

        private void Check_Add_DoublePolaroids(Control control)
        {
            if (Is_DoublePolaroid(control))
            {
                DoublePolaroids.Add(control);
            }
        }

        public void Assign_Click_Handers(List<Control> double_polaroids)
        {
            for (int i = 0; i < double_polaroids.Count; i++)
            {
                double_polaroids[i].Click += DoublePolaroid_Click_Handler;
                clickHelper.Assign_All_Children_To_Same_Click(double_polaroids[i], DoublePolaroid_Click_Handler);
            }
        }

        public void DoublePolaroid_Click_Handler(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            while(!DoublePolaroids.Contains(control))
            {
                control = control.Parent;
            }

            if (doublePolaroid == null)
            {
                doublePolaroid = new DoublePolaroid(openClose, textManager, resize, control);
            }
            else
            {
                doublePolaroid.Update_After_Gen(control);
            }
            openClose.Interaction();
            openClose.FadeIn(doublePolaroid);
        }

        public string Get_Long_Text_Name(System.Windows.Forms.Label label)
        {
            return label.Name + LONG_ANS_FLAG;
        }

        public string Get_Title_Name(Control control)
        {
            return control.Name + TITLE_FLAG;
        }
    }
}
