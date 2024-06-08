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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add_car
            // 
            this.button_add_car.Location = new System.Drawing.Point(12, 12);
            this.button_add_car.Name = "button_add_car";
            this.button_add_car.Size = new System.Drawing.Size(320, 176);
            this.button_add_car.TabIndex = 0;
            this.button_add_car.Text = "Add Car";
            this.button_add_car.UseVisualStyleBackColor = true;
            this.button_add_car.Click += new System.EventHandler(this.button_add_car_Click);
            // 
            // button_modify_car
            // 
            this.button_modify_car.Location = new System.Drawing.Point(12, 220);
            this.button_modify_car.Name = "button_modify_car";
            this.button_modify_car.Size = new System.Drawing.Size(320, 176);
            this.button_modify_car.TabIndex = 1;
            this.button_modify_car.Text = "Modify Car";
            this.button_modify_car.UseVisualStyleBackColor = true;
            // 
            // button_delete_car
            // 
            this.button_delete_car.Location = new System.Drawing.Point(12, 428);
            this.button_delete_car.Name = "button_delete_car";
            this.button_delete_car.Size = new System.Drawing.Size(320, 176);
            this.button_delete_car.TabIndex = 2;
            this.button_delete_car.Text = "Delete Car";
            this.button_delete_car.UseVisualStyleBackColor = true;
            this.button_delete_car.Click += new System.EventHandler(this.button_delete_car_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(12, 636);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(320, 176);
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
            this.dataGridView1.Location = new System.Drawing.Point(352, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1450, 592);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(347, 742);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(209, 25);
            this.TestLabel.TabIndex = 8;
            this.TestLabel.Text = "Testing (Click on data)";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1871, 824);
            this.Controls.Add(this.TestLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_delete_car);
            this.Controls.Add(this.button_modify_car);
            this.Controls.Add(this.button_add_car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InventoryForm";
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
    }
}