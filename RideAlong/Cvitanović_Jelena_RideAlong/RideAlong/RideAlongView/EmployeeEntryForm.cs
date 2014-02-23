using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RideAlongUtil;
using RideAlong_Controller;
namespace RideAlongView
{
    public partial class EmployeeEntryForm : Form, IEmployeeEntryForm
    {
        public EmployeeEntryForm()
        {
            InitializeComponent();
            MainController.Do().sayHelloToUser(this);        }


        public void showForm()
        {
            ShowDialog();
        }

        public void closeForm()
        {
            Close();
        }

        public int getSelectedMyTripID()
        {
            return int.Parse(listViewMyTrips.SelectedItems[0].SubItems[0].Text);
        }

        public int getSelectedPartTripID()
        {
            return int.Parse(listViewPartTrips.SelectedItems[0].SubItems[0].Text);
        }

        public void setHelloLabel(string s)
        {
            welcomeLabel.Text = "Welcome "+ s+ "!";
        }

        public void setDisplayTripDetails(string s)
        {
            ListViewItem lvi = new ListViewItem(s);
            listViewTripDetails.Items.Add(lvi);
        }
        public void setDisplayContacts(string name, string phone, string mail)
        {
            ListViewItem lvi = new ListViewItem(name);
            lvi.SubItems.Add(phone);
            lvi.SubItems.Add(mail);
            listViewContact.Items.Add(lvi);
            }
        public void setDisplayItem(string id, string from, string to, string date, string approved)
        {
            ListViewItem lvi = new ListViewItem(id);
            lvi.SubItems.Add(from);
            lvi.SubItems.Add(to);
            lvi.SubItems.Add(date);
            lvi.SubItems.Add(approved);
            listViewMyTrips.Items.Add(lvi);
        }

        public void setDisplayPartTrip(string id, string from, string to, string date, string driver)
        {
            ListViewItem lvi = new ListViewItem(id);
            lvi.SubItems.Add(from);
            lvi.SubItems.Add(to);
            lvi.SubItems.Add(date);
            lvi.SubItems.Add(driver);
            listViewPartTrips.Items.Add(lvi);
            
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void showOwnerTrips_Click(object sender, EventArgs e)
        {
            try
            {
                listViewMyTrips.Items.Clear();
                listViewTripDetails.Items.Clear();
                MainController.Do().displayMyTrips(this);
            }
            catch
            {
            }
        }

        private void viewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                listViewTripDetails.Items.Clear();
                MainController.Do().displayTripDetails(this);
            }
            catch
            {
            }
        }


        private void listViewTripDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewTripDetails.Items.Clear();
        }

        private void cancleTrip_Click(object sender, EventArgs e)
        {
            try
            {
                MainController.Do().cancelSelectedTrips(this);
                listViewMyTrips.Items.Clear();
                listViewTripDetails.Items.Clear();
                MainController.Do().displayMyTrips(this);
            }
            catch
            {
            }
        }

        private void tripDone_Click(object sender, EventArgs e)
        {
            try
            {
                MainController.Do().returnConfirmation(this);
                listViewMyTrips.Items.Clear();
                listViewTripDetails.Items.Clear();
                MainController.Do().displayMyTrips(this);
            }
            catch
            {
            }
        }

        private void showPartTrips_Click(object sender, EventArgs e)
        {
            try
            {
                listViewPartTrips.Items.Clear();
                listViewContact.Items.Clear();
                MainController.Do().displayPartTrips(this);

            }

            catch
            {
            }
        }

        private void removeUser_Click(object sender, EventArgs e)
        {
            try
            {
                MainController.Do().removeUserFromTrip(this);
                listViewPartTrips.Items.Clear();
                listViewContact.Items.Clear();
                MainController.Do().displayPartTrips(this);
            }

            catch
            {
            }
        }

        private void viewContact_Click(object sender, EventArgs e)
        {
            try
            {

                listViewContact.Items.Clear();
                MainController.Do().displayContacts(this);
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewTripForm form = new NewTripForm();
            MainController.Do().openNewTripForm(form);
        }

        private void searchTrips_Click(object sender, EventArgs e)
        {
            BrowseTripsForm form = new BrowseTripsForm();
            MainController.Do().openBrowseForm(form);
        }

        private void listViewMyTrips_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
