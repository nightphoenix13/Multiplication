namespace Multiplication
{
    partial class Form1
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.outputLabel3 = new System.Windows.Forms.Label();
            this.outputLabel4 = new System.Windows.Forms.Label();
            this.outputLabel5 = new System.Windows.Forms.Label();
            this.outputLabel6 = new System.Windows.Forms.Label();
            this.outputLabel7 = new System.Windows.Forms.Label();
            this.outputLabel8 = new System.Windows.Forms.Label();
            this.outputLabel9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(72, 21);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(85, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Enter an integer:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(163, 18);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(102, 54);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // outputLabel1
            // 
            this.outputLabel1.AutoSize = true;
            this.outputLabel1.Location = new System.Drawing.Point(110, 100);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(50, 13);
            this.outputLabel1.TabIndex = 3;
            this.outputLabel1.Text = "# x 2 = #";
            this.outputLabel1.Visible = false;
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.Location = new System.Drawing.Point(110, 115);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(50, 13);
            this.outputLabel2.TabIndex = 4;
            this.outputLabel2.Text = "# x 3 = #";
            this.outputLabel2.Visible = false;
            // 
            // outputLabel3
            // 
            this.outputLabel3.AutoSize = true;
            this.outputLabel3.Location = new System.Drawing.Point(110, 130);
            this.outputLabel3.Name = "outputLabel3";
            this.outputLabel3.Size = new System.Drawing.Size(50, 13);
            this.outputLabel3.TabIndex = 5;
            this.outputLabel3.Text = "# x 4 = #";
            this.outputLabel3.Visible = false;
            // 
            // outputLabel4
            // 
            this.outputLabel4.AutoSize = true;
            this.outputLabel4.Location = new System.Drawing.Point(110, 145);
            this.outputLabel4.Name = "outputLabel4";
            this.outputLabel4.Size = new System.Drawing.Size(50, 13);
            this.outputLabel4.TabIndex = 6;
            this.outputLabel4.Text = "# x 5 = #";
            this.outputLabel4.Visible = false;
            // 
            // outputLabel5
            // 
            this.outputLabel5.AutoSize = true;
            this.outputLabel5.Location = new System.Drawing.Point(110, 160);
            this.outputLabel5.Name = "outputLabel5";
            this.outputLabel5.Size = new System.Drawing.Size(50, 13);
            this.outputLabel5.TabIndex = 7;
            this.outputLabel5.Text = "# x 6 = #";
            this.outputLabel5.Visible = false;
            // 
            // outputLabel6
            // 
            this.outputLabel6.AutoSize = true;
            this.outputLabel6.Location = new System.Drawing.Point(110, 175);
            this.outputLabel6.Name = "outputLabel6";
            this.outputLabel6.Size = new System.Drawing.Size(50, 13);
            this.outputLabel6.TabIndex = 8;
            this.outputLabel6.Text = "# x 7 = #";
            this.outputLabel6.Visible = false;
            // 
            // outputLabel7
            // 
            this.outputLabel7.AutoSize = true;
            this.outputLabel7.Location = new System.Drawing.Point(110, 190);
            this.outputLabel7.Name = "outputLabel7";
            this.outputLabel7.Size = new System.Drawing.Size(50, 13);
            this.outputLabel7.TabIndex = 9;
            this.outputLabel7.Text = "# x 8 = #";
            this.outputLabel7.Visible = false;
            // 
            // outputLabel8
            // 
            this.outputLabel8.AutoSize = true;
            this.outputLabel8.Location = new System.Drawing.Point(110, 205);
            this.outputLabel8.Name = "outputLabel8";
            this.outputLabel8.Size = new System.Drawing.Size(50, 13);
            this.outputLabel8.TabIndex = 10;
            this.outputLabel8.Text = "# x 9 = #";
            this.outputLabel8.Visible = false;
            // 
            // outputLabel9
            // 
            this.outputLabel9.AutoSize = true;
            this.outputLabel9.Location = new System.Drawing.Point(110, 220);
            this.outputLabel9.Name = "outputLabel9";
            this.outputLabel9.Size = new System.Drawing.Size(56, 13);
            this.outputLabel9.TabIndex = 11;
            this.outputLabel9.Text = "# x 10 = #";
            this.outputLabel9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.outputLabel9);
            this.Controls.Add(this.outputLabel8);
            this.Controls.Add(this.outputLabel7);
            this.Controls.Add(this.outputLabel6);
            this.Controls.Add(this.outputLabel5);
            this.Controls.Add(this.outputLabel4);
            this.Controls.Add(this.outputLabel3);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.infoLabel);
            this.Name = "Form1";
            this.Text = "Multiplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Label outputLabel3;
        private System.Windows.Forms.Label outputLabel4;
        private System.Windows.Forms.Label outputLabel5;
        private System.Windows.Forms.Label outputLabel6;
        private System.Windows.Forms.Label outputLabel7;
        private System.Windows.Forms.Label outputLabel8;
        private System.Windows.Forms.Label outputLabel9;
    }
}

