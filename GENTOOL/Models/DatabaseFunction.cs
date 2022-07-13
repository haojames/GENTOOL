using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GENTOOL.Models.ExcelConvertXML;
//using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;
using DataTable = System.Data.DataTable;
using System.Reflection;
using GENTOOL.Controllers;
using System.Text.RegularExpressions;
namespace GENTOOL.Models
{
    public class DatabaseFunction
    {
        //public string _inputpath;
        

        public string Input { get; set; }
        string file = "C:\\Users\\trana\\OneDrive\\Documents\\Plan\\Database.xlsx";
        List<Valuedatabase> valuedatabases_list= new List<Valuedatabase>();
        public DatabaseFunction()
        {
        }
        public DatabaseFunction(string input)
        {
            this.Input = input;
        }
        public List<Valuedatabase> Getdatabase<T>(string inputpath)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            FileInfo existingFile = new FileInfo(inputpath);
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int colCount = worksheet.Dimension.End.Column;
                int rowCount = worksheet.Dimension.End.Row;
                try
                {
                    for (int rowindex = 2; rowindex <= rowCount; rowindex++)
                    {
                        Valuedatabase rowvaluedatabase  = new Valuedatabase();
                        for (int colindex = 1; colindex <= colCount; colindex++)
                        {
                            if(worksheet.Cells[1, colindex].Value.ToString() == "NoArgument")
                            {
                                rowvaluedatabase._Noargument = worksheet.Cells[rowindex, colindex].Value?.ToString();
                                //t.Add(worksheet.Cells[rowindex, colindex].Value?.ToString());
                            }
                            if (worksheet.Cells[1, colindex].Value.ToString() == "OneArgument")
                            {
                                rowvaluedatabase._Oneargument = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }
                            if (worksheet.Cells[1, colindex].Value.ToString() == "TwoArgument")
                            {
                                rowvaluedatabase._Twoargument = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }
                            if (worksheet.Cells[1, colindex].Value.ToString() == "ThreeArgument")
                            {
                                rowvaluedatabase._Threeargument = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }
                        }
                        valuedatabases_list.Add(rowvaluedatabase);
                    }
                }
                catch
                {
                }
            }
            return valuedatabases_list;
        }
        #region
        List<string> stringdb_list = new List<string>();
        #endregion
        public List<string> ParseList()
        {
            
            for (int i = 0;i<valuedatabases_list.Count();i++)
            {
                stringdb_list.Add(valuedatabases_list[i]._Noargument?.ToString());
                stringdb_list.Add(valuedatabases_list[i]._Oneargument?.ToString());
                stringdb_list.Add(valuedatabases_list[i]._Twoargument?.ToString());
                stringdb_list.Add(valuedatabases_list[i]._Threeargument?.ToString());
            }
            stringdb_list.RemoveAll(s => string.IsNullOrEmpty(s));
            return stringdb_list;
        }
    }
}
