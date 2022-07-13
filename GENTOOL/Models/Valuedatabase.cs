using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENTOOL.Models
{
    public class Valuedatabase
    {
        public string _Noargument { get; set; }
        public string _Oneargument { get; set; }
        public string _Twoargument { get; set; }
        public string _Threeargument { get; set; }
        public Valuedatabase()
        {
            this._Noargument = "";
            this._Oneargument = "";
            this._Twoargument = "";
            this._Threeargument = "";
        }
        public Valuedatabase(string noargument,string oneargument,string twoargument, string threeargument)
        {
            this._Noargument = noargument;
            this._Oneargument = oneargument;
            this._Twoargument= twoargument;
            this._Threeargument= threeargument;
        }
        
    }
}
