using System;

namespace HRApplication
{
    //inherits from the Employee class
    public class SalariedEmployee : Employee
    {
        public SalariedEmployee()
        {
        }
        
        public SalariedEmployee(string firstName,
                                string lastName,
                                string address,
                                string postCode,
                                string phoneNumber,
                                DateTime dateOfBirth,
                                decimal salary) : base( firstName, lastName, address, postCode, phoneNumber, dateOfBirth )
        {
            //gives Salary a value
            Salary = salary;
        }
        
        public decimal Salary
        {
            get;
            set;
        }

        public override string ToString( )
        {
            return "S|" + base.ToString( ) + "|" + Salary.ToString();
        }
    }
}
