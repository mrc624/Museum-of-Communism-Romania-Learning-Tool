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

        public Click_Helper() 
        { 
            
        }

        public void Assign_All_Children_To_Same_Click(Control parent, EventHandler click)
        {
            for (int i = 0; i < parent.Controls.Count; i++)
            {
                parent.Controls[i].Click += click;
            }
        }

    }
}
