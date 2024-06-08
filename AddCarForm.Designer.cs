namespace Team1CMPT291_Final
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
            this.Branch_ID_Box = new System.Windows.Forms.RichTextBox();
            this.Transmission_Box = new System.Windows.Forms.RichTextBox();
            this.Type_Box = new System.Windows.Forms.RichTextBox();
            this.VIN_Label = new System.Windows.Forms.TextBox();
            this.Licence_Plate_Label = new System.Windows.Forms.TextBox();
            this.Make_Label = new System.Windows.Forms.TextBox();
            this.Model_Label = new System.Windows.Forms.TextBox();
            this.Transmission_Label = new System.Windows.Forms.TextBox();
            this.Branch_ID_Label = new System.Windows.Forms.TextBox();
            this.Type_Label = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.Color.Lime;
            this.Save_Button.Location = new System.Drawing.Point(160, 546);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(280, 97);
            this.Save_Button.TabIndex = 0;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.Red;
            this.Cancel_Button.Location = new System.Drawing.Point(618, 546);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(280, 97);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // VIN_Box
            // 
            this.VIN_Box.AccessibleDescription = "Enter VIN number";
            this.VIN_Box.AccessibleName = "VIN_Box";
            this.VIN_Box.Location = new System.Drawing.Point(160, 42);
            this.VIN_Box.MaxLength = 17;
            this.VIN_Box.Multiline = false;
            this.VIN_Box.Name = "VIN_Box";
            this.VIN_Box.Size = new System.Drawing.Size(332, 62);
            this.VIN_Box.TabIndex = 2;
            this.VIN_Box.Text = "";
            this.VIN_Box.TextChanged += new System.EventHandler(this.VIN_Box_TextChanged);
            // 
            // Plate_Box
            // 
            this.Plate_Box.AccessibleDescription = "Enter Plate number";
            this.Plate_Box.AccessibleName = "Licence_Plate_Box";
            this.Plate_Box.Location = new System.Drawing.Point(160, 110);
            this.Plate_Box.MaxLength = 20;
            this.Plate_Box.Multiline = false;
            this.Plate_Box.Name = "Plate_Box";
            this.Plate_Box.Size = new System.Drawing.Size(332, 62);
            this.Plate_Box.TabIndex = 3;
            this.Plate_Box.Text = "";
            // 
            // Make_Box
            // 
            this.Make_Box.AccessibleDescription = "Enter Make";
            this.Make_Box.AccessibleName = "Make_Name";
            this.Make_Box.Location = new System.Drawing.Point(160, 178);
            this.Make_Box.MaxLength = 50;
            this.Make_Box.Multiline = false;
            this.Make_Box.Name = "Make_Box";
            this.Make_Box.Size = new System.Drawing.Size(332, 62);
            this.Make_Box.TabIndex = 4;
            this.Make_Box.Text = "";
            // 
            // Model_Box
            // 
            this.Model_Box.AccessibleDescription = "Enter Model";
            this.Model_Box.AccessibleName = "Model_Box";
            this.Model_Box.Location = new System.Drawing.Point(160, 246);
            this.Model_Box.MaxLength = 50;
            this.Model_Box.Multiline = false;
            this.Model_Box.Name = "Model_Box";
            this.Model_Box.Size = new System.Drawing.Size(332, 62);
            this.Model_Box.TabIndex = 5;
            this.Model_Box.Text = "";
            // 
            // Branch_ID_Box
            // 
            this.Branch_ID_Box.AccessibleDescription = "Enter Branch ID";
            this.Branch_ID_Box.AccessibleName = "Branch_ID_Box";
            this.Branch_ID_Box.Location = new System.Drawing.Point(160, 382);
            this.Branch_ID_Box.MaxLength = 50;
            this.Branch_ID_Box.Multiline = false;
            this.Branch_ID_Box.Name = "Branch_ID_Box";
            this.Branch_ID_Box.Size = new System.Drawing.Size(332, 62);
            this.Branch_ID_Box.TabIndex = 6;
            this.Branch_ID_Box.Text = "";
            // 
            // Transmission_Box
            // 
            this.Transmission_Box.AccessibleDescription = "Enter Transmission";
            this.Transmission_Box.AccessibleName = "Transmission_Box";
            this.Transmission_Box.Location = new System.Drawing.Point(160, 314);
            this.Transmission_Box.MaxLength = 50;
            this.Transmission_Box.Multiline = false;
            this.Transmission_Box.Name = "Transmission_Box";
            this.Transmission_Box.Size = new System.Drawing.Size(332, 62);
            this.Transmission_Box.TabIndex = 7;
            this.Transmission_Box.Text = "";
            // 
            // Type_Box
            // 
            this.Type_Box.AccessibleDescription = "Enter Type";
            this.Type_Box.AccessibleName = "Type_Box";
            this.Type_Box.Location = new System.Drawing.Point(160, 450);
            this.Type_Box.MaxLength = 20;
            this.Type_Box.Multiline = false;
            this.Type_Box.Name = "Type_Box";
            this.Type_Box.Size = new System.Drawing.Size(332, 62);
            this.Type_Box.TabIndex = 8;
            this.Type_Box.Text = "";
            // 
            // VIN_Label
            // 
            this.VIN_Label.AccessibleName = "VIN_Label";
            this.VIN_Label.BackColor = System.Drawing.SystemColors.Info;
            this.VIN_Label.Location = new System.Drawing.Point(28, 42);
            this.VIN_Label.Name = "VIN_Label";
            this.VIN_Label.ReadOnly = true;
            this.VIN_Label.Size = new System.Drawing.Size(109, 26);
            this.VIN_Label.TabIndex = 9;
            this.VIN_Label.Text = "VIN";
            this.VIN_Label.TextChanged += new System.EventHandler(this.VIN_Label_TextChanged);
            // 
            // Licence_Plate_Label
            // 
            this.Licence_Plate_Label.AccessibleName = "VIN_Label";
            this.Licence_Plate_Label.BackColor = System.Drawing.SystemColors.Info;
            this.Licence_Plate_Label.Location = new System.Drawing.Point(28, 110);
            this.Licence_Plate_Label.Name = "Licence_Plate_Label";
            this.Licence_Plate_Label.ReadOnly = true;
            this.Licence_Plate_Label.Size = new System.Drawing.Size(109, 26);
            this.Licence_Plate_Label.TabIndex = 10;
            this.Licence_Plate_Label.Text = "Licence Plate";
            this.Licence_Plate_Label.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Make_Label
            // 
            this.Make_Label.AccessibleName = "VIN_Label";
            this.Make_Label.BackColor = System.Drawing.SystemColors.Info;
            this.Make_Label.Location = new System.Drawing.Point(28, 178);
            this.Make_Label.Name = "Make_Label";
            this.Make_Label.ReadOnly = true;
            this.Make_Label.Size = new System.Drawing.Size(109, 26);
            this.Make_Label.TabIndex = 11;
            this.Make_Label.Text = "Make";
            // 
            // Model_Label
            // 
            this.Model_Label.AccessibleName = "VIN_Label";
            this.Model_Label.BackColor = System.Drawing.SystemColors.Info;
            this.Model_Label.Location = new System.Drawing.Point(28, 246);
            this.Model_Label.Name = "Model_Label";
            this.Model_Label.ReadOnly = true;
            this.Model_Label.Size = new System.Drawing.Size(109, 26);
            this.Model_Label.TabIndex = 12;
            this.Model_Label.Text = "Model";
            // 
            // Transmission_Label
            // 
            this.Transmission_Label.AccessibleName = "VIN_Label";
            this.Transmission_Label.BackColor = System.Drawing.SystemColors.Info;
            this.Transmission_Label.Location = new System.Drawing.Point(28, 314);
            this.Transmission_Label.Name = "Transmission_Label";
            this.Transmission_Label.ReadOnly = true;
            this.Transmission_Label.Size = new System.Drawing.Size(109, 26);
            this.Transmission_Label.TabIndex = 13;
            this.Transmission_Label.Text = "Transmission";
            // 
            // Branch_ID_Label
            // 
            this.Branch_ID_Label.AccessibleName = "VIN_Label";
            this.Branch_ID_Label.BackColor = System.Drawing.SystemColors.Info;
            this.Branch_ID_Label.Location = new System.Drawing.Point(28, 382);
            this.Branch_ID_Label.Name = "Branch_ID_Label";
            this.Branch_ID_Label.ReadOnly = true;
            this.Branch_ID_Label.Size = new System.Drawing.Size(109, 26);
            this.Branch_ID_Label.TabIndex = 14;
            this.Branch_ID_Label.Text = "Branch ID";
            // 
            // Type_Label
            // 
            this.Type_Label.AccessibleName = "VIN_Label";
            this.Type_Label.BackColor = System.Drawing.SystemColors.Info;
            this.Type_Label.Location = new System.Drawing.Point(28, 450);
            this.Type_Label.Name = "Type_Label";
            this.Type_Label.ReadOnly = true;
            this.Type_Label.Size = new System.Drawing.Size(109, 26);
            this.Type_Label.TabIndex = 15;
            this.Type_Label.Text = "Type";
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 710);
            this.Controls.Add(this.Type_Label);
            this.Controls.Add(this.Branch_ID_Label);
            this.Controls.Add(this.Transmission_Label);
            this.Controls.Add(this.Model_Label);
            this.Controls.Add(this.Make_Label);
            this.Controls.Add(this.Licence_Plate_Label);
            this.Controls.Add(this.VIN_Label);
            this.Controls.Add(this.Type_Box);
            this.Controls.Add(this.Transmission_Box);
            this.Controls.Add(this.Branch_ID_Box);
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
        private System.Windows.Forms.RichTextBox Branch_ID_Box;
        private System.Windows.Forms.RichTextBox Transmission_Box;
        private System.Windows.Forms.RichTextBox Type_Box;
        private System.Windows.Forms.TextBox VIN_Label;
        private System.Windows.Forms.TextBox Licence_Plate_Label;
        private System.Windows.Forms.TextBox Make_Label;
        private System.Windows.Forms.TextBox Model_Label;
        private System.Windows.Forms.TextBox Transmission_Label;
        private System.Windows.Forms.TextBox Branch_ID_Label;
        private System.Windows.Forms.TextBox Type_Label;
    }
}