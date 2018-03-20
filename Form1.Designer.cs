namespace ImageCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Toolbar = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.ImagePaddingUpDown = new System.Windows.Forms.NumericUpDown();
            this.ImageWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.addBorder = new System.Windows.Forms.CheckBox();
            this.useHeading = new System.Windows.Forms.CheckBox();
            this.DetailsCornerBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NumberCornerBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BackColorBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HeaderColor = new System.Windows.Forms.ComboBox();
            this.CreateNewImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceLocationTextBox = new System.Windows.Forms.TextBox();
            this.PriceColorBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberLocationTextBox = new System.Windows.Forms.TextBox();
            this.NumberColorBox = new System.Windows.Forms.ComboBox();
            this.PreviewImage = new System.Windows.Forms.Button();
            this.SaveImage = new System.Windows.Forms.Button();
            this.NewHeader = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Arrange = new System.Windows.Forms.DataGridView();
            this.HeaderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePaddingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageWidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Arrange)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Toolbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 100);
            this.panel1.TabIndex = 0;
            // 
            // Toolbar
            // 
            this.Toolbar.Controls.Add(this.MainTab);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Padding = new System.Drawing.Point(0, 0);
            this.Toolbar.SelectedIndex = 0;
            this.Toolbar.Size = new System.Drawing.Size(1264, 100);
            this.Toolbar.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.BackColor = System.Drawing.Color.White;
            this.MainTab.Controls.Add(this.ImagePaddingUpDown);
            this.MainTab.Controls.Add(this.ImageWidthUpDown);
            this.MainTab.Controls.Add(this.addBorder);
            this.MainTab.Controls.Add(this.useHeading);
            this.MainTab.Controls.Add(this.DetailsCornerBox);
            this.MainTab.Controls.Add(this.label9);
            this.MainTab.Controls.Add(this.label10);
            this.MainTab.Controls.Add(this.NumberCornerBox);
            this.MainTab.Controls.Add(this.label8);
            this.MainTab.Controls.Add(this.BackColorBox);
            this.MainTab.Controls.Add(this.label7);
            this.MainTab.Controls.Add(this.HeaderColor);
            this.MainTab.Controls.Add(this.CreateNewImage);
            this.MainTab.Controls.Add(this.label5);
            this.MainTab.Controls.Add(this.label6);
            this.MainTab.Controls.Add(this.label3);
            this.MainTab.Controls.Add(this.label4);
            this.MainTab.Controls.Add(this.PriceLocationTextBox);
            this.MainTab.Controls.Add(this.PriceColorBox);
            this.MainTab.Controls.Add(this.label2);
            this.MainTab.Controls.Add(this.label1);
            this.MainTab.Controls.Add(this.NumberLocationTextBox);
            this.MainTab.Controls.Add(this.NumberColorBox);
            this.MainTab.Controls.Add(this.PreviewImage);
            this.MainTab.Controls.Add(this.SaveImage);
            this.MainTab.Controls.Add(this.NewHeader);
            this.MainTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainTab.Location = new System.Drawing.Point(4, 22);
            this.MainTab.Margin = new System.Windows.Forms.Padding(0);
            this.MainTab.Name = "MainTab";
            this.MainTab.Size = new System.Drawing.Size(1256, 74);
            this.MainTab.TabIndex = 1;
            this.MainTab.Text = "    Design    ";
            // 
            // ImagePaddingUpDown
            // 
            this.ImagePaddingUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePaddingUpDown.Location = new System.Drawing.Point(1086, 42);
            this.ImagePaddingUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.ImagePaddingUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ImagePaddingUpDown.Name = "ImagePaddingUpDown";
            this.ImagePaddingUpDown.Size = new System.Drawing.Size(45, 20);
            this.ImagePaddingUpDown.TabIndex = 34;
            this.ImagePaddingUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ImageWidthUpDown
            // 
            this.ImageWidthUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageWidthUpDown.Location = new System.Drawing.Point(1086, 13);
            this.ImageWidthUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.ImageWidthUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ImageWidthUpDown.Name = "ImageWidthUpDown";
            this.ImageWidthUpDown.Size = new System.Drawing.Size(45, 20);
            this.ImageWidthUpDown.TabIndex = 33;
            this.ImageWidthUpDown.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // addBorder
            // 
            this.addBorder.AutoSize = true;
            this.addBorder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBorder.Location = new System.Drawing.Point(1157, 45);
            this.addBorder.Margin = new System.Windows.Forms.Padding(0);
            this.addBorder.Name = "addBorder";
            this.addBorder.Size = new System.Drawing.Size(79, 17);
            this.addBorder.TabIndex = 32;
            this.addBorder.Text = "Add Border";
            this.addBorder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addBorder.UseVisualStyleBackColor = true;
            // 
            // useHeading
            // 
            this.useHeading.AutoSize = true;
            this.useHeading.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.useHeading.Checked = true;
            this.useHeading.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useHeading.Location = new System.Drawing.Point(1148, 16);
            this.useHeading.Margin = new System.Windows.Forms.Padding(0);
            this.useHeading.Name = "useHeading";
            this.useHeading.Size = new System.Drawing.Size(88, 17);
            this.useHeading.TabIndex = 31;
            this.useHeading.Text = "Use Heading";
            this.useHeading.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.useHeading.UseVisualStyleBackColor = true;
            // 
            // DetailsCornerBox
            // 
            this.DetailsCornerBox.BackColor = System.Drawing.Color.White;
            this.DetailsCornerBox.DropDownWidth = 80;
            this.DetailsCornerBox.ForeColor = System.Drawing.Color.Black;
            this.DetailsCornerBox.FormattingEnabled = true;
            this.DetailsCornerBox.Items.AddRange(new object[] {
            "Top Right",
            "Top Left",
            "Bottom Right",
            "Bottom Left"});
            this.DetailsCornerBox.Location = new System.Drawing.Point(733, 41);
            this.DetailsCornerBox.Margin = new System.Windows.Forms.Padding(0);
            this.DetailsCornerBox.Name = "DetailsCornerBox";
            this.DetailsCornerBox.Size = new System.Drawing.Size(100, 21);
            this.DetailsCornerBox.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(654, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Details Corner";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(649, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Number Corner";
            // 
            // NumberCornerBox
            // 
            this.NumberCornerBox.BackColor = System.Drawing.Color.White;
            this.NumberCornerBox.DropDownWidth = 80;
            this.NumberCornerBox.ForeColor = System.Drawing.Color.Black;
            this.NumberCornerBox.FormattingEnabled = true;
            this.NumberCornerBox.Items.AddRange(new object[] {
            "Top Right",
            "Top Left",
            "Bottom Right",
            "Bottom Left"});
            this.NumberCornerBox.Location = new System.Drawing.Point(733, 12);
            this.NumberCornerBox.Margin = new System.Windows.Forms.Padding(0);
            this.NumberCornerBox.Name = "NumberCornerBox";
            this.NumberCornerBox.Size = new System.Drawing.Size(100, 21);
            this.NumberCornerBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(280, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Back Color";
            // 
            // BackColorBox
            // 
            this.BackColorBox.BackColor = System.Drawing.Color.White;
            this.BackColorBox.DropDownWidth = 80;
            this.BackColorBox.ForeColor = System.Drawing.Color.Black;
            this.BackColorBox.FormattingEnabled = true;
            this.BackColorBox.Location = new System.Drawing.Point(345, 41);
            this.BackColorBox.Margin = new System.Windows.Forms.Padding(0);
            this.BackColorBox.Name = "BackColorBox";
            this.BackColorBox.Size = new System.Drawing.Size(100, 21);
            this.BackColorBox.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(270, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Header Color";
            // 
            // HeaderColor
            // 
            this.HeaderColor.BackColor = System.Drawing.Color.White;
            this.HeaderColor.DropDownWidth = 80;
            this.HeaderColor.ForeColor = System.Drawing.Color.Black;
            this.HeaderColor.FormattingEnabled = true;
            this.HeaderColor.Location = new System.Drawing.Point(345, 12);
            this.HeaderColor.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderColor.Name = "HeaderColor";
            this.HeaderColor.Size = new System.Drawing.Size(100, 21);
            this.HeaderColor.TabIndex = 22;
            // 
            // CreateNewImage
            // 
            this.CreateNewImage.BackColor = System.Drawing.Color.White;
            this.CreateNewImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.CreateNewImage.FlatAppearance.BorderSize = 0;
            this.CreateNewImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewImage.ForeColor = System.Drawing.Color.Black;
            this.CreateNewImage.Image = ((System.Drawing.Image)(resources.GetObject("CreateNewImage.Image")));
            this.CreateNewImage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateNewImage.Location = new System.Drawing.Point(192, 0);
            this.CreateNewImage.Name = "CreateNewImage";
            this.CreateNewImage.Size = new System.Drawing.Size(64, 74);
            this.CreateNewImage.TabIndex = 21;
            this.CreateNewImage.Text = "Clear Image";
            this.CreateNewImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CreateNewImage.UseVisualStyleBackColor = false;
            this.CreateNewImage.Click += new System.EventHandler(this.CreateNewImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1002, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Image Padding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1022, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Max Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(852, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Details Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(463, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Details Color";
            // 
            // PriceLocationTextBox
            // 
            this.PriceLocationTextBox.BackColor = System.Drawing.Color.White;
            this.PriceLocationTextBox.ForeColor = System.Drawing.Color.Black;
            this.PriceLocationTextBox.Location = new System.Drawing.Point(941, 42);
            this.PriceLocationTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PriceLocationTextBox.Name = "PriceLocationTextBox";
            this.PriceLocationTextBox.Size = new System.Drawing.Size(45, 20);
            this.PriceLocationTextBox.TabIndex = 13;
            this.PriceLocationTextBox.Text = "5, 5";
            // 
            // PriceColorBox
            // 
            this.PriceColorBox.BackColor = System.Drawing.Color.White;
            this.PriceColorBox.DropDownWidth = 80;
            this.PriceColorBox.ForeColor = System.Drawing.Color.Black;
            this.PriceColorBox.FormattingEnabled = true;
            this.PriceColorBox.Location = new System.Drawing.Point(535, 41);
            this.PriceColorBox.Margin = new System.Windows.Forms.Padding(0);
            this.PriceColorBox.Name = "PriceColorBox";
            this.PriceColorBox.Size = new System.Drawing.Size(100, 21);
            this.PriceColorBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(847, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(458, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Color";
            // 
            // NumberLocationTextBox
            // 
            this.NumberLocationTextBox.BackColor = System.Drawing.Color.White;
            this.NumberLocationTextBox.ForeColor = System.Drawing.Color.Black;
            this.NumberLocationTextBox.Location = new System.Drawing.Point(941, 13);
            this.NumberLocationTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NumberLocationTextBox.Name = "NumberLocationTextBox";
            this.NumberLocationTextBox.Size = new System.Drawing.Size(45, 20);
            this.NumberLocationTextBox.TabIndex = 4;
            this.NumberLocationTextBox.Text = "5, 5";
            // 
            // NumberColorBox
            // 
            this.NumberColorBox.BackColor = System.Drawing.Color.White;
            this.NumberColorBox.DropDownWidth = 80;
            this.NumberColorBox.ForeColor = System.Drawing.Color.Black;
            this.NumberColorBox.FormattingEnabled = true;
            this.NumberColorBox.Location = new System.Drawing.Point(535, 12);
            this.NumberColorBox.Margin = new System.Windows.Forms.Padding(0);
            this.NumberColorBox.Name = "NumberColorBox";
            this.NumberColorBox.Size = new System.Drawing.Size(100, 21);
            this.NumberColorBox.TabIndex = 3;
            // 
            // PreviewImage
            // 
            this.PreviewImage.BackColor = System.Drawing.Color.White;
            this.PreviewImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviewImage.FlatAppearance.BorderSize = 0;
            this.PreviewImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewImage.ForeColor = System.Drawing.Color.Black;
            this.PreviewImage.Image = ((System.Drawing.Image)(resources.GetObject("PreviewImage.Image")));
            this.PreviewImage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PreviewImage.Location = new System.Drawing.Point(128, 0);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(64, 74);
            this.PreviewImage.TabIndex = 2;
            this.PreviewImage.Text = "Preview Image";
            this.PreviewImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PreviewImage.UseVisualStyleBackColor = false;
            this.PreviewImage.Click += new System.EventHandler(this.PreviewImage_Click);
            // 
            // SaveImage
            // 
            this.SaveImage.BackColor = System.Drawing.Color.White;
            this.SaveImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveImage.FlatAppearance.BorderSize = 0;
            this.SaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveImage.ForeColor = System.Drawing.Color.Black;
            this.SaveImage.Image = ((System.Drawing.Image)(resources.GetObject("SaveImage.Image")));
            this.SaveImage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveImage.Location = new System.Drawing.Point(64, 0);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(64, 74);
            this.SaveImage.TabIndex = 1;
            this.SaveImage.Text = "Save Image";
            this.SaveImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveImage.UseVisualStyleBackColor = false;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // NewHeader
            // 
            this.NewHeader.BackColor = System.Drawing.Color.White;
            this.NewHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewHeader.FlatAppearance.BorderSize = 0;
            this.NewHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewHeader.ForeColor = System.Drawing.Color.Black;
            this.NewHeader.Image = ((System.Drawing.Image)(resources.GetObject("NewHeader.Image")));
            this.NewHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewHeader.Location = new System.Drawing.Point(0, 0);
            this.NewHeader.Name = "NewHeader";
            this.NewHeader.Size = new System.Drawing.Size(64, 74);
            this.NewHeader.TabIndex = 0;
            this.NewHeader.Text = "New Header";
            this.NewHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewHeader.UseVisualStyleBackColor = false;
            this.NewHeader.Click += new System.EventHandler(this.NewHeader_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 661);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Arrange);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer2.Size = new System.Drawing.Size(275, 661);
            this.splitContainer2.SplitterDistance = 263;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 1;
            // 
            // Arrange
            // 
            this.Arrange.AllowUserToAddRows = false;
            this.Arrange.AllowUserToResizeRows = false;
            this.Arrange.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Arrange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Arrange.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Arrange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Arrange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderColumn,
            this.ImageColumn,
            this.PriceColumn});
            this.Arrange.ContextMenuStrip = this.contextMenuStrip1;
            this.Arrange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Arrange.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Arrange.Location = new System.Drawing.Point(0, 0);
            this.Arrange.Margin = new System.Windows.Forms.Padding(0);
            this.Arrange.Name = "Arrange";
            this.Arrange.RowHeadersVisible = false;
            this.Arrange.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Arrange.Size = new System.Drawing.Size(275, 263);
            this.Arrange.TabIndex = 1;
            this.Arrange.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Arrange_CellClick);
            // 
            // HeaderColumn
            // 
            this.HeaderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderColumn.HeaderText = "Header";
            this.HeaderColumn.MinimumWidth = 75;
            this.HeaderColumn.Name = "HeaderColumn";
            this.HeaderColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ImageColumn
            // 
            this.ImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageColumn.HeaderText = "Image";
            this.ImageColumn.Name = "ImageColumn";
            this.ImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PriceColumn
            // 
            this.PriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceColumn.HeaderText = "Details";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImagesToolStripMenuItem,
            this.removeImageToolStripMenuItem,
            this.removeHeaderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 70);
            // 
            // addImagesToolStripMenuItem
            // 
            this.addImagesToolStripMenuItem.Name = "addImagesToolStripMenuItem";
            this.addImagesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addImagesToolStripMenuItem.Text = "Add Images";
            this.addImagesToolStripMenuItem.Click += new System.EventHandler(this.addImagesToolStripMenuItem_Click);
            // 
            // removeImageToolStripMenuItem
            // 
            this.removeImageToolStripMenuItem.Name = "removeImageToolStripMenuItem";
            this.removeImageToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.removeImageToolStripMenuItem.Text = "Remove Image";
            this.removeImageToolStripMenuItem.Click += new System.EventHandler(this.removeImageToolStripMenuItem_Click);
            // 
            // removeHeaderToolStripMenuItem
            // 
            this.removeHeaderToolStripMenuItem.Name = "removeHeaderToolStripMenuItem";
            this.removeHeaderToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.removeHeaderToolStripMenuItem.Text = "Remove Header";
            this.removeHeaderToolStripMenuItem.Click += new System.EventHandler(this.removeHeaderToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 661);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 600);
            this.Name = "Form1";
            this.Text = "PhotoGrid #  by noah-@github.com";
            this.panel1.ResumeLayout(false);
            this.Toolbar.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePaddingUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageWidthUpDown)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Arrange)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl Toolbar;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NewHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberLocationTextBox;
        private System.Windows.Forms.ComboBox NumberColorBox;
        private System.Windows.Forms.Button PreviewImage;
        private System.Windows.Forms.Button SaveImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceLocationTextBox;
        private System.Windows.Forms.ComboBox PriceColorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeImageToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView Arrange;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BackColorBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox HeaderColor;
        private System.Windows.Forms.Button CreateNewImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.ToolStripMenuItem removeHeaderToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox NumberCornerBox;
        private System.Windows.Forms.ComboBox DetailsCornerBox;
        private System.Windows.Forms.CheckBox addBorder;
        private System.Windows.Forms.CheckBox useHeading;
        private System.Windows.Forms.NumericUpDown ImagePaddingUpDown;
        private System.Windows.Forms.NumericUpDown ImageWidthUpDown;
    }
}

