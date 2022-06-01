using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace GENTOOL.Models
{
    public class ExcelConvertXML
    {
        //string RequestResponseReg = "RequestResponse\\((.*)[ ]*,[ ]*(.*)[ ]*,[ ]*(.*)\\)";
        //string COL_TC_ID = "ID.?";
        //string COL_component_name = "XXX Component MDC Component COM Tests MDC DCOM Tests LabT_MDC_ERRMGR MDC Error Manager Tests  LabT_MDC_DCOM MDC_ERRMGR Labor Test Lane Deviation Warning";
        //string COL_test_description = "Test Description.?";
        //string COL_test_Step = "Test.*Steps.?";
        //string COL_test_response = "Test response.?";
        //string COL_teststep_keywords = "Test.+?words";
        //string COL_objectType = "ObjectType.?";
        //string COL_teststatus = "TestStatus.?";
        //string COL_project = "Project.?";
        //// todo --> modify input from gui
        //string COL_release = "";
        //string COL_test_result = "";
        public string _id;
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string _testdescription;
        public string Testdescription
        {
            get { return _testdescription; }
            set { _testdescription = value; }
        }
        public string _teststeps;
        public string Teststeps
        {
            get { return _teststeps; }
            set { _teststeps = value; }
        }
        public string _testresponse;
        public string Testresponse
        {
            get { return _testresponse; }
            set { _testresponse = value; }
        }

        public string _teststepkeywords;
        public string Teststepkeywords
        {
            get { return _teststepkeywords; }
            set { _teststepkeywords = value; }
        }

        public string _teststatus;
        public string Teststatus
        {
            get { return _teststatus; }
            set { _teststatus = value; }
        }
        public string _project;
        public string Project
        {
            get { return _project; }
            set { _project = value; }
        }

        public string _objecttype;
        public string Objecttype
        {
            get { return _objecttype; }
            set { _objecttype = value; }
        }

        public int _beginID;

        public int _endID;
        public ExcelConvertXML()
        {

        }
        public ExcelConvertXML(string id, string testdescription, string teststeps, string testresponse,
    string teststepkeywords, string teststatus, string project, string objecttype)
        {
            ID = id;
            Testdescription = testdescription;
            Teststeps = teststeps;
            Testresponse = testresponse;
            Teststepkeywords = teststepkeywords;
            Teststatus = teststatus;
            Project = project;
            Objecttype = objecttype;
        }
    }
}
