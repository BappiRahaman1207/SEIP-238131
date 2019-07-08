namespace StockManagementSystemApp
{
    partial class CategoryUi
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
            this.CategoryUiGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CategorySetupTextBox = new System.Windows.Forms.TextBox();
            this.CategorySetupDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CategoryUiGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategorySetupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryUiGroupBox
            // 
            this.CategoryUiGroupBox.Controls.Add(this.SaveButton);
            this.CategoryUiGroupBox.Controls.Add(this.CategorySetupDataGridView);
            this.CategoryUiGroupBox.Controls.Add(this.CategorySetupTextBox);
            this.CategoryUiGroupBox.Controls.Add(this.label1);
            this.CategoryUiGroupBox.Location = new System.Drawing.Point(81, 58);
            this.CategoryUiGroupBox.Name = "CategoryUiGroupBox";
            this.CategoryUiGroupBox.Size = new System.Drawing.Size(639, 353);
            this.CategoryUiGroupBox.TabIndex = 0;
            this.CategoryUiGroupBox.TabStop = false;
            this.CategoryUiGroupBox.Text = "Category Setup ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CategorySetupTextBox
            // 
            this.CategorySetupTextBox.Location = new System.Drawing.Point(165, 73);
            this.CategorySetupTextBox.Name = "CategorySetupTextBox";
            this.CategorySetupTextBox.Size = new System.Drawing.Size(135, 20);
            this.CategorySetupTextBox.TabIndex = 1;
            // 
            // CategorySetupDataGridView
            // 
            this.CategorySetupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategorySetupDataGridView.Location = new System.Drawing.Point(86, 148);
            this.CategorySetupDataGridView.Name = "CategorySetupDataGridView";
            this.CategorySetupDataGridView.Size = new System.Drawing.Size(330, 150);
            this.CategorySetupDataGridView.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(225, 108);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryUiGroupBox);
            this.Name = "CategoryUi";
            this.Text = "CategoryUi";
            this.Load += new System.EventHandler(this.CategoryUi_Load);
            this.CategoryUiGroupBox.ResumeLayout(false);
            this.CategoryUiGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategorySetupDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CategoryUiGroupBox;
        private System.Windows.Forms.DataGridView CategorySetupDataGridView;
        private System.Windows.Forms.TextBox CategorySetupTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
    }
}