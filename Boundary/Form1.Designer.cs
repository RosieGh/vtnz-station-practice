namespace oscar
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.litInspections = new System.Windows.Forms.ListBox();
            this.btnInspection = new System.Windows.Forms.Button();
            this.lbl_ReqDetails = new System.Windows.Forms.Label();
            this.lbl_ReqTotalNum = new System.Windows.Forms.Label();
            this.lbl_ReqDetailsPrompt = new System.Windows.Forms.Label();
            this.lbl_ReqTotalNumPrompt = new System.Windows.Forms.Label();
            this.lbl_reqTotalPrice = new System.Windows.Forms.Label();
            this.lbl_reqTotalPricePrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(294, 39);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 20);
            this.lblHeader.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(56, 157);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(145, 15);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Select the inspection type";
            // 
            // litInspections
            // 
            this.litInspections.FormattingEnabled = true;
            this.litInspections.Location = new System.Drawing.Point(288, 142);
            this.litInspections.Name = "litInspections";
            this.litInspections.Size = new System.Drawing.Size(213, 134);
            this.litInspections.TabIndex = 2;
            // 
            // btnInspection
            // 
            this.btnInspection.Location = new System.Drawing.Point(70, 196);
            this.btnInspection.Name = "btnInspection";
            this.btnInspection.Size = new System.Drawing.Size(119, 23);
            this.btnInspection.TabIndex = 3;
            this.btnInspection.Text = "Request Inspection";
            this.btnInspection.UseVisualStyleBackColor = true;
            this.btnInspection.Click += new System.EventHandler(this.btnInspection_Click);
            // 
            // lbl_ReqDetails
            // 
            this.lbl_ReqDetails.AutoSize = true;
            this.lbl_ReqDetails.Location = new System.Drawing.Point(90, 308);
            this.lbl_ReqDetails.Name = "lbl_ReqDetails";
            this.lbl_ReqDetails.Size = new System.Drawing.Size(158, 13);
            this.lbl_ReqDetails.TabIndex = 4;
            this.lbl_ReqDetails.Text = "Details of Insepction Requested";
            // 
            // lbl_ReqTotalNum
            // 
            this.lbl_ReqTotalNum.AutoSize = true;
            this.lbl_ReqTotalNum.Location = new System.Drawing.Point(525, 308);
            this.lbl_ReqTotalNum.Name = "lbl_ReqTotalNum";
            this.lbl_ReqTotalNum.Size = new System.Drawing.Size(192, 13);
            this.lbl_ReqTotalNum.TabIndex = 5;
            this.lbl_ReqTotalNum.Text = "Total Number ofInspections Requested";
            // 
            // lbl_ReqDetailsPrompt
            // 
            this.lbl_ReqDetailsPrompt.AutoSize = true;
            this.lbl_ReqDetailsPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_ReqDetailsPrompt.Location = new System.Drawing.Point(138, 343);
            this.lbl_ReqDetailsPrompt.Name = "lbl_ReqDetailsPrompt";
            this.lbl_ReqDetailsPrompt.Size = new System.Drawing.Size(0, 13);
            this.lbl_ReqDetailsPrompt.TabIndex = 6;
            // 
            // lbl_ReqTotalNumPrompt
            // 
            this.lbl_ReqTotalNumPrompt.AutoSize = true;
            this.lbl_ReqTotalNumPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_ReqTotalNumPrompt.Location = new System.Drawing.Point(594, 343);
            this.lbl_ReqTotalNumPrompt.Name = "lbl_ReqTotalNumPrompt";
            this.lbl_ReqTotalNumPrompt.Size = new System.Drawing.Size(0, 13);
            this.lbl_ReqTotalNumPrompt.TabIndex = 7;
            // 
            // lbl_reqTotalPrice
            // 
            this.lbl_reqTotalPrice.AutoSize = true;
            this.lbl_reqTotalPrice.Location = new System.Drawing.Point(318, 356);
            this.lbl_reqTotalPrice.Name = "lbl_reqTotalPrice";
            this.lbl_reqTotalPrice.Size = new System.Drawing.Size(197, 13);
            this.lbl_reqTotalPrice.TabIndex = 8;
            this.lbl_reqTotalPrice.Text = "Total price for all Inspections Requested";
            // 
            // lbl_reqTotalPricePrompt
            // 
            this.lbl_reqTotalPricePrompt.AutoSize = true;
            this.lbl_reqTotalPricePrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_reqTotalPricePrompt.Location = new System.Drawing.Point(389, 397);
            this.lbl_reqTotalPricePrompt.Name = "lbl_reqTotalPricePrompt";
            this.lbl_reqTotalPricePrompt.Size = new System.Drawing.Size(0, 13);
            this.lbl_reqTotalPricePrompt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_reqTotalPricePrompt);
            this.Controls.Add(this.lbl_reqTotalPrice);
            this.Controls.Add(this.lbl_ReqTotalNumPrompt);
            this.Controls.Add(this.lbl_ReqDetailsPrompt);
            this.Controls.Add(this.lbl_ReqTotalNum);
            this.Controls.Add(this.lbl_ReqDetails);
            this.Controls.Add(this.btnInspection);
            this.Controls.Add(this.litInspections);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ListBox litInspections;
        private System.Windows.Forms.Button btnInspection;
        private System.Windows.Forms.Label lbl_ReqDetails;
        private System.Windows.Forms.Label lbl_ReqTotalNum;
        private System.Windows.Forms.Label lbl_ReqDetailsPrompt;
        private System.Windows.Forms.Label lbl_ReqTotalNumPrompt;
        private System.Windows.Forms.Label lbl_reqTotalPrice;
        private System.Windows.Forms.Label lbl_reqTotalPricePrompt;
    }
}

