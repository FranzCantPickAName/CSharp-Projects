
using System.Globalization;

namespace MyClasses
{
    public sealed class Manager : IPerson, IEmployee
    {
        //fields
        private DateTime _dateOfBirth;

        private int _empID;
        private string _empName;
        protected string _location;

        private string _departmentName;

        //properties
        public string DepartmentName
        {
            set
            {
                _departmentName = value;
            }
            get
            {
                return _departmentName;
            }

        }

        public int EmpID
        {
            set
            {
                if (value >= 100 && value <= 2000)
                {
                    _empID = value;
                }
            }
            get
                    {
                return (_empID);
                }
        }

        public string EmpName
        {
            set
            {
                _empName = value;
            }
            get
            {
                return _empName;
            }

        }

        public string Location
        {
            set
            {
                _location = value;
            }
            get
            {
                return _location;
            }
        }

        public DateTime DateOfBirth
        {
            set
            {
                _dateOfBirth = value;
            }
            get
            {
                return _dateOfBirth;
            }

        }

        //methods
        public long GetTotalSalesOfTheYear()
        {
            return 10000;
        }

        public string GetFullDepartmentName()
        {
            return DepartmentName + " at " + _location;
        }

        //public sealed override string GetHealthInsuranceAmount()
        //{
        //    Console.WriteLine(base.GetHealthInsuranceAmount());
        //    return "Health Insurance amount is: 1500";
        //}
        public string GetHealthInsuranceAmount()
        {
            return "Health Insurance amount is: 1500";
        }

        public int GetAge()
        {
            int a = Convert.ToInt32((DateTime.Now - DateOfBirth).TotalDays / 365);
            return a;
        }


        //constructors
        public Manager(int empID, string empName, string location, string departmentName)
        {
            _empID = empID;
            _empName= empName;
            _location = location;
            _departmentName = departmentName;
        }

    }

    //public class BranchManager : Manager
    //{
    //    //constructors
    //    public BranchManager(int empID, string empName, string location, string departmentName) : base(empID, empName, location, departmentName)
    //    {

    //    }

    //    //public override string GetHealthInsuranceAmount()
    //    //{

    //    //}
    //}

}
