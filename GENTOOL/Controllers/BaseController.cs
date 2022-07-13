using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GENTOOL.Controllers
{
    public class BaseController
    {
        public BaseController() { }
        public void ShowConfirmAlert(string title, string content) => MessageBox.Show(content, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        public void ShowAlert(string title, string content) => MessageBox.Show(content, title);
    }
}
