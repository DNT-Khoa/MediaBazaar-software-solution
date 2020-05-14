﻿using MediaBazaarSolution.DAO;
using MediaBazaarSolution.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarSolution
{
    
    public partial class ScheduleForm : Form
    {
        private int workDayID;
        private ListView passedListView;
        private MainScreen parentForm;
        private List<Employee> availableEmployees;

        public ScheduleForm(MainScreen parent, int workDayID, ref ListView listView)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.workDayID = workDayID;
            this.passedListView = listView;

            FillAvailableWorkers();
            FillWorkersOnShift();
           
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            int employeeID = (lbxAvailableWorkers.SelectedItem as Employee).ID;

            if (lbxAvailableWorkers.SelectedIndex < 0)
            {
                MessageBox.Show("Please specify a worker to select!", "Add worker warnig!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if(lbxWorkersOnShift.Items.Count == 1)
            {
                MessageBox.Show("No more than one person is allowed to work on a shift!", "Require number of employees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (ScheduleDAO.Instance.AddEmployeeToShift(employeeID, workDayID))
                {
                    foreach(Employee employee in availableEmployees )
                    {
                        if (employee.ID == employeeID)
                        {
                            lbxWorkersOnShift.Items.Add(employee);
                            ListViewItem lvItem = new ListViewItem(employee.ID.ToString());
                            lvItem.SubItems.Add(employee.FirstName + " " + employee.LastName);
                            this.passedListView.Items.Add(lvItem);
                        }
                    }
                    MessageBox.Show("Successfully added the employee on shift!", "Successful Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                } else
                {
                    MessageBox.Show("Failed to add the employee on shift!", "Fail Notitfication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnRemoveWorker_Click(object sender, EventArgs e)
        {
            if (lbxWorkersOnShift.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a employee to be deleted from shift schedule!", "Remove Worker Notitfication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                int employeeID = (lbxWorkersOnShift.SelectedItem as Employee).ID;


                if (ScheduleDAO.Instance.RemoveEmployeeFromShift(employeeID, workDayID))
                {
                    lbxWorkersOnShift.Items.RemoveAt(lbxWorkersOnShift.SelectedIndex);
                    MessageBox.Show("Successfully removed the worker from shift schedule", "Remove Worker Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.passedListView.Items.Clear();
                } else
                {
                    MessageBox.Show("Failed to remove the worker from the worker on shift schedule!", "Remove Worker Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            if (lbxWorkersOnShift.Items.Count > 1)
            {
                MessageBox.Show("No more than one employee is allowed to work on shift!");
            } else
            {
                MessageBox.Show("Successfully saved !");
            }
        }

        private void FillAvailableWorkers()
        {
            availableEmployees = EmployeeDAO.Instance.GetAllEmployeesOnly();

            foreach(Employee employee in availableEmployees)
            {
                lbxAvailableWorkers.Items.Add(employee);
            }
        }

        private void FillWorkersOnShift()
        {
            List<Employee> employeeList = EmployeeDAO.Instance.GetAllEmployeesOnShift(this.workDayID);
            
            foreach(Employee employee in employeeList)
            {
                lbxWorkersOnShift.Items.Add(employee);
               
            }
        }

        
    }
}
