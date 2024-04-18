namespace LicencePlateManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutHeader = new TableLayoutPanel();
            labelCompany = new Label();
            pictureBoxLogo = new PictureBox();
            labelTitle = new Label();
            tableLayoutContent = new TableLayoutPanel();
            tableLayoutMain.SuspendLayout();
            tableLayoutHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutMain.Controls.Add(tableLayoutHeader, 0, 0);
            tableLayoutMain.Controls.Add(tableLayoutContent, 1, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 2;
            tableLayoutMain.RowStyles.Add(new RowStyle());
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(595, 461);
            tableLayoutMain.TabIndex = 1;
            // 
            // tableLayoutHeader
            // 
            tableLayoutHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutHeader.AutoSize = true;
            tableLayoutHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutHeader.BackColor = Color.White;
            tableLayoutHeader.ColumnCount = 4;
            tableLayoutMain.SetColumnSpan(tableLayoutHeader, 3);
            tableLayoutHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutHeader.ColumnStyles.Add(new ColumnStyle());
            tableLayoutHeader.ColumnStyles.Add(new ColumnStyle());
            tableLayoutHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutHeader.Controls.Add(labelCompany, 1, 0);
            tableLayoutHeader.Controls.Add(pictureBoxLogo, 2, 0);
            tableLayoutHeader.Controls.Add(labelTitle, 1, 1);
            tableLayoutHeader.Location = new Point(0, 0);
            tableLayoutHeader.Margin = new Padding(0);
            tableLayoutHeader.MaximumSize = new Size(10000, 100);
            tableLayoutHeader.Name = "tableLayoutHeader";
            tableLayoutHeader.RowCount = 2;
            tableLayoutHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutHeader.Size = new Size(595, 100);
            tableLayoutHeader.TabIndex = 1;
            // 
            // labelCompany
            // 
            labelCompany.Anchor = AnchorStyles.Bottom;
            labelCompany.AutoSize = true;
            labelCompany.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCompany.Location = new Point(124, 13);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(247, 37);
            labelCompany.TabIndex = 0;
            labelCompany.Text = "Active Systems Pty";
            labelCompany.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.active_systems_pty;
            pictureBoxLogo.Location = new Point(374, 0);
            pictureBoxLogo.Margin = new Padding(0);
            pictureBoxLogo.MaximumSize = new Size(100, 100);
            pictureBoxLogo.MinimumSize = new Size(100, 100);
            pictureBoxLogo.Name = "pictureBoxLogo";
            tableLayoutHeader.SetRowSpan(pictureBoxLogo, 2);
            pictureBoxLogo.Size = new Size(100, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(151, 50);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(192, 20);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Licence Plate Management";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutContent
            // 
            tableLayoutContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutContent.BackColor = SystemColors.Control;
            tableLayoutContent.ColumnCount = 2;
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutContent.Location = new Point(97, 100);
            tableLayoutContent.Margin = new Padding(0);
            tableLayoutContent.MaximumSize = new Size(1000, 1000);
            tableLayoutContent.Name = "tableLayoutContent";
            tableLayoutContent.RowCount = 2;
            tableLayoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutContent.Size = new Size(400, 361);
            tableLayoutContent.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 461);
            Controls.Add(tableLayoutMain);
            MinimumSize = new Size(400, 400);
            Name = "Form1";
            Text = "Licence Plate Management";
            Resize += Form1_Resize;
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            tableLayoutHeader.ResumeLayout(false);
            tableLayoutHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutHeader;
        private Label labelCompany;
        private Label labelTitle;
        private PictureBox pictureBoxLogo;
        private TableLayoutPanel tableLayoutContent;
    }
}
