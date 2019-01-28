namespace HRApplication
{
    partial class Salaried2
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
            this.lastName = new System.Windows.Forms.Label();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.adBox = new System.Windows.Forms.TextBox();
            this.adLabel = new System.Windows.Forms.Label();
            this.postLabel = new System.Windows.Forms.Label();
            this.mobLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.annualLabel = new System.Windows.Forms.Label();
            this.postBox = new System.Windows.Forms.TextBox();
            this.mobBox = new System.Windows.Forms.TextBox();
            this.annualBox = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(13, 23);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(64, 13);
            this.lastName.TabIndex = 0;
            this.lastName.Text = "Last Name: ";
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(83, 20);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(100, 20);
            this.lastBox.TabIndex = 1;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(245, 23);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(60, 13);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "First Name:";
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(311, 20);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(100, 20);
            this.firstBox.TabIndex = 3;
            // 
            // adBox
            // 
            this.adBox.Location = new System.Drawing.Point(83, 63);
            this.adBox.Multiline = true;
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(328, 50);
            this.adBox.TabIndex = 4;
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(13, 63);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(48, 13);
            this.adLabel.TabIndex = 5;
            this.adLabel.Text = "Address:";
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Location = new System.Drawing.Point(16, 141);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(59, 13);
            this.postLabel.TabIndex = 6;
            this.postLabel.Text = "Post Code:";
            // 
            // mobLabel
            // 
            this.mobLabel.AutoSize = true;
            this.mobLabel.Location = new System.Drawing.Point(248, 141);
            this.mobLabel.Name = "mobLabel";
            this.mobLabel.Size = new System.Drawing.Size(41, 13);
            this.mobLabel.TabIndex = 7;
            this.mobLabel.Text = "Mobile:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(19, 185);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(39, 13);
            this.dobLabel.TabIndex = 8;
            this.dobLabel.Text = "D.O.B:";
            // 
            // annualLabel
            // 
            this.annualLabel.AutoSize = true;
            this.annualLabel.Location = new System.Drawing.Point(251, 185);
            this.annualLabel.Name = "annualLabel";
            this.annualLabel.Size = new System.Drawing.Size(75, 13);
            this.annualLabel.TabIndex = 9;
            this.annualLabel.Text = "Annual Salary:";
            // 
            // postBox
            // 
            this.postBox.Location = new System.Drawing.Point(83, 134);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(100, 20);
            this.postBox.TabIndex = 10;
            // 
            // mobBox
            // 
            this.mobBox.Location = new System.Drawing.Point(295, 134);
            this.mobBox.Name = "mobBox";
            this.mobBox.Size = new System.Drawing.Size(100, 20);
            this.mobBox.TabIndex = 11;
            // 
            // annualBox
            // 
            this.annualBox.Location = new System.Drawing.Point(332, 182);
            this.annualBox.Name = "annualBox";
            this.annualBox.Size = new System.Drawing.Size(100, 20);
            this.annualBox.TabIndex = 13;
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(83, 179);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(136, 20);
            this.dobPicker.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(143, 236);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(284, 236);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Salaried2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 271);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.annualBox);
            this.Controls.Add(this.mobBox);
            this.Controls.Add(this.postBox);
            this.Controls.Add(this.annualLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.mobLabel);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.adLabel);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.lastName);
            this.Name = "Salaried2";
            this.Text = "Salaried Employee Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Label mobLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label annualLabel;
        private System.Windows.Forms.TextBox postBox;
        private System.Windows.Forms.TextBox mobBox;
        private System.Windows.Forms.TextBox annualBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}