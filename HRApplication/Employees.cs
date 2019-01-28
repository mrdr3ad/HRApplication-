using System;
using System.Collections.Generic;
using System.IO;

namespace HRApplication
{
    public class Employees : List<Employee>
    {
        public Employees( )
        {
        }


        private void SEmplyeeFromString( string data )
        {
            var DataArray = data.Split( '|' );

            SalariedEmployee _SalariedEmployee = new SalariedEmployee( );

            _SalariedEmployee.Address     = DataArray[ 3 ];
            _SalariedEmployee.DateOfBirth = new DateTime( Int32.Parse( DataArray[ 6 ] ), Int32.Parse( DataArray[ 7 ] ), Int32.Parse( DataArray[ 8 ] ) );
            _SalariedEmployee.FirstName   = DataArray[ 2 ];
            _SalariedEmployee.LastName    = DataArray[ 1 ];
            _SalariedEmployee.PhoneNumber = DataArray[ 5 ];
            _SalariedEmployee.PostCode    = DataArray[ 4 ];
            _SalariedEmployee.Salary      = decimal.Parse( DataArray[ 9 ] );

            this.Add( _SalariedEmployee );
        }

        private void HEmplyeeFromString( string data )
        {
            var DataArray = data.Split( '|' );

            HourlyEmployee _HourlyEmployee = new HourlyEmployee( );

            _HourlyEmployee.Address     = DataArray[ 3 ];
            _HourlyEmployee.DateOfBirth = new DateTime( Int32.Parse( DataArray[ 6 ] ), Int32.Parse( DataArray[ 7 ] ), Int32.Parse( DataArray[ 8 ] ) );
            _HourlyEmployee.FirstName   = DataArray[ 2 ];
            _HourlyEmployee.HourlyPay   = decimal.Parse( DataArray[ 9 ] ); 
            _HourlyEmployee.LastName    = DataArray[ 1 ];
            _HourlyEmployee.OvertimePay = decimal.Parse( DataArray[ 10 ] );
            _HourlyEmployee.PhoneNumber = DataArray[ 5 ];
            _HourlyEmployee.PostCode    = DataArray[ 4 ];

            this.Add( _HourlyEmployee );
        }

        public bool Load( string fileName )
        {
            if ( !File.Exists( "employees.txt" ) )
                return false;

            foreach ( string Line in File.ReadAllLines( "employees.txt" ) )
            {
                switch ( Line[ 0 ] )
                {
                    case 'H':
                        HEmplyeeFromString( Line );
                        break;

                    case 'S':
                        SEmplyeeFromString( Line );
                        break;

                    default:
                        throw new System.InvalidCastException( "Malformed String: " + Line );
                }
            }

            return true;
        }

        public bool Save( string filename )
        {
            

            using ( StreamWriter newTask = new StreamWriter( filename, false ) )
            {
                foreach ( Employee v in this )
                {
                    newTask.WriteLine( v.ToString( ) );
                }
            }

            return true;
        }
    }
}
