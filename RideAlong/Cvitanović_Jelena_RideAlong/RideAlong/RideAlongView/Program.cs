using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RideAlongUtil;
using RideAlong;

namespace RideAlongView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VehicleRepository.GetInstance().Load();
            EmployeeRepository.GetInstance().Load();
            TripRepository.GetInstance().Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
