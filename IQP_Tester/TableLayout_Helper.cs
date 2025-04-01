using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    public class TableLayout_Helper
    {

        public const float TITLE_FONT_SIZE = 14F;
        public const float STANDARD_FONT_SIZE = 10F;
        public const AnchorStyles TITLE_ANCHOR = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        public const AnchorStyles STANDARD_ANCHOR = AnchorStyles.Top | AnchorStyles.Left;
        public const ContentAlignment TITLE_ALIGN = ContentAlignment.MiddleCenter;
        public const ContentAlignment STANDARD_ALIGN = ContentAlignment.TopLeft;

        public System.Windows.Forms.Label Get_Title_Label(string title, string name)
        {
            return Get_Label(title, name, TITLE_FONT_SIZE, TITLE_ANCHOR, TITLE_ALIGN);
        }

        public System.Windows.Forms.Label Get_Standard_Label(string text, string name)
        {
            return Get_Label(text, name, STANDARD_FONT_SIZE, STANDARD_ANCHOR, STANDARD_ALIGN);
        }

        public System.Windows.Forms.Label Get_Label(string text, string name, float font, AnchorStyles anchor, ContentAlignment align)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();

            label.AutoSize = true;
            label.Location = new System.Drawing.Point(4, 1);
            label.Name = name;
            label.Size = new System.Drawing.Size(92, 32);
            label.TabIndex = 1;
            label.Text = text;
            label.Anchor = anchor;
            label.TextAlign = align;
            label.Font = new Font(label.Font.FontFamily, font);

            return label;
        }

        public void Set_Row_Heights(TableLayoutPanel table)
        {
            for (int i = 0; i < table.RowStyles.Count; i++)
            {
                RowStyle rowStyle = table.RowStyles[i];
                rowStyle.SizeType = SizeType.AutoSize;
            }
        }
    }
}
