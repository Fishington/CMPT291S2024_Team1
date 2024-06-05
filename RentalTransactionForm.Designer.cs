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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePickerPickup = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDropoff = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 194);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick Up Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drop Off Date:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 320);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 83);
            this.button2.TabIndex = 8;
            this.button2.Text = "Check Availiability";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 83);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 423);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 83);
            this.button3.TabIndex = 10;
            this.button3.Text = "Book Car";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerPickup
            // 
            this.dateTimePickerPickup.Location = new System.Drawing.Point(25, 64);
            this.dateTimePickerPickup.MaxDate = new System.DateTime(2029, 12, 31, 23, 59, 0, 0);
            this.dateTimePickerPickup.MinDate = new System.DateTime(2024, 6, 5, 0, 0, 0, 0);
            this.dateTimePickerPickup.Name = "dateTimePickerPickup";
            this.dateTimePickerPickup.Size = new System.Drawing.Size(146, 20);
            this.dateTimePickerPickup.TabIndex = 11;
            this.dateTimePickerPickup.ValueChanged += new System.EventHandler(this.dateTimePickerPickup_ValueChanged_1);
            // 
            // dateTimePickerDropoff
            // 
            this.dateTimePickerDropoff.Location = new System.Drawing.Point(25, 128);
            this.dateTimePickerDropoff.MaxDate = new System.DateTime(2029, 12, 31, 23, 59, 0, 0);
            this.dateTimePickerDropoff.MinDate = new System.DateTime(2024, 6, 5, 0, 0, 0, 0);
            this.dateTimePickerDropoff.Name = "dateTimePickerDropoff";
            this.dateTimePickerDropoff.Size = new System.Drawing.Size(143, 20);
            this.dateTimePickerDropoff.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Branch:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RentalTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 555);
            this.Controls.Add(this.dateTimePickerDropoff);
            this.Controls.Add(this.dateTimePickerPickup);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RentalTransactionForm";
            this.Text = "RentalTransactionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePickerPickup;
        private System.Windows.Forms.DateTimePicker dateTimePickerDropoff;
        private System.Windows.Forms.Label label3;
    }
}