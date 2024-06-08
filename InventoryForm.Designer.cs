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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(868, 592);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 672);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(382, 42);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Branch:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 824);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}