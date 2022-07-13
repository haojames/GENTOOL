using Ganss.Excel;
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
        #region property
        /*
         * GET DATA HEADER FOLLOW SHEET => Fist row of all columns to create header.
         */
        public string _TC_ID { get; set; }
        public string _Test_description { get; set; }
        public string _Test_step { get; set; }
        public string _Project { get; set; }
        public string _Test_response { get; set; }
        public string _Teststep_key { get; set; }
        public string _Test_status { get; set; }

        public string _Test_release_arr { get; set; }
        public string _Object_type { get; set; }
        public string _Test_result_arr { get; set; }
        public string _labT { get; set; }
        public int _ID_start { get; set; }
        public int _ID_end { get; set; }
        #endregion

        public ExcelConvertXML(string labT,string ID,string Test_description, string Test_step,string Project,string Test_response,string Teststep_key, string TestStatus, string Objecttype)
        {
            this._labT = labT;
            this._TC_ID = ID;
            this._Test_step = Test_step;
            this._Test_description = Test_description;
            this._Project = Project;
            this._Test_response = Test_response;
            this._Teststep_key = Teststep_key;
            this._Test_status = TestStatus;
            this._Object_type = Objecttype;
        }
        public ExcelConvertXML()
        {
            this._labT = "";
            this._TC_ID = "";
            this._Test_step = "";
            this._Test_description = "";
            this._Project = "";
            this._Test_response = "";
            this._Teststep_key = "";
            this._Test_status = "";
            this._Object_type = "";
        }    

    }
}