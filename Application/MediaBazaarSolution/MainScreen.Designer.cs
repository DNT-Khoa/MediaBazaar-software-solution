﻿namespace MediaBazaarSolution
{
    partial class MainScreen
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ScheduleTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToday = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.EmployeesTab = new System.Windows.Forms.TabPage();
            this.btnReloadEmployees = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSearchEmployeeByName = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.DepotTab = new System.Windows.Forms.TabPage();
            this.btnReloadItems = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxItemCategory = new System.Windows.Forms.ComboBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchItemById = new System.Windows.Forms.TextBox();
            this.dgvDepot = new System.Windows.Forms.DataGridView();
            this.StatisticsTab = new System.Windows.Forms.TabPage();
            this.SalesPieChart = new LiveCharts.WinForms.PieChart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.EmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StProductDGV = new System.Windows.Forms.DataGridView();
            this.PrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblAlerts = new System.Windows.Forms.Label();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnRemoveAlert = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgvAlerts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblSortAlerts = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Tabs.SuspendLayout();
            this.ScheduleTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EmployeesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.DepotTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepot)).BeginInit();
            this.StatisticsTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StProductDGV)).BeginInit();
            this.OrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(708, 11);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(485, 55);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME, <User>!";
            // 
            // Tabs
            // 
            this.Tabs.CausesValidation = false;
            this.Tabs.Controls.Add(this.ScheduleTab);
            this.Tabs.Controls.Add(this.EmployeesTab);
            this.Tabs.Controls.Add(this.DepotTab);
            this.Tabs.Controls.Add(this.StatisticsTab);
            this.Tabs.Controls.Add(this.OrdersTab);
            this.Tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.Location = new System.Drawing.Point(13, 59);
            this.Tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1844, 751);
            this.Tabs.TabIndex = 2;
            // 
            // ScheduleTab
            // 
            this.ScheduleTab.BackColor = System.Drawing.Color.Transparent;
            this.ScheduleTab.Controls.Add(this.panel2);
            this.ScheduleTab.Controls.Add(this.panel1);
            this.ScheduleTab.Location = new System.Drawing.Point(4, 38);
            this.ScheduleTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScheduleTab.Name = "ScheduleTab";
            this.ScheduleTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScheduleTab.Size = new System.Drawing.Size(1836, 709);
            this.ScheduleTab.TabIndex = 0;
            this.ScheduleTab.Text = "Schedule";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMatrix);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(4, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1825, 670);
            this.panel2.TabIndex = 1;
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Location = new System.Drawing.Point(271, 112);
            this.pnlMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(1327, 558);
            this.pnlMatrix.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNextMonth);
            this.panel3.Controls.Add(this.btnPreviousMonth);
            this.panel3.Controls.Add(this.btnSunday);
            this.panel3.Controls.Add(this.btnSaturday);
            this.panel3.Controls.Add(this.btnFriday);
            this.panel3.Controls.Add(this.btnThursday);
            this.panel3.Controls.Add(this.btnWednesday);
            this.panel3.Controls.Add(this.btnTuesday);
            this.panel3.Controls.Add(this.btnMonday);
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1816, 100);
            this.panel3.TabIndex = 0;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(1629, 4);
            this.btnNextMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(183, 91);
            this.btnNextMonth.TabIndex = 8;
            this.btnNextMonth.Text = "Next Month";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.Location = new System.Drawing.Point(4, 4);
            this.btnPreviousMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(183, 91);
            this.btnPreviousMonth.TabIndex = 7;
            this.btnPreviousMonth.Text = "Previous Month ";
            this.btnPreviousMonth.UseVisualStyleBackColor = true;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(1409, 5);
            this.btnSunday.Margin = new System.Windows.Forms.Padding(4);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(183, 91);
            this.btnSunday.TabIndex = 6;
            this.btnSunday.Text = "Sunday";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(1219, 5);
            this.btnSaturday.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(183, 91);
            this.btnSaturday.TabIndex = 5;
            this.btnSaturday.Text = "Saturday";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(1028, 5);
            this.btnFriday.Margin = new System.Windows.Forms.Padding(4);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(183, 91);
            this.btnFriday.TabIndex = 4;
            this.btnFriday.Text = "Friday";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            this.btnThursday.Location = new System.Drawing.Point(837, 5);
            this.btnThursday.Margin = new System.Windows.Forms.Padding(4);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(183, 91);
            this.btnThursday.TabIndex = 3;
            this.btnThursday.Text = "Thursday";
            this.btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(647, 5);
            this.btnWednesday.Margin = new System.Windows.Forms.Padding(4);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(183, 91);
            this.btnWednesday.TabIndex = 2;
            this.btnWednesday.Text = "Wednesday";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.Location = new System.Drawing.Point(456, 5);
            this.btnTuesday.Margin = new System.Windows.Forms.Padding(4);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(183, 91);
            this.btnTuesday.TabIndex = 1;
            this.btnTuesday.Text = "Tuesday";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(265, 4);
            this.btnMonday.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(183, 91);
            this.btnMonday.TabIndex = 0;
            this.btnMonday.Text = "Monday";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1825, 33);
            this.panel1.TabIndex = 0;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(1061, 1);
            this.btnToday.Margin = new System.Windows.Forms.Padding(4);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(120, 32);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(652, 1);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(375, 35);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // EmployeesTab
            // 
            this.EmployeesTab.Controls.Add(this.btnReloadEmployees);
            this.EmployeesTab.Controls.Add(this.btnSearchEmployee);
            this.EmployeesTab.Controls.Add(this.label4);
            this.EmployeesTab.Controls.Add(this.tbxSearchEmployeeByName);
            this.EmployeesTab.Controls.Add(this.btnAddEmployee);
            this.EmployeesTab.Controls.Add(this.btnDeleteEmployee);
            this.EmployeesTab.Controls.Add(this.dgvEmployees);
            this.EmployeesTab.Location = new System.Drawing.Point(4, 38);
            this.EmployeesTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeesTab.Name = "EmployeesTab";
            this.EmployeesTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeesTab.Size = new System.Drawing.Size(1836, 709);
            this.EmployeesTab.TabIndex = 1;
            this.EmployeesTab.Text = "Employees";
            this.EmployeesTab.UseVisualStyleBackColor = true;
            // 
            // btnReloadEmployees
            // 
            this.btnReloadEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadEmployees.Location = new System.Drawing.Point(840, 598);
            this.btnReloadEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadEmployees.Name = "btnReloadEmployees";
            this.btnReloadEmployees.Size = new System.Drawing.Size(133, 43);
            this.btnReloadEmployees.TabIndex = 11;
            this.btnReloadEmployees.Text = "Reload";
            this.btnReloadEmployees.UseVisualStyleBackColor = true;
            this.btnReloadEmployees.Click += new System.EventHandler(this.btnReloadEmployees_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(1541, 256);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(140, 46);
            this.btnSearchEmployee.TabIndex = 10;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1447, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Employee Last Name";
            // 
            // tbxSearchEmployeeByName
            // 
            this.tbxSearchEmployeeByName.Location = new System.Drawing.Point(1451, 138);
            this.tbxSearchEmployeeByName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSearchEmployeeByName.Name = "tbxSearchEmployeeByName";
            this.tbxSearchEmployeeByName.Size = new System.Drawing.Size(327, 35);
            this.tbxSearchEmployeeByName.TabIndex = 8;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(1232, 598);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(133, 43);
            this.btnAddEmployee.TabIndex = 7;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(1036, 598);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(133, 43);
            this.btnDeleteEmployee.TabIndex = 6;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(33, 21);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1348, 465);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvEmployees_CellBeginEdit);
            this.dgvEmployees.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellEndEdit);
            this.dgvEmployees.SelectionChanged += new System.EventHandler(this.dgvEmployees_SelectionChanged);
            // 
            // DepotTab
            // 
            this.DepotTab.Controls.Add(this.btnReloadItems);
            this.DepotTab.Controls.Add(this.label3);
            this.DepotTab.Controls.Add(this.cbxItemCategory);
            this.DepotTab.Controls.Add(this.btnDeleteItem);
            this.DepotTab.Controls.Add(this.btnAddProduct);
            this.DepotTab.Controls.Add(this.btnSearch);
            this.DepotTab.Controls.Add(this.label1);
            this.DepotTab.Controls.Add(this.tbxSearchItemById);
            this.DepotTab.Controls.Add(this.dgvDepot);
            this.DepotTab.Location = new System.Drawing.Point(4, 38);
            this.DepotTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepotTab.Name = "DepotTab";
            this.DepotTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepotTab.Size = new System.Drawing.Size(1836, 709);
            this.DepotTab.TabIndex = 2;
            this.DepotTab.Text = "Depot";
            this.DepotTab.UseVisualStyleBackColor = true;
            // 
            // btnReloadItems
            // 
            this.btnReloadItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadItems.Location = new System.Drawing.Point(945, 588);
            this.btnReloadItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadItems.Name = "btnReloadItems";
            this.btnReloadItems.Size = new System.Drawing.Size(133, 43);
            this.btnReloadItems.TabIndex = 12;
            this.btnReloadItems.Text = "Reload";
            this.btnReloadItems.UseVisualStyleBackColor = true;
            this.btnReloadItems.Click += new System.EventHandler(this.btnReloadItems_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1595, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select category:";
            // 
            // cbxItemCategory
            // 
            this.cbxItemCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemCategory.FormattingEnabled = true;
            this.cbxItemCategory.Location = new System.Drawing.Point(1581, 282);
            this.cbxItemCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxItemCategory.Name = "cbxItemCategory";
            this.cbxItemCategory.Size = new System.Drawing.Size(237, 37);
            this.cbxItemCategory.TabIndex = 6;
            this.cbxItemCategory.SelectedValueChanged += new System.EventHandler(this.cbxItemCategory_SelectedValueChanged);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(1155, 588);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(133, 43);
            this.btnDeleteItem.TabIndex = 5;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(1368, 588);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(133, 43);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1623, 366);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 46);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1607, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Item ID:";
            // 
            // tbxSearchItemById
            // 
            this.tbxSearchItemById.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchItemById.Location = new System.Drawing.Point(1623, 148);
            this.tbxSearchItemById.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSearchItemById.Name = "tbxSearchItemById";
            this.tbxSearchItemById.Size = new System.Drawing.Size(140, 41);
            this.tbxSearchItemById.TabIndex = 1;
            // 
            // dgvDepot
            // 
            this.dgvDepot.AllowUserToAddRows = false;
            this.dgvDepot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepot.Location = new System.Drawing.Point(20, 39);
            this.dgvDepot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDepot.MultiSelect = false;
            this.dgvDepot.Name = "dgvDepot";
            this.dgvDepot.RowHeadersWidth = 51;
            this.dgvDepot.RowTemplate.Height = 24;
            this.dgvDepot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepot.Size = new System.Drawing.Size(1481, 436);
            this.dgvDepot.TabIndex = 0;
            this.dgvDepot.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDepot_CellBeginEdit);
            this.dgvDepot.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepot_CellEndEdit);
            this.dgvDepot.SelectionChanged += new System.EventHandler(this.dgvDepot_SelectionChanged);
            // 
            // StatisticsTab
            // 
            this.StatisticsTab.Controls.Add(this.SalesPieChart);
            this.StatisticsTab.Controls.Add(this.tabControl1);
            this.StatisticsTab.Location = new System.Drawing.Point(4, 38);
            this.StatisticsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatisticsTab.Name = "StatisticsTab";
            this.StatisticsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatisticsTab.Size = new System.Drawing.Size(1836, 709);
            this.StatisticsTab.TabIndex = 3;
            this.StatisticsTab.Text = "Statistics";
            this.StatisticsTab.UseVisualStyleBackColor = true;
            // 
            // SalesPieChart
            // 
            this.SalesPieChart.Location = new System.Drawing.Point(1160, 73);
            this.SalesPieChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalesPieChart.Name = "SalesPieChart";
            this.SalesPieChart.Size = new System.Drawing.Size(627, 370);
            this.SalesPieChart.TabIndex = 1;
            this.SalesPieChart.Text = "pieChart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1051, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmID,
            this.EmName,
            this.EmWage});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 2);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1045, 424);
            this.dataGridView3.TabIndex = 0;
            // 
            // EmID
            // 
            this.EmID.HeaderText = "ID";
            this.EmID.MinimumWidth = 6;
            this.EmID.Name = "EmID";
            this.EmID.Width = 125;
            // 
            // EmName
            // 
            this.EmName.HeaderText = "Name";
            this.EmName.MinimumWidth = 6;
            this.EmName.Name = "EmName";
            this.EmName.Width = 125;
            // 
            // EmWage
            // 
            this.EmWage.HeaderText = "Wage";
            this.EmWage.MinimumWidth = 6;
            this.EmWage.Name = "EmWage";
            this.EmWage.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StProductDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1051, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StProductDGV
            // 
            this.StProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StProductDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrName,
            this.PrSold,
            this.PrPrice});
            this.StProductDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StProductDGV.Location = new System.Drawing.Point(3, 2);
            this.StProductDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StProductDGV.Name = "StProductDGV";
            this.StProductDGV.RowHeadersWidth = 51;
            this.StProductDGV.RowTemplate.Height = 24;
            this.StProductDGV.Size = new System.Drawing.Size(1045, 424);
            this.StProductDGV.TabIndex = 0;
            // 
            // PrName
            // 
            this.PrName.HeaderText = "Name";
            this.PrName.MinimumWidth = 6;
            this.PrName.Name = "PrName";
            this.PrName.Width = 125;
            // 
            // PrSold
            // 
            this.PrSold.HeaderText = "Sold";
            this.PrSold.MinimumWidth = 6;
            this.PrSold.Name = "PrSold";
            this.PrSold.Width = 125;
            // 
            // PrPrice
            // 
            this.PrPrice.HeaderText = "Price";
            this.PrPrice.MinimumWidth = 6;
            this.PrPrice.Name = "PrPrice";
            this.PrPrice.Width = 125;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.groupBox1);
            this.OrdersTab.Controls.Add(this.button2);
            this.OrdersTab.Controls.Add(this.button1);
            this.OrdersTab.Controls.Add(this.lblOrders);
            this.OrdersTab.Controls.Add(this.lblAlerts);
            this.OrdersTab.Controls.Add(this.btnChangeStatus);
            this.OrdersTab.Controls.Add(this.btnCancelOrder);
            this.OrdersTab.Controls.Add(this.btnRemoveAlert);
            this.OrdersTab.Controls.Add(this.btnMakeOrder);
            this.OrdersTab.Controls.Add(this.dataGridView2);
            this.OrdersTab.Controls.Add(this.dgvAlerts);
            this.OrdersTab.Location = new System.Drawing.Point(4, 38);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Size = new System.Drawing.Size(1836, 709);
            this.OrdersTab.TabIndex = 4;
            this.OrdersTab.Text = "Orders";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 71);
            this.button2.TabIndex = 9;
            this.button2.Text = "Change Priority";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1060, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 71);
            this.button1.TabIndex = 8;
            this.button1.Text = "Change Amount";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(811, 49);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(88, 29);
            this.lblOrders.TabIndex = 7;
            this.lblOrders.Text = "Orders";
            // 
            // lblAlerts
            // 
            this.lblAlerts.AutoSize = true;
            this.lblAlerts.Location = new System.Drawing.Point(186, 49);
            this.lblAlerts.Name = "lblAlerts";
            this.lblAlerts.Size = new System.Drawing.Size(74, 29);
            this.lblAlerts.TabIndex = 6;
            this.lblAlerts.Text = "Alerts";
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(1060, 241);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(132, 71);
            this.btnChangeStatus.TabIndex = 5;
            this.btnChangeStatus.Text = "Toggle Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(1060, 395);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(132, 71);
            this.btnCancelOrder.TabIndex = 4;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAlert
            // 
            this.btnRemoveAlert.Location = new System.Drawing.Point(477, 395);
            this.btnRemoveAlert.Name = "btnRemoveAlert";
            this.btnRemoveAlert.Size = new System.Drawing.Size(132, 71);
            this.btnRemoveAlert.TabIndex = 3;
            this.btnRemoveAlert.Text = "Remove Alert";
            this.btnRemoveAlert.UseVisualStyleBackColor = true;
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(477, 241);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(132, 71);
            this.btnMakeOrder.TabIndex = 2;
            this.btnMakeOrder.Text = "Make Order";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(650, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(394, 559);
            this.dataGridView2.TabIndex = 1;
            // 
            // dgvAlerts
            // 
            this.dgvAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlerts.Location = new System.Drawing.Point(50, 91);
            this.dgvAlerts.Name = "dgvAlerts";
            this.dgvAlerts.RowHeadersWidth = 62;
            this.dgvAlerts.RowTemplate.Height = 24;
            this.dgvAlerts.Size = new System.Drawing.Size(411, 559);
            this.dgvAlerts.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lblSortAlerts);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(1331, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 347);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(51, 99);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 33);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Priority";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(51, 150);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 33);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Time";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblSortAlerts
            // 
            this.lblSortAlerts.AutoSize = true;
            this.lblSortAlerts.Location = new System.Drawing.Point(46, 57);
            this.lblSortAlerts.Name = "lblSortAlerts";
            this.lblSortAlerts.Size = new System.Drawing.Size(163, 29);
            this.lblSortAlerts.TabIndex = 2;
            this.lblSortAlerts.Text = "Sort Alerts By:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(51, 218);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(296, 33);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show completed orders";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1872, 806);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Text = "Hello";
            this.Tabs.ResumeLayout(false);
            this.ScheduleTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.EmployeesTab.ResumeLayout(false);
            this.EmployeesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.DepotTab.ResumeLayout(false);
            this.DepotTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepot)).EndInit();
            this.StatisticsTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StProductDGV)).EndInit();
            this.OrdersTab.ResumeLayout(false);
            this.OrdersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage ScheduleTab;
        private System.Windows.Forms.TabPage EmployeesTab;
        private System.Windows.Forms.TabPage DepotTab;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearchItemById;
        private System.Windows.Forms.DataGridView dgvDepot;
        private System.Windows.Forms.TabPage StatisticsTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView StProductDGV;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.ComboBox cbxItemCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSearchEmployeeByName;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnReloadEmployees;
        private System.Windows.Forms.Button btnReloadItems;
        private LiveCharts.WinForms.PieChart SalesPieChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmWage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnRemoveAlert;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgvAlerts;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblAlerts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblSortAlerts;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}