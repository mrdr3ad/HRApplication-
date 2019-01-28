using System;

namespace HRApplication
{
    public class Employee : IComparable
    {
        
        public Employee()
        {
        }
        
        public Employee(string firstName,
                        string lastName,
                        string address,
                        string postCode,
                        string phoneNumber,
                        DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PostCode = postCode;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }                       
        
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public string PostCode
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public DateTime DateOfBirth
        {
            get;
            set;
        }

        public int CompareTo( object obj )
        {
            if ( obj is Employee )
            {
                return this.LastName.CompareTo( ((Employee)obj).LastName );
            }
            else
            {
                throw new InvalidCastException( "Unexpected Object Type" );
            }
        }

        //for the text file 
        public override string ToString( )
        {
            return LastName + "|" +
                   FirstName + "|" +
                   Address + "|" +
                   PostCode + "|" +
                   PhoneNumber + "|" +
                   DateOfBirth.Year.ToString() + "|" +
                   DateOfBirth.Month.ToString() + "|" +
                   DateOfBirth.Day.ToString();
        }
    }
}
