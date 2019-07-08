namespace StockManagementSystemApp
{
    partial class CompanyUi
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
            this.CompanyUiGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.companyUiTextBox = new System.Windows.Forms.TextBox();
            this.CompanyUiButton = new System.Windows.Forms.Button();
            this.CompanyUiDataGridView = new System.Windows.Forms.DataGridView();
            this.CompanyUiGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyUiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyUiGroupBox
            // 
            this.CompanyUiGroupBox.Controls.Add(this.CompanyUiDataGridView);
            this.CompanyUiGroupBox.Controls.Add(this.CompanyUiButton);
            this.CompanyUiGroupBox.Controls.Add(this.companyUiTextBox);
            this.CompanyUiGroupBox.Controls.Add(this.label1);
            this.CompanyUiGroupBox.Location = new System.Drawing.Point(38, 41);
            this.CompanyUiGroupBox.Name = "CompanyUiGroupBox";
            this.CompanyUiGroupBox.Size = new System.Drawing.Size(698, 361);
            this.CompanyUiGroupBox.TabIndex = 0;
            this.CompanyUiGroupBox.TabStop = false;
            this.CompanyUiGroupBox.Text = "Company Setup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // companyUiTextBox
            // 
            this.companyUiTextBox.Location = new System.Drawing.Point(246, 59);
            this.companyUiTextBox.Name = "companyUiTextBox";
            this.companyUiTextBox.Size = new System.Drawing.Size(164, 20);
            this.companyUiTextBox.TabIndex = 1;
            // 
            // CompanyUiButton
            // 
            this.CompanyUiButton.Location = new System.Drawing.Point(335, 97);
            this.CompanyUiButton.Name = "CompanyUiButton";
            this.CompanyUiButton.Size = new System.Drawing.Size(75, 23);
            this.CompanyUiButton.TabIndex = 2;
            this.CompanyUiButton.Text = "Save";
            this.CompanyUiButton.UseVisualStyleBackColor = true;
            this.CompanyUiButton.Click += new System.EventHandler(this.CompanyUiButton_Click);
            // 
            // CompanyUiDataGridView
            // 
            this.CompanyUiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyUiDataGridView.Location = new System.Drawing.Point(161, 160);
            this.CompanyUiDataGridView.Name = "CompanyUiDataGridView";
            this.CompanyUiDataGridView.Size = new System.Drawing.Size(313, 150);
            this.CompanyUiDataGridView.TabIndex = 3;
            // 
            // CompanyUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompanyUiGroupBox);
            this.Name = "CompanyUi";
            this.Text = "CompanyUi";
            this.Load += new System.EventHandler(this.CompanyUi_Load);
            this.CompanyUiGroupBox.ResumeLayout(false);
            this.CompanyUiGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyUiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CompanyUiGroupBox;
        private System.Windows.Forms.DataGridView CompanyUiDataGridView;
        private System.Windows.Forms.Button CompanyUiButton;
        private System.Windows.Forms.TextBox companyUiTextBox;
        private System.Windows.Forms.Label label1;
    }
}