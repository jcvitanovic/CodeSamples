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
    public partial class AddVehicleForm : Form,IAddVehicleForm
    {

       
        
        public AddVehicleForm()
        {
            InitializeComponent();
            vehicleTypes.Items.Add("Car");
            vehicleTypes.Items.Add("Minivan");
            vehicleTypes.Items.Add("Caravan");
            vehicleTypes.Items.Add("Other");
        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
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


        public string getVehicleType()
        {
            return vehicleTypes.SelectedText;
        }
        public string getVehicleModel()
        {
            return txt_model.Text;

        }
        public float getConsumption()
        {
            return float.Parse(txt_consumption.Text);

        }
        public int getCapacity()
        {
            return int.Parse(txt_capacity.Text);

        }
        public string getCity()
        {
            return txt_city.Text;

        }
        public string getCountry()
        {
            return txt_country.Text;
        }

        public string getAddress()
        {
            return txt_address.Text;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                MainController.Do().addVehicleToRepository(this);
            }
            catch
            {
                MessageBox.Show("Please enter all valid information that are required in the form");
            }
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            MainController.Do().closeAddVehicleForm(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
