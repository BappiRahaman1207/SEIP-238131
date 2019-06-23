namespace MobileApps
{
    partial class PriceRange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DisplayDataGridView = new System.Windows.Forms.DataGridView();
            this.imeiTextBox = new System.Windows.Forms.TextBox();
            this.ImeiButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imeiTextBox);
            this.groupBox1.Controls.Add(this.DisplayDataGridView);
            this.groupBox1.Controls.Add(this.ImeiButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.secondTextBox);
            this.groupBox1.Controls.Add(this.firstTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Price Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price between";
            // 
            // firstTextBox
            // 
            this.firstTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTextBox.Location = new System.Drawing.Point(150, 89);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(100, 26);
            this.firstTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "and";
            // 
            // secondTextBox
            // 
            this.secondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTextBox.Location = new System.Drawing.Point(334, 89);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(100, 26);
            this.secondTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(452, 89);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(110, 27);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // DisplayDataGridView
            // 
            this.DisplayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayDataGridView.Location = new System.Drawing.Point(19, 153);
            this.DisplayDataGridView.Name = "DisplayDataGridView";
            this.DisplayDataGridView.Size = new System.Drawing.Size(678, 150);
            this.DisplayDataGridView.TabIndex = 3;
            // 
            // imeiTextBox
            // 
            this.imeiTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeiTextBox.Location = new System.Drawing.Point(150, 328);
            this.imeiTextBox.Name = "imeiTextBox";
            this.imeiTextBox.Size = new System.Drawing.Size(192, 29);
            this.imeiTextBox.TabIndex = 4;
            // 
            // ImeiButton
            // 
            this.ImeiButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeiButton.Location = new System.Drawing.Point(375, 328);
            this.ImeiButton.Name = "ImeiButton";
            this.ImeiButton.Size = new System.Drawing.Size(110, 27);
            this.ImeiButton.TabIndex = 2;
            this.ImeiButton.Text = "Search";
            this.ImeiButton.UseVisualStyleBackColor = true;
            this.ImeiButton.Click += new System.EventHandler(this.ImeiButton_Click);
            // 
            // PriceRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "PriceRange";
            this.Text = "Search By Price Range";
            this.Load += new System.EventHandler(this.PriceRange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeiTextBox;
        private System.Windows.Forms.DataGridView DisplayDataGridView;
        private System.Windows.Forms.Button ImeiButton;
        private System.Windows.Forms.Button SearchButton;
    }
}