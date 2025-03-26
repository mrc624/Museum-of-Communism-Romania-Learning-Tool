using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IQP_Tester.Citation_Helper;

namespace IQP_Tester
{
    public partial class Credits : Form
    {

        Citation_Helper citation_Helper;

        List<string> Members;

        public float TITLE_FONT_SIZE = 14F;

        public Credits(Citation_Helper citation_helper)
        {
            InitializeComponent();
            citation_Helper = citation_helper;
        }

        public const uint ROW_VERTICAL_OFFSET = 10;

        private void Credits_Load(object sender, EventArgs e)
        {
            Load_Members();
            Set_Row_Heights();
        }
        
        private void Load_Members()
        {
            System.Windows.Forms.Label labelTitle = new System.Windows.Forms.Label();

            labelTitle.AutoSize = true;
            labelTitle.Location = new System.Drawing.Point(4, 1);
            labelTitle.Name = "MemberTitle";
            labelTitle.Size = new System.Drawing.Size(92, 32);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Project Members:\n";
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            labelTitle.Font = new Font(labelTitle.Font.FontFamily, TITLE_FONT_SIZE);
            CreditsTableLayoutPanel.RowCount++;
            CreditsTableLayoutPanel.Controls.Add(labelTitle, 0, CreditsTableLayoutPanel.RowCount);

            Members = citation_Helper.Get_Team_Members();

            for (int i = 0; i < Members.Count; i++)
            {
                System.Windows.Forms.Label labelMem = new System.Windows.Forms.Label();

                labelMem.AutoSize = true;
                labelMem.Location = new System.Drawing.Point(4, 1);
                labelMem.Name = "Member" + i.ToString();
                labelMem.Size = new System.Drawing.Size(92, 32);
                labelMem.TabIndex = 1;
                labelMem.Text = Members[i].ToString();
                labelMem.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
                labelMem.TextAlign = ContentAlignment.MiddleCenter;
                CreditsTableLayoutPanel.RowCount++;
                CreditsTableLayoutPanel.Controls.Add(labelMem, 0, CreditsTableLayoutPanel.RowCount);
            }
        }

        private void Set_Row_Heights()
        {
            for (int i = 0; i < CreditsTableLayoutPanel.RowStyles.Count; i++)
            {
                RowStyle rowStyle = CreditsTableLayoutPanel.RowStyles[i];
                rowStyle.SizeType = SizeType.AutoSize;
            }
        }






















        // The following code puts in images into the table:
        /* 
            CreditsTableLayoutPanel.RowCount = 10;
            
            for (int i = 0;  i < CreditsTableLayoutPanel.RowCount; i++)
            {
                PictureBox Pb = new PictureBox();

                Pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                Pb.Image = global::IQP_Tester.Properties.Resources.Romanian_Revolution;
                Pb.Location = new System.Drawing.Point(4, 4);
                Pb.Name = "pbTestingCredits" + i.ToString();
                Pb.Size = new System.Drawing.Size(722, 117);
                Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                Pb.TabIndex = 0;
                Pb.TabStop = false;

                Label label = new Label();

                label.AutoSize = true;
                label.Location = new System.Drawing.Point(4, 1);
                label.Name = "label" + i.ToString();
                label.Size = new System.Drawing.Size(92, 32);
                label.TabIndex = 1;
                label.Text = "PB Citation " + i.ToString();

                CreditsTableLayoutPanel.Controls.Add(Pb, i, 0);
                CreditsTableLayoutPanel.Controls.Add(label, i, 0);
            }

            for (int i = 0; i < CreditsTableLayoutPanel.RowStyles.Count; i++)
            {
                RowStyle rowStyle = CreditsTableLayoutPanel.RowStyles[i];
                rowStyle.SizeType = SizeType.AutoSize;
            }
         */
    }
}
