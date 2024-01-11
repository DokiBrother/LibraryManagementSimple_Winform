namespace Topic9_Lab_Reservation
{
    partial class AddLabForm
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
            cblabSpecialization = new ComboBox();
            BtnReturnDashboard = new Button();
            label2 = new Label();
            label3 = new Label();
            txtLabName = new TextBox();
            label4 = new Label();
            txtLabPrice = new TextBox();
            dgvAddLab = new DataGridView();
            BtnAddLab = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAddLab).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(231, 23);
            label1.Name = "label1";
            label1.Size = new Size(261, 38);
            label1.TabIndex = 0;
            label1.Text = "LABORATORY LIST";
            // 
            // cblabSpecialization
            // 
            cblabSpecialization.FormattingEnabled = true;
            cblabSpecialization.Items.AddRange(new object[] { "Agriculture", "Astronomy", "Biology", "Biochemistry", "Biophysics", "Cellular biology", "Chemistry", "Computer Science", "Earth science", "Ecology", "Genetics", "Kinesiology", "Meteorology", "Microbiology", "Physical science ", "Physics", "Zoology" });
            cblabSpecialization.Location = new Point(748, 205);
            cblabSpecialization.Name = "cblabSpecialization";
            cblabSpecialization.Size = new Size(254, 28);
            cblabSpecialization.TabIndex = 1;
            // 
            // BtnReturnDashboard
            // 
            BtnReturnDashboard.Location = new Point(748, 377);
            BtnReturnDashboard.Name = "BtnReturnDashboard";
            BtnReturnDashboard.Size = new Size(254, 43);
            BtnReturnDashboard.TabIndex = 2;
            BtnReturnDashboard.Text = "Return to Dashboard";
            BtnReturnDashboard.UseVisualStyleBackColor = true;
            BtnReturnDashboard.Click += BtnReturnDashboard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(743, 118);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Lab Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(744, 182);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 4;
            label3.Text = "Specialization";
            // 
            // txtLabName
            // 
            txtLabName.Location = new Point(747, 141);
            txtLabName.Name = "txtLabName";
            txtLabName.Size = new Size(254, 27);
            txtLabName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(745, 248);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // txtLabPrice
            // 
            txtLabPrice.Location = new Point(748, 271);
            txtLabPrice.Name = "txtLabPrice";
            txtLabPrice.Size = new Size(254, 27);
            txtLabPrice.TabIndex = 7;
            // 
            // dgvAddLab
            // 
            dgvAddLab.AllowUserToAddRows = false;
            dgvAddLab.AllowUserToDeleteRows = false;
            dgvAddLab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddLab.Location = new Point(42, 84);
            dgvAddLab.Name = "dgvAddLab";
            dgvAddLab.ReadOnly = true;
            dgvAddLab.RowHeadersWidth = 51;
            dgvAddLab.RowTemplate.Height = 29;
            dgvAddLab.Size = new Size(673, 377);
            dgvAddLab.TabIndex = 8;
            // 
            // BtnAddLab
            // 
            BtnAddLab.Location = new Point(748, 320);
            BtnAddLab.Name = "BtnAddLab";
            BtnAddLab.Size = new Size(254, 43);
            BtnAddLab.TabIndex = 9;
            BtnAddLab.Text = "Add now";
            BtnAddLab.UseVisualStyleBackColor = true;
            BtnAddLab.Click += BtnAddLab_Click;
            // 
            // AddLabForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 537);
            Controls.Add(BtnAddLab);
            Controls.Add(dgvAddLab);
            Controls.Add(txtLabPrice);
            Controls.Add(label4);
            Controls.Add(txtLabName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnReturnDashboard);
            Controls.Add(cblabSpecialization);
            Controls.Add(label1);
            Name = "AddLabForm";
            Text = "AddLabForm";
            Load += AddLabForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAddLab).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cblabSpecialization;
        private Button BtnReturnDashboard;
        private Label label2;
        private Label label3;
        private TextBox txtLabName;
        private Label label4;
        private TextBox txtLabPrice;
        private DataGridView dgvAddLab;
        private Button BtnAddLab;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn labName;
        private DataGridViewTextBoxColumn labSpecialization;
        private DataGridViewTextBoxColumn labPrice;
        private DataGridViewTextBoxColumn isReversed;
    }
}