using System;

namespace HRApplication
{
    public class HourlyEmployee : Employee
    {
        public HourlyEmployee()
        {
        }

        public HourlyEmployee( string firstName,
                              string lastName,
                              string address,
                              string postCode,
                              string phoneNumber,
                              DateTime dateOfBirth,
                              decimal hourlyPay,
                              decimal overtimePay ): base( firstName, lastName, address, postCode, phoneNumber, dateOfBirth )
        {
            HourlyPay = hourlyPay;
            OvertimePay = overtimePay;
        }

        public decimal HourlyPay
        {
            get;
            set;
        }

        public decimal OvertimePay
        {
            get;
            set;
        }

        public override string ToString( )
        {
            return "H|" + base.ToString( ) + "|" + HourlyPay.ToString( ) + "|" + OvertimePay.ToString();
        }

    }
}
