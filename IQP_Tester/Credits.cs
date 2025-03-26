using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQP_Tester
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        public const uint ROW_VERTICAL_OFFSET = 10;

        private void Credits_Load(object sender, EventArgs e)
        {
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
        }


        private void Cite_Images()
        {

        }
    }
}
