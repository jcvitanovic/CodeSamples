using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RideAlongUtil;
using RideAlong;
using RideAlong_Controller;

namespace RideAlongView
{
    public partial class NewTripForm : Form, INewTripForm
    {
        public NewTripForm()
        {
            InitializeComponent();
        }

        private void NewTripForm_Load(object sender, EventArgs e)
        {
        }

        public string[] getDepartureCity()
        {
            string[] tmp = new string[2];
            tmp[0] = txt_depCity.Text;
            tmp[1] = txt_depCountry.Text;
            return tmp;
        }
        public int getRouteLngth()
        {
            return int.Parse(txt_length.Text);
        }
        public string[] getDestinationCity()
        {

            string[] tmp = new string[2];
            tmp[0] = txt_destCity.Text;
            tmp[1] = txt_destCountry.Text;
            return tmp;
        }

        public DateTime getDepartureDate()
        {
            return new DateTime(int.Parse(txt_dateYear.Text), int.Parse(txt_dateMonth.Text), int.Parse(txt_dateDay.Text), int.Parse(txt_HrsDate.Text), int.Parse(txt_minDate.Text), 0);
        }


        public string[] getStop1()
        {
            string[] tmp = new string[2];

            if (txt_stop1city.Text != "city" && txt_stop1Country.Text != "country"&&txt_stop1city.Text != "" && txt_stop1Country.Text != "")
            {
                tmp[0] = txt_stop1city.Text;
                tmp[1] = txt_stop1Country.Text;
                return tmp;
            }
            else
                return null;
        }

        public string[] getStop2()
        {
            string[] tmp = new string[2];

            if (txt_stop2city.Text != "city" && txt_stop2Country.Text != "country" && txt_stop2city.Text != "" && txt_stop2Country.Text != "")
            {
                tmp[0] = txt_stop2city.Text;
                tmp[1] = txt_stop2Country.Text;
                return tmp;
            }
            else
                return null;
        }


        public string[] getStop3()
        {
            string[] tmp = new string[2];

            if (txt_stop3city.Text != "city" && txt_stop3Country.Text != "country" && txt_stop3city.Text != "" && txt_stop3Country.Text != "")
            {
                tmp[0] = txt_stop3city.Text;
                tmp[1] = txt_stop3Country.Text;
                return tmp;
            }
            else
                return null;
        }

        public string[] getStop4()
        {
            string[] tmp = new string[2];

            if (txt_stop4city.Text != "city" && txt_stop4Country.Text != "country" && txt_stop4city.Text != "" && txt_stop4Country.Text != "")
            {
                tmp[0] = txt_stop4city.Text;
                tmp[1] = txt_stop4Country.Text;
                return tmp;
            }
            else
                return null;
        }



        public DateTime getStop1Date()
        {
            if (getStop1() != null)
            {
                return new DateTime(int.Parse(txt_stop1yr.Text), int.Parse(txt_stop1mnt.Text), int.Parse(txt_stop1day.Text), int.Parse(txt_stop1h.Text), int.Parse(txt_stop1min.Text), 0);
            }

            else
                return new DateTime(0, 0, 0, 0, 0, 0);
        }

        public DateTime getStop2Date()
        {
            if (getStop2() != null)
            {
                return new DateTime(int.Parse(txt_stop2yr.Text), int.Parse(txt_stop2mnt.Text), int.Parse(txt_stop2day.Text), int.Parse(txt_stop2h.Text), int.Parse(txt_stop2min.Text), 0);
            }

            else
                return new DateTime(0, 0, 0, 0, 0, 0);
        }


        public DateTime getStop3Date()
        {
            if (getStop3() != null)
            {
                return new DateTime(int.Parse(txt_stop3yr.Text), int.Parse(txt_stop3mnt.Text), int.Parse(txt_stop3day.Text), int.Parse(txt_stop3h.Text), int.Parse(txt_stop3min.Text), 0);
            }

            else
                return new DateTime(0, 0, 0, 0, 0, 0);
        }


        public DateTime getStop4Date()
        {
            if (getStop4() != null)
            {
                return new DateTime(int.Parse(txt_stop4yr.Text), int.Parse(txt_stop4mnt.Text), int.Parse(txt_stop4day.Text), int.Parse(txt_stop4h.Text), int.Parse(txt_stop4min.Text), 0);
            }

            else
                return new DateTime(0, 0, 0, 0, 0, 0);
        }

        public void getAvVehiclesDisplay(string id, string model, string location, string consumption)
        {
            ListViewItem lvi2 = new ListViewItem(id);
            lvi2.SubItems.Add(model);
            lvi2.SubItems.Add(location);
            lvi2.SubItems.Add(consumption);
            listViewAvCars.Items.Add(lvi2);
        }





        


        public void showForm()
        {
            ShowDialog();
        }

        public void closeForm()
        {
            Close();
        }


        public int getSelectedVehicleID()
        {
            return int.Parse(listViewAvCars.SelectedItems[0].SubItems[0].Text);
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                listViewAvCars.Items.Clear();
                MainController.Do().getAvailableVehicles(this);
            }

            catch
            {
                MessageBox.Show("Sorry, no more available vehicles.");
            }

        }

        private void subbmit_Click(object sender, EventArgs e)
        {
            try
            {
                MainController.Do().addTripToRepository(this);
                MainController.Do().closeNewTripForm(this);
            }
            catch
            {
                MessageBox.Show("Please verify your input data");
            }
        }

    }
}
