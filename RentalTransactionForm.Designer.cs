using System;

namespace Team1CMPT291_Final
{
    partial class RentalTransactionForm
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
            this.comboBox_Branch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Book = new System.Windows.Forms.Button();
            this.dateTimePickerPickup = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDropoff = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_Employee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Customer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Branch
            // 
            this.comboBox_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Branch.FormattingEnabled = true;
            this.comboBox_Branch.Location = new System.Drawing.Point(46, 358);
            this.comboBox_Branch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Branch.Name = "comboBox_Branch";
            this.comboBox_Branch.Size = new System.Drawing.Size(354, 50);
            this.comboBox_Branch.TabIndex = 2;
            this.comboBox_Branch.SelectedIndexChanged += new System.EventHandler(this.comboBox_Branch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick Up Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drop Off Date:";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(73, 781);
            this.button_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(268, 153);
            this.button_Back.TabIndex = 9;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Book
            // 
            this.button_Book.Location = new System.Drawing.Point(1109, 781);
            this.button_Book.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Book.Name = "button_Book";
            this.button_Book.Size = new System.Drawing.Size(268, 153);
            this.button_Book.TabIndex = 10;
            this.button_Book.Text = "View Quote";
            this.button_Book.UseVisualStyleBackColor = true;
            this.button_Book.Click += new System.EventHandler(this.button_Book_Click);
            // 
            // dateTimePickerPickup
            // 
            this.dateTimePickerPickup.Location = new System.Drawing.Point(46, 118);
            this.dateTimePickerPickup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePickerPickup.MaxDate = new System.DateTime(2029, 12, 31, 23, 59, 0, 0);
            this.dateTimePickerPickup.MinDate = new System.DateTime(2024, 6, 5, 0, 0, 0, 0);
            this.dateTimePickerPickup.Name = "dateTimePickerPickup";
            this.dateTimePickerPickup.Size = new System.Drawing.Size(264, 29);
            this.dateTimePickerPickup.TabIndex = 11;
            this.dateTimePickerPickup.ValueChanged += new System.EventHandler(this.dateTimePickerPickup_ValueChanged_1);
            // 
            // dateTimePickerDropoff
            // 
            this.dateTimePickerDropoff.Location = new System.Drawing.Point(46, 236);
            this.dateTimePickerDropoff.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePickerDropoff.MaxDate = new System.DateTime(2029, 12, 31, 23, 59, 0, 0);
            this.dateTimePickerDropoff.MinDate = new System.DateTime(2024, 6, 5, 0, 0, 0, 0);
            this.dateTimePickerDropoff.Name = "dateTimePickerDropoff";
            this.dateTimePickerDropoff.Size = new System.Drawing.Size(259, 29);
            this.dateTimePickerDropoff.TabIndex = 12;
            this.dateTimePickerDropoff.ValueChanged += new System.EventHandler(this.dateTimePickerDropoff_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Branch:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(442, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(977, 628);
            this.dataGridView1.TabIndex = 13;
            // 
            // comboBox_Employee
            // 
            this.comboBox_Employee.FormattingEnabled = true;
            this.comboBox_Employee.Location = new System.Drawing.Point(647, 781);
            this.comboBox_Employee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox_Employee.Name = "comboBox_Employee";
            this.comboBox_Employee.Size = new System.Drawing.Size(305, 32);
            this.comboBox_Employee.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 781);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Employee:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 871);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Customer:";
            // 
            // comboBox_Customer
            // 
            this.comboBox_Customer.FormattingEnabled = true;
            this.comboBox_Customer.Location = new System.Drawing.Point(647, 871);
            this.comboBox_Customer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox_Customer.Name = "comboBox_Customer";
            this.comboBox_Customer.Size = new System.Drawing.Size(305, 32);
            this.comboBox_Customer.TabIndex = 17;
            // 
            // RentalTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 1025);
            this.Controls.Add(this.comboBox_Customer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Employee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerDropoff);
            this.Controls.Add(this.dateTimePickerPickup);
            this.Controls.Add(this.button_Book);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Branch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RentalTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalTransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Branch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Book;
        private System.Windows.Forms.DateTimePicker dateTimePickerPickup;
        private System.Windows.Forms.DateTimePicker dateTimePickerDropoff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_Employee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Customer;
    }
}