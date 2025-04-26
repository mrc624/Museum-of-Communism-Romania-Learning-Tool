using IQP_Tester.Properties;
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
        public const HorizontalAlignment TB_STANDARD = HorizontalAlignment.Left;
        public const ScrollBars TB_SCROLLBARS = ScrollBars.Vertical;
        public const int FONT_HEIGHT_OFFSET = 5;

        public System.Windows.Forms.Label Get_Title_Label(string title, string name)
        {
            return Get_Label(title, name, TITLE_FONT_SIZE, TITLE_ANCHOR, TITLE_ALIGN);
        }

        public System.Windows.Forms.Label Get_Standard_Label(string text, string name)
        {
            return Get_Label(text, name, STANDARD_FONT_SIZE, STANDARD_ANCHOR, STANDARD_ALIGN);
        }

        public System.Windows.Forms.PictureBox Get_PictureBox(Image image, string name)
        {
            PictureBox pb = new PictureBox();

            pb.Dock = DockStyle.Fill;
            pb.Location = new System.Drawing.Point(3, 3);
            pb.Name = name;
            pb.Size = new System.Drawing.Size(270, 169);
            pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb.TabIndex = 0;
            pb.TabStop = false;
            pb.Image = image;

            return pb;
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

        public TextBox Get_Textbox(string text, string name, int width, float font, AnchorStyles anchor, HorizontalAlignment align, ScrollBars scrollbar, bool auto_height = false)
        {
            TextBox textbox = new TextBox();

            textbox.Location = new System.Drawing.Point(4, 1);
            textbox.Name = name;
            textbox.Size = new System.Drawing.Size(100, 20);
            textbox.TabIndex = 1;
            textbox.Text = text;
            textbox.Anchor = anchor;
            textbox.TextAlign = align;
            textbox.Font = new Font(textbox.Font.FontFamily, font);
            textbox.Multiline = true;
            textbox.WordWrap = true;
            textbox.Width = width;
            textbox.ScrollBars = scrollbar;
            
            if (auto_height) // produces a taller textbox than neccessary
            {
                int lines = textbox.GetLineFromCharIndex(textbox.TextLength) + 1;
                int height_of_one_line = textbox.Height;
                textbox.Height = lines * height_of_one_line;
            }

            return textbox;
        }

        public TextBox Get_Textbox(string text, string name, int width, bool auto_size)
        {
            return Get_Textbox(text, name, width, STANDARD_FONT_SIZE, STANDARD_ANCHOR, TB_STANDARD, TB_SCROLLBARS, auto_size);
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
