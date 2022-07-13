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

namespace GENTOOL.Views
{
    public partial class Main : Form, IMainView
    {
        MainController _controller;

        public Main()
        {
            InitializeComponent();
        }

        public string InputPath { get; set; }
        public string OutputPath { get; set; }
        public int RangeId { get; set; }

        public void SetController(MainController controller)
        {
            
        }

        public void ShowLog()
        {

        }
    }
}
