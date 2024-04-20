using FindJobApplication.Daos;
using FindJobApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
           // Application.Run(new FLogin());
            Application.Run(new FHome());
=======
           Application.Run(new FLogin());
>>>>>>> 83d6e7c68be127793323ed3a0233aef83c474efd

        }
    }
}
