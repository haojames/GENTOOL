using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using GENTOOL.Controllers;
//using GENTOOL.Models;
namespace GENTOOL.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }
        private void radioButton_ExcelConvertXML_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ExcelConvertXML.Checked == true && radioButton_ExcelConvertXML.Text == "Convert excel to xml")
            {
                MessageBox.Show("Convert excel to xml", "OPTION");
            }
        }

        private void radioButton_XMLConvertExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_XMLConvertExcel.Checked == true && radioButton_XMLConvertExcel.Text == "Convert xml to excel")
            {
                MessageBox.Show("Convert xml to excel", "OPTION");
            }
        }

        private void pictureBox_FileDialog_Click(object sender, EventArgs e)
        {
            if (radioButton_ExcelConvertXML.Checked == true && radioButton_ExcelConvertXML.Text == "Convert excel to xml")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = @"D:\";
                openFileDialog.Title = "Browse Text Files";
                openFileDialog.CheckPathExists = true;
                openFileDialog.CheckFileExists = true;
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_Input.Text = openFileDialog.FileName;
                }
            }
            else if (radioButton_XMLConvertExcel.Checked == true && radioButton_XMLConvertExcel.Text == "Convert xml to excel")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = @"D:\";
                openFileDialog.Title = "Browse Text Files";
                openFileDialog.CheckPathExists = true;
                openFileDialog.CheckFileExists = true;
                openFileDialog.Filter = "XML Files| *.xml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_Input.Text = openFileDialog.FileName;
                }
            }
            else
            {
                MessageBox.Show("Please choice option need convert", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_Output.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
