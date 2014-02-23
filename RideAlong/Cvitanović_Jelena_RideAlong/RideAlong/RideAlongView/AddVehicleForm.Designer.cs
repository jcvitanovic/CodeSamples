namespace RideAlongView
{
    partial class AddVehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehicleForm));
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_capacity = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.newVType = new System.Windows.Forms.Label();
            this.newVModel = new System.Windows.Forms.Label();
            this.newVcap = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_consumption = new System.Windows.Forms.TextBox();
            this.newVcnsm = new System.Windows.Forms.Label();
            this.newVLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveVehicle = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(102, 79);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(100, 20);
            this.txt_model.TabIndex = 1;
            // 
            // txt_capacity
            // 
            this.txt_capacity.Location = new System.Drawing.Point(102, 131);
            this.txt_capacity.Name = "txt_capacity";
            this.txt_capacity.Size = new System.Drawing.Size(51, 20);
            this.txt_capacity.TabIndex = 2;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(147, 262);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(100, 20);
            this.txt_city.TabIndex = 3;
            // 
            // newVType
            // 
            this.newVType.AutoSize = true;
            this.newVType.Location = new System.Drawing.Point(259, 82);
            this.newVType.Name = "newVType";
            this.newVType.Size = new System.Drawing.Size(63, 13);
            this.newVType.TabIndex = 5;
            this.newVType.Text = "Select type:";
            // 
            // newVModel
            // 
            this.newVModel.AutoSize = true;
            this.newVModel.Location = new System.Drawing.Point(14, 82);
            this.newVModel.Name = "newVModel";
            this.newVModel.Size = new System.Drawing.Size(39, 13);
            this.newVModel.TabIndex = 6;
            this.newVModel.Text = "Model:";
            // 
            // newVcap
            // 
            this.newVcap.AutoSize = true;
            this.newVcap.Location = new System.Drawing.Point(14, 131);
            this.newVcap.Name = "newVcap";
            this.newVcap.Size = new System.Drawing.Size(51, 13);
            this.newVcap.TabIndex = 7;
            this.newVcap.Text = "Capacity:";
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(350, 265);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(100, 20);
            this.txt_country.TabIndex = 8;
            // 
            // txt_consumption
            // 
            this.txt_consumption.Location = new System.Drawing.Point(22, 208);
            this.txt_consumption.Name = "txt_consumption";
            this.txt_consumption.Size = new System.Drawing.Size(65, 20);
            this.txt_consumption.TabIndex = 9;
            // 
            // newVcnsm
            // 
            this.newVcnsm.AutoSize = true;
            this.newVcnsm.Location = new System.Drawing.Point(7, 180);
            this.newVcnsm.Name = "newVcnsm";
            this.newVcnsm.Size = new System.Drawing.Size(119, 13);
            this.newVcnsm.TabIndex = 10;
            this.newVcnsm.Text = "Consumption l/100km : ";
            // 
            // newVLocation
            // 
            this.newVLocation.AutoSize = true;
            this.newVLocation.Location = new System.Drawing.Point(7, 265);
            this.newVLocation.Name = "newVLocation";
            this.newVLocation.Size = new System.Drawing.Size(73, 13);
            this.newVLocation.TabIndex = 11;
            this.newVLocation.Text = "Basic location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "County:";
            // 
            // vehicleTypes
            // 
            this.vehicleTypes.BackColor = System.Drawing.Color.AliceBlue;
            this.vehicleTypes.FormattingEnabled = true;
            this.vehicleTypes.Location = new System.Drawing.Point(350, 82);
            this.vehicleTypes.Name = "vehicleTypes";
            this.vehicleTypes.Size = new System.Drawing.Size(121, 21);
            this.vehicleTypes.TabIndex = 14;
            this.vehicleTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Please fill in the form with all necessary info:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // saveVehicle
            // 
            this.saveVehicle.Location = new System.Drawing.Point(294, 331);
            this.saveVehicle.Name = "saveVehicle";
            this.saveVehicle.Size = new System.Drawing.Size(75, 23);
            this.saveVehicle.TabIndex = 16;
            this.saveVehicle.Text = "ADD";
            this.saveVehicle.UseVisualStyleBackColor = true;
            this.saveVehicle.Click += new System.EventHandler(this.saveVehicle_Click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(147, 305);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 20);
            this.txt_address.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Full address (optional):";
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(387, 331);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(75, 23);
            this.cancle.TabIndex = 19;
            this.cancle.Text = "CANCLE";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 365);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.saveVehicle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vehicleTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newVLocation);
            this.Controls.Add(this.newVcnsm);
            this.Controls.Add(this.txt_consumption);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.newVcap);
            this.Controls.Add(this.newVModel);
            this.Controls.Add(this.newVType);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_capacity);
            this.Controls.Add(this.txt_model);
            this.Name = "AddVehicleForm";
            this.Text = "AddVehicleForm";
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_capacity;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label newVType;
        private System.Windows.Forms.Label newVModel;
        private System.Windows.Forms.Label newVcap;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_consumption;
        private System.Windows.Forms.Label newVcnsm;
        private System.Windows.Forms.Label newVLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vehicleTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveVehicle;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancle;
    }
}