namespace Topic9_Lab_Reservation
{
    partial class CustomerRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtCustomerName = new TextBox();
            txtNationalID = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            cbGender = new ComboBox();
            label8 = new Label();
            timePickerCheckIn = new DateTimePicker();
            BtnReturnDashboard = new Button();
            BtnAllocateLab = new Button();
            cblabSpecialization = new ComboBox();
            cbLabName = new ComboBox();
            txtLabPrice = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtLabID = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(431, 37);
            label1.Name = "label1";
            label1.Size = new Size(253, 38);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 147);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 140);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 259);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 372);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Check in";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(813, 259);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 5;
            label6.Text = "Lab Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(813, 142);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 6;
            label7.Text = "Lab Specialization";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 260);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 8;
            label9.Text = "National ID";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(58, 178);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(247, 27);
            txtCustomerName.TabIndex = 9;
            // 
            // txtNationalID
            // 
            txtNationalID.Location = new Point(58, 293);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.Size = new Size(247, 27);
            txtNationalID.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(431, 176);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(247, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(431, 293);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(247, 27);
            txtAddress.TabIndex = 12;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cbGender.Location = new Point(55, 404);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(250, 28);
            cbGender.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 372);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 14;
            label8.Text = "Gender";
            // 
            // timePickerCheckIn
            // 
            timePickerCheckIn.Location = new Point(431, 405);
            timePickerCheckIn.Name = "timePickerCheckIn";
            timePickerCheckIn.Size = new Size(247, 27);
            timePickerCheckIn.TabIndex = 17;
            // 
            // BtnReturnDashboard
            // 
            BtnReturnDashboard.Location = new Point(849, 519);
            BtnReturnDashboard.Name = "BtnReturnDashboard";
            BtnReturnDashboard.Size = new Size(254, 43);
            BtnReturnDashboard.TabIndex = 18;
            BtnReturnDashboard.Text = "Return to Dashboard";
            BtnReturnDashboard.UseVisualStyleBackColor = true;
            BtnReturnDashboard.Click += BtnReturnDashboard_Click;
            // 
            // BtnAllocateLab
            // 
            BtnAllocateLab.Location = new Point(553, 519);
            BtnAllocateLab.Name = "BtnAllocateLab";
            BtnAllocateLab.Size = new Size(254, 43);
            BtnAllocateLab.TabIndex = 19;
            BtnAllocateLab.Text = "Allocate lab";
            BtnAllocateLab.UseVisualStyleBackColor = true;
            BtnAllocateLab.Click += BtnAllocateLab_Click;
            // 
            // cblabSpecialization
            // 
            cblabSpecialization.FormattingEnabled = true;
            cblabSpecialization.Items.AddRange(new object[] { "Agriculture", "Astronomy", "Biology", "Biochemistry", "Biophysics", "Cellular biology", "Chemistry", "Computer Science", "Earth science", "Ecology", "Genetics", "Kinesiology", "Meteorology", "Microbiology", "Physical science ", "Physics", "Zoology" });
            cblabSpecialization.Location = new Point(813, 175);
            cblabSpecialization.Name = "cblabSpecialization";
            cblabSpecialization.Size = new Size(254, 28);
            cblabSpecialization.TabIndex = 20;
            cblabSpecialization.SelectedIndexChanged += cblabSpecialization_SelectedIndexChanged;
            // 
            // cbLabName
            // 
            cbLabName.FormattingEnabled = true;
            cbLabName.Location = new Point(813, 292);
            cbLabName.Name = "cbLabName";
            cbLabName.Size = new Size(254, 28);
            cbLabName.TabIndex = 21;
            cbLabName.SelectedIndexChanged += cbLabName_SelectedIndexChanged;
            // 
            // txtLabPrice
            // 
            txtLabPrice.Location = new Point(933, 405);
            txtLabPrice.Name = "txtLabPrice";
            txtLabPrice.ReadOnly = true;
            txtLabPrice.Size = new Size(134, 27);
            txtLabPrice.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(933, 372);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 23;
            label10.Text = "Lab Price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(813, 372);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 24;
            label11.Text = "Lab ID";
            // 
            // txtLabID
            // 
            txtLabID.Location = new Point(813, 405);
            txtLabID.Name = "txtLabID";
            txtLabID.ReadOnly = true;
            txtLabID.Size = new Size(94, 27);
            txtLabID.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1046, 407);
            label12.Name = "label12";
            label12.Size = new Size(17, 20);
            label12.TabIndex = 26;
            label12.Text = "$";
            // 
            // CustomerRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 585);
            Controls.Add(label12);
            Controls.Add(txtLabID);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtLabPrice);
            Controls.Add(cbLabName);
            Controls.Add(cblabSpecialization);
            Controls.Add(BtnAllocateLab);
            Controls.Add(BtnReturnDashboard);
            Controls.Add(timePickerCheckIn);
            Controls.Add(label8);
            Controls.Add(cbGender);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtNationalID);
            Controls.Add(txtCustomerName);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerRegistration";
            Text = "CustomerRegistration";
            Load += CustomerRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox txtCustomerName;
        private TextBox txtNationalID;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private ComboBox cbGender;
        private Label label8;
        private DateTimePicker timePickerCheckIn;
        private Button BtnReturnDashboard;
        private Button BtnAllocateLab;
        private ComboBox cblabSpecialization;
        private ComboBox cbLabName;
        private TextBox txtLabPrice;
        private Label label10;
        private Label label11;
        private TextBox txtLabID;
        private Label label12;
    }
}