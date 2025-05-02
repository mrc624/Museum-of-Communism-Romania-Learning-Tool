using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
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
        TableLayout_Helper tableLayout_Helper = new TableLayout_Helper();
        Resize_Helper resize;
        Open_Close_Helper openClose;
        Citation_Helper citation_Helper;

        public const uint ROW_VERTICAL_OFFSET = 10;

        public Credits(Citation_Helper citation_helper, Open_Close_Helper openClose, Resize_Helper resize)
        {
            InitializeComponent();
            citation_Helper = citation_helper;
            this.openClose = openClose;
            this.resize = resize;

            for (int i = 0; i < (int)Citation_Type.NUM_CITATION_TYPES; i++)
            {
                Load_Citations_Except_Pictures((Citation_Type)i);
            }
            Load_Citations_Pictures();
            tableLayout_Helper.Set_Row_Heights(CreditsTableLayoutPanel);

            btnBack.Visible = Settings.btn_back_state;
        }

        private void Load_Citations_Pictures()
        {
            citation_Helper.Add_Pictures();

            System.Windows.Forms.Label labelTitle = tableLayout_Helper.Get_Title_Label(citation_Helper.Citations_to_String[(int)Citation_Type.Pictures], "lbl" + citation_Helper.Get_Citation_Shortened[(int)Citation_Type.Pictures] + "title");
            CreditsTableLayoutPanel.RowCount++;
            CreditsTableLayoutPanel.Controls.Add(labelTitle, 0, CreditsTableLayoutPanel.RowCount);

            List<PictureBox> pictures = citation_Helper.Get_Pictures_List();

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Anchor = TableLayout_Helper.TITLE_ANCHOR;
                pictures[i].Name = pictures[i].Name;
                CreditsTableLayoutPanel.RowCount++;
                CreditsTableLayoutPanel.Controls.Add(pictures[i], 0, CreditsTableLayoutPanel.RowCount);

                string citation = citation_Helper.Citations[citation_Helper.Citations_to_String[(int)Citation_Type.Pictures]][pictures[i].Name];
                citation = citation_Helper.Format_Hanging_Indentation(citation);
                System.Windows.Forms.Label label = tableLayout_Helper.Get_Standard_Label(citation, "lbl" + pictures[i].Name + i.ToString());
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

            System.Windows.Forms.Label labelTitle = tableLayout_Helper.Get_Title_Label(citation_Helper.Citations_to_String[(int)type], "lbl" + citation_Helper.Get_Citation_Shortened[(int)type] + "title");
            CreditsTableLayoutPanel.RowCount++;
            CreditsTableLayoutPanel.Controls.Add(labelTitle, 0, CreditsTableLayoutPanel.RowCount);

            List<string> Citations = citation_Helper.Get_Citations_Except_Pictures(type);

            for (int i = 0; i < Citations.Count; i++)
            {
                System.Windows.Forms.Label label = tableLayout_Helper.Get_Standard_Label(Citations[i].ToString(), "lbl" + citation_Helper.Get_Citation_Shortened[(int)type] + i.ToString());

                CreditsTableLayoutPanel.RowCount++;
                CreditsTableLayoutPanel.Controls.Add(label, 0, CreditsTableLayoutPanel.RowCount);
            }
        }

        private void Empty_Credits_Table()
        {
            while (CreditsTableLayoutPanel.Controls.Count > 1)
            {
                CreditsTableLayoutPanel.Controls[1].Dispose();
            }
            CreditsTableLayoutPanel.RowCount = 1;
        }

        private void Credits_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            openClose.Close(this);
        }

        private void Credits_Load(object sender, EventArgs e)
        {

        }

        private void Credits_Shown(object sender, EventArgs e)
        {
            resize.Fullscreen_Form(this);
        }

        private void CreditsTableLayoutPanel_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }

        private void Credits_VisibleChanged(object sender, EventArgs e)
        {
            btnBack.Visible = Settings.btn_back_state;
        }

        private void tableLayoutCreditsMain_Click(object sender, EventArgs e)
        {
            openClose.Close(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tableLayoutCreditsMain_Click(sender, e);
        }

        private void TableLayoutbtnBackAlignCredits_Click(object sender, EventArgs e)
        {
            tableLayoutCreditsMain_Click(sender, e);
        }
    }
}
