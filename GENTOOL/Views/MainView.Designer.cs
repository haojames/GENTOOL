namespace GENTOOL.Views
{
    partial class MainView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Overall = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Option = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_ChoiceOption = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_XMLConvertExcel = new System.Windows.Forms.RadioButton();
            this.radioButton_ExcelConvertXML = new System.Windows.Forms.RadioButton();
            this.groupBox_ExcelConvertXMLandXMLConvertExcel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_InputOuputExcel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_FileDialog = new System.Windows.Forms.PictureBox();
            this.pictureBox_Folder = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_Input = new System.Windows.Forms.TableLayoutPanel();
            this.label_Input = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Ouput = new System.Windows.Forms.TableLayoutPanel();
            this.label_Output = new System.Windows.Forms.Label();
            this.tableLayoutPanel_textboxInput = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_TextBoxOuput = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_RangeTCAndInformation = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_RangeTC = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_InputRangeTC = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_InputStartNumber = new System.Windows.Forms.TextBox();
            this.textBox_InputFinishNumber = new System.Windows.Forms.TextBox();
            this.label_TO = new System.Windows.Forms.Label();
            this.label_FROM = new System.Windows.Forms.Label();
            this.groupBox_Information = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_TestModule = new System.Windows.Forms.Label();
            this.label_generateoption = new System.Windows.Forms.Label();
            this.textBox_TestModule = new System.Windows.Forms.TextBox();
            this.comboBox_ChoiceOption = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel_ProcessBarAndRun = new System.Windows.Forms.TableLayoutPanel();
            this.button_RUN = new System.Windows.Forms.Button();
            this.progressBar_Gentool = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel_Footer = new System.Windows.Forms.TableLayoutPanel();
            this.label_version = new System.Windows.Forms.Label();
            this.pictureBox_firm = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel_Overall.SuspendLayout();
            this.groupBox_Option.SuspendLayout();
            this.tableLayoutPanel_ChoiceOption.SuspendLayout();
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.SuspendLayout();
            this.tableLayoutPanel_InputOuputExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FileDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Folder)).BeginInit();
            this.tableLayoutPanel_Input.SuspendLayout();
            this.tableLayoutPanel_Ouput.SuspendLayout();
            this.tableLayoutPanel_textboxInput.SuspendLayout();
            this.tableLayoutPanel_TextBoxOuput.SuspendLayout();
            this.tableLayoutPanel_RangeTCAndInformation.SuspendLayout();
            this.groupBox_RangeTC.SuspendLayout();
            this.tableLayoutPanel_InputRangeTC.SuspendLayout();
            this.groupBox_Information.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_ProcessBarAndRun.SuspendLayout();
            this.tableLayoutPanel_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_firm)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1641, 920);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel_Overall);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1633, 887);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Overall
            // 
            this.tableLayoutPanel_Overall.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel_Overall.ColumnCount = 1;
            this.tableLayoutPanel_Overall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Overall.Controls.Add(this.groupBox_Option, 0, 0);
            this.tableLayoutPanel_Overall.Controls.Add(this.groupBox_ExcelConvertXMLandXMLConvertExcel, 0, 1);
            this.tableLayoutPanel_Overall.Controls.Add(this.tableLayoutPanel_RangeTCAndInformation, 0, 2);
            this.tableLayoutPanel_Overall.Controls.Add(this.tableLayoutPanel_ProcessBarAndRun, 0, 4);
            this.tableLayoutPanel_Overall.Controls.Add(this.tableLayoutPanel_Footer, 0, 5);
            this.tableLayoutPanel_Overall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Overall.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel_Overall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Overall.Name = "tableLayoutPanel_Overall";
            this.tableLayoutPanel_Overall.RowCount = 6;
            this.tableLayoutPanel_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.98374F));
            this.tableLayoutPanel_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.61789F));
            this.tableLayoutPanel_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.39837F));
            this.tableLayoutPanel_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel_Overall.Size = new System.Drawing.Size(1625, 877);
            this.tableLayoutPanel_Overall.TabIndex = 1;
            // 
            // groupBox_Option
            // 
            this.groupBox_Option.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox_Option.Controls.Add(this.tableLayoutPanel_ChoiceOption);
            this.groupBox_Option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Option.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Option.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox_Option.Location = new System.Drawing.Point(4, 5);
            this.groupBox_Option.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Option.Name = "groupBox_Option";
            this.groupBox_Option.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Option.Size = new System.Drawing.Size(1617, 153);
            this.groupBox_Option.TabIndex = 0;
            this.groupBox_Option.TabStop = false;
            this.groupBox_Option.Text = "Option";
            // 
            // tableLayoutPanel_ChoiceOption
            // 
            this.tableLayoutPanel_ChoiceOption.ColumnCount = 1;
            this.tableLayoutPanel_ChoiceOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.23127F));
            this.tableLayoutPanel_ChoiceOption.Controls.Add(this.radioButton_XMLConvertExcel, 0, 1);
            this.tableLayoutPanel_ChoiceOption.Controls.Add(this.radioButton_ExcelConvertXML, 0, 0);
            this.tableLayoutPanel_ChoiceOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ChoiceOption.Location = new System.Drawing.Point(4, 33);
            this.tableLayoutPanel_ChoiceOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_ChoiceOption.Name = "tableLayoutPanel_ChoiceOption";
            this.tableLayoutPanel_ChoiceOption.RowCount = 2;
            this.tableLayoutPanel_ChoiceOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ChoiceOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ChoiceOption.Size = new System.Drawing.Size(1609, 115);
            this.tableLayoutPanel_ChoiceOption.TabIndex = 0;
            // 
            // radioButton_XMLConvertExcel
            // 
            this.radioButton_XMLConvertExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_XMLConvertExcel.AutoSize = true;
            this.radioButton_XMLConvertExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton_XMLConvertExcel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.radioButton_XMLConvertExcel.Location = new System.Drawing.Point(4, 62);
            this.radioButton_XMLConvertExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_XMLConvertExcel.Name = "radioButton_XMLConvertExcel";
            this.radioButton_XMLConvertExcel.Size = new System.Drawing.Size(1601, 48);
            this.radioButton_XMLConvertExcel.TabIndex = 1;
            this.radioButton_XMLConvertExcel.TabStop = true;
            this.radioButton_XMLConvertExcel.Text = "XML Convert Excel";
            this.radioButton_XMLConvertExcel.UseVisualStyleBackColor = false;
            this.radioButton_XMLConvertExcel.CheckedChanged += new System.EventHandler(this.radioButton_XMLConvertExcel_CheckedChanged);
            // 
            // radioButton_ExcelConvertXML
            // 
            this.radioButton_ExcelConvertXML.AutoSize = true;
            this.radioButton_ExcelConvertXML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton_ExcelConvertXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_ExcelConvertXML.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radioButton_ExcelConvertXML.Location = new System.Drawing.Point(4, 5);
            this.radioButton_ExcelConvertXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_ExcelConvertXML.Name = "radioButton_ExcelConvertXML";
            this.radioButton_ExcelConvertXML.Size = new System.Drawing.Size(1601, 47);
            this.radioButton_ExcelConvertXML.TabIndex = 2;
            this.radioButton_ExcelConvertXML.TabStop = true;
            this.radioButton_ExcelConvertXML.Text = "Excel Convert XML";
            this.radioButton_ExcelConvertXML.UseVisualStyleBackColor = false;
            this.radioButton_ExcelConvertXML.CheckedChanged += new System.EventHandler(this.radioButton_ExcelConvertXML_CheckedChanged);
            // 
            // groupBox_ExcelConvertXMLandXMLConvertExcel
            // 
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.Controls.Add(this.tableLayoutPanel_InputOuputExcel);
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.Location = new System.Drawing.Point(4, 168);
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.Name = "groupBox_ExcelConvertXMLandXMLConvertExcel";
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.Size = new System.Drawing.Size(1617, 147);
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.TabIndex = 1;
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.TabStop = false;
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.Text = "EXCEL Convert XML And XML Convert EXCEL";
            // 
            // tableLayoutPanel_InputOuputExcel
            // 
            this.tableLayoutPanel_InputOuputExcel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel_InputOuputExcel.ColumnCount = 3;
            this.tableLayoutPanel_InputOuputExcel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_InputOuputExcel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.84608F));
            this.tableLayoutPanel_InputOuputExcel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.180918F));
            this.tableLayoutPanel_InputOuputExcel.Controls.Add(this.pictureBox_FileDialog, 2, 0);
            this.tableLayoutPanel_InputOuputExcel.Controls.Add(this.pictureBox_Folder, 2, 1);
            this.tableLayoutPanel_InputOuputExcel.Controls.Add(this.tableLayoutPanel_Input, 0, 0);
            this.tableLayoutPanel_InputOuputExcel.Controls.Add(this.tableLayoutPanel_Ouput, 0, 1);
            this.tableLayoutPanel_InputOuputExcel.Controls.Add(this.tableLayoutPanel_textboxInput, 1, 0);
            this.tableLayoutPanel_InputOuputExcel.Controls.Add(this.tableLayoutPanel_TextBoxOuput, 1, 1);
            this.tableLayoutPanel_InputOuputExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_InputOuputExcel.Location = new System.Drawing.Point(4, 33);
            this.tableLayoutPanel_InputOuputExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_InputOuputExcel.Name = "tableLayoutPanel_InputOuputExcel";
            this.tableLayoutPanel_InputOuputExcel.RowCount = 2;
            this.tableLayoutPanel_InputOuputExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel_InputOuputExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.tableLayoutPanel_InputOuputExcel.Size = new System.Drawing.Size(1609, 109);
            this.tableLayoutPanel_InputOuputExcel.TabIndex = 0;
            // 
            // pictureBox_FileDialog
            // 
            this.pictureBox_FileDialog.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox_FileDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_FileDialog.Image = global::GENTOOL.Properties.Resources.file;
            this.pictureBox_FileDialog.Location = new System.Drawing.Point(1464, 5);
            this.pictureBox_FileDialog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_FileDialog.Name = "pictureBox_FileDialog";
            this.pictureBox_FileDialog.Size = new System.Drawing.Size(141, 43);
            this.pictureBox_FileDialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_FileDialog.TabIndex = 4;
            this.pictureBox_FileDialog.TabStop = false;
            this.pictureBox_FileDialog.Click += new System.EventHandler(this.pictureBox_FileDialog_Click);
            // 
            // pictureBox_Folder
            // 
            this.pictureBox_Folder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox_Folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Folder.Image = global::GENTOOL.Properties.Resources.folder;
            this.pictureBox_Folder.Location = new System.Drawing.Point(1464, 58);
            this.pictureBox_Folder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Folder.Name = "pictureBox_Folder";
            this.pictureBox_Folder.Size = new System.Drawing.Size(141, 46);
            this.pictureBox_Folder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Folder.TabIndex = 5;
            this.pictureBox_Folder.TabStop = false;
            this.pictureBox_Folder.Click += new System.EventHandler(this.pictureBox_Folder_Click);
            // 
            // tableLayoutPanel_Input
            // 
            this.tableLayoutPanel_Input.ColumnCount = 1;
            this.tableLayoutPanel_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Input.Controls.Add(this.label_Input, 0, 0);
            this.tableLayoutPanel_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Input.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Input.Name = "tableLayoutPanel_Input";
            this.tableLayoutPanel_Input.RowCount = 1;
            this.tableLayoutPanel_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Input.Size = new System.Drawing.Size(474, 43);
            this.tableLayoutPanel_Input.TabIndex = 6;
            // 
            // label_Input
            // 
            this.label_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Input.AutoSize = true;
            this.label_Input.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Input.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_Input.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Input.Location = new System.Drawing.Point(4, 0);
            this.label_Input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(466, 43);
            this.label_Input.TabIndex = 0;
            this.label_Input.Text = "INPUT PATH";
            this.label_Input.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel_Ouput
            // 
            this.tableLayoutPanel_Ouput.ColumnCount = 1;
            this.tableLayoutPanel_Ouput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Ouput.Controls.Add(this.label_Output, 0, 0);
            this.tableLayoutPanel_Ouput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Ouput.Location = new System.Drawing.Point(4, 58);
            this.tableLayoutPanel_Ouput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Ouput.Name = "tableLayoutPanel_Ouput";
            this.tableLayoutPanel_Ouput.RowCount = 1;
            this.tableLayoutPanel_Ouput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Ouput.Size = new System.Drawing.Size(474, 46);
            this.tableLayoutPanel_Ouput.TabIndex = 7;
            // 
            // label_Output
            // 
            this.label_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Output.AutoSize = true;
            this.label_Output.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Output.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_Output.Location = new System.Drawing.Point(4, 0);
            this.label_Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(466, 46);
            this.label_Output.TabIndex = 0;
            this.label_Output.Text = "OUPUT PATH";
            this.label_Output.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_Output.Click += new System.EventHandler(this.label_Output_Click);
            // 
            // tableLayoutPanel_textboxInput
            // 
            this.tableLayoutPanel_textboxInput.AutoSize = true;
            this.tableLayoutPanel_textboxInput.ColumnCount = 1;
            this.tableLayoutPanel_textboxInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_textboxInput.Controls.Add(this.textBox_Input, 0, 0);
            this.tableLayoutPanel_textboxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_textboxInput.Location = new System.Drawing.Point(486, 5);
            this.tableLayoutPanel_textboxInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_textboxInput.Name = "tableLayoutPanel_textboxInput";
            this.tableLayoutPanel_textboxInput.RowCount = 1;
            this.tableLayoutPanel_textboxInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_textboxInput.Size = new System.Drawing.Size(970, 43);
            this.tableLayoutPanel_textboxInput.TabIndex = 8;
            // 
            // textBox_Input
            // 
            this.textBox_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Input.Location = new System.Drawing.Point(4, 5);
            this.textBox_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(962, 35);
            this.textBox_Input.TabIndex = 0;
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            // 
            // tableLayoutPanel_TextBoxOuput
            // 
            this.tableLayoutPanel_TextBoxOuput.AutoSize = true;
            this.tableLayoutPanel_TextBoxOuput.ColumnCount = 1;
            this.tableLayoutPanel_TextBoxOuput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TextBoxOuput.Controls.Add(this.textBox_Output, 0, 0);
            this.tableLayoutPanel_TextBoxOuput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextBoxOuput.Location = new System.Drawing.Point(486, 58);
            this.tableLayoutPanel_TextBoxOuput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_TextBoxOuput.Name = "tableLayoutPanel_TextBoxOuput";
            this.tableLayoutPanel_TextBoxOuput.RowCount = 1;
            this.tableLayoutPanel_TextBoxOuput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TextBoxOuput.Size = new System.Drawing.Size(970, 46);
            this.tableLayoutPanel_TextBoxOuput.TabIndex = 9;
            // 
            // textBox_Output
            // 
            this.textBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Output.Location = new System.Drawing.Point(4, 5);
            this.textBox_Output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(962, 35);
            this.textBox_Output.TabIndex = 0;
            this.textBox_Output.TextChanged += new System.EventHandler(this.textBox_Output_TextChanged);
            // 
            // tableLayoutPanel_RangeTCAndInformation
            // 
            this.tableLayoutPanel_RangeTCAndInformation.ColumnCount = 2;
            this.tableLayoutPanel_RangeTCAndInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_RangeTCAndInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_RangeTCAndInformation.Controls.Add(this.groupBox_RangeTC, 0, 0);
            this.tableLayoutPanel_RangeTCAndInformation.Controls.Add(this.groupBox_Information, 1, 0);
            this.tableLayoutPanel_RangeTCAndInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_RangeTCAndInformation.Location = new System.Drawing.Point(4, 325);
            this.tableLayoutPanel_RangeTCAndInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_RangeTCAndInformation.Name = "tableLayoutPanel_RangeTCAndInformation";
            this.tableLayoutPanel_RangeTCAndInformation.RowCount = 1;
            this.tableLayoutPanel_RangeTCAndInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tableLayoutPanel_RangeTCAndInformation.Size = new System.Drawing.Size(1617, 242);
            this.tableLayoutPanel_RangeTCAndInformation.TabIndex = 2;
            // 
            // groupBox_RangeTC
            // 
            this.groupBox_RangeTC.Controls.Add(this.tableLayoutPanel_InputRangeTC);
            this.groupBox_RangeTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_RangeTC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_RangeTC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_RangeTC.Location = new System.Drawing.Point(4, 5);
            this.groupBox_RangeTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_RangeTC.Name = "groupBox_RangeTC";
            this.groupBox_RangeTC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_RangeTC.Size = new System.Drawing.Size(800, 273);
            this.groupBox_RangeTC.TabIndex = 0;
            this.groupBox_RangeTC.TabStop = false;
            this.groupBox_RangeTC.Text = "Range TC";
            // 
            // tableLayoutPanel_InputRangeTC
            // 
            this.tableLayoutPanel_InputRangeTC.ColumnCount = 4;
            this.tableLayoutPanel_InputRangeTC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel_InputRangeTC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputRangeTC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel_InputRangeTC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputRangeTC.Controls.Add(this.textBox_InputStartNumber, 1, 1);
            this.tableLayoutPanel_InputRangeTC.Controls.Add(this.textBox_InputFinishNumber, 3, 1);
            this.tableLayoutPanel_InputRangeTC.Controls.Add(this.label_TO, 2, 1);
            this.tableLayoutPanel_InputRangeTC.Controls.Add(this.label_FROM, 0, 1);
            this.tableLayoutPanel_InputRangeTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_InputRangeTC.Location = new System.Drawing.Point(4, 33);
            this.tableLayoutPanel_InputRangeTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_InputRangeTC.Name = "tableLayoutPanel_InputRangeTC";
            this.tableLayoutPanel_InputRangeTC.RowCount = 3;
            this.tableLayoutPanel_InputRangeTC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputRangeTC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel_InputRangeTC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InputRangeTC.Size = new System.Drawing.Size(792, 235);
            this.tableLayoutPanel_InputRangeTC.TabIndex = 0;
            // 
            // textBox_InputStartNumber
            // 
            this.textBox_InputStartNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_InputStartNumber.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputStartNumber.Location = new System.Drawing.Point(115, 98);
            this.textBox_InputStartNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_InputStartNumber.Name = "textBox_InputStartNumber";
            this.textBox_InputStartNumber.Size = new System.Drawing.Size(274, 37);
            this.textBox_InputStartNumber.TabIndex = 2;
            this.textBox_InputStartNumber.TextChanged += new System.EventHandler(this.textBox_InputStartNumber_TextChanged);
            // 
            // textBox_InputFinishNumber
            // 
            this.textBox_InputFinishNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_InputFinishNumber.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InputFinishNumber.Location = new System.Drawing.Point(513, 98);
            this.textBox_InputFinishNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_InputFinishNumber.Name = "textBox_InputFinishNumber";
            this.textBox_InputFinishNumber.Size = new System.Drawing.Size(275, 37);
            this.textBox_InputFinishNumber.TabIndex = 3;
            this.textBox_InputFinishNumber.TextChanged += new System.EventHandler(this.textBox_InputFinishNumber_TextChanged);
            // 
            // label_TO
            // 
            this.label_TO.AutoSize = true;
            this.label_TO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_TO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TO.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_TO.Location = new System.Drawing.Point(397, 93);
            this.label_TO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TO.Name = "label_TO";
            this.label_TO.Size = new System.Drawing.Size(108, 48);
            this.label_TO.TabIndex = 1;
            this.label_TO.Text = "To";
            this.label_TO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FROM
            // 
            this.label_FROM.AutoSize = true;
            this.label_FROM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_FROM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FROM.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_FROM.Location = new System.Drawing.Point(4, 93);
            this.label_FROM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FROM.Name = "label_FROM";
            this.label_FROM.Size = new System.Drawing.Size(103, 48);
            this.label_FROM.TabIndex = 0;
            this.label_FROM.Text = "From";
            this.label_FROM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Information
            // 
            this.groupBox_Information.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox_Information.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Information.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Information.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Information.Location = new System.Drawing.Point(812, 5);
            this.groupBox_Information.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Information.Name = "groupBox_Information";
            this.groupBox_Information.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Information.Size = new System.Drawing.Size(801, 273);
            this.groupBox_Information.TabIndex = 1;
            this.groupBox_Information.TabStop = false;
            this.groupBox_Information.Text = "Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.42105F));
            this.tableLayoutPanel1.Controls.Add(this.label_TestModule, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_generateoption, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_TestModule, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_ChoiceOption, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 33);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 235);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_TestModule
            // 
            this.label_TestModule.AutoSize = true;
            this.label_TestModule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_TestModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TestModule.Location = new System.Drawing.Point(4, 55);
            this.label_TestModule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TestModule.Name = "label_TestModule";
            this.label_TestModule.Size = new System.Drawing.Size(242, 62);
            this.label_TestModule.TabIndex = 0;
            this.label_TestModule.Text = "Test Module";
            // 
            // label_generateoption
            // 
            this.label_generateoption.AutoSize = true;
            this.label_generateoption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_generateoption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_generateoption.Location = new System.Drawing.Point(4, 117);
            this.label_generateoption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_generateoption.Name = "label_generateoption";
            this.label_generateoption.Size = new System.Drawing.Size(242, 62);
            this.label_generateoption.TabIndex = 1;
            this.label_generateoption.Text = "Generate Option";
            // 
            // textBox_TestModule
            // 
            this.textBox_TestModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TestModule.Location = new System.Drawing.Point(254, 60);
            this.textBox_TestModule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TestModule.Name = "textBox_TestModule";
            this.textBox_TestModule.Size = new System.Drawing.Size(535, 35);
            this.textBox_TestModule.TabIndex = 2;
            // 
            // comboBox_ChoiceOption
            // 
            this.comboBox_ChoiceOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_ChoiceOption.FormattingEnabled = true;
            this.comboBox_ChoiceOption.Items.AddRange(new object[] {
            "Single File Module",
            "Mutil File Module"});
            this.comboBox_ChoiceOption.Location = new System.Drawing.Point(253, 120);
            this.comboBox_ChoiceOption.Name = "comboBox_ChoiceOption";
            this.comboBox_ChoiceOption.Size = new System.Drawing.Size(537, 37);
            this.comboBox_ChoiceOption.TabIndex = 3;
            // 
            // tableLayoutPanel_ProcessBarAndRun
            // 
            this.tableLayoutPanel_ProcessBarAndRun.ColumnCount = 2;
            this.tableLayoutPanel_ProcessBarAndRun.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.36723F));
            this.tableLayoutPanel_ProcessBarAndRun.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.632772F));
            this.tableLayoutPanel_ProcessBarAndRun.Controls.Add(this.button_RUN, 1, 0);
            this.tableLayoutPanel_ProcessBarAndRun.Controls.Add(this.progressBar_Gentool, 0, 0);
            this.tableLayoutPanel_ProcessBarAndRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProcessBarAndRun.Location = new System.Drawing.Point(4, 658);
            this.tableLayoutPanel_ProcessBarAndRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_ProcessBarAndRun.Name = "tableLayoutPanel_ProcessBarAndRun";
            this.tableLayoutPanel_ProcessBarAndRun.RowCount = 1;
            this.tableLayoutPanel_ProcessBarAndRun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_ProcessBarAndRun.Size = new System.Drawing.Size(1617, 72);
            this.tableLayoutPanel_ProcessBarAndRun.TabIndex = 3;
            // 
            // button_RUN
            // 
            this.button_RUN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_RUN.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RUN.Location = new System.Drawing.Point(1529, 5);
            this.button_RUN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_RUN.Name = "button_RUN";
            this.button_RUN.Size = new System.Drawing.Size(84, 62);
            this.button_RUN.TabIndex = 0;
            this.button_RUN.Text = "RUN";
            this.button_RUN.UseVisualStyleBackColor = true;
            this.button_RUN.Click += new System.EventHandler(this.button_RUN_Click);
            // 
            // progressBar_Gentool
            // 
            this.progressBar_Gentool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_Gentool.Location = new System.Drawing.Point(4, 5);
            this.progressBar_Gentool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar_Gentool.Name = "progressBar_Gentool";
            this.progressBar_Gentool.Size = new System.Drawing.Size(1517, 62);
            this.progressBar_Gentool.TabIndex = 1;
            // 
            // tableLayoutPanel_Footer
            // 
            this.tableLayoutPanel_Footer.ColumnCount = 3;
            this.tableLayoutPanel_Footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel_Footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel_Footer.Controls.Add(this.label_version, 0, 0);
            this.tableLayoutPanel_Footer.Controls.Add(this.pictureBox_firm, 2, 0);
            this.tableLayoutPanel_Footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Footer.Location = new System.Drawing.Point(4, 740);
            this.tableLayoutPanel_Footer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel_Footer.Name = "tableLayoutPanel_Footer";
            this.tableLayoutPanel_Footer.RowCount = 1;
            this.tableLayoutPanel_Footer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Footer.Size = new System.Drawing.Size(1617, 132);
            this.tableLayoutPanel_Footer.TabIndex = 4;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.Location = new System.Drawing.Point(4, 0);
            this.label_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(182, 132);
            this.label_version.TabIndex = 0;
            this.label_version.Text = "R3.1.0";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_version.Visible = false;
            // 
            // pictureBox_firm
            // 
            this.pictureBox_firm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_firm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_firm.Location = new System.Drawing.Point(1384, 5);
            this.pictureBox_firm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_firm.Name = "pictureBox_firm";
            this.pictureBox_firm.Size = new System.Drawing.Size(229, 122);
            this.pictureBox_firm.TabIndex = 1;
            this.pictureBox_firm.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1633, 887);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 920);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainView";
            this.Text = "Testcase Format Converter";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel_Overall.ResumeLayout(false);
            this.groupBox_Option.ResumeLayout(false);
            this.tableLayoutPanel_ChoiceOption.ResumeLayout(false);
            this.tableLayoutPanel_ChoiceOption.PerformLayout();
            this.groupBox_ExcelConvertXMLandXMLConvertExcel.ResumeLayout(false);
            this.tableLayoutPanel_InputOuputExcel.ResumeLayout(false);
            this.tableLayoutPanel_InputOuputExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FileDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Folder)).EndInit();
            this.tableLayoutPanel_Input.ResumeLayout(false);
            this.tableLayoutPanel_Input.PerformLayout();
            this.tableLayoutPanel_Ouput.ResumeLayout(false);
            this.tableLayoutPanel_Ouput.PerformLayout();
            this.tableLayoutPanel_textboxInput.ResumeLayout(false);
            this.tableLayoutPanel_textboxInput.PerformLayout();
            this.tableLayoutPanel_TextBoxOuput.ResumeLayout(false);
            this.tableLayoutPanel_TextBoxOuput.PerformLayout();
            this.tableLayoutPanel_RangeTCAndInformation.ResumeLayout(false);
            this.groupBox_RangeTC.ResumeLayout(false);
            this.tableLayoutPanel_InputRangeTC.ResumeLayout(false);
            this.tableLayoutPanel_InputRangeTC.PerformLayout();
            this.groupBox_Information.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel_ProcessBarAndRun.ResumeLayout(false);
            this.tableLayoutPanel_Footer.ResumeLayout(false);
            this.tableLayoutPanel_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_firm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Overall;
        private System.Windows.Forms.GroupBox groupBox_Option;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ChoiceOption;
        private System.Windows.Forms.RadioButton radioButton_XMLConvertExcel;
        private System.Windows.Forms.RadioButton radioButton_ExcelConvertXML;
        private System.Windows.Forms.GroupBox groupBox_ExcelConvertXMLandXMLConvertExcel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_InputOuputExcel;
        private System.Windows.Forms.PictureBox pictureBox_FileDialog;
        private System.Windows.Forms.PictureBox pictureBox_Folder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Input;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Ouput;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_textboxInput;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextBoxOuput;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_RangeTCAndInformation;
        private System.Windows.Forms.GroupBox groupBox_RangeTC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_InputRangeTC;
        private System.Windows.Forms.TextBox textBox_InputStartNumber;
        private System.Windows.Forms.TextBox textBox_InputFinishNumber;
        private System.Windows.Forms.Label label_TO;
        private System.Windows.Forms.Label label_FROM;
        private System.Windows.Forms.GroupBox groupBox_Information;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProcessBarAndRun;
        private System.Windows.Forms.Button button_RUN;
        private System.Windows.Forms.ProgressBar progressBar_Gentool;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Footer;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_TestModule;
        private System.Windows.Forms.Label label_generateoption;
        private System.Windows.Forms.TextBox textBox_TestModule;
        private System.Windows.Forms.PictureBox pictureBox_firm;

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox comboBox_ChoiceOption;
    }
}