namespace RideAlongView
{
    partial class BrowseTripsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseTripsForm));
            this.txt_depCity = new System.Windows.Forms.TextBox();
            this.txt_depCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_destCountry = new System.Windows.Forms.TextBox();
            this.txt_destCity = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.listViewmatchingTrips = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_depCity
            // 
            this.txt_depCity.Location = new System.Drawing.Point(150, 37);
            this.txt_depCity.Name = "txt_depCity";
            this.txt_depCity.Size = new System.Drawing.Size(100, 20);
            this.txt_depCity.TabIndex = 0;
            this.txt_depCity.Text = "city";
            // 
            // txt_depCountry
            // 
            this.txt_depCountry.Location = new System.Drawing.Point(278, 37);
            this.txt_depCountry.Name = "txt_depCountry";
            this.txt_depCountry.Size = new System.Drawing.Size(100, 20);
            this.txt_depCountry.TabIndex = 1;
            this.txt_depCountry.Text = "country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "I want to go from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // txt_destCountry
            // 
            this.txt_destCountry.Location = new System.Drawing.Point(278, 97);
            this.txt_destCountry.Name = "txt_destCountry";
            this.txt_destCountry.Size = new System.Drawing.Size(100, 20);
            this.txt_destCountry.TabIndex = 5;
            this.txt_destCountry.Text = "country";
            // 
            // txt_destCity
            // 
            this.txt_destCity.Location = new System.Drawing.Point(150, 97);
            this.txt_destCity.Name = "txt_destCity";
            this.txt_destCity.Size = new System.Drawing.Size(100, 20);
            this.txt_destCity.TabIndex = 4;
            this.txt_destCity.Text = "city";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(15, 157);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(235, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Find me all trips that have this route!";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listViewmatchingTrips
            // 
            this.listViewmatchingTrips.BackColor = System.Drawing.SystemColors.Info;
            this.listViewmatchingTrips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewmatchingTrips.FullRowSelect = true;
            this.listViewmatchingTrips.Location = new System.Drawing.Point(15, 212);
            this.listViewmatchingTrips.Name = "listViewmatchingTrips";
            this.listViewmatchingTrips.Size = new System.Drawing.Size(425, 188);
            this.listViewmatchingTrips.TabIndex = 7;
            this.listViewmatchingTrips.UseCompatibleStateImageBehavior = false;
            this.listViewmatchingTrips.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Trip ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "When in my departure city;";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "When in my destination city:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Driver";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Contact phone";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contact mail:";
            this.columnHeader6.Width = 85;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register for the selected trip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrowseTripsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewmatchingTrips);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.txt_destCountry);
            this.Controls.Add(this.txt_destCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_depCountry);
            this.Controls.Add(this.txt_depCity);
            this.Name = "BrowseTripsForm";
            this.Text = "Browse trips for the route";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_depCity;
        private System.Windows.Forms.TextBox txt_depCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_destCountry;
        private System.Windows.Forms.TextBox txt_destCity;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView listViewmatchingTrips;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
    }
}