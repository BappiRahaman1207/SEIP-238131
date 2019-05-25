namespace ArraySum
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
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.numbeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(242, 72);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(274, 180);
            this.showRichTextBox.TabIndex = 0;
            this.showRichTextBox.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(415, 277);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // numbeTextBox
            // 
            this.numbeTextBox.Location = new System.Drawing.Point(259, 279);
            this.numbeTextBox.Name = "numbeTextBox";
            this.numbeTextBox.Size = new System.Drawing.Size(140, 20);
            this.numbeTextBox.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numbeTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.showRichTextBox);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox numbeTextBox;
    }
}

