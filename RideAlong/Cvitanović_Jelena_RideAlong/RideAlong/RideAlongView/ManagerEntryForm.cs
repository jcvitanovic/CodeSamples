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
    public partial class ManagerEntryForm : Form,IManagerEntryForm, IObserver
    {
        public ManagerEntryForm()
        {
            InitializeComponent();
        }

        public void update()
        {

        }

        private void ManagerEntryForm_Load(object sender, EventArgs e)
        {
           
        }
        public void showForm()
        {
            ShowDialog();
        }

        public void closeForm()
        {
            Close();
        }

        public void setDisplayItem(string id, string departure,string date, string employee, string model, string cost)
        {
            ListViewItem lvi = new ListViewItem(id);
            lvi.SubItems.Add(departure);
            lvi.SubItems.Add(date);
            lvi.SubItems.Add(employee);
            lvi.SubItems.Add(model);
            lvi.SubItems.Add(cost);
            ListViewNotApprovedTrips.Items.Add(lvi);
        }

        public void setDisplayVehicle(string id, string model, string location, string available)
        {
            ListViewItem lvi2 = new ListViewItem(id);
            lvi2.SubItems.Add(model);
            lvi2.SubItems.Add(location);
            lvi2.SubItems.Add(available);
            listViewVehicles.Items.Add(lvi2);
            
        }

        private void addVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm form = new AddVehicleForm();
            MainController.Do().openAddVehicleForm(form);
           
        }

        private void managerLogOut_Click(object sender, EventArgs e)
        {
            MainController.Do().closeManagerEntryForm(this);
        }

        private void listViewTripDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getTrips_Click(object sender, EventArgs e)
        {
            ListViewNotApprovedTrips.Items.Clear();
            MainController.Do().displayUnapprovedTrips(this);

        }

        public int getSelectedTripID()
        {
            return int.Parse(ListViewNotApprovedTrips.SelectedItems[0].SubItems[0].Text);

        }

        private void approveTrip_Click(object sender, EventArgs e)
        {
            MainController.Do().approveSelectedTrips(this);
            MainController.Do().displayUnapprovedTrips(this);
        }

        public void clearItems()
        {
            ListViewNotApprovedTrips.Items.Clear();
        }

        private void showAllVehicles_Click(object sender, EventArgs e)
        {
            listViewVehicles.Items.Clear();
            MainController.Do().displayAllVehicles(this);
        }

        private void ListViewNotApprovedTrips_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
