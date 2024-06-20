namespace Team1CMPT291_Final
{
    partial class InventoryForm
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
            this.button_add_car = new System.Windows.Forms.Button();
            this.button_modify_car = new System.Windows.Forms.Button();
            this.button_delete_car = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TestLabel = new System.Windows.Forms.Label();
            this.ComboBox_Branch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox_Type = new System.Windows.Forms.ComboBox();
            this.Combo_Transmission = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_Make = new System.Windows.Forms.ComboBox();
            this.Combo_Model = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetFiltersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add_car
            // 
            this.button_add_car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(254)))), ((int)(((byte)(111)))));
            this.button_add_car.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_add_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_car.Location = new System.Drawing.Point(7, 6);
            this.button_add_car.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_add_car.Name = "button_add_car";
            this.button_add_car.Size = new System.Drawing.Size(175, 95);
            this.button_add_car.TabIndex = 0;
            this.button_add_car.Text = "Add Car";
            this.button_add_car.UseVisualStyleBackColor = false;
            this.button_add_car.Click += new System.EventHandler(this.button_add_car_Click);
            // 
            // button_modify_car
            // 
            this.button_modify_car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(193)))), ((int)(((byte)(254)))));
            this.button_modify_car.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_modify_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modify_car.Location = new System.Drawing.Point(7, 119);
            this.button_modify_car.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_modify_car.Name = "button_modify_car";
            this.button_modify_car.Size = new System.Drawing.Size(175, 95);
            this.button_modify_car.TabIndex = 1;
            this.button_modify_car.Text = "Modify Car";
            this.button_modify_car.UseVisualStyleBackColor = false;
            this.button_modify_car.Click += new System.EventHandler(this.button_modify_car_Click);
            // 
            // button_delete_car
            // 
            this.button_delete_car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(193)))), ((int)(((byte)(254)))));
            this.button_delete_car.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_delete_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_car.Location = new System.Drawing.Point(7, 232);
            this.button_delete_car.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_delete_car.Name = "button_delete_car";
            this.button_delete_car.Size = new System.Drawing.Size(175, 95);
            this.button_delete_car.TabIndex = 2;
            this.button_delete_car.Text = "Delete Car";
            this.button_delete_car.UseVisualStyleBackColor = false;
            this.button_delete_car.Click += new System.EventHandler(this.button_delete_car_Click);
            // 
            // button_back
            // 
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Location = new System.Drawing.Point(7, 344);
            this.button_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(175, 95);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(192, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(791, 321);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(19)))));
            this.TestLabel.Location = new System.Drawing.Point(200, 419);
            this.TestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(113, 13);
            this.TestLabel.TabIndex = 8;
            this.TestLabel.Text = "Testing (Click on data)";
            this.TestLabel.Visible = false;
            // 
            // ComboBox_Branch
            // 
            this.ComboBox_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Branch.FormattingEnabled = true;
            this.ComboBox_Branch.Location = new System.Drawing.Point(721, 335);
            this.ComboBox_Branch.Name = "ComboBox_Branch";
            this.ComboBox_Branch.Size = new System.Drawing.Size(262, 28);
            this.ComboBox_Branch.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(19)))));
            this.label5.Location = new System.Drawing.Point(653, 339);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Branch: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(19)))));
            this.label6.Location = new System.Drawing.Point(471, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Type:";
            // 
            // ComboBox_Type
            // 
            this.ComboBox_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Type.FormattingEnabled = true;
            this.ComboBox_Type.Location = new System.Drawing.Point(522, 368);
            this.ComboBox_Type.Name = "ComboBox_Type";
            this.ComboBox_Type.Size = new System.Drawing.Size(121, 28);
            this.ComboBox_Type.TabIndex = 22;
            // 
            // Combo_Transmission
            // 
            this.Combo_Transmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Transmission.FormattingEnabled = true;
            this.Combo_Transmission.Location = new System.Drawing.Point(522, 336);
            this.Combo_Transmission.Name = "Combo_Transmission";
            this.Combo_Transmission.Size = new System.Drawing.Size(121, 28);
            this.Combo_Transmission.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(19)))));
            this.label4.Location = new System.Drawing.Point(416, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Transmission:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(19)))));
            this.label2.Location = new System.Drawing.Point(200, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Make:";
            // 
            // Combo_Make
            // 
            this.Combo_Make.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Make.FormattingEnabled = true;
            this.Combo_Make.Location = new System.Drawing.Point(254, 339);
            this.Combo_Make.Name = "Combo_Make";
            this.Combo_Make.Size = new System.Drawing.Size(159, 28);
            this.Combo_Make.TabIndex = 26;
            // 
            // Combo_Model
            // 
            this.Combo_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Model.FormattingEnabled = true;
            this.Combo_Model.Location = new System.Drawing.Point(254, 368);
            this.Combo_Model.Name = "Combo_Model";
            this.Combo_Model.Size = new System.Drawing.Size(159, 28);
            this.Combo_Model.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(19)))));
            this.label3.Location = new System.Drawing.Point(200, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Model:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(59)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(721, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "Search Cars";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetFiltersButton
            // 
            this.ResetFiltersButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetFiltersButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ResetFiltersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetFiltersButton.Location = new System.Drawing.Point(899, 411);
            this.ResetFiltersButton.Name = "ResetFiltersButton";
            this.ResetFiltersButton.Size = new System.Drawing.Size(84, 28);
            this.ResetFiltersButton.TabIndex = 30;
            this.ResetFiltersButton.Text = "Reset Filters";
            this.ResetFiltersButton.UseVisualStyleBackColor = false;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1021, 446);
            this.Controls.Add(this.ResetFiltersButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Combo_Model);
            this.Controls.Add(this.Combo_Make);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Combo_Transmission);
            this.Controls.Add(this.ComboBox_Type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBox_Branch);
            this.Controls.Add(this.TestLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_delete_car);
            this.Controls.Add(this.button_modify_car);
            this.Controls.Add(this.button_add_car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add_car;
        private System.Windows.Forms.Button button_modify_car;
        private System.Windows.Forms.Button button_delete_car;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.ComboBox ComboBox_Branch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBox_Type;
        private System.Windows.Forms.ComboBox Combo_Transmission;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combo_Make;
        private System.Windows.Forms.ComboBox Combo_Model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetFiltersButton;
    }
}