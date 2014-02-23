using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RideAlong_Controller;

namespace RideAlongView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainController.Do().setActiveUser(); //kasnije - povezivanje s login podacima, daljnji rad
        }

        private void loginManager_Click(object sender, EventArgs e)
        {
            ManagerEntryForm form = new ManagerEntryForm();
            MainController.Do().openManagerEntryForm(form);
            


        }

        private void loginEmployee_Click(object sender, EventArgs e)
        {
            EmployeeEntryForm form = new EmployeeEntryForm();
            MainController.Do().openEmployeeEntryForm(form);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
