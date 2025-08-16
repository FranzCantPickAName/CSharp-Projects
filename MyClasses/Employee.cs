
namespace MyClasses
{
    public abstract class Employee
    {
        //fields
        private int _empID;
        private string _empName;
        protected string _location;

        //properties
        public int EmpID
        {
            set
            {
                _empID = value;
            }
            get
            {
                return _empID;
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
            { _location = value; }
            get
            { return _location; }
        }

        //methods
        //public virtual string GetHealthInsuranceAmount()
        //{
        //    return "Health Insurance amount is: " + 500;
        //}
        public abstract string GetHealthInsuranceAmount();

        //constructors
        public Employee(int empID, string empName, string location)
        {
            this._empID = empID;
            this._empName = empName;
            this._location = location;
        }


    }

}
