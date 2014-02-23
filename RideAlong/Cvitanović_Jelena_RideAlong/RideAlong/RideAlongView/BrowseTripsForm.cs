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
    public partial class BrowseTripsForm : Form,IBrowseTripsForm
    {
        public BrowseTripsForm()
        {
            InitializeComponent();
        }

        public void showForm()
        {
            ShowDialog();
        }

        public void closeForm()
        {
            Close();
        }

        public string getSelectedCityDeparture()
        {
            return this.txt_depCity.Text;
        }

        public string getSelectedCountryDeparture()
        {
            return this.txt_depCountry.Text;
        }

        public string getSelectedCityDestination()
        {
            return this.txt_destCity.Text;
        }

        public string getSelectedCountryDest()
        {
            return this.txt_destCountry.Text;
        }


        public int getSelectedTripID()
        {
            return int.Parse(listViewmatchingTrips.SelectedItems[0].SubItems[0].Text);
        }


        public void setDisplayItem(string id, string departure, string arrival, string name, string mobile, string email)
        {
            ListViewItem lvi = new ListViewItem(id);
            lvi.SubItems.Add(departure);
            lvi.SubItems.Add(arrival);
            lvi.SubItems.Add(name);
            lvi.SubItems.Add(mobile);
            lvi.SubItems.Add(email);
            listViewmatchingTrips.Items.Add(lvi);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try{
                MainController.Do().getSearchedTrip(this);
            }
            catch
            {
                MessageBox.Show("Please try a different search");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MainController.Do().registerUserForTheTrip(this);
                
            }
            catch
            {

            }
        }


    }
}
