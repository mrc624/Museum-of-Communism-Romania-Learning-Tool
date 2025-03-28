﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IQP_Tester.Citation_Helper;
using static System.Net.Mime.MediaTypeNames;

namespace IQP_Tester
{
    public partial class Credits : Form
    {

        Citation_Helper citation_Helper;

        List<string> Members;

        public const float TITLE_FONT_SIZE = 14F;
        public const float STANDARD_FONT_SIZE = 10F;
        public const AnchorStyles TITLE_ANCHOR = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        public const AnchorStyles STANDARD_ANCHOR = AnchorStyles.Top | AnchorStyles.Left;
        public const ContentAlignment TITLE_ALIGN = ContentAlignment.MiddleCenter;
        public const ContentAlignment STANDARD_ALIGN = ContentAlignment.TopLeft;


        public Credits(Citation_Helper citation_helper)
        {
            InitializeComponent();
            citation_Helper = citation_helper;
        }

        public const uint ROW_VERTICAL_OFFSET = 10;

        private void Credits_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < (int)Citation_Type.NUM_CITATION_TYPES; i++)
            {
                Load_Citations_Except_Pictures((Citation_Type)i);
            }
            Load_Citations_Pictures();
            Set_Row_Heights();
        }

        private void Load_Citations_Pictures()
        {
            citation_Helper.Add_Pictures();

            System.Windows.Forms.Label labelTitle = Get_Title_Label(citation_Helper.Citations_to_String[(int)Citation_Type.Pictures], "lbl" + citation_Helper.Get_Citation_Shortened[(int)Citation_Type.Pictures] + "title");
            CreditsTableLayoutPanel.RowCount++;
            CreditsTableLayoutPanel.Controls.Add(labelTitle, 0, CreditsTableLayoutPanel.RowCount);

            List<PictureBox> pictures = citation_Helper.Get_Pictures_List();

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Anchor = STANDARD_ANCHOR;
                pictures[i].Name = pictures[i].Name;
                CreditsTableLayoutPanel.RowCount++;
                CreditsTableLayoutPanel.Controls.Add(pictures[i], 0, CreditsTableLayoutPanel.RowCount);

                string citation = citation_Helper.Citations[citation_Helper.Citations_to_String[(int)Citation_Type.Pictures]][pictures[i].Name];
                System.Windows.Forms.Label label = Get_Standard_Label(citation, "lbl" + pictures[i].Name + i.ToString());
                CreditsTableLayoutPanel.RowCount++;
                CreditsTableLayoutPanel.Controls.Add(label, 0, CreditsTableLayoutPanel.RowCount);
            }
        }

        private void Load_Citations_Except_Pictures(Citation_Type type)
        {
            if (type == Citation_Type.Pictures)
            {
                return;
            }

            System.Windows.Forms.Label labelTitle = Get_Title_Label(citation_Helper.Citations_to_String[(int)type], "lbl" + citation_Helper.Get_Citation_Shortened[(int)type] + "title");
            CreditsTableLayoutPanel.RowCount++;
            CreditsTableLayoutPanel.Controls.Add(labelTitle, 0, CreditsTableLayoutPanel.RowCount);

            List<string> Citations = citation_Helper.Get_Citations_Except_Pictures(type);

            for (int i = 0; i < Citations.Count; i++)
            {
                System.Windows.Forms.Label label = Get_Standard_Label(Citations[i].ToString(), "lbl" + citation_Helper.Get_Citation_Shortened[(int)type] + i.ToString());

                CreditsTableLayoutPanel.RowCount++;
                CreditsTableLayoutPanel.Controls.Add(label, 0, CreditsTableLayoutPanel.RowCount);
            }
        }

        private System.Windows.Forms.Label Get_Title_Label(string title, string name)
        {
            return Get_Label(title, name, TITLE_FONT_SIZE, TITLE_ANCHOR, TITLE_ALIGN);
        }

        private System.Windows.Forms.Label Get_Standard_Label(string text, string name)
        {
            return Get_Label(text, name, STANDARD_FONT_SIZE, STANDARD_ANCHOR, STANDARD_ALIGN);
        }

        private System.Windows.Forms.Label Get_Label(string text, string name, float font, AnchorStyles anchor, ContentAlignment align)
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

        private void Set_Row_Heights()
        {
            for (int i = 0; i < CreditsTableLayoutPanel.RowStyles.Count; i++)
            {
                RowStyle rowStyle = CreditsTableLayoutPanel.RowStyles[i];
                rowStyle.SizeType = SizeType.AutoSize;
            }
        }
    }
}
