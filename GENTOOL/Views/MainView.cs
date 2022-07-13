using GENTOOL.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GENTOOL.Utils;
using GENTOOL.Models;
namespace GENTOOL.Views
{
    public partial class MainView : Form, IMainView
    {
        public string InputPath { get; set; }
        public string OutputPath { get; set; }
        public string FromRow { get; set; }
        public string ToRow { get; set; }
        public int RangeId { get; set; }
        public string Modude { get; set; }
        public string GenerationOption { get; set; }
        public string OutputFolder { get; set; }
        /*
         * 1.StartID
         * 2.EndID
         */
        MainController _controller;

        public MainView()
        {
            InitializeComponent();
        }

        public void UpdateInputPath()
        {
            textBox_Input.Text = InputPath;
        }
        public void UpdateOutputPath()
        {
            textBox_Output.Text = OutputPath;
        }
        private void pictureBox_FileDialog_Click(object sender, EventArgs e)
        {
            if (radioButton_ExcelConvertXML.Checked == true && radioButton_ExcelConvertXML.Text == "Excel Convert XML")
            {
                _controller.GetInputPath(ConvertType.ExcelToXML);
            }
            else if (radioButton_XMLConvertExcel.Checked == true && radioButton_XMLConvertExcel.Text == "XML Convert Excel")
            {
                _controller.GetInputPath(ConvertType.XMLToExcel);
            }
            else
            {
                _controller.ShowConfirmAlert("Warning", "Please choice option need convert");
            }
        }

        private void radioButton_ExcelConvertXML_CheckedChanged(object sender, EventArgs e)
        {
            _controller.ShowAlert("OPTION", "Convert excel to xml");
        }

        private void radioButton_XMLConvertExcel_CheckedChanged(object sender, EventArgs e)
        {
            _controller.ShowAlert("OPTION", "Convert xml to excel");
        }

        private void pictureBox_Folder_Click(object sender, EventArgs e)
        {
            _controller.GetOutputPath();
        }

        public void SetController(MainController controller)
        {
            _controller = controller;
        }

        public void ShowLog()
        {
            throw new NotImplementedException();
        }

        private void button_RUN_Click(object sender, EventArgs e)
        {
            FromRow = textBox_InputStartNumber.Text;
            ToRow = textBox_InputFinishNumber.Text;
            Modude = textBox_TestModule.Text;
            GenerationOption = comboBox_ChoiceOption.Text;
            OutputFolder = textBox_Output.Text;
            _controller.GetDataSheet();
        }

        private void textBox_InputFinishNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Output_Click(object sender, EventArgs e)
        {

        }

        private void textBox_InputStartNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_Output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
