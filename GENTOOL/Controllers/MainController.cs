using GENTOOL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GENTOOL.Utils;
using System.Windows.Forms;
using GENTOOL.Controllers;
using static GENTOOL.Models.ExcelConvertXML;
using GENTOOL.Views;

namespace GENTOOL.Controllers
{
    public interface IMainView
    {
        void SetController(MainController controller);
        void UpdateInputPath();
        void UpdateOutputPath();

        //void UpdateModule();

        string InputPath { get; set; }
        string OutputPath { get; set; }
        string FromRow { get; set; }
        string ToRow { get; set; }
        string Modude { get; set; }
        string GenerationOption { get; set; }
        string OutputFolder { get; set; }
    }
    public class MainController: BaseController
    {
        IMainView _mainView;
        ExcelConvertXML _excalConvertXML;

        public MainController(IMainView mainView)
        {
            _mainView = mainView;
            mainView.SetController(this);
        }

        public MainController()
        {
        }

        public void GetInputPath(ConvertType type)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\";
            openFileDialog.Title = "Browse Text Files";
            openFileDialog.CheckPathExists = openFileDialog.CheckFileExists = true;
            openFileDialog.Filter = type == ConvertType.ExcelToXML ? "Excel Files|*.xls;*.xlsx" : "XML Files| *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                _mainView.InputPath = openFileDialog.FileName;
            else
                _mainView.InputPath = String.Empty;
            _mainView.UpdateInputPath();
        }

        public void GetOutputPath()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                _mainView.OutputPath =folderBrowserDialog.SelectedPath;
            _mainView.UpdateOutputPath();
        }
        public void GetDatabase()
        {
            DatabaseFunction databaseFunction = new DatabaseFunction();
            string file = "C:\\Users\\trana\\OneDrive\\Documents\\Plan\\Database.xlsx";
            databaseFunction.Getdatabase<Valuedatabase>(file);
            databaseFunction.ParseList();
        }
        public void GetDataSheet()
        {
            GetDatabase();
            GetDataFromExcelTestCase getDataFromExcelTestCase = new GetDataFromExcelTestCase();
            getDataFromExcelTestCase.Getdata<ExcelConvertXML>(_mainView.InputPath);
            getDataFromExcelTestCase.ConvertFunctionInRowToXML(_mainView.OutputFolder,_mainView.FromRow,_mainView.ToRow,_mainView.Modude,_mainView.GenerationOption);
            //getDataFromExcelTestCase.DatabaseFunction();
            //getDataFromExcelTestCase.SaveFile(_mainView.OutputFolder);
        }  
    }
}