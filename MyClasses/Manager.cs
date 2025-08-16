
using System.Globalization;

namespace MyClasses
{
    public sealed class Manager : Employee
    {
        //fields
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

        //methods
        public long GetTotalSalesOfTheYear()
        {
            return 10000;
        }

        public string GetFullDepartmentName()
        {
            return DepartmentName + " at " + base._location;
        }

        //public sealed override string GetHealthInsuranceAmount()
        //{
        //    Console.WriteLine(base.GetHealthInsuranceAmount());
        //    return "Health Insurance amount is: 1500";
        //}
        public override string GetHealthInsuranceAmount()
        {
            return "Health Insurance amount is: 1500";
        }


        //constructors
        public Manager(int empID, string empName, string location, string departmentName) : base(empID, empName, location)
        {
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
