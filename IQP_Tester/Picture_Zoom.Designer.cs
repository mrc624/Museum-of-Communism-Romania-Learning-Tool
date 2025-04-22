namespace IQP_Tester
{
    partial class Picture_Zoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TableLayoutPictureZoomMain = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.TableLayoutbtnBackAlignPictureZoom = new IQP_Tester.DoubleBufferedTableLayout(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.pbPictureZoom = new System.Windows.Forms.PictureBox();
            this.TableLayoutPictureZoomMain.SuspendLayout();
            this.TableLayoutbtnBackAlignPictureZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPictureZoomMain
            // 
            this.TableLayoutPictureZoomMain.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPictureZoomMain.ColumnCount = 1;
            this.TableLayoutPictureZoomMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPictureZoomMain.Controls.Add(this.TableLayoutbtnBackAlignPictureZoom, 0, 0);
            this.TableLayoutPictureZoomMain.Controls.Add(this.pbPictureZoom, 0, 1);
            this.TableLayoutPictureZoomMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPictureZoomMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPictureZoomMain.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TableLayoutPictureZoomMain.Name = "TableLayoutPictureZoomMain";
            this.TableLayoutPictureZoomMain.RowCount = 3;
            this.TableLayoutPictureZoomMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPictureZoomMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableLayoutPictureZoomMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPictureZoomMain.Size = new System.Drawing.Size(1904, 1041);
            this.TableLayoutPictureZoomMain.TabIndex = 2;
            this.TableLayoutPictureZoomMain.Click += new System.EventHandler(this.TableLayoutPictureZoomMain_Click);
            // 
            // TableLayoutbtnBackAlignPictureZoom
            // 
            this.TableLayoutbtnBackAlignPictureZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutbtnBackAlignPictureZoom.ColumnCount = 3;
            this.TableLayoutbtnBackAlignPictureZoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.TableLayoutbtnBackAlignPictureZoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.25F));
            this.TableLayoutbtnBackAlignPictureZoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.75F));
            this.TableLayoutbtnBackAlignPictureZoom.Controls.Add(this.btnBack, 1, 1);
            this.TableLayoutbtnBackAlignPictureZoom.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutbtnBackAlignPictureZoom.Name = "TableLayoutbtnBackAlignPictureZoom";
            this.TableLayoutbtnBackAlignPictureZoom.RowCount = 3;
            this.TableLayoutbtnBackAlignPictureZoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.75F));
            this.TableLayoutbtnBackAlignPictureZoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.25F));
            this.TableLayoutbtnBackAlignPictureZoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.TableLayoutbtnBackAlignPictureZoom.Size = new System.Drawing.Size(1898, 98);
            this.TableLayoutbtnBackAlignPictureZoom.TabIndex = 35;
            this.TableLayoutbtnBackAlignPictureZoom.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutbtnBackAlignPictureZoom_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1787, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 35);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbPictureZoom
            // 
            this.pbPictureZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPictureZoom.Location = new System.Drawing.Point(1, 105);
            this.pbPictureZoom.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pbPictureZoom.Name = "pbPictureZoom";
            this.pbPictureZoom.Size = new System.Drawing.Size(1902, 830);
            this.pbPictureZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPictureZoom.TabIndex = 1;
            this.pbPictureZoom.TabStop = false;
            this.pbPictureZoom.Click += new System.EventHandler(this.pbPictureZoom_Click);
            // 
            // Picture_Zoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.TableLayoutPictureZoomMain);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Picture_Zoom";
            this.Text = "Picture_Zoom";
            this.Shown += new System.EventHandler(this.Picture_Zoom_Shown);
            this.Click += new System.EventHandler(this.Picture_Zoom_Click);
            this.TableLayoutPictureZoomMain.ResumeLayout(false);
            this.TableLayoutbtnBackAlignPictureZoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPictureZoom;
        private DoubleBufferedTableLayout TableLayoutPictureZoomMain;
        private DoubleBufferedTableLayout TableLayoutbtnBackAlignPictureZoom;
        private System.Windows.Forms.Button btnBack;
    }
}