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
            this.SuspendLayout();
            // 
            // button_add_car
            // 
            this.button_add_car.Location = new System.Drawing.Point(9, 8);
            this.button_add_car.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_car.Name = "button_add_car";
            this.button_add_car.Size = new System.Drawing.Size(233, 117);
            this.button_add_car.TabIndex = 0;
            this.button_add_car.Text = "Add Car";
            this.button_add_car.UseVisualStyleBackColor = true;
            // 
            // button_modify_car
            // 
            this.button_modify_car.Location = new System.Drawing.Point(9, 147);
            this.button_modify_car.Margin = new System.Windows.Forms.Padding(2);
            this.button_modify_car.Name = "button_modify_car";
            this.button_modify_car.Size = new System.Drawing.Size(233, 117);
            this.button_modify_car.TabIndex = 1;
            this.button_modify_car.Text = "Modify Car";
            this.button_modify_car.UseVisualStyleBackColor = true;
            // 
            // button_delete_car
            // 
            this.button_delete_car.Location = new System.Drawing.Point(9, 285);
            this.button_delete_car.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete_car.Name = "button_delete_car";
            this.button_delete_car.Size = new System.Drawing.Size(233, 117);
            this.button_delete_car.TabIndex = 2;
            this.button_delete_car.Text = "Delete Car";
            this.button_delete_car.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(9, 424);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(233, 117);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 549);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_delete_car);
            this.Controls.Add(this.button_modify_car);
            this.Controls.Add(this.button_add_car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InventoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_car;
        private System.Windows.Forms.Button button_modify_car;
        private System.Windows.Forms.Button button_delete_car;
        private System.Windows.Forms.Button button_back;
    }
}