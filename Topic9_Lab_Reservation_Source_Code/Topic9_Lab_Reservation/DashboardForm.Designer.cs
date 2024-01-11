namespace Topic9_Lab_Reservation
{
    partial class DashboardForm
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
            BtnAddLab = new Button();
            label1 = new Label();
            BtnCustomerRegistration = new Button();
            BtnCheckOut = new Button();
            BtnCustomerDetail = new Button();
            BtnExit = new Button();
            BtnUpdateLab = new Button();
            SuspendLayout();
            // 
            // BtnAddLab
            // 
            BtnAddLab.Location = new Point(104, 112);
            BtnAddLab.Name = "BtnAddLab";
            BtnAddLab.Size = new Size(256, 63);
            BtnAddLab.TabIndex = 0;
            BtnAddLab.Text = "Add LAB";
            BtnAddLab.UseVisualStyleBackColor = true;
            BtnAddLab.Click += BtnAddRoom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(201, 36);
            label1.Name = "label1";
            label1.Size = new Size(414, 38);
            label1.TabIndex = 1;
            label1.Text = "LAB RESERVATION MANAGER";
            // 
            // BtnCustomerRegistration
            // 
            BtnCustomerRegistration.Location = new Point(441, 112);
            BtnCustomerRegistration.Name = "BtnCustomerRegistration";
            BtnCustomerRegistration.Size = new Size(256, 63);
            BtnCustomerRegistration.TabIndex = 2;
            BtnCustomerRegistration.Text = "Customer Registration";
            BtnCustomerRegistration.UseVisualStyleBackColor = true;
            BtnCustomerRegistration.Click += BtnCustomerRegistration_Click;
            // 
            // BtnCheckOut
            // 
            BtnCheckOut.Location = new Point(441, 190);
            BtnCheckOut.Name = "BtnCheckOut";
            BtnCheckOut.Size = new Size(256, 63);
            BtnCheckOut.TabIndex = 3;
            BtnCheckOut.Text = "Check Out";
            BtnCheckOut.UseVisualStyleBackColor = true;
            BtnCheckOut.Click += BtnCheckOut_Click;
            // 
            // BtnCustomerDetail
            // 
            BtnCustomerDetail.Location = new Point(441, 273);
            BtnCustomerDetail.Name = "BtnCustomerDetail";
            BtnCustomerDetail.Size = new Size(256, 63);
            BtnCustomerDetail.TabIndex = 4;
            BtnCustomerDetail.Text = "Customer Detail";
            BtnCustomerDetail.UseVisualStyleBackColor = true;
            BtnCustomerDetail.Click += BtnCustomerDetail_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(651, 385);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(122, 38);
            BtnExit.TabIndex = 6;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnUpdateLab
            // 
            BtnUpdateLab.Location = new Point(104, 190);
            BtnUpdateLab.Name = "BtnUpdateLab";
            BtnUpdateLab.Size = new Size(256, 63);
            BtnUpdateLab.TabIndex = 7;
            BtnUpdateLab.Text = "Update/Remove LAB";
            BtnUpdateLab.UseVisualStyleBackColor = true;
            BtnUpdateLab.Click += BtnUpdateLab_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnUpdateLab);
            Controls.Add(BtnExit);
            Controls.Add(BtnCustomerDetail);
            Controls.Add(BtnCheckOut);
            Controls.Add(BtnCustomerRegistration);
            Controls.Add(label1);
            Controls.Add(BtnAddLab);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAddLab;
        private Label label1;
        private Button BtnCustomerRegistration;
        private Button BtnCheckOut;
        private Button BtnCustomerDetail;
        private Button BtnExit;
        private Button BtnUpdateLab;
    }
}