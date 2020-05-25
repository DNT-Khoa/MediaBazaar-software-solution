﻿namespace MediaBazaarSolution
{
    partial class ScheduleAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbxEmployees = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTaskName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchedule.Location = new System.Drawing.Point(12, 12);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(738, 370);
            this.dgvSchedule.TabIndex = 0;
            this.dgvSchedule.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvSchedule_RowStateChanged);
            this.dgvSchedule.SelectionChanged += new System.EventHandler(this.dgvSchedule_SelectionChanged);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddSchedule.Location = new System.Drawing.Point(296, 403);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(108, 34);
            this.btnAddSchedule.TabIndex = 1;
            this.btnAddSchedule.Text = "Add ";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteSchedule.Location = new System.Drawing.Point(638, 403);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(108, 34);
            this.btnDeleteSchedule.TabIndex = 3;
            this.btnDeleteSchedule.Text = "Delete";
            this.btnDeleteSchedule.UseVisualStyleBackColor = true;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReload.Location = new System.Drawing.Point(410, 403);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(108, 34);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(777, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee:";
            // 
            // cbbxEmployees
            // 
            this.cbbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbbxEmployees.FormattingEnabled = true;
            this.cbbxEmployees.Location = new System.Drawing.Point(781, 72);
            this.cbbxEmployees.Name = "cbbxEmployees";
            this.cbbxEmployees.Size = new System.Drawing.Size(254, 26);
            this.cbbxEmployees.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(777, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date:";
            // 
            // tbxDate
            // 
            this.tbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbxDate.Location = new System.Drawing.Point(781, 157);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.ReadOnly = true;
            this.tbxDate.Size = new System.Drawing.Size(254, 24);
            this.tbxDate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(777, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Task Name:";
            // 
            // tbxTaskName
            // 
            this.tbxTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbxTaskName.Location = new System.Drawing.Point(781, 339);
            this.tbxTaskName.Name = "tbxTaskName";
            this.tbxTaskName.Size = new System.Drawing.Size(254, 24);
            this.tbxTaskName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(777, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time:";
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(781, 240);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(115, 24);
            this.dtpTime.TabIndex = 16;
            // 
            // btnUpdateSchedule
            // 
            this.btnUpdateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateSchedule.Location = new System.Drawing.Point(524, 403);
            this.btnUpdateSchedule.Name = "btnUpdateSchedule";
            this.btnUpdateSchedule.Size = new System.Drawing.Size(108, 34);
            this.btnUpdateSchedule.TabIndex = 17;
            this.btnUpdateSchedule.Text = "Update";
            this.btnUpdateSchedule.UseVisualStyleBackColor = true;
            this.btnUpdateSchedule.Click += new System.EventHandler(this.btnUpdateSchedule_Click);
            // 
            // ScheduleAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 462);
            this.Controls.Add(this.btnUpdateSchedule);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.tbxTaskName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbxEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDeleteSchedule);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.dgvSchedule);
            this.Name = "ScheduleAddForm";
            this.Text = "AddSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbxEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTaskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnUpdateSchedule;
    }
}