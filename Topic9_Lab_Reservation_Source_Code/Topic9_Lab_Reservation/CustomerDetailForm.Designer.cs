namespace Topic9_Lab_Reservation
{
    partial class CustomerDetailForm
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
            dgvCustomerDetail = new DataGridView();
            BtnSearchName = new Button();
            txtSearchName = new TextBox();
            printCustomerDetail = new System.Drawing.Printing.PrintDocument();
            BtnPrintRaw = new Button();
            BtnPrintReport = new Button();
            BtnReturnDashboard = new Button();
            checkBoxMale = new CheckBox();
            checkBoxFemale = new CheckBox();
            checkBoxOtherGender = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            dtpDateFrom = new DateTimePicker();
            label4 = new Label();
            dtpDateTo = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPriceFrom = new TextBox();
            txtPriceTo = new TextBox();
            label8 = new Label();
            label9 = new Label();
            BtnReset = new Button();
            cbCheckedOutOnly = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(507, 23);
            label1.Name = "label1";
            label1.Size = new Size(267, 38);
            label1.TabIndex = 2;
            label1.Text = "CUSTOMER DETAIL";
            // 
            // dgvCustomerDetail
            // 
            dgvCustomerDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerDetail.Location = new Point(40, 204);
            dgvCustomerDetail.Name = "dgvCustomerDetail";
            dgvCustomerDetail.RowHeadersWidth = 51;
            dgvCustomerDetail.RowTemplate.Height = 29;
            dgvCustomerDetail.Size = new Size(1153, 377);
            dgvCustomerDetail.TabIndex = 3;
            // 
            // BtnSearchName
            // 
            BtnSearchName.Location = new Point(430, 89);
            BtnSearchName.Name = "BtnSearchName";
            BtnSearchName.Size = new Size(113, 27);
            BtnSearchName.TabIndex = 33;
            BtnSearchName.Text = "Search";
            BtnSearchName.UseVisualStyleBackColor = true;
            BtnSearchName.Click += BtnSearchName_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(167, 89);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(237, 27);
            txtSearchName.TabIndex = 32;
            txtSearchName.Enter += txtSearchName_Enter;
            // 
            // printCustomerDetail
            // 
            printCustomerDetail.DocumentName = "Customer Report";
            printCustomerDetail.PrintPage += printCustomerDetail_PrintPage;
            // 
            // BtnPrintRaw
            // 
            BtnPrintRaw.Location = new Point(784, 606);
            BtnPrintRaw.Name = "BtnPrintRaw";
            BtnPrintRaw.Size = new Size(210, 56);
            BtnPrintRaw.TabIndex = 35;
            BtnPrintRaw.Text = "Print displayed frame";
            BtnPrintRaw.UseVisualStyleBackColor = true;
            BtnPrintRaw.Click += BtnPrint_Click;
            // 
            // BtnPrintReport
            // 
            BtnPrintReport.Location = new Point(600, 606);
            BtnPrintReport.Name = "BtnPrintReport";
            BtnPrintReport.Size = new Size(166, 56);
            BtnPrintReport.TabIndex = 36;
            BtnPrintReport.Text = "Print all as Report";
            BtnPrintReport.UseVisualStyleBackColor = true;
            BtnPrintReport.Click += BtnPrintReport_Click;
            // 
            // BtnReturnDashboard
            // 
            BtnReturnDashboard.Location = new Point(1014, 606);
            BtnReturnDashboard.Name = "BtnReturnDashboard";
            BtnReturnDashboard.Size = new Size(179, 56);
            BtnReturnDashboard.TabIndex = 37;
            BtnReturnDashboard.Text = "Return to Dashboard";
            BtnReturnDashboard.UseVisualStyleBackColor = true;
            BtnReturnDashboard.Click += BtnReturnDashboard_Click;
            // 
            // checkBoxMale
            // 
            checkBoxMale.AutoSize = true;
            checkBoxMale.Location = new Point(40, 155);
            checkBoxMale.Name = "checkBoxMale";
            checkBoxMale.Size = new Size(64, 24);
            checkBoxMale.TabIndex = 38;
            checkBoxMale.Text = "Male";
            checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // checkBoxFemale
            // 
            checkBoxFemale.AutoSize = true;
            checkBoxFemale.Location = new Point(110, 155);
            checkBoxFemale.Name = "checkBoxFemale";
            checkBoxFemale.Size = new Size(79, 24);
            checkBoxFemale.TabIndex = 39;
            checkBoxFemale.Text = "Female";
            checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // checkBoxOtherGender
            // 
            checkBoxOtherGender.AutoSize = true;
            checkBoxOtherGender.Location = new Point(195, 155);
            checkBoxOtherGender.Name = "checkBoxOtherGender";
            checkBoxOtherGender.Size = new Size(68, 24);
            checkBoxOtherGender.TabIndex = 40;
            checkBoxOtherGender.Text = "Other";
            checkBoxOtherGender.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 132);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 41;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 47);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 42;
            label3.Text = "FILTER";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Location = new Point(655, 153);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(250, 27);
            dtpDateFrom.TabIndex = 43;
            dtpDateFrom.Value = new DateTime(2023, 1, 1, 0, 15, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(607, 126);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 44;
            label4.Text = "Reservation Time";
            // 
            // dtpDateTo
            // 
            dtpDateTo.Location = new Point(943, 155);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(250, 27);
            dtpDateTo.TabIndex = 45;
            dtpDateTo.Value = new DateTime(2023, 12, 29, 0, 15, 31, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(914, 158);
            label5.Name = "label5";
            label5.Size = new Size(23, 20);
            label5.TabIndex = 46;
            label5.Text = "to";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 158);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 47;
            label6.Text = "From";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(305, 132);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 48;
            label7.Text = "Lab Price";
            // 
            // txtPriceFrom
            // 
            txtPriceFrom.Location = new Point(305, 155);
            txtPriceFrom.Name = "txtPriceFrom";
            txtPriceFrom.Size = new Size(99, 27);
            txtPriceFrom.TabIndex = 49;
            // 
            // txtPriceTo
            // 
            txtPriceTo.Location = new Point(444, 155);
            txtPriceTo.Name = "txtPriceTo";
            txtPriceTo.Size = new Size(99, 27);
            txtPriceTo.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(410, 154);
            label8.Name = "label8";
            label8.Size = new Size(25, 25);
            label8.TabIndex = 51;
            label8.Text = "~";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(40, 92);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 52;
            label9.Text = "Name Contain";
            // 
            // BtnReset
            // 
            BtnReset.Location = new Point(1080, 92);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(113, 27);
            BtnReset.TabIndex = 53;
            BtnReset.Text = "Reset Filter";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // cbCheckedOutOnly
            // 
            cbCheckedOutOnly.AutoSize = true;
            cbCheckedOutOnly.Location = new Point(167, 50);
            cbCheckedOutOnly.Name = "cbCheckedOutOnly";
            cbCheckedOutOnly.Size = new Size(210, 24);
            cbCheckedOutOnly.TabIndex = 54;
            cbCheckedOutOnly.Text = "Customer checked out only";
            cbCheckedOutOnly.UseVisualStyleBackColor = true;
            // 
            // CustomerDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 704);
            Controls.Add(cbCheckedOutOnly);
            Controls.Add(BtnReset);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtPriceTo);
            Controls.Add(txtPriceFrom);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpDateTo);
            Controls.Add(label4);
            Controls.Add(dtpDateFrom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBoxOtherGender);
            Controls.Add(checkBoxFemale);
            Controls.Add(checkBoxMale);
            Controls.Add(BtnReturnDashboard);
            Controls.Add(BtnPrintReport);
            Controls.Add(BtnPrintRaw);
            Controls.Add(BtnSearchName);
            Controls.Add(txtSearchName);
            Controls.Add(dgvCustomerDetail);
            Controls.Add(label1);
            Name = "CustomerDetailForm";
            Text = "CustomerDetailForm";
            Load += CustomerDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCustomerDetail;
        private Button BtnSearchName;
        private TextBox txtSearchName;
        private System.Drawing.Printing.PrintDocument printCustomerDetail;
        private Button BtnPrintRaw;
        private Button BtnPrintReport;
        private Button BtnReturnDashboard;
        private CheckBox checkBoxMale;
        private CheckBox checkBoxFemale;
        private CheckBox checkBoxOtherGender;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDateFrom;
        private Label label4;
        private DateTimePicker dtpDateTo;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPriceFrom;
        private TextBox txtPriceTo;
        private Label label8;
        private Label label9;
        private Button BtnReset;
        private CheckBox cbCheckedOutOnly;
    }
}