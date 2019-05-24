namespace ArrayApps
{
    partial class Array
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
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(174, 78);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(327, 193);
            this.showRichTextBox.TabIndex = 0;
            this.showRichTextBox.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(202, 313);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 33);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(325, 313);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(83, 33);
            this.ReverseButton.TabIndex = 2;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.showRichTextBox);
            this.Name = "Array";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReverseButton;
    }
}

