namespace HRApplication
{
    partial class Hourly
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
            this.firstLabel = new System.Windows.Forms.Label();
            this.lastLabel = new System.Windows.Forms.Label();
            this.adLabel = new System.Windows.Forms.Label();
            this.postLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.mobLabel = new System.Windows.Forms.Label();
            this.overLabel = new System.Windows.Forms.Label();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.postBox = new System.Windows.Forms.TextBox();
            this.hourlyBox = new System.Windows.Forms.TextBox();
            this.adBox = new System.Windows.Forms.TextBox();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.mobBox = new System.Windows.Forms.TextBox();
            this.overtimeBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(25, 33);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(60, 13);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "First Name:";
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(235, 33);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(61, 13);
            this.lastLabel.TabIndex = 1;
            this.lastLabel.Text = "Last Name:";
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(25, 76);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(48, 13);
            this.adLabel.TabIndex = 2;
            this.adLabel.Text = "Address:";
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Location = new System.Drawing.Point(25, 139);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(59, 13);
            this.postLabel.TabIndex = 3;
            this.postLabel.Text = "Post Code:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(25, 175);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(39, 13);
            this.dobLabel.TabIndex = 4;
            this.dobLabel.Text = "D.O.B:";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(25, 215);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(61, 13);
            this.hourLabel.TabIndex = 5;
            this.hourLabel.Text = "Hourly Pay:";
            // 
            // mobLabel
            // 
            this.mobLabel.AutoSize = true;
            this.mobLabel.Location = new System.Drawing.Point(255, 139);
            this.mobLabel.Name = "mobLabel";
            this.mobLabel.Size = new System.Drawing.Size(41, 13);
            this.mobLabel.TabIndex = 6;
            this.mobLabel.Text = "Mobile:";
            // 
            // overLabel
            // 
            this.overLabel.AutoSize = true;
            this.overLabel.Location = new System.Drawing.Point(230, 215);
            this.overLabel.Name = "overLabel";
            this.overLabel.Size = new System.Drawing.Size(73, 13);
            this.overLabel.TabIndex = 7;
            this.overLabel.Text = "Overtime Pay:";
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(91, 30);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(133, 20);
            this.firstBox.TabIndex = 8;
            // 
            // postBox
            // 
            this.postBox.Location = new System.Drawing.Point(90, 136);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(134, 20);
            this.postBox.TabIndex = 10;
            // 
            // hourlyBox
            // 
            this.hourlyBox.Location = new System.Drawing.Point(91, 212);
            this.hourlyBox.Name = "hourlyBox";
            this.hourlyBox.Size = new System.Drawing.Size(133, 20);
            this.hourlyBox.TabIndex = 12;
            // 
            // adBox
            // 
            this.adBox.Location = new System.Drawing.Point(91, 76);
            this.adBox.Multiline = true;
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(339, 40);
            this.adBox.TabIndex = 9;
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(302, 30);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(128, 20);
            this.lastBox.TabIndex = 13;
            // 
            // mobBox
            // 
            this.mobBox.Location = new System.Drawing.Point(302, 136);
            this.mobBox.Name = "mobBox";
            this.mobBox.Size = new System.Drawing.Size(128, 20);
            this.mobBox.TabIndex = 14;
            // 
            // overtimeBox
            // 
            this.overtimeBox.Location = new System.Drawing.Point(302, 212);
            this.overtimeBox.Name = "overtimeBox";
            this.overtimeBox.Size = new System.Drawing.Size(128, 20);
            this.overtimeBox.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(190, 267);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(319, 267);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dobPicker.Location = new System.Drawing.Point(91, 169);
            this.dobPicker.Name = "dateTimePicker1";
            this.dobPicker.Size = new System.Drawing.Size(133, 20);
            this.dobPicker.TabIndex = 18;
            // 
            // Hourly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 302);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.overtimeBox);
            this.Controls.Add(this.mobBox);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.hourlyBox);
            this.Controls.Add(this.postBox);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.overLabel);
            this.Controls.Add(this.mobLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.adLabel);
            this.Controls.Add(this.lastLabel);
            this.Controls.Add(this.firstLabel);
            this.Name = "Hourly";
            this.Text = "Hourly Employee Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label mobLabel;
        private System.Windows.Forms.Label overLabel;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox postBox;
        private System.Windows.Forms.TextBox hourlyBox;
        private System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.TextBox mobBox;
        private System.Windows.Forms.TextBox overtimeBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker dobPicker;
    }
}