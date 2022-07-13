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
using System.Xml;
using System.Xml.Linq;
using Dnp.IO;
using System.Xml.XPath;

namespace GENTOOL.Models
{
    public class GetDataFromExcelTestCase : DatabaseFunction
    {
        #region function of coresi and dbc
        //string RequestResponseReg = "RequestResponse\\((.*)[ ]*,[ ]*(.*)[ ]*,[ ]*(.*)\\)";
        string Checking_Configuration_Req = "Checking_Configuration\\((.*)[ ]*,[ ]*(.*)[ ]*,[ ]*(.*)[ ]*,[ ]*(.*)\\)";    //SendDiagFrame(messageID,DLC,frame,deltaT)
        //# tatecheck([message], [signal], [channel], [node], [value])
        //# e.g. statecheck(Camera_Display_Status, HhBmCntSta, E_can, CSM, 0)
        string statecheck_Reg = "statecheck[ ]*\\([ ]*([^ ]*?)[ ]*,[ ]*([^ ]*?)[ ]*,[ ]*([^ ]*?)[ ]*,[ ]*([^ ]*?)[ ]*,[ ]*([^ ]*?)[ ]*\\)";
        string AvoidSignalValue_Req = "(AvoidSignalValue)\\s*\\(\\s*(.+)\\)";
        //# WaitForSignalValue_Req = r'(WaitForSignalValue)\s?\(\s?(.+)\)'
        string WaitForSignalValue_Req = "(WaitForSignalValue)\\s*\\(\\s*([\\w\\s,]+)\\)";
        string DeactivateFunction_Req = "(DeactivateFunction)\\s*\\(\\s*(.+)\\)";
        string ActivateFunction_Req = "(ActivateFunction)\\s*\\(\\s*(.+)\\)";
        string TesterConfirm_Req = "(TesterConfirm)\\s*\\(\\s*(.+)\\)";
        string TimeNowStart_Req = "TimeNowStart";
        string TimeNowEnd_Req = "TimeNowEnd[ ]?\\([ ]?(.+), [ ]?(.+)\\)";  // min time, max time
        string CheckSignalValueIsPermanentStart_Req = "(CheckSignalValueIsPermanentStart)\\s*\\(\\s*(.+)\\)";
        string CheckSignalValueIsPermanentStop_Req = "(CheckSignalValueIsPermanentStop)\\s*\\(\\s*(.+)\\)";
        string startVideo_Req = "(startVideo)\\(\\s*(.+)\\)";
        string stopVideo_Req = "(stopVideo)\\s*\\(\\s*(.*)\\)";
        string WaitForSignalValueOutsideRange_Req = "(WaitForSignalValueOutsideRange)\\s*\\(\\s*(.+)\\)";
        string CheckSignalValueIsNotTaken_START_Req = "(CheckSignalValueIsNotTaken_START)\\s*\\(\\s*(.+)\\)";
        string CheckSignalValueIsNotTaken_STOP_Req = "(CheckSignalValueIsNotTaken_STOP)\\s*\\(\\s*(.+)\\)";
        string StartLoggingCANtrace_Req = "(StartLoggingCANtrace)\\s*\\(\\s*(.+)\\)";
        string StopLoggingCANtrace_Req = "(StopLoggingCANtrace)\\s*\\(\\s*(.+)\\)";
        string SendMsg_Req = "(SendMsg)\\s*\\(\\s*(.+)\\)";
        #endregion
        public string _inputpath;
        public string _outputpath;
        #region -List-
        int i = 0;
        List<ExcelConvertXML> list = new List<ExcelConvertXML>();
        #endregion

        Function function = new Function();

        #region List follow column need to gen
        List<string> _listdata_teststep = new List<string>();
        List<string> _listdata_testreponse = new List<string>();
        List<string> _listdata_testkeywor = new List<string>();
        List<string> _listdata_objectype = new List<string>();

        //Database
        List<string> databasefunction = new List<string>();
        #endregion

        public string Input
        {
            get { return _inputpath; }
            set { _inputpath = value; }
        }
        public string Output
        {
            get { return _outputpath; }
            set { _outputpath = value; }
        }

        //public object excelConvertXMLs { get; private set; }

        public GetDataFromExcelTestCase()
        {
            List<ExcelConvertXML> list = new List<ExcelConvertXML>();
        }
        public GetDataFromExcelTestCase(string input)
        {
            Input = input;
        }
        #region --- read data from sheet ---
        public List<ExcelConvertXML> Getdata<T>(string inputpath)
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
                        ExcelConvertXML rowdataindex = new ExcelConvertXML();
                        for (int colindex = 1; colindex <= colCount; colindex++)
                        {
                            if (worksheet.Cells[1, colindex].Value.ToString() == "LabT_")
                            {
                                rowdataindex._labT = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }

                            if (worksheet.Cells[1, colindex].Value.ToString() == "ID")
                            {
                                rowdataindex._TC_ID = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }

                            if (worksheet.Cells[1, colindex].Value.ToString() == "Test Description")
                            {
                                rowdataindex._Test_description = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }
                            if (worksheet.Cells[1, colindex].Value.ToString() == "TestSteps")
                            {
                                rowdataindex._Test_step = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }
                            if (worksheet.Cells[1, colindex].Value.ToString() == "Project")
                            {
                                rowdataindex._Project = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }
                            if (worksheet.Cells[1, colindex].Value.ToString() == "Test Response")
                            {
                                rowdataindex._Test_response = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }
                            if (worksheet.Cells[1, colindex].Value.ToString() == "Teststep keywords")
                            {
                                rowdataindex._Teststep_key = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }
                            if (worksheet.Cells[1, colindex].Value.ToString() == "TestStatus")
                            {
                                rowdataindex._Test_status = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }
                            if (worksheet.Cells[1, colindex].Value.ToString() == "ObjectType")
                            {
                                rowdataindex._Object_type = worksheet.Cells[rowindex, colindex].Value?.ToString();
                            }
                        }
                        list.Add(rowdataindex);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return list;
            }
        }
        #endregion
        public void ExportXML()
        {
            var list_teststep = ParseCellToArray(list[14]._Test_step);
            var list_testreponse = ParseCellToArray(list[14]._Test_response);
            var list_testkeywor = ParseCellToArray(list[14]._Teststep_key);
            if (list[14]._Test_status == "implemented" && list[14]._Object_type == "Automated Testcase")
            {
                Console.WriteLine("OK");
                int a = list_testkeywor.Count();
                int b = list_testreponse.Count();
                int c = list_teststep.Count();
                try
                {
                    if (a == b && b == c && c == a)
                    {
                        for (int i = 0; i < a; i++)
                        {
                            Console.WriteLine(list_testkeywor[i].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        #region Parse cell to array
        private string[] ParseCellToArray(string input)
        {
            string[] sperator = { "\r\n", "\n" };
            return input.Split(sperator, 10000, StringSplitOptions.RemoveEmptyEntries);
        }
        #endregion
        public List<string> DatabaseFunction()
        {
            DatabaseFunction databaseFunction = new DatabaseFunction();
            databaseFunction.Getdatabase<Valuedatabase>("C:\\Users\\trana\\OneDrive\\Documents\\Plan\\Database.xlsx");
            //databaseFunction.ParseList();
            databasefunction = databaseFunction.ParseList();
            return databasefunction;
        }
        public string RemoveCharacter(string input)
        {
            return input.Substring(input.IndexOf(") ") + 2);
        }


        #region Get Teststep column
        public List<string> Getdatafromteststep(int index)
        {
            //int index = int.Parse(startID);
            var list_teststep = ParseCellToArray(list[index]._Test_step);
            for (int j = 0; j < list_teststep.Count(); j++)
            {
                //System.Diagnostics.Debug.Write(list_teststep[j].ToString());
                //Console.WriteLine();
                var data_teststep = RemoveCharacter(list_teststep[j].ToString());
                _listdata_teststep.Add(data_teststep);
            }
            return _listdata_teststep;
        }
        #endregion
        #region Get testreponse column
        public List<string> Getdatafromtestreponse(int index)
        {
            //int index = int.Parse(startID);
            var list_response = ParseCellToArray(list[index]._Test_response);
            for (int j = 0; j < list_response.Count(); j++)
            {
                var data_response = RemoveCharacter(list_response[j].ToString());
                _listdata_testreponse.Add(data_response);
            }
            return _listdata_testreponse;
        }
        #endregion
        #region Get Testkeyword
        public List<string> Getdatafromteststepkeywor(int index)
        {
            //int index = int.Parse(startID);
            var list_teststepkeyword = ParseCellToArray(list[index]._Teststep_key);
            for (int j = 0; j < list_teststepkeyword.Count(); j++)
            {
                var data_teststepkeyword = RemoveCharacter(list_teststepkeyword[j].ToString());
                _listdata_testkeywor.Add(data_teststepkeyword);
            }
            return _listdata_testkeywor;
        }
        #endregion
        public string DeleteRegex(string input)
        {
            return Regex.Replace(input, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }
        public void ConvertFunctionInRowToXML(string FolderPath, string startID, string endID, string module, string option)
        {
            string file = "\\testTC.xml";
            string tmp_file = "\\testfile.xml";
            string pathfile = FolderPath + file;
            string tmp_path = FolderPath + tmp_file;
            //Call process nesscessary
            int row_index_start = int.Parse(startID) - 2;
            int row_index_end = int.Parse(endID) - 2; //Not yet
            Getdatafromteststepkeywor(row_index_start);
            Getdatafromtestreponse(row_index_start);
            Getdatafromteststep(row_index_start);
            //Running database
            DatabaseFunction();
            //RUN XML
            File.Delete(pathfile);
            XmlDocument xmlDocument = new XmlDocument();
            //TESTMODULE
            XmlElement testmodule = xmlDocument.CreateElement("testmodule");
            testmodule.SetAttribute("title", module);
            testmodule.SetAttribute("version", "1.0");
            //variants
            XmlElement variants = xmlDocument.CreateElement("variants");
            XmlElement variant = xmlDocument.CreateElement("variant");
            variants.AppendChild(variant);
            variant.SetAttribute("name", "Automated");
            variant.InnerText = "TestsAutomated Testcase";
            //testgroup1
            XmlElement group1 = xmlDocument.CreateElement("testgroup");
            group1.SetAttribute("title", list[row_index_start]._labT + " Automated Testcase");
            //testgroup2
            XmlElement group2 = xmlDocument.CreateElement("testgroup");
            group2.SetAttribute("title", list[row_index_start]._labT);
            XmlElement externalref = xmlDocument.CreateElement("externalref");
            externalref.SetAttribute("type", "doors");
            externalref.SetAttribute("owner", "TAE - DOORS extension");
            externalref.SetAttribute("title", list[row_index_start]._TC_ID);
            group2.AppendChild(externalref);
            group1.AppendChild(group2);
            int num_keyword = _listdata_testkeywor.Count();
            int num_testreponse = _listdata_testreponse.Count();
            int num_teststep = _listdata_teststep.Count();
            try
            {
                if (num_keyword == num_testreponse && num_testreponse == num_teststep && num_teststep == num_keyword)
                {
                    for (int i = 0; i < num_keyword; i++)
                    {
                        if (_listdata_testkeywor[i].Contains("TimeNowStart") && databasefunction.Contains("TimeNowStart"))
                        {
                            string name = DeleteRegex(_listdata_testkeywor[i].ToString());
                            string title = (i + 1) + "- " + _listdata_teststep[i].ToString();
                            string ident = _listdata_testreponse[i].ToString();
                            string variants_auto = "Automated";
                            group2.AppendChild(group2.OwnerDocument.ImportNode(function.TimeNowStart(name, title, ident, variants_auto), true));
                        }
                        else if (_listdata_testkeywor[i].Contains("wait") && databasefunction.Contains("wait"))
                        {
                            //wait(n) -> waitn -> get n
                            string title = (i + 1) + "- " + _listdata_teststep[i].ToString();
                            string ident = _listdata_testreponse[i].ToString();
                            string time = GetNumberFromWait(_listdata_testkeywor[i].ToString());
                            string name = DeleteRegex(GetStringFromWait(_listdata_testkeywor[i].ToString()));
                            group2.AppendChild(group2.OwnerDocument.ImportNode(function.wait(title, ident, name, time), true));
                        }
                        else if(_listdata_testkeywor[i].Contains("envvar") && databasefunction.Contains("envvar"))
                        {
                            string title = (i + 1) + "- " + _listdata_teststep[i].ToString();
                            string ident = _listdata_testreponse[i].ToString();
                            string name_function = Getnamefunction(_listdata_testkeywor[i].ToString()); //envvar
                            string namedbcfullvalue = Getnamefunctiondbc(_listdata_testkeywor[i].ToString());//function(a,b,...)
                            string namedbc = Getnamefunction(Getnamefunctiondbc(_listdata_testkeywor[i].ToString())); //function
                            string value = Getvalue(namedbcfullvalue); // state;timeout
                            string statesignal = Getstatesignal(value); //state
                            string timeout = Gettimeout(value);
                            group2.AppendChild(group2.OwnerDocument.ImportNode(function.envvar(title, ident, namedbc, statesignal, timeout, name_function), true));
                        }
                        else if(_listdata_testkeywor[i].Contains("CheckSignalValueIsPermanentStop") && databasefunction.Contains("CheckSignalValueIsPermanentStop"))
                        {
                            string title = (i + 1) + "- " + _listdata_teststep[i].ToString();
                            string ident = _listdata_testreponse[i].ToString();
                            string name_function = Getnamefunction(_listdata_testkeywor[i].ToString()); //CheckSignalValueIsPermanentStop
                            string valuesinfunction = Getvalue(_listdata_testkeywor[i].ToString());
                            string[] valueinvalues = Splitstringinstring(valuesinfunction); //["variable","type","namedbc"]
                            string variable = valueinvalues.ElementAt(0);
                            string name_type = valueinvalues.ElementAt(1);
                            string namedbc = valueinvalues.ElementAt(2);
                            group2.AppendChild(group2.OwnerDocument.ImportNode(function.CheckSignalValueIsPermanentStop(name_function, title, ident, name_type, variable, namedbc), true));
                        }    
                        else
                        {
                            XmlElement testcase = xmlDocument.CreateElement("testcase");
                            testcase.SetAttribute("title", (i + 1) + "- " + "Not yet ");
                            group2.AppendChild(testcase);
                        }    
                    }
                }
            }
            catch (Exception ex)
            { }
            //Append
            testmodule.AppendChild(variants);
            testmodule.AppendChild(group1);
            xmlDocument.AppendChild(testmodule);
            xmlDocument.LoadXml(testmodule.OuterXml);

            string a = xmlDocument.GetOuterXml();
            File.AppendAllText(pathfile, a + Environment.NewLine);
        }

        #region wait(n)
        public string GetNumberFromWait(string input)
        {
            string number = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    number += input[i];
                }
            }
            return number;
        }

        public string GetStringFromWait(string input)
        {
            string str_function = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < '0' || input[i] > '9')
                    str_function += input[i];
            }
            return str_function;
        }
        #endregion
        #region envvar(function(a,b))
        /*
         * Get name's function -> envvar
         * Can use different function
         */
        public string Getnamefunction(string input)
        {
            string stringBeforeChar = input.Substring(0, input.IndexOf("("));
            return stringBeforeChar;
        }

        public string Getnamefunctiondbc(string input)
        {
            string outputstring;
            int startindex = input.IndexOf('(');
            int endindex = input.IndexOf(')');
            outputstring = input.Substring(startindex + 1, endindex - startindex);
            return outputstring;
        }

        public string Getvalue(string input)
        {
            string value;
            int startindex = input.IndexOf('(');
            int endindex = input.IndexOf(')');
            value = input.Substring(startindex + 1, endindex - startindex -1);
            return value;
        }

        public string Getstatesignal(string input)
        {
            string statesignalBeforeChar = input.Substring(0, input.IndexOf(";"));
            return statesignalBeforeChar;
        }

        public string Gettimeout(string input)
        {
            string stringAfterChar = input.Substring(input.IndexOf(";") + 1);
            return stringAfterChar;
        }
        #endregion
        #region CheckSignalValueIsPermanentStop
        public string[] Splitstringinstring(string input)
        {
            string[] words = input.Split(' ');
            return words;
        }
        #endregion
    }
    public static partial class XmlSerializationHelper
    {
        public static string GetOuterXml(this XmlDocument doc, bool indent = true)
        {
            if (doc == null)
                return null;
            using (var textWriter = new StringWriterWithEncoding())
            {
                using (var xmlWriter = new CustomQuoteCharXmlTextWriter(textWriter) { Formatting = indent ? Formatting.Indented : Formatting.None })
                {
                    doc.Save(xmlWriter);
                }
                return textWriter.ToString();
            }
        }
    }

    public class CustomQuoteCharXmlTextWriter : XmlTextWriter
    {
        public CustomQuoteCharXmlTextWriter(Stream w, Encoding encoding) : base(w, encoding) => QuoteChar = '\'';
        public CustomQuoteCharXmlTextWriter(String filename, Encoding encoding) : base(filename, encoding) => QuoteChar = '\'';
        public CustomQuoteCharXmlTextWriter(TextWriter w) : base(w) => QuoteChar = '\'';

        public override void WriteStartDocument()
        {
            base.WriteStartDocument();
            QuoteChar = '"';
        }
    }

    public sealed class StringWriterWithEncoding : StringWriter
    {
        // From this answer https://stackoverflow.com/a/42584394/3744182
        // To https://stackoverflow.com/questions/42583299/xmlwriter-encoding-utf-8-using-stringwriter-in-c-sharp
        public StringWriterWithEncoding() : this(Encoding.UTF8) { }
        public StringWriterWithEncoding(Encoding encoding) => this.Encoding = encoding;
        public override Encoding Encoding { get; }
    }

}