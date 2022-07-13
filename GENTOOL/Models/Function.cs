using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
namespace GENTOOL.Models
{
    public class Function
    {
        string TimeNowStart_Req = "TimeNowStart";
        public Function()
        {

        }

        XmlDocument doc_function = new XmlDocument();

        
        public XmlNode TimeNowStart(string name, string title, string ident,string variants)
        {
            /*
             * <capltestcase name="a" title="b" ident="c" variants="d" />
             */
            XmlElement capltestcase = doc_function.CreateElement("capltestcase");
            capltestcase.SetAttribute("name", name);
            capltestcase.SetAttribute("title", title);
            capltestcase.SetAttribute("ident", ident);
            capltestcase.SetAttribute("variants", variants);
            return capltestcase;
        }
        public XmlNode wait(string title, string ident, string name_f, string time)
        {
            XmlElement testcase = doc_function.CreateElement("testcase");
            testcase.SetAttribute("title", title);
            testcase.SetAttribute("ident", ident);
            XmlElement wait = doc_function.CreateElement("wait");
            wait.SetAttribute("time", time);
            wait.SetAttribute("title", name_f);
            testcase.AppendChild(wait);
            return testcase;
        }
        public XmlNode envvar(string title, string ident, string name_dbc,string statesignal, string timeout,string namefunction)
        {
            XmlElement testcase = doc_function.CreateElement("testcase");
            testcase.SetAttribute("title", title);
            testcase.SetAttribute("ident", ident);

            XmlElement set = doc_function.CreateElement("set");
            set.SetAttribute("title", name_dbc);

            XmlElement envvar = doc_function.CreateElement(namefunction);
            envvar.SetAttribute("name", name_dbc);
            envvar.InnerText = statesignal;

            XmlElement wait = doc_function.CreateElement("wait");
            wait.SetAttribute("time", timeout);
            wait.SetAttribute("title", "wait");
            set.AppendChild(envvar);
            testcase.AppendChild(set);
            testcase.AppendChild(wait);
            return testcase;
        }
        public XmlNode CheckSignalValueIsPermanentStop(string name_function, string title, string ident,string name_type,string variable,string namedbc)
        {
            XmlElement capltestcase = doc_function.CreateElement("capltestcase");
            capltestcase.SetAttribute("name", name_function);
            capltestcase.SetAttribute("title", title);
            capltestcase.SetAttribute("ident", ident);
            capltestcase.SetAttribute("variants", "Automated");
            XmlElement caplparam = doc_function.CreateElement("caplparam");
            caplparam.SetAttribute("name", name_type);
            caplparam.SetAttribute("type", variable);
            caplparam.InnerText = namedbc;
            capltestcase.AppendChild(caplparam);
            return capltestcase;
        }
    }
}
