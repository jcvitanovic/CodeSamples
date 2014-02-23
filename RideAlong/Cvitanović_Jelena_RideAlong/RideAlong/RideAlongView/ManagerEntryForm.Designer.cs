namespace RideAlongView
{
    partial class ManagerEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListViewNotApprovedTrips = new System.Windows.Forms.ListView();
            this.TripID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartureDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tripCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.approveTrip = new System.Windows.Forms.Button();
            this.addVehicle = new System.Windows.Forms.Button();
            this.managerLogOut = new System.Windows.Forms.Button();
            this.getTrips = new System.Windows.Forms.Button();
            this.showAllVehicles = new System.Windows.Forms.Button();
            this.listViewVehicles = new System.Windows.Forms.ListView();
            this.VehicleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewNotApprovedTrips
            // 
            this.ListViewNotApprovedTrips.BackColor = System.Drawing.SystemColors.Info;
            this.ListViewNotApprovedTrips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TripID,
            this.departure,
            this.DepartureDate,
            this.Employee,
            this.Vehicle,
            this.tripCost});
            this.tableLayoutPanel1.SetColumnSpan(this.ListViewNotApprovedTrips, 2);
            this.ListViewNotApprovedTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewNotApprovedTrips.FullRowSelect = true;
            this.ListViewNotApprovedTrips.Location = new System.Drawing.Point(3, 52);
            this.ListViewNotApprovedTrips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListViewNotApprovedTrips.Name = "ListViewNotApprovedTrips";
            this.ListViewNotApprovedTrips.Size = new System.Drawing.Size(560, 332);
            this.ListViewNotApprovedTrips.TabIndex = 0;
            this.ListViewNotApprovedTrips.UseCompatibleStateImageBehavior = false;
            this.ListViewNotApprovedTrips.View = System.Windows.Forms.View.Details;
            this.ListViewNotApprovedTrips.SelectedIndexChanged += new System.EventHandler(this.ListViewNotApprovedTrips_SelectedIndexChanged);
            // 
            // TripID
            // 
            this.TripID.Text = "Trip ID";
            // 
            // departure
            // 
            this.departure.DisplayIndex = 5;
            this.departure.Text = "Departure City";
            this.departure.Width = 129;
            // 
            // DepartureDate
            // 
            this.DepartureDate.DisplayIndex = 1;
            this.DepartureDate.Text = "Departure Date";
            this.DepartureDate.Width = 115;
            // 
            // Employee
            // 
            this.Employee.DisplayIndex = 2;
            this.Employee.Text = "Initiated by:";
            this.Employee.Width = 87;
            // 
            // Vehicle
            // 
            this.Vehicle.DisplayIndex = 3;
            this.Vehicle.Text = "Vehicle Model";
            this.Vehicle.Width = 105;
            // 
            // tripCost
            // 
            this.tripCost.DisplayIndex = 4;
            this.tripCost.Text = "Cost  (€ )";
            this.tripCost.Width = 104;
            // 
            // approveTrip
            // 
            this.approveTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.approveTrip.Location = new System.Drawing.Point(286, 392);
            this.approveTrip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.approveTrip.Name = "approveTrip";
            this.approveTrip.Size = new System.Drawing.Size(277, 42);
            this.approveTrip.TabIndex = 2;
            this.approveTrip.Text = "Accept sellected";
            this.approveTrip.UseVisualStyleBackColor = true;
            this.approveTrip.Click += new System.EventHandler(this.approveTrip_Click);
            // 
            // addVehicle
            // 
            this.addVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addVehicle.Location = new System.Drawing.Point(906, 392);
            this.addVehicle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addVehicle.Name = "addVehicle";
            this.addVehicle.Size = new System.Drawing.Size(226, 42);
            this.addVehicle.TabIndex = 5;
            this.addVehicle.Text = "Add new company vehicle";
            this.addVehicle.UseVisualStyleBackColor = true;
            this.addVehicle.Click += new System.EventHandler(this.addVehicle_Click);
            // 
            // managerLogOut
            // 
            this.managerLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.managerLogOut.Location = new System.Drawing.Point(906, 18);
            this.managerLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managerLogOut.Name = "managerLogOut";
            this.managerLogOut.Size = new System.Drawing.Size(226, 26);
            this.managerLogOut.TabIndex = 6;
            this.managerLogOut.Text = "LOG OUT";
            this.managerLogOut.UseVisualStyleBackColor = true;
            this.managerLogOut.Click += new System.EventHandler(this.managerLogOut_Click);
            // 
            // getTrips
            // 
            this.getTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getTrips.Location = new System.Drawing.Point(3, 392);
            this.getTrips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getTrips.Name = "getTrips";
            this.getTrips.Size = new System.Drawing.Size(277, 42);
            this.getTrips.TabIndex = 9;
            this.getTrips.Text = "Show unaprroved trips";
            this.getTrips.UseVisualStyleBackColor = true;
            this.getTrips.Click += new System.EventHandler(this.getTrips_Click);
            // 
            // showAllVehicles
            // 
            this.showAllVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showAllVehicles.Location = new System.Drawing.Point(569, 392);
            this.showAllVehicles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showAllVehicles.Name = "showAllVehicles";
            this.showAllVehicles.Size = new System.Drawing.Size(331, 42);
            this.showAllVehicles.TabIndex = 10;
            this.showAllVehicles.Text = "Show all company vehicles";
            this.showAllVehicles.UseVisualStyleBackColor = true;
            this.showAllVehicles.Click += new System.EventHandler(this.showAllVehicles_Click);
            // 
            // listViewVehicles
            // 
            this.listViewVehicles.BackColor = System.Drawing.SystemColors.Info;
            this.listViewVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VehicleID,
            this.model,
            this.location,
            this.availability});
            this.tableLayoutPanel1.SetColumnSpan(this.listViewVehicles, 2);
            this.listViewVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVehicles.FullRowSelect = true;
            this.listViewVehicles.Location = new System.Drawing.Point(569, 52);
            this.listViewVehicles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewVehicles.Name = "listViewVehicles";
            this.listViewVehicles.Size = new System.Drawing.Size(563, 332);
            this.listViewVehicles.TabIndex = 11;
            this.listViewVehicles.UseCompatibleStateImageBehavior = false;
            this.listViewVehicles.View = System.Windows.Forms.View.Details;
            // 
            // VehicleID
            // 
            this.VehicleID.Text = "VehicleID";
            this.VehicleID.Width = 75;
            // 
            // model
            // 
            this.model.Text = "Model";
            this.model.Width = 103;
            // 
            // location
            // 
            this.location.Text = "Location";
            this.location.Width = 73;
            // 
            // availability
            // 
            this.availability.Text = "Available";
            this.availability.Width = 96;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.9779F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.9779F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70822F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.33599F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.getTrips, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listViewVehicles, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.showAllVehicles, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.addVehicle, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.approveTrip, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ListViewNotApprovedTrips, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.managerLogOut, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1135, 438);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15);
            this.label1.Size = new System.Drawing.Size(277, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pending trips:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(569, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15);
            this.label2.Size = new System.Drawing.Size(331, 48);
            this.label2.TabIndex = 15;
            this.label2.Text = "Show all company vehicles:";
            // 
            // ManagerEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1135, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagerEntryForm";
            this.Load += new System.EventHandler(this.ManagerEntryForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewNotApprovedTrips;
        private System.Windows.Forms.Button approveTrip;
        private System.Windows.Forms.Button addVehicle;
        private System.Windows.Forms.Button managerLogOut;
        private System.Windows.Forms.ColumnHeader TripID;
        private System.Windows.Forms.ColumnHeader DepartureDate;
        private System.Windows.Forms.ColumnHeader Employee;
        private System.Windows.Forms.ColumnHeader Vehicle;
        private System.Windows.Forms.ColumnHeader tripCost;
        private System.Windows.Forms.Button getTrips;
        private System.Windows.Forms.ColumnHeader departure;
        private System.Windows.Forms.Button showAllVehicles;
        private System.Windows.Forms.ListView listViewVehicles;
        private System.Windows.Forms.ColumnHeader VehicleID;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader availability;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}