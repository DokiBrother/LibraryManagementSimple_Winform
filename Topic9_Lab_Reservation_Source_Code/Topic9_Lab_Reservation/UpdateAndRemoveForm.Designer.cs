namespace Topic9_Lab_Reservation
{
    partial class UpdateAndRemoveForm
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
            BtnUpdateLab = new Button();
            dgvUpdateRemoveLab = new DataGridView();
            txtLabPrice = new TextBox();
            label4 = new Label();
            txtLabName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            BtnReturnDashboard = new Button();
            cblabSpecialization = new ComboBox();
            label1 = new Label();
            txtLabID = new TextBox();
            label5 = new Label();
            BtnRemoveLab = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateRemoveLab).BeginInit();
            SuspendLayout();
            // 
            // BtnUpdateLab
            // 
            BtnUpdateLab.Location = new Point(875, 367);
            BtnUpdateLab.Name = "BtnUpdateLab";
            BtnUpdateLab.Size = new Size(119, 43);
            BtnUpdateLab.TabIndex = 19;
            BtnUpdateLab.Text = "Update";
            BtnUpdateLab.UseVisualStyleBackColor = true;
            BtnUpdateLab.Click += BtnUpdateLab_Click;
            // 
            // dgvUpdateRemoveLab
            // 
            dgvUpdateRemoveLab.AllowUserToAddRows = false;
            dgvUpdateRemoveLab.AllowUserToDeleteRows = false;
            dgvUpdateRemoveLab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateRemoveLab.Location = new Point(28, 100);
            dgvUpdateRemoveLab.Name = "dgvUpdateRemoveLab";
            dgvUpdateRemoveLab.ReadOnly = true;
            dgvUpdateRemoveLab.RowHeadersWidth = 51;
            dgvUpdateRemoveLab.RowTemplate.Height = 29;
            dgvUpdateRemoveLab.Size = new Size(673, 377);
            dgvUpdateRemoveLab.TabIndex = 18;
            // 
            // txtLabPrice
            // 
            txtLabPrice.Location = new Point(741, 321);
            txtLabPrice.Name = "txtLabPrice";
            txtLabPrice.Size = new Size(254, 27);
            txtLabPrice.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(738, 298);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 16;
            label4.Text = "Price";
            // 
            // txtLabName
            // 
            txtLabName.Location = new Point(740, 191);
            txtLabName.Name = "txtLabName";
            txtLabName.Size = new Size(254, 27);
            txtLabName.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(737, 232);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 14;
            label3.Text = "Specialization";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(736, 168);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 13;
            label2.Text = "Lab Name";
            // 
            // BtnReturnDashboard
            // 
            BtnReturnDashboard.Location = new Point(741, 427);
            BtnReturnDashboard.Name = "BtnReturnDashboard";
            BtnReturnDashboard.Size = new Size(254, 43);
            BtnReturnDashboard.TabIndex = 12;
            BtnReturnDashboard.Text = "Return to Dashboard";
            BtnReturnDashboard.UseVisualStyleBackColor = true;
            BtnReturnDashboard.Click += BtnReturnDashboard_Click;
            // 
            // cblabSpecialization
            // 
            cblabSpecialization.FormattingEnabled = true;
            cblabSpecialization.Items.AddRange(new object[] { "Agriculture", "Astronomy", "Biology", "Biochemistry", "Biophysics", "Cellular biology", "Chemistry", "Computer Science", "Earth science", "Ecology", "Genetics", "Kinesiology", "Meteorology", "Microbiology", "Physical science ", "Physics", "Zoology" });
            cblabSpecialization.Location = new Point(741, 255);
            cblabSpecialization.Name = "cblabSpecialization";
            cblabSpecialization.Size = new Size(254, 28);
            cblabSpecialization.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 24);
            label1.Name = "label1";
            label1.Size = new Size(261, 38);
            label1.TabIndex = 10;
            label1.Text = "LABORATORY LIST";
            // 
            // txtLabID
            // 
            txtLabID.Location = new Point(741, 126);
            txtLabID.Name = "txtLabID";
            txtLabID.Size = new Size(254, 27);
            txtLabID.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(737, 103);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 20;
            label5.Text = "Lab ID";
            // 
            // BtnRemoveLab
            // 
            BtnRemoveLab.BackColor = Color.Red;
            BtnRemoveLab.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRemoveLab.ForeColor = SystemColors.ButtonFace;
            BtnRemoveLab.Location = new Point(741, 367);
            BtnRemoveLab.Name = "BtnRemoveLab";
            BtnRemoveLab.Size = new Size(119, 43);
            BtnRemoveLab.TabIndex = 22;
            BtnRemoveLab.Text = "Remove";
            BtnRemoveLab.UseVisualStyleBackColor = false;
            BtnRemoveLab.Click += BtnRemoveLab_Click;
            // 
            // UpdateAndRemoveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 547);
            Controls.Add(BtnRemoveLab);
            Controls.Add(txtLabID);
            Controls.Add(label5);
            Controls.Add(BtnUpdateLab);
            Controls.Add(dgvUpdateRemoveLab);
            Controls.Add(txtLabPrice);
            Controls.Add(label4);
            Controls.Add(txtLabName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnReturnDashboard);
            Controls.Add(cblabSpecialization);
            Controls.Add(label1);
            Name = "UpdateAndRemoveForm";
            Text = "UpdateAndRemoveForm";
            Load += UpdateAndRemoveForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUpdateRemoveLab).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnUpdateLab;
        private DataGridView dgvUpdateRemoveLab;
        private TextBox txtLabPrice;
        private Label label4;
        private TextBox txtLabName;
        private Label label3;
        private Label label2;
        private Button BtnReturnDashboard;
        private ComboBox cblabSpecialization;
        private Label label1;
        private TextBox txtLabID;
        private Label label5;
        private Button BtnRemoveLab;
    }
}