using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOCR
{
    public class Seconday_Form_Helper
    {
        public Form Get_Form(Control control)
        {
            while (!(control is Form))
            {
                control = control.Parent;
            }
            return (Form)control;
        }
    }
}
