using System;
using System.Windows.Forms;

namespace HRApplication
{
    public partial class Hourly : Form  //Salaried
    {
        public Hourly() 
        {
            InitializeComponent();
        }

        public Employees Employees
        {
            get;
            set;
        }

        public HourlyEmployee Employee
        {
            get;
            set;
        }

        private void saveButton_Click( object sender, System.EventArgs e )
        {
            Boolean AddToCollection = false;

            if ( Employee == null )
            {
                Employee = new HourlyEmployee( );
                AddToCollection = true;
            }

            Employee.FirstName   = firstBox.Text;
            Employee.LastName    = lastBox.Text;
            Employee.Address     = adBox.Text;
            Employee.PostCode    = postBox.Text;
            Employee.PhoneNumber = mobBox.Text;
            Employee.DateOfBirth = dobPicker.Value;
            Employee.HourlyPay   = decimal.Parse( hourlyBox.Text );
            Employee.OvertimePay = decimal.Parse( overtimeBox.Text );

            if ( AddToCollection && Employees != null )
            {
                Employees.Add( Employee );
            }

            Close( );
        }

        private void cancelButton_Click( object sender, System.EventArgs e )
        {
            Close( );
        }

        public new DialogResult ShowDialog( )
        {
            if ( Employee != null )
            {
                 firstBox.Text   = Employee.FirstName   ;
                 lastBox.Text    = Employee.LastName    ;
                 adBox.Text      = Employee.Address     ;
                 postBox.Text    = Employee.PostCode   ;
                 mobBox.Text     = Employee.PhoneNumber ;
                 dobPicker.Value = Employee.DateOfBirth;
                 hourlyBox.Text = Employee.HourlyPay.ToString( );
                overtimeBox.Text = Employee.OvertimePay.ToString( );
            }

            return base.ShowDialog( );
        }

    }
}
