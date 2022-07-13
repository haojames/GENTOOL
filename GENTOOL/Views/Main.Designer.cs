namespace GENTOOL.Views
{
    partial class Main
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_InputRangeTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Option = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label_GenerateOption = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_ProMeasureType = new System.Windows.Forms.Label();
            this.textBox_TestModule = new System.Windows.Forms.TextBox();
            this.label_TestModule = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_RUN_Excel_Convert_XML = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_RUNXMLConvertExcel = new System.Windows.Forms.Button();
            this.groupBox_XmlConvertExcel = new System.Windows.Forms.GroupBox();
            this.textBox_OutputExcel = new System.Windows.Forms.TextBox();
            this.textBox_InputXML = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_InputXML = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_Option.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox_XmlConvertExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1523, 740);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox_Option);
            this.tabPage1.Controls.Add(this.button_RUN_Excel_Convert_XML);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1515, 707);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Excel convert XML";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_InputRangeTC);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(6, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 137);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Range Testcase";
            // 
            // textBox_InputRangeTC
            // 
            this.textBox_InputRangeTC.Location = new System.Drawing.Point(139, 41);
            this.textBox_InputRangeTC.Name = "textBox_InputRangeTC";
            this.textBox_InputRangeTC.Size = new System.Drawing.Size(71, 26);
            this.textBox_InputRangeTC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Range";
            // 
            // groupBox_Option
            // 
            this.groupBox_Option.Controls.Add(this.comboBox2);
            this.groupBox_Option.Controls.Add(this.label_GenerateOption);
            this.groupBox_Option.Controls.Add(this.comboBox1);
            this.groupBox_Option.Controls.Add(this.label_ProMeasureType);
            this.groupBox_Option.Controls.Add(this.textBox_TestModule);
            this.groupBox_Option.Controls.Add(this.label_TestModule);
            this.groupBox_Option.Controls.Add(this.label3);
            this.groupBox_Option.Location = new System.Drawing.Point(599, 221);
            this.groupBox_Option.Name = "groupBox_Option";
            this.groupBox_Option.Size = new System.Drawing.Size(449, 233);
            this.groupBox_Option.TabIndex = 2;
            this.groupBox_Option.TabStop = false;
            this.groupBox_Option.Text = "Option";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Single cell",
            "Mutil cell"});
            this.comboBox2.Location = new System.Drawing.Point(213, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(456, 28);
            this.comboBox2.TabIndex = 6;
            // 
            // label_GenerateOption
            // 
            this.label_GenerateOption.Location = new System.Drawing.Point(11, 138);
            this.label_GenerateOption.Name = "label_GenerateOption";
            this.label_GenerateOption.Size = new System.Drawing.Size(169, 23);
            this.label_GenerateOption.TabIndex = 5;
            this.label_GenerateOption.Text = "Generate Option";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.comboBox1.Location = new System.Drawing.Point(213, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(456, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // label_ProMeasureType
            // 
            this.label_ProMeasureType.Location = new System.Drawing.Point(7, 84);
            this.label_ProMeasureType.Name = "label_ProMeasureType";
            this.label_ProMeasureType.Size = new System.Drawing.Size(173, 23);
            this.label_ProMeasureType.TabIndex = 3;
            // 
            // textBox_TestModule
            // 
            this.textBox_TestModule.Location = new System.Drawing.Point(213, 25);
            this.textBox_TestModule.Name = "textBox_TestModule";
            this.textBox_TestModule.Size = new System.Drawing.Size(456, 26);
            this.textBox_TestModule.TabIndex = 2;
            // 
            // label_TestModule
            // 
            this.label_TestModule.Location = new System.Drawing.Point(7, 27);
            this.label_TestModule.Name = "label_TestModule";
            this.label_TestModule.Size = new System.Drawing.Size(130, 40);
            this.label_TestModule.TabIndex = 1;
            this.label_TestModule.Text = "Test Module";
            this.label_TestModule.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // button_RUN_Excel_Convert_XML
            // 
            this.button_RUN_Excel_Convert_XML.Location = new System.Drawing.Point(1324, 579);
            this.button_RUN_Excel_Convert_XML.Name = "button_RUN_Excel_Convert_XML";
            this.button_RUN_Excel_Convert_XML.Size = new System.Drawing.Size(159, 80);
            this.button_RUN_Excel_Convert_XML.TabIndex = 1;
            this.button_RUN_Excel_Convert_XML.Text = "RUN";
            this.button_RUN_Excel_Convert_XML.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1477, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group Excel covert XML";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.274181F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.72582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1471, 131);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "output";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::GENTOOL.Properties.Resources.file;
            this.pictureBox2.Location = new System.Drawing.Point(1254, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::GENTOOL.Properties.Resources.folder;
            this.pictureBox3.Location = new System.Drawing.Point(1254, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(94, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1154, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(94, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1154, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "input";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_RUNXMLConvertExcel);
            this.tabPage2.Controls.Add(this.groupBox_XmlConvertExcel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1515, 707);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XML convert Excel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_RUNXMLConvertExcel
            // 
            this.button_RUNXMLConvertExcel.Location = new System.Drawing.Point(1275, 591);
            this.button_RUNXMLConvertExcel.Name = "button_RUNXMLConvertExcel";
            this.button_RUNXMLConvertExcel.Size = new System.Drawing.Size(189, 86);
            this.button_RUNXMLConvertExcel.TabIndex = 1;
            this.button_RUNXMLConvertExcel.Text = "RUN";
            this.button_RUNXMLConvertExcel.UseVisualStyleBackColor = true;
            // 
            // groupBox_XmlConvertExcel
            // 
            this.groupBox_XmlConvertExcel.Controls.Add(this.textBox_OutputExcel);
            this.groupBox_XmlConvertExcel.Controls.Add(this.textBox_InputXML);
            this.groupBox_XmlConvertExcel.Controls.Add(this.label2);
            this.groupBox_XmlConvertExcel.Controls.Add(this.label_InputXML);
            this.groupBox_XmlConvertExcel.Location = new System.Drawing.Point(6, 6);
            this.groupBox_XmlConvertExcel.Name = "groupBox_XmlConvertExcel";
            this.groupBox_XmlConvertExcel.Size = new System.Drawing.Size(1503, 169);
            this.groupBox_XmlConvertExcel.TabIndex = 0;
            this.groupBox_XmlConvertExcel.TabStop = false;
            this.groupBox_XmlConvertExcel.Text = "Group XML convert Excel";
            // 
            // textBox_OutputExcel
            // 
            this.textBox_OutputExcel.Location = new System.Drawing.Point(218, 99);
            this.textBox_OutputExcel.Name = "textBox_OutputExcel";
            this.textBox_OutputExcel.Size = new System.Drawing.Size(1240, 26);
            this.textBox_OutputExcel.TabIndex = 3;
            // 
            // textBox_InputXML
            // 
            this.textBox_InputXML.Location = new System.Drawing.Point(218, 37);
            this.textBox_InputXML.Name = "textBox_InputXML";
            this.textBox_InputXML.Size = new System.Drawing.Size(1240, 26);
            this.textBox_InputXML.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "OUTPUT PATH";
            // 
            // label_InputXML
            // 
            this.label_InputXML.Location = new System.Drawing.Point(17, 37);
            this.label_InputXML.Name = "label_InputXML";
            this.label_InputXML.Size = new System.Drawing.Size(166, 23);
            this.label_InputXML.TabIndex = 0;
            this.label_InputXML.Text = "INPUT PATH";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1515, 707);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DOOR Upload";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 831);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "GEN TOOL 3.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_Option.ResumeLayout(false);
            this.groupBox_Option.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox_XmlConvertExcel.ResumeLayout(false);
            this.groupBox_XmlConvertExcel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox_Option;
        private System.Windows.Forms.Button button_RUN_Excel_Convert_XML;
        private System.Windows.Forms.GroupBox groupBox_XmlConvertExcel;
        private System.Windows.Forms.Button button_RUNXMLConvertExcel;
        private System.Windows.Forms.TextBox textBox_OutputExcel;
        private System.Windows.Forms.TextBox textBox_InputXML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_InputXML;
        private System.Windows.Forms.TextBox textBox_InputRangeTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_ProMeasureType;
        private System.Windows.Forms.TextBox textBox_TestModule;
        private System.Windows.Forms.Label label_TestModule;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label_GenerateOption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}