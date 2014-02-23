namespace RideAlongView
{
    partial class EmployeeEntryForm
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
            this.userTripsOwn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showOwnerTrips = new System.Windows.Forms.Button();
            this.cancleTrip = new System.Windows.Forms.Button();
            this.showPartTrips = new System.Windows.Forms.Button();
            this.removeUser = new System.Windows.Forms.Button();
            this.searchTrips = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tripDone = new System.Windows.Forms.Button();
            this.listViewPartTrips = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMyTrips = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewContact = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.viewDetails = new System.Windows.Forms.Button();
            this.listViewTripDetails = new System.Windows.Forms.ListView();
            this.listViewContact = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // userTripsOwn
            // 
            this.userTripsOwn.AutoSize = true;
            this.userTripsOwn.Location = new System.Drawing.Point(55, 40);
            this.userTripsOwn.Name = "userTripsOwn";
            this.userTripsOwn.Size = new System.Drawing.Size(51, 15);
            this.userTripsOwn.TabIndex = 0;
            this.userTripsOwn.Text = "My trips:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "My participating trips:";
            // 
            // showOwnerTrips
            // 
            this.showOwnerTrips.Location = new System.Drawing.Point(222, 10);
            this.showOwnerTrips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showOwnerTrips.Name = "showOwnerTrips";
            this.showOwnerTrips.Size = new System.Drawing.Size(149, 55);
            this.showOwnerTrips.TabIndex = 2;
            this.showOwnerTrips.Text = "Show me my trips";
            this.showOwnerTrips.UseVisualStyleBackColor = true;
            this.showOwnerTrips.Click += new System.EventHandler(this.showOwnerTrips_Click);
            // 
            // cancleTrip
            // 
            this.cancleTrip.Location = new System.Drawing.Point(170, 361);
            this.cancleTrip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancleTrip.Name = "cancleTrip";
            this.cancleTrip.Size = new System.Drawing.Size(99, 46);
            this.cancleTrip.TabIndex = 3;
            this.cancleTrip.Text = "Cancel selected trip";
            this.cancleTrip.UseVisualStyleBackColor = true;
            this.cancleTrip.Click += new System.EventHandler(this.cancleTrip_Click);
            // 
            // showPartTrips
            // 
            this.showPartTrips.Location = new System.Drawing.Point(699, 14);
            this.showPartTrips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showPartTrips.Name = "showPartTrips";
            this.showPartTrips.Size = new System.Drawing.Size(149, 55);
            this.showPartTrips.TabIndex = 4;
            this.showPartTrips.Text = "Show me my ride alongs";
            this.showPartTrips.UseVisualStyleBackColor = true;
            this.showPartTrips.Click += new System.EventHandler(this.showPartTrips_Click);
            // 
            // removeUser
            // 
            this.removeUser.Location = new System.Drawing.Point(699, 361);
            this.removeUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(113, 46);
            this.removeUser.TabIndex = 5;
            this.removeUser.Text = "Remove me from selected ride";
            this.removeUser.UseVisualStyleBackColor = true;
            this.removeUser.Click += new System.EventHandler(this.removeUser_Click);
            // 
            // searchTrips
            // 
            this.searchTrips.Location = new System.Drawing.Point(589, 653);
            this.searchTrips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTrips.Name = "searchTrips";
            this.searchTrips.Size = new System.Drawing.Size(169, 26);
            this.searchTrips.TabIndex = 6;
            this.searchTrips.Text = "I want to find a ride";
            this.searchTrips.UseVisualStyleBackColor = true;
            this.searchTrips.Click += new System.EventHandler(this.searchTrips_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 653);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "I want to set up a ride";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tripDone
            // 
            this.tripDone.Location = new System.Drawing.Point(297, 361);
            this.tripDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tripDone.Name = "tripDone";
            this.tripDone.Size = new System.Drawing.Size(155, 46);
            this.tripDone.TabIndex = 8;
            this.tripDone.Text = "This selected trip is done - vehicle is returned";
            this.tripDone.UseVisualStyleBackColor = true;
            this.tripDone.Click += new System.EventHandler(this.tripDone_Click);
            // 
            // listViewPartTrips
            // 
            this.listViewPartTrips.BackColor = System.Drawing.SystemColors.Info;
            this.listViewPartTrips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader9});
            this.listViewPartTrips.FullRowSelect = true;
            this.listViewPartTrips.HoverSelection = true;
            this.listViewPartTrips.Location = new System.Drawing.Point(491, 82);
            this.listViewPartTrips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewPartTrips.Name = "listViewPartTrips";
            this.listViewPartTrips.Size = new System.Drawing.Size(376, 252);
            this.listViewPartTrips.TabIndex = 9;
            this.listViewPartTrips.UseCompatibleStateImageBehavior = false;
            this.listViewPartTrips.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TripID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "From";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "To";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Date";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Driver";
            // 
            // listViewMyTrips
            // 
            this.listViewMyTrips.BackColor = System.Drawing.SystemColors.Info;
            this.listViewMyTrips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewMyTrips.FullRowSelect = true;
            this.listViewMyTrips.Location = new System.Drawing.Point(42, 82);
            this.listViewMyTrips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewMyTrips.Name = "listViewMyTrips";
            this.listViewMyTrips.Size = new System.Drawing.Size(410, 252);
            this.listViewMyTrips.TabIndex = 10;
            this.listViewMyTrips.UseCompatibleStateImageBehavior = false;
            this.listViewMyTrips.View = System.Windows.Forms.View.Details;
            this.listViewMyTrips.SelectedIndexChanged += new System.EventHandler(this.listViewMyTrips_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TripID";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "From";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "To";
            this.columnHeader3.Width = 47;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Departure date";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Approved";
            this.columnHeader5.Width = 72;
            // 
            // viewContact
            // 
            this.viewContact.Location = new System.Drawing.Point(558, 361);
            this.viewContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewContact.Name = "viewContact";
            this.viewContact.Size = new System.Drawing.Size(87, 46);
            this.viewContact.TabIndex = 11;
            this.viewContact.Text = "Show me fellow riders contacts";
            this.viewContact.UseVisualStyleBackColor = true;
            this.viewContact.Click += new System.EventHandler(this.viewContact_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(38, 10);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(59, 15);
            this.welcomeLabel.TabIndex = 12;
            this.welcomeLabel.Text = "Welcome";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // viewDetails
            // 
            this.viewDetails.Location = new System.Drawing.Point(58, 361);
            this.viewDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewDetails.Name = "viewDetails";
            this.viewDetails.Size = new System.Drawing.Size(87, 46);
            this.viewDetails.TabIndex = 13;
            this.viewDetails.Text = "Show details";
            this.viewDetails.UseVisualStyleBackColor = true;
            this.viewDetails.Click += new System.EventHandler(this.viewDetails_Click);
            // 
            // listViewTripDetails
            // 
            this.listViewTripDetails.BackColor = System.Drawing.SystemColors.Info;
            this.listViewTripDetails.Location = new System.Drawing.Point(42, 448);
            this.listViewTripDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewTripDetails.Name = "listViewTripDetails";
            this.listViewTripDetails.Size = new System.Drawing.Size(410, 198);
            this.listViewTripDetails.TabIndex = 14;
            this.listViewTripDetails.UseCompatibleStateImageBehavior = false;
            this.listViewTripDetails.View = System.Windows.Forms.View.List;
            this.listViewTripDetails.SelectedIndexChanged += new System.EventHandler(this.listViewTripDetails_SelectedIndexChanged);
            // 
            // listViewContact
            // 
            this.listViewContact.BackColor = System.Drawing.SystemColors.Info;
            this.listViewContact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewContact.Location = new System.Drawing.Point(502, 448);
            this.listViewContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewContact.Name = "listViewContact";
            this.listViewContact.Size = new System.Drawing.Size(366, 198);
            this.listViewContact.TabIndex = 15;
            this.listViewContact.UseCompatibleStateImageBehavior = false;
            this.listViewContact.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Colleague";
            this.columnHeader11.Width = 94;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Cell phone number";
            this.columnHeader12.Width = 118;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "E mail address";
            this.columnHeader13.Width = 118;
            // 
            // EmployeeEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(898, 694);
            this.Controls.Add(this.listViewContact);
            this.Controls.Add(this.listViewTripDetails);
            this.Controls.Add(this.viewDetails);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.viewContact);
            this.Controls.Add(this.listViewMyTrips);
            this.Controls.Add(this.listViewPartTrips);
            this.Controls.Add(this.tripDone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTrips);
            this.Controls.Add(this.removeUser);
            this.Controls.Add(this.showPartTrips);
            this.Controls.Add(this.cancleTrip);
            this.Controls.Add(this.showOwnerTrips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userTripsOwn);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeEntryForm";
            this.Text = "EmployeeEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userTripsOwn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showOwnerTrips;
        private System.Windows.Forms.Button cancleTrip;
        private System.Windows.Forms.Button showPartTrips;
        private System.Windows.Forms.Button removeUser;
        private System.Windows.Forms.Button searchTrips;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tripDone;
        private System.Windows.Forms.ListView listViewPartTrips;
        private System.Windows.Forms.ListView listViewMyTrips;
        private System.Windows.Forms.Button viewContact;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button viewDetails;
        private System.Windows.Forms.ListView listViewTripDetails;
        private System.Windows.Forms.ListView listViewContact;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}