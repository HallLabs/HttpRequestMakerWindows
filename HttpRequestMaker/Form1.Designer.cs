namespace HttpRequestMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RequestSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HeaderAddButton = new System.Windows.Forms.Button();
            this.HeaderValueBox = new System.Windows.Forms.TextBox();
            this.HeaderNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HeadersListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ContentListBox = new System.Windows.Forms.ListBox();
            this.ContentAddButton = new System.Windows.Forms.Button();
            this.ContentValueBox = new System.Windows.Forms.TextBox();
            this.ContentNameBox = new System.Windows.Forms.TextBox();
            this.ResponseTabControl = new System.Windows.Forms.TabControl();
            this.RawTab = new System.Windows.Forms.TabPage();
            this.RawTextBox = new System.Windows.Forms.RichTextBox();
            this.JSONTab = new System.Windows.Forms.TabPage();
            this.JSONFormatButton = new System.Windows.Forms.Button();
            this.JSONTextBox = new System.Windows.Forms.RichTextBox();
            this.ImageTab = new System.Windows.Forms.TabPage();
            this.ImageSaveButton = new System.Windows.Forms.Button();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.ErrorMessageBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ErrorSourceBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ResponseHeaderListBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ContentTypeBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ResponseCodeBox = new System.Windows.Forms.TextBox();
            this.FunctionComboBox = new System.Windows.Forms.ComboBox();
            this.RequestButton = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.UploadFilesButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.HistoryLoadButton = new System.Windows.Forms.Button();
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.RequestSplitContainer)).BeginInit();
            this.RequestSplitContainer.Panel1.SuspendLayout();
            this.RequestSplitContainer.Panel2.SuspendLayout();
            this.RequestSplitContainer.SuspendLayout();
            this.ResponseTabControl.SuspendLayout();
            this.RawTab.SuspendLayout();
            this.JSONTab.SuspendLayout();
            this.ImageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.InfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLTextBox
            // 
            this.URLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URLTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTextBox.Location = new System.Drawing.Point(33, 6);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(739, 20);
            this.URLTextBox.TabIndex = 0;
            this.URLTextBox.Text = "http://admin.pinsimple.com/api/";
            this.URLTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuppressEnterSound);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // RequestSplitContainer
            // 
            this.RequestSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestSplitContainer.Location = new System.Drawing.Point(4, 32);
            this.RequestSplitContainer.Name = "RequestSplitContainer";
            // 
            // RequestSplitContainer.Panel1
            // 
            this.RequestSplitContainer.Panel1.Controls.Add(this.label5);
            this.RequestSplitContainer.Panel1.Controls.Add(this.label4);
            this.RequestSplitContainer.Panel1.Controls.Add(this.HeaderAddButton);
            this.RequestSplitContainer.Panel1.Controls.Add(this.HeaderValueBox);
            this.RequestSplitContainer.Panel1.Controls.Add(this.HeaderNameBox);
            this.RequestSplitContainer.Panel1.Controls.Add(this.label2);
            this.RequestSplitContainer.Panel1.Controls.Add(this.HeadersListBox);
            // 
            // RequestSplitContainer.Panel2
            // 
            this.RequestSplitContainer.Panel2.Controls.Add(this.label7);
            this.RequestSplitContainer.Panel2.Controls.Add(this.label3);
            this.RequestSplitContainer.Panel2.Controls.Add(this.label6);
            this.RequestSplitContainer.Panel2.Controls.Add(this.ContentListBox);
            this.RequestSplitContainer.Panel2.Controls.Add(this.ContentAddButton);
            this.RequestSplitContainer.Panel2.Controls.Add(this.ContentValueBox);
            this.RequestSplitContainer.Panel2.Controls.Add(this.ContentNameBox);
            this.RequestSplitContainer.Size = new System.Drawing.Size(673, 191);
            this.RequestSplitContainer.SplitterDistance = 334;
            this.RequestSplitContainer.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Value";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // HeaderAddButton
            // 
            this.HeaderAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderAddButton.Location = new System.Drawing.Point(238, 165);
            this.HeaderAddButton.Name = "HeaderAddButton";
            this.HeaderAddButton.Size = new System.Drawing.Size(93, 23);
            this.HeaderAddButton.TabIndex = 4;
            this.HeaderAddButton.Text = "Add";
            this.HeaderAddButton.UseVisualStyleBackColor = true;
            this.HeaderAddButton.Click += new System.EventHandler(this.HeaderAddButton_Click);
            // 
            // HeaderValueBox
            // 
            this.HeaderValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderValueBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderValueBox.Location = new System.Drawing.Point(147, 168);
            this.HeaderValueBox.Name = "HeaderValueBox";
            this.HeaderValueBox.Size = new System.Drawing.Size(85, 20);
            this.HeaderValueBox.TabIndex = 3;
            this.HeaderValueBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuppressEnterSound);
            this.HeaderValueBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HeaderValueBox_KeyUp);
            // 
            // HeaderNameBox
            // 
            this.HeaderNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HeaderNameBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderNameBox.Location = new System.Drawing.Point(6, 168);
            this.HeaderNameBox.Name = "HeaderNameBox";
            this.HeaderNameBox.Size = new System.Drawing.Size(135, 20);
            this.HeaderNameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Headers";
            // 
            // HeadersListBox
            // 
            this.HeadersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeadersListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadersListBox.FormattingEnabled = true;
            this.HeadersListBox.Location = new System.Drawing.Point(3, 16);
            this.HeadersListBox.Name = "HeadersListBox";
            this.HeadersListBox.Size = new System.Drawing.Size(328, 134);
            this.HeadersListBox.TabIndex = 0;
            this.HeadersListBox.SelectedIndexChanged += new System.EventHandler(this.HeadersListBox_SelectedIndexChanged);
            this.HeadersListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HeadersListBox_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Content";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // ContentListBox
            // 
            this.ContentListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentListBox.FormattingEnabled = true;
            this.ContentListBox.Location = new System.Drawing.Point(3, 16);
            this.ContentListBox.Name = "ContentListBox";
            this.ContentListBox.Size = new System.Drawing.Size(329, 134);
            this.ContentListBox.TabIndex = 0;
            this.ContentListBox.SelectedIndexChanged += new System.EventHandler(this.ContentListBox_SelectedIndexChanged);
            this.ContentListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ContentListBox_KeyUp);
            // 
            // ContentAddButton
            // 
            this.ContentAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentAddButton.Location = new System.Drawing.Point(241, 162);
            this.ContentAddButton.Name = "ContentAddButton";
            this.ContentAddButton.Size = new System.Drawing.Size(91, 23);
            this.ContentAddButton.TabIndex = 4;
            this.ContentAddButton.Text = "Add";
            this.ContentAddButton.UseVisualStyleBackColor = true;
            this.ContentAddButton.Click += new System.EventHandler(this.ContentAddButton_Click);
            // 
            // ContentValueBox
            // 
            this.ContentValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentValueBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentValueBox.Location = new System.Drawing.Point(147, 165);
            this.ContentValueBox.Name = "ContentValueBox";
            this.ContentValueBox.Size = new System.Drawing.Size(88, 20);
            this.ContentValueBox.TabIndex = 3;
            this.ContentValueBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuppressEnterSound);
            this.ContentValueBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ContentValueBox_KeyUp);
            // 
            // ContentNameBox
            // 
            this.ContentNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContentNameBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentNameBox.Location = new System.Drawing.Point(6, 165);
            this.ContentNameBox.Name = "ContentNameBox";
            this.ContentNameBox.Size = new System.Drawing.Size(135, 20);
            this.ContentNameBox.TabIndex = 2;
            // 
            // ResponseTabControl
            // 
            this.ResponseTabControl.Controls.Add(this.RawTab);
            this.ResponseTabControl.Controls.Add(this.JSONTab);
            this.ResponseTabControl.Controls.Add(this.ImageTab);
            this.ResponseTabControl.Controls.Add(this.InfoTab);
            this.ResponseTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseTabControl.Location = new System.Drawing.Point(0, 0);
            this.ResponseTabControl.Name = "ResponseTabControl";
            this.ResponseTabControl.SelectedIndex = 0;
            this.ResponseTabControl.Size = new System.Drawing.Size(628, 252);
            this.ResponseTabControl.TabIndex = 3;
            this.ResponseTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.ResponseTabControl_Selected);
            // 
            // RawTab
            // 
            this.RawTab.Controls.Add(this.RawTextBox);
            this.RawTab.Location = new System.Drawing.Point(4, 22);
            this.RawTab.Name = "RawTab";
            this.RawTab.Padding = new System.Windows.Forms.Padding(3);
            this.RawTab.Size = new System.Drawing.Size(620, 226);
            this.RawTab.TabIndex = 0;
            this.RawTab.Text = "Raw";
            this.RawTab.UseVisualStyleBackColor = true;
            // 
            // RawTextBox
            // 
            this.RawTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RawTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawTextBox.Location = new System.Drawing.Point(3, 3);
            this.RawTextBox.Name = "RawTextBox";
            this.RawTextBox.ReadOnly = true;
            this.RawTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RawTextBox.Size = new System.Drawing.Size(614, 220);
            this.RawTextBox.TabIndex = 0;
            this.RawTextBox.Text = "No request made";
            // 
            // JSONTab
            // 
            this.JSONTab.Controls.Add(this.JSONFormatButton);
            this.JSONTab.Controls.Add(this.JSONTextBox);
            this.JSONTab.Location = new System.Drawing.Point(4, 22);
            this.JSONTab.Name = "JSONTab";
            this.JSONTab.Padding = new System.Windows.Forms.Padding(3);
            this.JSONTab.Size = new System.Drawing.Size(620, 226);
            this.JSONTab.TabIndex = 1;
            this.JSONTab.Text = "JSON";
            this.JSONTab.UseVisualStyleBackColor = true;
            // 
            // JSONFormatButton
            // 
            this.JSONFormatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.JSONFormatButton.Location = new System.Drawing.Point(566, 139);
            this.JSONFormatButton.Name = "JSONFormatButton";
            this.JSONFormatButton.Size = new System.Drawing.Size(51, 81);
            this.JSONFormatButton.TabIndex = 2;
            this.JSONFormatButton.Text = "Try Format";
            this.JSONFormatButton.UseVisualStyleBackColor = true;
            this.JSONFormatButton.Click += new System.EventHandler(this.JSONFormatButton_Click);
            // 
            // JSONTextBox
            // 
            this.JSONTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JSONTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JSONTextBox.Location = new System.Drawing.Point(3, 3);
            this.JSONTextBox.Name = "JSONTextBox";
            this.JSONTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.JSONTextBox.Size = new System.Drawing.Size(557, 220);
            this.JSONTextBox.TabIndex = 1;
            this.JSONTextBox.Text = "No request made";
            // 
            // ImageTab
            // 
            this.ImageTab.Controls.Add(this.ImageSaveButton);
            this.ImageTab.Controls.Add(this.ImageBox);
            this.ImageTab.Location = new System.Drawing.Point(4, 22);
            this.ImageTab.Name = "ImageTab";
            this.ImageTab.Size = new System.Drawing.Size(620, 226);
            this.ImageTab.TabIndex = 2;
            this.ImageTab.Text = "Image Data";
            this.ImageTab.UseVisualStyleBackColor = true;
            // 
            // ImageSaveButton
            // 
            this.ImageSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSaveButton.Location = new System.Drawing.Point(576, 128);
            this.ImageSaveButton.Name = "ImageSaveButton";
            this.ImageSaveButton.Size = new System.Drawing.Size(41, 95);
            this.ImageSaveButton.TabIndex = 1;
            this.ImageSaveButton.Text = "Save";
            this.ImageSaveButton.UseVisualStyleBackColor = true;
            this.ImageSaveButton.Click += new System.EventHandler(this.ImageSaveButton_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBox.Location = new System.Drawing.Point(0, 0);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(570, 223);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // InfoTab
            // 
            this.InfoTab.Controls.Add(this.label14);
            this.InfoTab.Controls.Add(this.ErrorMessageBox);
            this.InfoTab.Controls.Add(this.label13);
            this.InfoTab.Controls.Add(this.ErrorSourceBox);
            this.InfoTab.Controls.Add(this.label12);
            this.InfoTab.Controls.Add(this.ResponseHeaderListBox);
            this.InfoTab.Controls.Add(this.label11);
            this.InfoTab.Controls.Add(this.ContentTypeBox);
            this.InfoTab.Controls.Add(this.label10);
            this.InfoTab.Controls.Add(this.ResponseCodeBox);
            this.InfoTab.Location = new System.Drawing.Point(4, 22);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.InfoTab.Size = new System.Drawing.Size(620, 226);
            this.InfoTab.TabIndex = 3;
            this.InfoTab.Text = "Response Info";
            this.InfoTab.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Error Message";
            // 
            // ErrorMessageBox
            // 
            this.ErrorMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorMessageBox.Location = new System.Drawing.Point(113, 45);
            this.ErrorMessageBox.Name = "ErrorMessageBox";
            this.ErrorMessageBox.ReadOnly = true;
            this.ErrorMessageBox.Size = new System.Drawing.Size(499, 20);
            this.ErrorMessageBox.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "HResult";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // ErrorSourceBox
            // 
            this.ErrorSourceBox.Location = new System.Drawing.Point(9, 45);
            this.ErrorSourceBox.Name = "ErrorSourceBox";
            this.ErrorSourceBox.ReadOnly = true;
            this.ErrorSourceBox.Size = new System.Drawing.Size(98, 20);
            this.ErrorSourceBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Response Headers:";
            // 
            // ResponseHeaderListBox
            // 
            this.ResponseHeaderListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseHeaderListBox.FormattingEnabled = true;
            this.ResponseHeaderListBox.Location = new System.Drawing.Point(9, 84);
            this.ResponseHeaderListBox.Name = "ResponseHeaderListBox";
            this.ResponseHeaderListBox.Size = new System.Drawing.Size(603, 134);
            this.ResponseHeaderListBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Content Type";
            // 
            // ContentTypeBox
            // 
            this.ContentTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTypeBox.Location = new System.Drawing.Point(303, 6);
            this.ContentTypeBox.Name = "ContentTypeBox";
            this.ContentTypeBox.ReadOnly = true;
            this.ContentTypeBox.Size = new System.Drawing.Size(309, 20);
            this.ContentTypeBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Response Code";
            // 
            // ResponseCodeBox
            // 
            this.ResponseCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseCodeBox.Location = new System.Drawing.Point(95, 6);
            this.ResponseCodeBox.Name = "ResponseCodeBox";
            this.ResponseCodeBox.ReadOnly = true;
            this.ResponseCodeBox.Size = new System.Drawing.Size(125, 20);
            this.ResponseCodeBox.TabIndex = 0;
            // 
            // FunctionComboBox
            // 
            this.FunctionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FunctionComboBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionComboBox.FormattingEnabled = true;
            this.FunctionComboBox.Items.AddRange(new object[] {
            "GET",
            "POST",
            "DELETE"});
            this.FunctionComboBox.Location = new System.Drawing.Point(10, 229);
            this.FunctionComboBox.Name = "FunctionComboBox";
            this.FunctionComboBox.Size = new System.Drawing.Size(118, 21);
            this.FunctionComboBox.TabIndex = 4;
            this.FunctionComboBox.Text = "POST";
            this.FunctionComboBox.SelectedIndexChanged += new System.EventHandler(this.FunctionComboBox_SelectedIndexChanged);
            // 
            // RequestButton
            // 
            this.RequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestButton.Location = new System.Drawing.Point(134, 229);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(524, 23);
            this.RequestButton.TabIndex = 5;
            this.RequestButton.Text = "Submit Request";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(683, 48);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(94, 121);
            this.FilesListBox.TabIndex = 6;
            this.FilesListBox.SelectedIndexChanged += new System.EventHandler(this.FilesListBox_SelectedIndexChanged);
            this.FilesListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FilesListBox_KeyUp);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFileButton.Location = new System.Drawing.Point(683, 197);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(94, 23);
            this.AddFileButton.TabIndex = 7;
            this.AddFileButton.Text = "...";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(675, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Files";
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "OpenDialog";
            // 
            // FileNameBox
            // 
            this.FileNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameBox.Location = new System.Drawing.Point(683, 171);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(94, 20);
            this.FileNameBox.TabIndex = 9;
            this.FileNameBox.Text = "file";
            // 
            // UploadFilesButton
            // 
            this.UploadFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadFilesButton.Location = new System.Drawing.Point(664, 229);
            this.UploadFilesButton.Name = "UploadFilesButton";
            this.UploadFilesButton.Size = new System.Drawing.Size(113, 23);
            this.UploadFilesButton.TabIndex = 10;
            this.UploadFilesButton.Text = "Upload Files";
            this.UploadFilesButton.UseVisualStyleBackColor = true;
            this.UploadFilesButton.Click += new System.EventHandler(this.UploadFilesButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.FilesListBox);
            this.splitContainer1.Panel1.Controls.Add(this.RequestButton);
            this.splitContainer1.Panel1.Controls.Add(this.UploadFilesButton);
            this.splitContainer1.Panel1.Controls.Add(this.URLTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.FileNameBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.RequestSplitContainer);
            this.splitContainer1.Panel1.Controls.Add(this.AddFileButton);
            this.splitContainer1.Panel1.Controls.Add(this.FunctionComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 511);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Files";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.HistoryLoadButton);
            this.splitContainer2.Panel1.Controls.Add(this.HistoryListBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ResponseTabControl);
            this.splitContainer2.Size = new System.Drawing.Size(784, 252);
            this.splitContainer2.SplitterDistance = 152;
            this.splitContainer2.TabIndex = 4;
            // 
            // HistoryLoadButton
            // 
            this.HistoryLoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryLoadButton.Enabled = false;
            this.HistoryLoadButton.Location = new System.Drawing.Point(3, 225);
            this.HistoryLoadButton.Name = "HistoryLoadButton";
            this.HistoryLoadButton.Size = new System.Drawing.Size(146, 23);
            this.HistoryLoadButton.TabIndex = 2;
            this.HistoryLoadButton.Text = "Load";
            this.HistoryLoadButton.UseVisualStyleBackColor = true;
            this.HistoryLoadButton.Click += new System.EventHandler(this.HistoryLoadButton_Click);
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.Location = new System.Drawing.Point(0, 0);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(152, 225);
            this.HistoryListBox.TabIndex = 0;
            this.HistoryListBox.SelectedIndexChanged += new System.EventHandler(this.HistoryListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "Form1";
            this.Text = "Http Request Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RequestSplitContainer.Panel1.ResumeLayout(false);
            this.RequestSplitContainer.Panel1.PerformLayout();
            this.RequestSplitContainer.Panel2.ResumeLayout(false);
            this.RequestSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestSplitContainer)).EndInit();
            this.RequestSplitContainer.ResumeLayout(false);
            this.ResponseTabControl.ResumeLayout(false);
            this.RawTab.ResumeLayout(false);
            this.JSONTab.ResumeLayout(false);
            this.ImageTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.InfoTab.ResumeLayout(false);
            this.InfoTab.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer RequestSplitContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button HeaderAddButton;
        private System.Windows.Forms.TextBox HeaderValueBox;
        private System.Windows.Forms.TextBox HeaderNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox HeadersListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ContentListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ContentAddButton;
        private System.Windows.Forms.TextBox ContentValueBox;
        private System.Windows.Forms.TextBox ContentNameBox;
        private System.Windows.Forms.TabControl ResponseTabControl;
        private System.Windows.Forms.TabPage RawTab;
        private System.Windows.Forms.TabPage JSONTab;
        private System.Windows.Forms.RichTextBox RawTextBox;
        private System.Windows.Forms.TabPage ImageTab;
        private System.Windows.Forms.ComboBox FunctionComboBox;
        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.RichTextBox JSONTextBox;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button JSONFormatButton;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Button UploadFilesButton;
        private System.Windows.Forms.Button ImageSaveButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.Button HistoryLoadButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage InfoTab;
        private System.Windows.Forms.ListBox ResponseHeaderListBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ContentTypeBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ResponseCodeBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ErrorMessageBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ErrorSourceBox;
    }
}

