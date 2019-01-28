using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplication
{
    public partial class MainForm : Form
    {
        // The file used to store employee details
        string employeesFile = "employees.txt";
        
        // The collection used to hold the employee data
        Employees employees;
    
        public MainForm()
        {
            InitializeComponent();
        }

        //method to load employees text file 
        private void MainForm_Load(object sender, EventArgs e)
        {
            employees = new Employees();
            if (!employees.Load(employeesFile))
            {
                MessageBox.Show("Unable to load employees file");
            }
            else
            {
                PopulateListBox();
            }
        }
        
        private void PopulateListBox()
        {
            listBoxEmployees.Items.Clear();
            
            employees.Sort();
            foreach (Employee employee in employees)
            {
                listBoxEmployees.Items.Add(employee.LastName + ", " + employee.FirstName);
            }
            listBoxEmployees.SelectedIndex = 0;
        }

        private void listBoxEmployees_DoubleClick(object sender, EventArgs e)
        {
            //allows user to edit the selected employee 

            buttonEdit_Click( sender, e );
        }

        private void buttonNewSalaried_Click(object sender, EventArgs e)
        {
            //creates a new instance of a salaried employee 
            Salaried2 salaried = new Salaried2( );

            salaried.Employees = employees;

            salaried.ShowDialog();
            //saves employee
            employees.Save( employeesFile );
            PopulateListBox( );
        }

        private void buttonNewHourly_Click(object sender, EventArgs e)
        {
            
            Hourly hourly = new Hourly( );

            hourly.Employees = employees;
            hourly.ShowDialog();
            employees.Save( employeesFile );
            PopulateListBox( );
        }

        //opens the form to edit an employee 
        private void buttonEdit_Click( object sender, EventArgs e )
        {
           
            var selected = employees[ listBoxEmployees.SelectedIndex ];

            //checks wether employee is a salaried or hourly
            if ( selected is SalariedEmployee )
            {
                var dialog = new Salaried2( );
                dialog.Employee = ( selected as SalariedEmployee );
                dialog.ShowDialog( );
            }
            else
            {
                var dialog = new Hourly( );
                dialog.Employee = ( selected as HourlyEmployee );
                dialog.ShowDialog( );
            }

            employees.Save( employeesFile );
            PopulateListBox( );
        }
    }
}