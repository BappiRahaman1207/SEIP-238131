namespace MobileApps
{
    partial class Home
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
            this.imeiButton = new System.Windows.Forms.Button();
            this.PiceRangeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imeiButton);
            this.groupBox1.Controls.Add(this.PiceRangeButton);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index";
            // 
            // imeiButton
            // 
            this.imeiButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeiButton.Location = new System.Drawing.Point(143, 252);
            this.imeiButton.Name = "imeiButton";
            this.imeiButton.Size = new System.Drawing.Size(333, 40);
            this.imeiButton.TabIndex = 1;
            this.imeiButton.Text = "Search Mobile Handset by IMEI";
            this.imeiButton.UseVisualStyleBackColor = true;
            // 
            // PiceRangeButton
            // 
            this.PiceRangeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiceRangeButton.Location = new System.Drawing.Point(143, 165);
            this.PiceRangeButton.Name = "PiceRangeButton";
            this.PiceRangeButton.Size = new System.Drawing.Size(333, 40);
            this.PiceRangeButton.TabIndex = 2;
            this.PiceRangeButton.Text = "Search Mobile Handset by Price Range";
            this.PiceRangeButton.UseVisualStyleBackColor = true;
            this.PiceRangeButton.Click += new System.EventHandler(this.PiceRangeButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(143, 88);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(333, 40);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save Mobile Handset Information";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "MENU";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button imeiButton;
        private System.Windows.Forms.Button PiceRangeButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

