using GENTOOL.Controllers;
using GENTOOL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GENTOOL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainView mainView = new MainView();
            mainView.Visible = false;

            MainController mainController = new MainController(mainView);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(mainView);
            Application.Run(mainView);
        }
    }
}
