namespace Team1CMPT291_Final
{
    partial class ReportFormNew
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
            this.TabControlMenu = new System.Windows.Forms.TabControl();
            this.ReportTab1 = new System.Windows.Forms.TabPage();
            this.comboBox_CarUsage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CarUsagesSubmit = new System.Windows.Forms.Button();
            this.CarUsageResults = new System.Windows.Forms.DataGridView();
            this.ReportTab2 = new System.Windows.Forms.TabPage();
            this.FrequentFlyersSubmit = new System.Windows.Forms.Button();
            this.FrequentFlyerResults = new System.Windows.Forms.DataGridView();
            this.ReportTab3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MonthlyRevenueSubmit = new System.Windows.Forms.Button();
            this.MonthlyRevenueResults = new System.Windows.Forms.DataGridView();
            this.ReportTab4 = new System.Windows.Forms.TabPage();
            this.comboBox_Busy_Branch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BusyBranchTimesSubmit = new System.Windows.Forms.Button();
            this.BusyBranchTimesResults = new System.Windows.Forms.DataGridView();
            this.ReportTab5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UnderPerformingEmpsSubmit = new System.Windows.Forms.Button();
            this.UnderPerformingEmpsResults = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.TabControlMenu.SuspendLayout();
            this.ReportTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarUsageResults)).BeginInit();
            this.ReportTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrequentFlyerResults)).BeginInit();
            this.ReportTab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyRevenueResults)).BeginInit();
            this.ReportTab4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusyBranchTimesResults)).BeginInit();
            this.ReportTab5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnderPerformingEmpsResults)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlMenu
            // 
            this.TabControlMenu.Controls.Add(this.ReportTab1);
            this.TabControlMenu.Controls.Add(this.ReportTab2);
            this.TabControlMenu.Controls.Add(this.ReportTab3);
            this.TabControlMenu.Controls.Add(this.ReportTab4);
            this.TabControlMenu.Controls.Add(this.ReportTab5);
            this.TabControlMenu.Location = new System.Drawing.Point(-2, 22);
            this.TabControlMenu.Margin = new System.Windows.Forms.Padding(6);
            this.TabControlMenu.Name = "TabControlMenu";
            this.TabControlMenu.SelectedIndex = 0;
            this.TabControlMenu.Size = new System.Drawing.Size(1668, 980);
            this.TabControlMenu.TabIndex = 0;
            // 
            // ReportTab1
            // 
            this.ReportTab1.Controls.Add(this.comboBox_CarUsage);
            this.ReportTab1.Controls.Add(this.label5);
            this.ReportTab1.Controls.Add(this.CarUsagesSubmit);
            this.ReportTab1.Controls.Add(this.CarUsageResults);
            this.ReportTab1.Location = new System.Drawing.Point(4, 33);
            this.ReportTab1.Margin = new System.Windows.Forms.Padding(6);
            this.ReportTab1.Name = "ReportTab1";
            this.ReportTab1.Padding = new System.Windows.Forms.Padding(6);
            this.ReportTab1.Size = new System.Drawing.Size(1660, 943);
            this.ReportTab1.TabIndex = 0;
            this.ReportTab1.Text = "Car Usages";
            this.ReportTab1.UseVisualStyleBackColor = true;
            // 
            // comboBox_CarUsage
            // 
            this.comboBox_CarUsage.FormattingEnabled = true;
            this.comboBox_CarUsage.Location = new System.Drawing.Point(119, 825);
            this.comboBox_CarUsage.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_CarUsage.Name = "comboBox_CarUsage";
            this.comboBox_CarUsage.Size = new System.Drawing.Size(218, 32);
            this.comboBox_CarUsage.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(110, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(801, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "Car Usage By Make, Model, or Transmission";
            // 
            // CarUsagesSubmit
            // 
            this.CarUsagesSubmit.Location = new System.Drawing.Point(1344, 825);
            this.CarUsagesSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.CarUsagesSubmit.Name = "CarUsagesSubmit";
            this.CarUsagesSubmit.Size = new System.Drawing.Size(191, 76);
            this.CarUsagesSubmit.TabIndex = 7;
            this.CarUsagesSubmit.Text = "Run Report";
            this.CarUsagesSubmit.UseVisualStyleBackColor = true;
            this.CarUsagesSubmit.Click += new System.EventHandler(this.CarUsagesSubmit_Click);
            // 
            // CarUsageResults
            // 
            this.CarUsageResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarUsageResults.Location = new System.Drawing.Point(119, 209);
            this.CarUsageResults.Margin = new System.Windows.Forms.Padding(6);
            this.CarUsageResults.Name = "CarUsageResults";
            this.CarUsageResults.RowHeadersWidth = 72;
            this.CarUsageResults.Size = new System.Drawing.Size(1415, 604);
            this.CarUsageResults.TabIndex = 2;
            // 
            // ReportTab2
            // 
            this.ReportTab2.Controls.Add(this.FrequentFlyersSubmit);
            this.ReportTab2.Controls.Add(this.FrequentFlyerResults);
            this.ReportTab2.Location = new System.Drawing.Point(4, 33);
            this.ReportTab2.Margin = new System.Windows.Forms.Padding(6);
            this.ReportTab2.Name = "ReportTab2";
            this.ReportTab2.Padding = new System.Windows.Forms.Padding(6);
            this.ReportTab2.Size = new System.Drawing.Size(1660, 943);
            this.ReportTab2.TabIndex = 1;
            this.ReportTab2.Text = "Frequent Flyers";
            this.ReportTab2.UseVisualStyleBackColor = true;
            // 
            // FrequentFlyersSubmit
            // 
            this.FrequentFlyersSubmit.Location = new System.Drawing.Point(1344, 825);
            this.FrequentFlyersSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.FrequentFlyersSubmit.Name = "FrequentFlyersSubmit";
            this.FrequentFlyersSubmit.Size = new System.Drawing.Size(191, 76);
            this.FrequentFlyersSubmit.TabIndex = 7;
            this.FrequentFlyersSubmit.Text = "Run Report";
            this.FrequentFlyersSubmit.UseVisualStyleBackColor = true;
            this.FrequentFlyersSubmit.Click += new System.EventHandler(this.FrequentFlyersSubmit_Click);
            // 
            // FrequentFlyerResults
            // 
            this.FrequentFlyerResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FrequentFlyerResults.Location = new System.Drawing.Point(119, 209);
            this.FrequentFlyerResults.Margin = new System.Windows.Forms.Padding(6);
            this.FrequentFlyerResults.Name = "FrequentFlyerResults";
            this.FrequentFlyerResults.RowHeadersWidth = 72;
            this.FrequentFlyerResults.Size = new System.Drawing.Size(1415, 604);
            this.FrequentFlyerResults.TabIndex = 1;
            // 
            // ReportTab3
            // 
            this.ReportTab3.Controls.Add(this.label6);
            this.ReportTab3.Controls.Add(this.label7);
            this.ReportTab3.Controls.Add(this.MonthlyRevenueSubmit);
            this.ReportTab3.Controls.Add(this.MonthlyRevenueResults);
            this.ReportTab3.Location = new System.Drawing.Point(4, 33);
            this.ReportTab3.Margin = new System.Windows.Forms.Padding(6);
            this.ReportTab3.Name = "ReportTab3";
            this.ReportTab3.Size = new System.Drawing.Size(1660, 943);
            this.ReportTab3.TabIndex = 2;
            this.ReportTab3.Text = "Daily Revenue";
            this.ReportTab3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(490, 42);
            this.label6.TabIndex = 15;
            this.label6.Text = "Top Daily Branch Revenue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Daily list of #1 revenue branches.";
            // 
            // MonthlyRevenueSubmit
            // 
            this.MonthlyRevenueSubmit.Location = new System.Drawing.Point(1344, 825);
            this.MonthlyRevenueSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.MonthlyRevenueSubmit.Name = "MonthlyRevenueSubmit";
            this.MonthlyRevenueSubmit.Size = new System.Drawing.Size(191, 76);
            this.MonthlyRevenueSubmit.TabIndex = 7;
            this.MonthlyRevenueSubmit.Text = "Run Report";
            this.MonthlyRevenueSubmit.UseVisualStyleBackColor = true;
            this.MonthlyRevenueSubmit.Click += new System.EventHandler(this.MonthlyRevenueSubmit_Click);
            // 
            // MonthlyRevenueResults
            // 
            this.MonthlyRevenueResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonthlyRevenueResults.Location = new System.Drawing.Point(119, 209);
            this.MonthlyRevenueResults.Margin = new System.Windows.Forms.Padding(6);
            this.MonthlyRevenueResults.Name = "MonthlyRevenueResults";
            this.MonthlyRevenueResults.RowHeadersWidth = 72;
            this.MonthlyRevenueResults.Size = new System.Drawing.Size(1415, 604);
            this.MonthlyRevenueResults.TabIndex = 1;
            // 
            // ReportTab4
            // 
            this.ReportTab4.Controls.Add(this.comboBox_Busy_Branch);
            this.ReportTab4.Controls.Add(this.label3);
            this.ReportTab4.Controls.Add(this.label4);
            this.ReportTab4.Controls.Add(this.BusyBranchTimesSubmit);
            this.ReportTab4.Controls.Add(this.BusyBranchTimesResults);
            this.ReportTab4.Location = new System.Drawing.Point(4, 33);
            this.ReportTab4.Margin = new System.Windows.Forms.Padding(6);
            this.ReportTab4.Name = "ReportTab4";
            this.ReportTab4.Size = new System.Drawing.Size(1660, 943);
            this.ReportTab4.TabIndex = 3;
            this.ReportTab4.Text = "Busy Branch Times";
            this.ReportTab4.UseVisualStyleBackColor = true;
            // 
            // comboBox_Busy_Branch
            // 
            this.comboBox_Busy_Branch.FormattingEnabled = true;
            this.comboBox_Busy_Branch.Location = new System.Drawing.Point(119, 825);
            this.comboBox_Busy_Branch.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Busy_Branch.Name = "comboBox_Busy_Branch";
            this.comboBox_Busy_Branch.Size = new System.Drawing.Size(218, 32);
            this.comboBox_Busy_Branch.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(491, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "Busiest months per Branch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(780, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "A list of all month with the amount of reservations per branch.";
            // 
            // BusyBranchTimesSubmit
            // 
            this.BusyBranchTimesSubmit.Location = new System.Drawing.Point(1344, 825);
            this.BusyBranchTimesSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BusyBranchTimesSubmit.Name = "BusyBranchTimesSubmit";
            this.BusyBranchTimesSubmit.Size = new System.Drawing.Size(191, 76);
            this.BusyBranchTimesSubmit.TabIndex = 7;
            this.BusyBranchTimesSubmit.Text = "Run Report";
            this.BusyBranchTimesSubmit.UseVisualStyleBackColor = true;
            this.BusyBranchTimesSubmit.Click += new System.EventHandler(this.BusyBranchTimesSubmit_Click);
            // 
            // BusyBranchTimesResults
            // 
            this.BusyBranchTimesResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusyBranchTimesResults.Location = new System.Drawing.Point(119, 209);
            this.BusyBranchTimesResults.Margin = new System.Windows.Forms.Padding(6);
            this.BusyBranchTimesResults.Name = "BusyBranchTimesResults";
            this.BusyBranchTimesResults.RowHeadersWidth = 72;
            this.BusyBranchTimesResults.Size = new System.Drawing.Size(1415, 604);
            this.BusyBranchTimesResults.TabIndex = 1;
            // 
            // ReportTab5
            // 
            this.ReportTab5.Controls.Add(this.label2);
            this.ReportTab5.Controls.Add(this.label1);
            this.ReportTab5.Controls.Add(this.UnderPerformingEmpsSubmit);
            this.ReportTab5.Controls.Add(this.UnderPerformingEmpsResults);
            this.ReportTab5.Location = new System.Drawing.Point(4, 33);
            this.ReportTab5.Margin = new System.Windows.Forms.Padding(6);
            this.ReportTab5.Name = "ReportTab5";
            this.ReportTab5.Size = new System.Drawing.Size(1660, 943);
            this.ReportTab5.TabIndex = 4;
            this.ReportTab5.Text = "Under-performing Employees";
            this.ReportTab5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Under-performing Employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1121, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "A list of all of employees, each with a sum of their revenue and a count of their" +
    " bookings.";
            // 
            // UnderPerformingEmpsSubmit
            // 
            this.UnderPerformingEmpsSubmit.Location = new System.Drawing.Point(1344, 825);
            this.UnderPerformingEmpsSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.UnderPerformingEmpsSubmit.Name = "UnderPerformingEmpsSubmit";
            this.UnderPerformingEmpsSubmit.Size = new System.Drawing.Size(191, 76);
            this.UnderPerformingEmpsSubmit.TabIndex = 6;
            this.UnderPerformingEmpsSubmit.Text = "Run Report";
            this.UnderPerformingEmpsSubmit.UseVisualStyleBackColor = true;
            this.UnderPerformingEmpsSubmit.Click += new System.EventHandler(this.UnderPerformingEmpsSubmit_Click);
            // 
            // UnderPerformingEmpsResults
            // 
            this.UnderPerformingEmpsResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnderPerformingEmpsResults.Location = new System.Drawing.Point(119, 209);
            this.UnderPerformingEmpsResults.Margin = new System.Windows.Forms.Padding(6);
            this.UnderPerformingEmpsResults.Name = "UnderPerformingEmpsResults";
            this.UnderPerformingEmpsResults.RowHeadersWidth = 72;
            this.UnderPerformingEmpsResults.Size = new System.Drawing.Size(1415, 604);
            this.UnderPerformingEmpsResults.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1470, 9);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(189, 42);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // ReportFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 1002);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TabControlMenu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReportFormNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportFormNew_Load);
            this.TabControlMenu.ResumeLayout(false);
            this.ReportTab1.ResumeLayout(false);
            this.ReportTab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarUsageResults)).EndInit();
            this.ReportTab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FrequentFlyerResults)).EndInit();
            this.ReportTab3.ResumeLayout(false);
            this.ReportTab3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyRevenueResults)).EndInit();
            this.ReportTab4.ResumeLayout(false);
            this.ReportTab4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusyBranchTimesResults)).EndInit();
            this.ReportTab5.ResumeLayout(false);
            this.ReportTab5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnderPerformingEmpsResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMenu;
        private System.Windows.Forms.TabPage ReportTab1;
        private System.Windows.Forms.TabPage ReportTab2;
        private System.Windows.Forms.TabPage ReportTab3;
        private System.Windows.Forms.TabPage ReportTab4;
        private System.Windows.Forms.TabPage ReportTab5;
        private System.Windows.Forms.DataGridView CarUsageResults;
        private System.Windows.Forms.DataGridView FrequentFlyerResults;
        private System.Windows.Forms.DataGridView MonthlyRevenueResults;
        private System.Windows.Forms.DataGridView BusyBranchTimesResults;
        private System.Windows.Forms.DataGridView UnderPerformingEmpsResults;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CarUsagesSubmit;
        private System.Windows.Forms.Button FrequentFlyersSubmit;
        private System.Windows.Forms.Button MonthlyRevenueSubmit;
        private System.Windows.Forms.Button BusyBranchTimesSubmit;
        private System.Windows.Forms.Button UnderPerformingEmpsSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Busy_Branch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_CarUsage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}