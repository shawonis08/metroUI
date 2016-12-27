namespace metroUI
{
    partial class formEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridEmployee = new MetroFramework.Controls.MetroGrid();
            this.metroLabelAllEmployee = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabelEmployeeName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEmployeeDepartment = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonDepartment = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEmployee)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridEmployee
            // 
            this.metroGridEmployee.AllowUserToResizeRows = false;
            this.metroGridEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroGridEmployee.EnableHeadersVisualStyles = false;
            this.metroGridEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEmployee.Location = new System.Drawing.Point(20, 360);
            this.metroGridEmployee.Name = "metroGridEmployee";
            this.metroGridEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridEmployee.RowTemplate.Height = 24;
            this.metroGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridEmployee.Size = new System.Drawing.Size(859, 150);
            this.metroGridEmployee.TabIndex = 0;
            // 
            // metroLabelAllEmployee
            // 
            this.metroLabelAllEmployee.AutoSize = true;
            this.metroLabelAllEmployee.Location = new System.Drawing.Point(23, 286);
            this.metroLabelAllEmployee.Name = "metroLabelAllEmployee";
            this.metroLabelAllEmployee.Size = new System.Drawing.Size(96, 20);
            this.metroLabelAllEmployee.TabIndex = 1;
            this.metroLabelAllEmployee.Text = "All Employees";
            this.metroLabelAllEmployee.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButtonDepartment);
            this.metroPanel1.Controls.Add(this.metroTextBoxEmployeeName);
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.metroLabelEmployeeDepartment);
            this.metroPanel1.Controls.Add(this.metroLabelEmployeeName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 87);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(859, 145);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabelEmployeeName
            // 
            this.metroLabelEmployeeName.AutoSize = true;
            this.metroLabelEmployeeName.Location = new System.Drawing.Point(19, 22);
            this.metroLabelEmployeeName.Name = "metroLabelEmployeeName";
            this.metroLabelEmployeeName.Size = new System.Drawing.Size(113, 20);
            this.metroLabelEmployeeName.TabIndex = 2;
            this.metroLabelEmployeeName.Text = "Employee Name";
            // 
            // metroLabelEmployeeDepartment
            // 
            this.metroLabelEmployeeDepartment.AutoSize = true;
            this.metroLabelEmployeeDepartment.Location = new System.Drawing.Point(48, 81);
            this.metroLabelEmployeeDepartment.Name = "metroLabelEmployeeDepartment";
            this.metroLabelEmployeeDepartment.Size = new System.Drawing.Size(84, 20);
            this.metroLabelEmployeeDepartment.TabIndex = 3;
            this.metroLabelEmployeeDepartment.Text = "Department";
            this.metroLabelEmployeeDepartment.Click += new System.EventHandler(this.metroLabelEmployeeDepartment_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(162, 76);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(275, 30);
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroTextBoxEmployeeName
            // 
            // 
            // 
            // 
            this.metroTextBoxEmployeeName.CustomButton.Image = null;
            this.metroTextBoxEmployeeName.CustomButton.Location = new System.Drawing.Point(380, 2);
            this.metroTextBoxEmployeeName.CustomButton.Name = "";
            this.metroTextBoxEmployeeName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmployeeName.CustomButton.TabIndex = 1;
            this.metroTextBoxEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmployeeName.CustomButton.UseSelectable = true;
            this.metroTextBoxEmployeeName.CustomButton.Visible = false;
            this.metroTextBoxEmployeeName.Lines = new string[0];
            this.metroTextBoxEmployeeName.Location = new System.Drawing.Point(162, 17);
            this.metroTextBoxEmployeeName.MaxLength = 32767;
            this.metroTextBoxEmployeeName.Name = "metroTextBoxEmployeeName";
            this.metroTextBoxEmployeeName.PasswordChar = '\0';
            this.metroTextBoxEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmployeeName.SelectedText = "";
            this.metroTextBoxEmployeeName.SelectionLength = 0;
            this.metroTextBoxEmployeeName.SelectionStart = 0;
            this.metroTextBoxEmployeeName.ShortcutsEnabled = true;
            this.metroTextBoxEmployeeName.Size = new System.Drawing.Size(408, 30);
            this.metroTextBoxEmployeeName.TabIndex = 5;
            this.metroTextBoxEmployeeName.UseSelectable = true;
            this.metroTextBoxEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonDepartment
            // 
            this.metroButtonDepartment.Location = new System.Drawing.Point(481, 76);
            this.metroButtonDepartment.Name = "metroButtonDepartment";
            this.metroButtonDepartment.Size = new System.Drawing.Size(89, 30);
            this.metroButtonDepartment.TabIndex = 6;
            this.metroButtonDepartment.Text = "Add New";
            this.metroButtonDepartment.UseSelectable = true;
            this.metroButtonDepartment.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // formEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 530);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabelAllEmployee);
            this.Controls.Add(this.metroGridEmployee);
            this.Name = "formEmployee";
            this.Text = "Employee Manage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEmployee)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridEmployee;
        private MetroFramework.Controls.MetroLabel metroLabelAllEmployee;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButtonDepartment;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmployeeName;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabelEmployeeDepartment;
        private MetroFramework.Controls.MetroLabel metroLabelEmployeeName;
    }
}

