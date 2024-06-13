﻿namespace Team1CMPT291_Final
{
    partial class AddCarForm
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
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.VIN_Box = new System.Windows.Forms.RichTextBox();
            this.Plate_Box = new System.Windows.Forms.RichTextBox();
            this.Make_Box = new System.Windows.Forms.RichTextBox();
            this.Model_Box = new System.Windows.Forms.RichTextBox();
            this.Transmission_Box = new System.Windows.Forms.RichTextBox();
            this.label_VIN = new System.Windows.Forms.Label();
            this.label_LicencePlate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox_Type = new System.Windows.Forms.ComboBox();
            this.ComboBox_Branch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.Color.Lime;
            this.Save_Button.Location = new System.Drawing.Point(160, 546);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(281, 97);
            this.Save_Button.TabIndex = 15;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.Red;
            this.Cancel_Button.Location = new System.Drawing.Point(618, 546);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(281, 97);
            this.Cancel_Button.TabIndex = 16;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // VIN_Box
            // 
            this.VIN_Box.AccessibleDescription = "Enter VIN number";
            this.VIN_Box.AccessibleName = "VIN_Box";
            this.VIN_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIN_Box.Location = new System.Drawing.Point(29, 89);
            this.VIN_Box.MaxLength = 17;
            this.VIN_Box.Multiline = false;
            this.VIN_Box.Name = "VIN_Box";
            this.VIN_Box.Size = new System.Drawing.Size(333, 62);
            this.VIN_Box.TabIndex = 8;
            this.VIN_Box.Text = "";
            this.VIN_Box.TextChanged += new System.EventHandler(this.VIN_Box_TextChanged);
            // 
            // Plate_Box
            // 
            this.Plate_Box.AccessibleDescription = "Enter Plate number";
            this.Plate_Box.AccessibleName = "Licence_Plate_Box";
            this.Plate_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Plate_Box.Location = new System.Drawing.Point(29, 210);
            this.Plate_Box.MaxLength = 20;
            this.Plate_Box.Multiline = false;
            this.Plate_Box.Name = "Plate_Box";
            this.Plate_Box.Size = new System.Drawing.Size(333, 62);
            this.Plate_Box.TabIndex = 9;
            this.Plate_Box.Text = "";
            // 
            // Make_Box
            // 
            this.Make_Box.AccessibleDescription = "Enter Make";
            this.Make_Box.AccessibleName = "Make_Name";
            this.Make_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Make_Box.Location = new System.Drawing.Point(29, 331);
            this.Make_Box.MaxLength = 50;
            this.Make_Box.Multiline = false;
            this.Make_Box.Name = "Make_Box";
            this.Make_Box.Size = new System.Drawing.Size(333, 62);
            this.Make_Box.TabIndex = 10;
            this.Make_Box.Text = "";
            // 
            // Model_Box
            // 
            this.Model_Box.AccessibleDescription = "Enter Model";
            this.Model_Box.AccessibleName = "Model_Box";
            this.Model_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Model_Box.Location = new System.Drawing.Point(29, 452);
            this.Model_Box.MaxLength = 50;
            this.Model_Box.Multiline = false;
            this.Model_Box.Name = "Model_Box";
            this.Model_Box.Size = new System.Drawing.Size(333, 62);
            this.Model_Box.TabIndex = 11;
            this.Model_Box.Text = "";
            // 
            // Transmission_Box
            // 
            this.Transmission_Box.AccessibleDescription = "Enter Transmission";
            this.Transmission_Box.AccessibleName = "Transmission_Box";
            this.Transmission_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Transmission_Box.Location = new System.Drawing.Point(455, 89);
            this.Transmission_Box.MaxLength = 50;
            this.Transmission_Box.Multiline = false;
            this.Transmission_Box.Name = "Transmission_Box";
            this.Transmission_Box.Size = new System.Drawing.Size(333, 62);
            this.Transmission_Box.TabIndex = 12;
            this.Transmission_Box.Text = "";
            // 
            // label_VIN
            // 
            this.label_VIN.AutoSize = true;
            this.label_VIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VIN.Location = new System.Drawing.Point(24, 47);
            this.label_VIN.Name = "label_VIN";
            this.label_VIN.Size = new System.Drawing.Size(58, 29);
            this.label_VIN.TabIndex = 17;
            this.label_VIN.Text = "VIN:";
            // 
            // label_LicencePlate
            // 
            this.label_LicencePlate.AutoSize = true;
            this.label_LicencePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LicencePlate.Location = new System.Drawing.Point(24, 168);
            this.label_LicencePlate.Name = "label_LicencePlate";
            this.label_LicencePlate.Size = new System.Drawing.Size(164, 29);
            this.label_LicencePlate.TabIndex = 18;
            this.label_LicencePlate.Text = "License Plate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Transmission:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Branch_ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Type:";
            // 
            // ComboBox_Type
            // 
            this.ComboBox_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Type.FormattingEnabled = true;
            this.ComboBox_Type.Location = new System.Drawing.Point(455, 331);
            this.ComboBox_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_Type.Name = "ComboBox_Type";
            this.ComboBox_Type.Size = new System.Drawing.Size(333, 37);
            this.ComboBox_Type.TabIndex = 24;
            // 
            // ComboBox_Branch
            // 
            this.ComboBox_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Branch.FormattingEnabled = true;
            this.ComboBox_Branch.Location = new System.Drawing.Point(455, 210);
            this.ComboBox_Branch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_Branch.Name = "ComboBox_Branch";
            this.ComboBox_Branch.Size = new System.Drawing.Size(333, 37);
            this.ComboBox_Branch.TabIndex = 25;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 709);
            this.Controls.Add(this.ComboBox_Branch);
            this.Controls.Add(this.ComboBox_Type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_LicencePlate);
            this.Controls.Add(this.label_VIN);
            this.Controls.Add(this.Transmission_Box);
            this.Controls.Add(this.Model_Box);
            this.Controls.Add(this.Make_Box);
            this.Controls.Add(this.Plate_Box);
            this.Controls.Add(this.VIN_Box);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.RichTextBox VIN_Box;
        private System.Windows.Forms.RichTextBox Plate_Box;
        private System.Windows.Forms.RichTextBox Make_Box;
        private System.Windows.Forms.RichTextBox Model_Box;
        private System.Windows.Forms.RichTextBox Transmission_Box;
        private System.Windows.Forms.Label label_VIN;
        private System.Windows.Forms.Label label_LicencePlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBox_Type;
        private System.Windows.Forms.ComboBox ComboBox_Branch;
    }
}