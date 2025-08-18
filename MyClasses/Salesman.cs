
namespace MyClasses
{
    public class Salesman : IEmployee
    {
        //fields
        private int _empID;
        private string _empName;
        protected string _location;

        private string _region;

        //properties
        public string Region
        {
            set
            {
                _region = value;
            }
            get
            {
                return _region;
            }
        }

        public int EmpID
        {
            set
            {
                if (value >= 500 && value <= 1000)
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

        //methods
        public long GetSalesOfTheCurrentMonth()
        {
            return 10000;
        }

        public string GetHealthInsuranceAmount()
        {
            return "Health Insurance amount is: 2000";
        }

        //public sealed override string GetHealthInsuranceAmount()
        //{
        //    return "Health Insurance amount is: 500";
        //}

        //constructors
        public Salesman(int empID, string empName, string location, string region) 
        {
            _empID = empID;
            _empName = empName;
            _location = location;
            _region = region;
        }

    }
}
