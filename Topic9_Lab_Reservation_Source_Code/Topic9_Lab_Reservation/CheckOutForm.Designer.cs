namespace Topic9_Lab_Reservation
{
    partial class CheckOutForm
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
            BtnReturnDashboard = new Button();
            txtCustomerID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSearchName = new TextBox();
            BtnCheckOutNow = new Button();
            dgvCheckOut = new DataGridView();
            BtnSearchName = new Button();
            label3 = new Label();
            label4 = new Label();
            txtNationalID = new TextBox();
            label7 = new Label();
            label8 = new Label();
            timePickerCheckOut = new DateTimePicker();
            customerFeedBackBox = new CheckBox();
            txtCustomerName = new TextBox();
            label5 = new Label();
            txtLabName = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).BeginInit();
            SuspendLayout();
            // 
            // BtnReturnDashboard
            // 
            BtnReturnDashboard.Location = new Point(950, 615);
            BtnReturnDashboard.Name = "BtnReturnDashboard";
            BtnReturnDashboard.Size = new Size(179, 56);
            BtnReturnDashboard.TabIndex = 24;
            BtnReturnDashboard.Text = "Return to Dashboard";
            BtnReturnDashboard.UseVisualStyleBackColor = true;
            BtnReturnDashboard.Click += BtnReturnDashboard_Click;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(181, 529);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(247, 27);
            txtCustomerID.TabIndex = 22;
            txtCustomerID.TextChanged += txtCustomerID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 106);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 25;
            label1.Text = "Search Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(459, 44);
            label2.Name = "label2";
            label2.Size = new Size(359, 38);
            label2.TabIndex = 26;
            label2.Text = "CHECK OUT LABORATORY";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(522, 103);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(247, 27);
            txtSearchName.TabIndex = 27;
            txtSearchName.KeyDown += txtSearchName_KeyDown;
            // 
            // BtnCheckOutNow
            // 
            BtnCheckOutNow.Location = new Point(950, 529);
            BtnCheckOutNow.Name = "BtnCheckOutNow";
            BtnCheckOutNow.Size = new Size(179, 56);
            BtnCheckOutNow.TabIndex = 28;
            BtnCheckOutNow.Text = "Check out now";
            BtnCheckOutNow.UseVisualStyleBackColor = true;
            BtnCheckOutNow.Click += BtnCheckOutNow_Click;
            // 
            // dgvCheckOut
            // 
            dgvCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckOut.Location = new Point(102, 165);
            dgvCheckOut.Name = "dgvCheckOut";
            dgvCheckOut.RowHeadersWidth = 51;
            dgvCheckOut.RowTemplate.Height = 29;
            dgvCheckOut.Size = new Size(1027, 318);
            dgvCheckOut.TabIndex = 29;
            // 
            // BtnSearchName
            // 
            BtnSearchName.Location = new Point(787, 103);
            BtnSearchName.Name = "BtnSearchName";
            BtnSearchName.Size = new Size(113, 27);
            BtnSearchName.TabIndex = 30;
            BtnSearchName.Text = "Search";
            BtnSearchName.UseVisualStyleBackColor = true;
            BtnSearchName.Click += BtnSearchName_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 532);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 31;
            label3.Text = "Customer ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(497, 532);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 32;
            // 
            // txtNationalID
            // 
            txtNationalID.Location = new Point(614, 529);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.ReadOnly = true;
            txtNationalID.Size = new Size(260, 27);
            txtNationalID.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(517, 532);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 37;
            label7.Text = "National ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(522, 586);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 38;
            label8.Text = "Check Out";
            // 
            // timePickerCheckOut
            // 
            timePickerCheckOut.Location = new Point(614, 583);
            timePickerCheckOut.Name = "timePickerCheckOut";
            timePickerCheckOut.Size = new Size(260, 27);
            timePickerCheckOut.TabIndex = 39;
            // 
            // customerFeedBackBox
            // 
            customerFeedBackBox.AutoSize = true;
            customerFeedBackBox.Location = new Point(676, 633);
            customerFeedBackBox.Name = "customerFeedBackBox";
            customerFeedBackBox.Size = new Size(196, 24);
            customerFeedBackBox.TabIndex = 40;
            customerFeedBackBox.Text = "Save Customer Feedback";
            customerFeedBackBox.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(181, 583);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(247, 27);
            txtCustomerName.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 586);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 33;
            label5.Text = "Customer Name";
            // 
            // txtLabName
            // 
            txtLabName.Location = new Point(181, 633);
            txtLabName.Name = "txtLabName";
            txtLabName.ReadOnly = true;
            txtLabName.Size = new Size(247, 27);
            txtLabName.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 633);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 35;
            label6.Text = "Lab Name";
            // 
            // CheckOutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 715);
            Controls.Add(customerFeedBackBox);
            Controls.Add(timePickerCheckOut);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtNationalID);
            Controls.Add(label6);
            Controls.Add(txtLabName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnSearchName);
            Controls.Add(dgvCheckOut);
            Controls.Add(BtnCheckOutNow);
            Controls.Add(txtSearchName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnReturnDashboard);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerID);
            Name = "CheckOutForm";
            Text = "CheckOutForm";
            Load += CheckOutForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnReturnDashboard;
        private TextBox txtCustomerID;
        private Label label1;
        private Label label2;
        private TextBox txtSearchName;
        private Button BtnCheckOutNow;
        private DataGridView dgvCheckOut;
        private Button BtnSearchName;
        private Label label3;
        private Label label4;
        private TextBox txtNationalID;
        private Label label7;
        private Label label8;
        private DateTimePicker timePickerCheckOut;
        private CheckBox customerFeedBackBox;
        private TextBox txtCustomerName;
        private Label label5;
        private TextBox txtLabName;
        private Label label6;
    }
}