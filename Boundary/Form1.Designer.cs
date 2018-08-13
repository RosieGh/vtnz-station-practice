namespace Boundary
{
    partial class Form1
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
            this.label_Header = new System.Windows.Forms.Label();
            this.label_Select = new System.Windows.Forms.Label();
            this.label_Details = new System.Windows.Forms.Label();
            this.label_PromptDetails = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.label_PromptTotalPrice = new System.Windows.Forms.Label();
            this.label_TotalNumber = new System.Windows.Forms.Label();
            this.label_PromptTotalNumber = new System.Windows.Forms.Label();
            this.listBox_SerciceList = new System.Windows.Forms.ListBox();
            this.button_Request = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Truck = new System.Windows.Forms.RadioButton();
            this.radioButton_Car = new System.Windows.Forms.RadioButton();
            this.label_selctVehicle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Header
            // 
            this.label_Header.AutoSize = true;
            this.label_Header.Location = new System.Drawing.Point(325, 13);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(0, 13);
            this.label_Header.TabIndex = 0;
            // 
            // label_Select
            // 
            this.label_Select.AutoSize = true;
            this.label_Select.Location = new System.Drawing.Point(95, 122);
            this.label_Select.Name = "label_Select";
            this.label_Select.Size = new System.Drawing.Size(140, 13);
            this.label_Select.TabIndex = 1;
            this.label_Select.Text = "Select the Inspepction Type";
            // 
            // label_Details
            // 
            this.label_Details.AutoSize = true;
            this.label_Details.Location = new System.Drawing.Point(127, 228);
            this.label_Details.Name = "label_Details";
            this.label_Details.Size = new System.Drawing.Size(158, 13);
            this.label_Details.TabIndex = 2;
            this.label_Details.Text = "Details of Inspection Requested";
            // 
            // label_PromptDetails
            // 
            this.label_PromptDetails.AutoSize = true;
            this.label_PromptDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_PromptDetails.Location = new System.Drawing.Point(130, 278);
            this.label_PromptDetails.Name = "label_PromptDetails";
            this.label_PromptDetails.Size = new System.Drawing.Size(0, 13);
            this.label_PromptDetails.TabIndex = 3;
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Location = new System.Drawing.Point(339, 228);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(197, 13);
            this.label_TotalPrice.TabIndex = 4;
            this.label_TotalPrice.Text = "Total price for all Inspections Requested";
            // 
            // label_PromptTotalPrice
            // 
            this.label_PromptTotalPrice.AutoSize = true;
            this.label_PromptTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_PromptTotalPrice.Location = new System.Drawing.Point(342, 287);
            this.label_PromptTotalPrice.Name = "label_PromptTotalPrice";
            this.label_PromptTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.label_PromptTotalPrice.TabIndex = 5;
            // 
            // label_TotalNumber
            // 
            this.label_TotalNumber.AutoSize = true;
            this.label_TotalNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_TotalNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TotalNumber.Location = new System.Drawing.Point(590, 228);
            this.label_TotalNumber.Name = "label_TotalNumber";
            this.label_TotalNumber.Size = new System.Drawing.Size(135, 13);
            this.label_TotalNumber.TabIndex = 6;
            this.label_TotalNumber.Text = "Total Number of Inspection";
            // 
            // label_PromptTotalNumber
            // 
            this.label_PromptTotalNumber.AutoSize = true;
            this.label_PromptTotalNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_PromptTotalNumber.Location = new System.Drawing.Point(539, 286);
            this.label_PromptTotalNumber.Name = "label_PromptTotalNumber";
            this.label_PromptTotalNumber.Size = new System.Drawing.Size(0, 13);
            this.label_PromptTotalNumber.TabIndex = 7;
            // 
            // listBox_SerciceList
            // 
            this.listBox_SerciceList.FormattingEnabled = true;
            this.listBox_SerciceList.Location = new System.Drawing.Point(328, 113);
            this.listBox_SerciceList.Name = "listBox_SerciceList";
            this.listBox_SerciceList.Size = new System.Drawing.Size(120, 95);
            this.listBox_SerciceList.TabIndex = 8;
            // 
            // button_Request
            // 
            this.button_Request.Location = new System.Drawing.Point(133, 169);
            this.button_Request.Name = "button_Request";
            this.button_Request.Size = new System.Drawing.Size(128, 23);
            this.button_Request.TabIndex = 9;
            this.button_Request.Text = "Request Inspection";
            this.button_Request.UseVisualStyleBackColor = true;
            this.button_Request.Click += new System.EventHandler(this.Button_Request_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Truck);
            this.groupBox1.Controls.Add(this.radioButton_Car);
            this.groupBox1.Location = new System.Drawing.Point(288, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 36);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton_Truck
            // 
            this.radioButton_Truck.AutoSize = true;
            this.radioButton_Truck.Location = new System.Drawing.Point(93, 19);
            this.radioButton_Truck.Name = "radioButton_Truck";
            this.radioButton_Truck.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Truck.TabIndex = 1;
            this.radioButton_Truck.TabStop = true;
            this.radioButton_Truck.Text = "Truck";
            this.radioButton_Truck.UseVisualStyleBackColor = true;
            // 
            // radioButton_Car
            // 
            this.radioButton_Car.AutoSize = true;
            this.radioButton_Car.Location = new System.Drawing.Point(6, 19);
            this.radioButton_Car.Name = "radioButton_Car";
            this.radioButton_Car.Size = new System.Drawing.Size(41, 17);
            this.radioButton_Car.TabIndex = 0;
            this.radioButton_Car.TabStop = true;
            this.radioButton_Car.Text = "Car";
            this.radioButton_Car.UseVisualStyleBackColor = true;
            this.radioButton_Car.Click += new System.EventHandler(this.radioButton_Car_Click);
            // 
            // label_selctVehicle
            // 
            this.label_selctVehicle.AutoSize = true;
            this.label_selctVehicle.Location = new System.Drawing.Point(139, 94);
            this.label_selctVehicle.Name = "label_selctVehicle";
            this.label_selctVehicle.Size = new System.Drawing.Size(90, 13);
            this.label_selctVehicle.TabIndex = 11;
            this.label_selctVehicle.Text = "Slect The vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_selctVehicle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Request);
            this.Controls.Add(this.listBox_SerciceList);
            this.Controls.Add(this.label_PromptTotalNumber);
            this.Controls.Add(this.label_TotalNumber);
            this.Controls.Add(this.label_PromptTotalPrice);
            this.Controls.Add(this.label_TotalPrice);
            this.Controls.Add(this.label_PromptDetails);
            this.Controls.Add(this.label_Details);
            this.Controls.Add(this.label_Select);
            this.Controls.Add(this.label_Header);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Header;
        private System.Windows.Forms.Label label_Select;
        private System.Windows.Forms.Label label_Details;
        private System.Windows.Forms.Label label_PromptDetails;
        private System.Windows.Forms.Label label_TotalPrice;
        private System.Windows.Forms.Label label_PromptTotalPrice;
        private System.Windows.Forms.Label label_TotalNumber;
        private System.Windows.Forms.Label label_PromptTotalNumber;
        private System.Windows.Forms.ListBox listBox_SerciceList;
        private System.Windows.Forms.Button button_Request;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Truck;
        private System.Windows.Forms.RadioButton radioButton_Car;
        private System.Windows.Forms.Label label_selctVehicle;
        private System.Windows.Forms.Label label1;
    }
}

