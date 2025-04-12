using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    internal class Click_Helper
    {
        Polaroid_Helper polaroid_Helper;
        DoublePolaroid_Helper doublePolaroid_Helper;

        public Click_Helper() 
        { 
            
        }

        public Click_Helper(Polaroid_Helper polaroid_Helper)
        {
            this.polaroid_Helper = polaroid_Helper;
        }

        public Click_Helper(DoublePolaroid_Helper doublePolaroid_Helper)
        {
            this.doublePolaroid_Helper = doublePolaroid_Helper;
        }

        public Click_Helper(Polaroid_Helper polaroid_Helper, DoublePolaroid_Helper doublePolaroid_Helper)
        {
            this.polaroid_Helper = polaroid_Helper;
            this.doublePolaroid_Helper = doublePolaroid_Helper;
        }

        public void Assign_All_Children_To_Same_Click(Control parent, EventHandler click)
        {
            for (int i = 0; i < parent.Controls.Count; i++)
            {
                parent.Controls[i].Click += click;
                if (parent.Controls[i].HasChildren)
                {
                    Assign_All_Children_To_Same_Click(parent.Controls[i], click);
                }
            }
        }

        public void Assign_Children_To_Same_Click_Avoid_Polaroids(Control parent, EventHandler click)
        {
            if (polaroid_Helper != null)
            {
                if (!polaroid_Helper.Is_Polaroid(parent))
                {
                    parent.Click += click;
                    for (int i = 0; i < parent.Controls.Count; i++)
                    {
                        if (parent.Controls[i].HasChildren)
                        {
                            Assign_Children_To_Same_Click_Avoid_Polaroids(parent.Controls[i], click);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Polaroid Helper Not Set\nOccurred When Assigning Children And Avoiding Polaroids");
            }
        }

        public void Assign_Children_To_Same_Click_Avoid_DoublePolaroids(Control parent, EventHandler click)
        {
            if (doublePolaroid_Helper != null)
            {
                if (!doublePolaroid_Helper.Is_DoublePolaroid(parent))
                {
                    parent.Click += click;
                    for (int i = 0; i < parent.Controls.Count; i++)
                    {
                        if (parent.Controls[i].HasChildren)
                        {
                            Assign_Children_To_Same_Click_Avoid_Polaroids(parent.Controls[i], click);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Double Polaroid Helper Not Set\nOccurred When Assigning Children And Avoiding Double Polaroids");
            }
        }

    }
}
