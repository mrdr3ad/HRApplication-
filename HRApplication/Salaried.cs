using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApplication
{
    public partial class Salaried2 : Form
    {
        public Salaried2( )
        {
            InitializeComponent();
        }

        public Employees Employees
        {
            get;
            set;
        }

        public SalariedEmployee Employee
        {
            get;
            set;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Boolean AddToCollection = false;

            if ( Employee == null )
            {
                Employee = new SalariedEmployee( );
                AddToCollection = true;
            }

            Employee.FirstName   = firstBox.Text;
            Employee.LastName    = lastBox.Text;
            Employee.Address     = adBox.Text;
            Employee.PostCode    = postBox.Text;
            Employee.PhoneNumber = mobBox.Text;
            Employee.DateOfBirth = dobPicker.Value;
            Employee.Salary      = decimal.Parse( annualBox.Text );

            if ( AddToCollection && Employees != null )
            {
                Employees.Add( Employee );
            }
            
            Close();
        }

        public new DialogResult ShowDialog( )
        {
            if ( Employee != null )
            {
                 firstBox.Text   = Employee.FirstName   ;
                 lastBox.Text    = Employee.LastName    ;
                 adBox.Text      = Employee.Address     ;
                 postBox.Text    = Employee.PostCode    ;
                 mobBox.Text     = Employee.PhoneNumber ;
                 dobPicker.Value = Employee.DateOfBirth;
                 annualBox.Text  = Employee.Salary.ToString( );
            }

            return base.ShowDialog( );
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
