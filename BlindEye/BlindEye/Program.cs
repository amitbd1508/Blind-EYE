using BlindEye.Control.User_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlindEye.Control.Books;
using BlindEye.Control;

namespace BlindEye
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Final

            //Splash _Splash = new Splash();
            //Application.Run(new Splash());

            //if (_Splash.flg == false)
            //    Application.Run(new frgLogIn());

            #endregion

            Application.Run(new frgLogIn()); 
            //Application.Run(new frmVoiceRecognigetion());

       //Application.Run(new MDIParent());
         //Application.Run(new frmStatistics());
        }
    }
}
