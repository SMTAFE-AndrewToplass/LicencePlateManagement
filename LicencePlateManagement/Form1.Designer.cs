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
            groupBoxFile = new GroupBox();
            flowLayoutFile = new FlowLayoutPanel();
            btnFileLoad = new Button();
            btnFileSave = new Button();
            btnFileReset = new Button();
            groupBoxActions = new GroupBox();
            tableLayoutActions = new TableLayoutPanel();
            txtBoxAction = new TextBox();
            btnActionEnter = new Button();
            btnActionExit = new Button();
            btnSearchBinary = new Button();
            btnSearchLinear = new Button();
            btnActionEdit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            listBoxMain = new ListBox();
            listBoxTagged = new ListBox();
            lblTag = new Label();
            btnTagAdd = new Button();
            btnTagRemove = new Button();
            lblMainListBox = new Label();
            lblTaggedListBox = new Label();
            tableLayoutMain.SuspendLayout();
            tableLayoutHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tableLayoutContent.SuspendLayout();
            groupBoxFile.SuspendLayout();
            flowLayoutFile.SuspendLayout();
            groupBoxActions.SuspendLayout();
            tableLayoutActions.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutMain.Size = new Size(484, 561);
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
            tableLayoutHeader.Size = new Size(484, 100);
            tableLayoutHeader.TabIndex = 1;
            // 
            // labelCompany
            // 
            labelCompany.Anchor = AnchorStyles.Bottom;
            labelCompany.AutoSize = true;
            labelCompany.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCompany.Location = new Point(68, 13);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(247, 37);
            labelCompany.TabIndex = 0;
            labelCompany.Text = "Active Systems Pty";
            labelCompany.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.active_systems_pty;
            pictureBoxLogo.Location = new Point(318, 0);
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
            labelTitle.Location = new Point(95, 50);
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
            tableLayoutContent.ColumnCount = 1;
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutContent.Controls.Add(groupBoxFile, 0, 0);
            tableLayoutContent.Controls.Add(groupBoxActions, 0, 1);
            tableLayoutContent.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutContent.Location = new Point(41, 100);
            tableLayoutContent.Margin = new Padding(0);
            tableLayoutContent.MaximumSize = new Size(700, 10000);
            tableLayoutContent.Name = "tableLayoutContent";
            tableLayoutContent.Padding = new Padding(3);
            tableLayoutContent.RowCount = 3;
            tableLayoutContent.RowStyles.Add(new RowStyle());
            tableLayoutContent.RowStyles.Add(new RowStyle());
            tableLayoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutContent.Size = new Size(400, 461);
            tableLayoutContent.TabIndex = 2;
            // 
            // groupBoxFile
            // 
            groupBoxFile.AutoSize = true;
            groupBoxFile.Controls.Add(flowLayoutFile);
            groupBoxFile.Dock = DockStyle.Fill;
            groupBoxFile.Location = new Point(6, 6);
            groupBoxFile.Name = "groupBoxFile";
            groupBoxFile.Size = new Size(388, 51);
            groupBoxFile.TabIndex = 0;
            groupBoxFile.TabStop = false;
            groupBoxFile.Text = "File actions:";
            // 
            // flowLayoutFile
            // 
            flowLayoutFile.AutoSize = true;
            flowLayoutFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutFile.Controls.Add(btnFileLoad);
            flowLayoutFile.Controls.Add(btnFileSave);
            flowLayoutFile.Controls.Add(btnFileReset);
            flowLayoutFile.Dock = DockStyle.Fill;
            flowLayoutFile.Location = new Point(3, 19);
            flowLayoutFile.Margin = new Padding(0);
            flowLayoutFile.Name = "flowLayoutFile";
            flowLayoutFile.Size = new Size(382, 29);
            flowLayoutFile.TabIndex = 0;
            // 
            // btnFileLoad
            // 
            btnFileLoad.Location = new Point(3, 3);
            btnFileLoad.Name = "btnFileLoad";
            btnFileLoad.Size = new Size(75, 23);
            btnFileLoad.TabIndex = 0;
            btnFileLoad.Text = "Load";
            btnFileLoad.UseVisualStyleBackColor = true;
            // 
            // btnFileSave
            // 
            btnFileSave.Location = new Point(84, 3);
            btnFileSave.Name = "btnFileSave";
            btnFileSave.Size = new Size(75, 23);
            btnFileSave.TabIndex = 1;
            btnFileSave.Text = "Save";
            btnFileSave.UseVisualStyleBackColor = true;
            // 
            // btnFileReset
            // 
            btnFileReset.Location = new Point(165, 3);
            btnFileReset.Name = "btnFileReset";
            btnFileReset.Size = new Size(75, 23);
            btnFileReset.TabIndex = 2;
            btnFileReset.Text = "Reset";
            btnFileReset.UseVisualStyleBackColor = true;
            // 
            // groupBoxActions
            // 
            groupBoxActions.AutoSize = true;
            groupBoxActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxActions.Controls.Add(tableLayoutActions);
            groupBoxActions.Dock = DockStyle.Fill;
            groupBoxActions.Location = new Point(6, 63);
            groupBoxActions.Name = "groupBoxActions";
            groupBoxActions.Size = new Size(388, 109);
            groupBoxActions.TabIndex = 1;
            groupBoxActions.TabStop = false;
            groupBoxActions.Text = "Licence plate actions:";
            // 
            // tableLayoutActions
            // 
            tableLayoutActions.AutoSize = true;
            tableLayoutActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutActions.ColumnCount = 5;
            tableLayoutActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33667F));
            tableLayoutActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.663332F));
            tableLayoutActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.663332F));
            tableLayoutActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33667F));
            tableLayoutActions.Controls.Add(txtBoxAction, 0, 0);
            tableLayoutActions.Controls.Add(btnActionEnter, 0, 1);
            tableLayoutActions.Controls.Add(btnActionExit, 1, 1);
            tableLayoutActions.Controls.Add(btnSearchBinary, 0, 2);
            tableLayoutActions.Controls.Add(btnSearchLinear, 3, 2);
            tableLayoutActions.Controls.Add(btnActionEdit, 4, 1);
            tableLayoutActions.Dock = DockStyle.Fill;
            tableLayoutActions.Location = new Point(3, 19);
            tableLayoutActions.Name = "tableLayoutActions";
            tableLayoutActions.RowCount = 3;
            tableLayoutActions.RowStyles.Add(new RowStyle());
            tableLayoutActions.RowStyles.Add(new RowStyle());
            tableLayoutActions.RowStyles.Add(new RowStyle());
            tableLayoutActions.Size = new Size(382, 87);
            tableLayoutActions.TabIndex = 0;
            // 
            // txtBoxAction
            // 
            txtBoxAction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutActions.SetColumnSpan(txtBoxAction, 5);
            txtBoxAction.Location = new Point(3, 3);
            txtBoxAction.Name = "txtBoxAction";
            txtBoxAction.PlaceholderText = "Enter licence plate";
            txtBoxAction.Size = new Size(376, 23);
            txtBoxAction.TabIndex = 0;
            // 
            // btnActionEnter
            // 
            btnActionEnter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnActionEnter.Location = new Point(3, 32);
            btnActionEnter.Name = "btnActionEnter";
            btnActionEnter.Size = new Size(121, 23);
            btnActionEnter.TabIndex = 1;
            btnActionEnter.Text = "Enter";
            btnActionEnter.UseVisualStyleBackColor = true;
            // 
            // btnActionExit
            // 
            btnActionExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutActions.SetColumnSpan(btnActionExit, 3);
            btnActionExit.Location = new Point(130, 32);
            btnActionExit.Name = "btnActionExit";
            btnActionExit.Size = new Size(120, 23);
            btnActionExit.TabIndex = 2;
            btnActionExit.Text = "Exit";
            btnActionExit.UseVisualStyleBackColor = true;
            // 
            // btnSearchBinary
            // 
            btnSearchBinary.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutActions.SetColumnSpan(btnSearchBinary, 2);
            btnSearchBinary.Location = new Point(3, 61);
            btnSearchBinary.Name = "btnSearchBinary";
            btnSearchBinary.Size = new Size(184, 23);
            btnSearchBinary.TabIndex = 4;
            btnSearchBinary.Text = "Binary search";
            btnSearchBinary.UseVisualStyleBackColor = true;
            // 
            // btnSearchLinear
            // 
            btnSearchLinear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutActions.SetColumnSpan(btnSearchLinear, 2);
            btnSearchLinear.Location = new Point(193, 61);
            btnSearchLinear.Name = "btnSearchLinear";
            btnSearchLinear.Size = new Size(186, 23);
            btnSearchLinear.TabIndex = 5;
            btnSearchLinear.Text = "Linear search";
            btnSearchLinear.UseVisualStyleBackColor = true;
            // 
            // btnActionEdit
            // 
            btnActionEdit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnActionEdit.Location = new Point(256, 32);
            btnActionEdit.Name = "btnActionEdit";
            btnActionEdit.Size = new Size(123, 23);
            btnActionEdit.TabIndex = 3;
            btnActionEdit.Text = "Edit";
            btnActionEdit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.Controls.Add(listBoxMain, 0, 1);
            tableLayoutPanel1.Controls.Add(listBoxTagged, 2, 1);
            tableLayoutPanel1.Controls.Add(lblTag, 1, 1);
            tableLayoutPanel1.Controls.Add(btnTagAdd, 1, 2);
            tableLayoutPanel1.Controls.Add(btnTagRemove, 1, 3);
            tableLayoutPanel1.Controls.Add(lblMainListBox, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTaggedListBox, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(6, 178);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(388, 277);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // listBoxMain
            // 
            listBoxMain.Dock = DockStyle.Fill;
            listBoxMain.FormattingEnabled = true;
            listBoxMain.ItemHeight = 15;
            listBoxMain.Location = new Point(6, 21);
            listBoxMain.Name = "listBoxMain";
            tableLayoutPanel1.SetRowSpan(listBoxMain, 3);
            listBoxMain.Size = new Size(142, 250);
            listBoxMain.TabIndex = 0;
            // 
            // listBoxTagged
            // 
            listBoxTagged.Dock = DockStyle.Fill;
            listBoxTagged.FormattingEnabled = true;
            listBoxTagged.ItemHeight = 15;
            listBoxTagged.Location = new Point(239, 21);
            listBoxTagged.Name = "listBoxTagged";
            tableLayoutPanel1.SetRowSpan(listBoxTagged, 3);
            listBoxTagged.Size = new Size(143, 250);
            listBoxTagged.TabIndex = 1;
            // 
            // lblTag
            // 
            lblTag.Anchor = AnchorStyles.Bottom;
            lblTag.AutoSize = true;
            lblTag.Location = new Point(168, 93);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(50, 15);
            lblTag.TabIndex = 2;
            lblTag.Text = "Edit tag:";
            // 
            // btnTagAdd
            // 
            btnTagAdd.Anchor = AnchorStyles.None;
            btnTagAdd.AutoSize = true;
            btnTagAdd.Location = new Point(156, 111);
            btnTagAdd.Name = "btnTagAdd";
            btnTagAdd.Size = new Size(75, 25);
            btnTagAdd.TabIndex = 3;
            btnTagAdd.Text = "Add >>";
            btnTagAdd.UseVisualStyleBackColor = true;
            // 
            // btnTagRemove
            // 
            btnTagRemove.Anchor = AnchorStyles.Top;
            btnTagRemove.AutoSize = true;
            btnTagRemove.Location = new Point(154, 142);
            btnTagRemove.Name = "btnTagRemove";
            btnTagRemove.Size = new Size(79, 25);
            btnTagRemove.TabIndex = 4;
            btnTagRemove.Text = "Remove <<";
            btnTagRemove.UseVisualStyleBackColor = true;
            // 
            // lblMainListBox
            // 
            lblMainListBox.AutoSize = true;
            lblMainListBox.Location = new Point(6, 3);
            lblMainListBox.Name = "lblMainListBox";
            lblMainListBox.Size = new Size(84, 15);
            lblMainListBox.TabIndex = 5;
            lblMainListBox.Text = "Licence plates:";
            // 
            // lblTaggedListBox
            // 
            lblTaggedListBox.AutoSize = true;
            lblTaggedListBox.Location = new Point(239, 3);
            lblTaggedListBox.Name = "lblTaggedListBox";
            lblTaggedListBox.Size = new Size(122, 15);
            lblTaggedListBox.TabIndex = 6;
            lblTaggedListBox.Text = "Tagged licence plates:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
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
            tableLayoutContent.ResumeLayout(false);
            tableLayoutContent.PerformLayout();
            groupBoxFile.ResumeLayout(false);
            groupBoxFile.PerformLayout();
            flowLayoutFile.ResumeLayout(false);
            groupBoxActions.ResumeLayout(false);
            groupBoxActions.PerformLayout();
            tableLayoutActions.ResumeLayout(false);
            tableLayoutActions.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnActionEnter;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutHeader;
        private Label labelCompany;
        private Label labelTitle;
        private PictureBox pictureBoxLogo;
        private TableLayoutPanel tableLayoutContent;
        private GroupBox groupBoxFile;
        private FlowLayoutPanel flowLayoutFile;
        private Button btnFileLoad;
        private Button btnFileSave;
        private Button btnFileReset;
        private GroupBox groupBoxActions;
        private TableLayoutPanel tableLayoutActions;
        private TextBox txtBoxAction;
        private Button btnActionExit;
        private Button btnSearchBinary;
        private Button btnSearchLinear;
        private Button btnActionEdit;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBoxMain;
        private ListBox listBoxTagged;
        private Label lblTag;
        private Button btnTagAdd;
        private Button btnTagRemove;
        private Label lblMainListBox;
        private Label lblTaggedListBox;
    }
}
