namespace Topic9_Lab_Reservation
{
    partial class CustomerFeedback
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
            label2 = new Label();
            txtTitle = new RichTextBox();
            txtContent = new RichTextBox();
            cbProblemType = new ComboBox();
            BtnSaveFeedback = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(215, 36);
            label2.Name = "label2";
            label2.Size = new Size(313, 38);
            label2.TabIndex = 27;
            label2.Text = "CUSTOMER FEEDBACK";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(80, 156);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(563, 35);
            txtTitle.TabIndex = 28;
            txtTitle.Text = "Customer Problem Title";
            txtTitle.MouseClick += txtTitle_MouseClick;
            txtTitle.Leave += txtTitle_Leave;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(81, 212);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(563, 439);
            txtContent.TabIndex = 29;
            txtContent.Text = "Detail the problem";
            txtContent.MouseClick += txtContent_MouseClick;
            txtContent.Leave += txtContent_Leave;
            // 
            // cbProblemType
            // 
            cbProblemType.FormattingEnabled = true;
            cbProblemType.Items.AddRange(new object[] { "On research equipment and machinery", "About location and working environment", "Having problems with prepared research objects", "Staff attitude and service expertise", "Price compared to facilities", "Others" });
            cbProblemType.Location = new Point(80, 111);
            cbProblemType.Name = "cbProblemType";
            cbProblemType.Size = new Size(563, 28);
            cbProblemType.TabIndex = 30;
            // 
            // BtnSaveFeedback
            // 
            BtnSaveFeedback.Location = new Point(260, 671);
            BtnSaveFeedback.Name = "BtnSaveFeedback";
            BtnSaveFeedback.Size = new Size(202, 49);
            BtnSaveFeedback.TabIndex = 31;
            BtnSaveFeedback.Text = "Save";
            BtnSaveFeedback.UseVisualStyleBackColor = true;
            BtnSaveFeedback.Click += BtnSaveFeedback_Click;
            // 
            // CustomerFeedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 747);
            Controls.Add(BtnSaveFeedback);
            Controls.Add(cbProblemType);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Name = "CustomerFeedback";
            Text = "CustomerFeedback";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private RichTextBox txtTitle;
        private RichTextBox txtContent;
        private ComboBox cbProblemType;
        private Button BtnSaveFeedback;
    }
}