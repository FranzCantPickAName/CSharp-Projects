namespace ConsoleApp1
{
    public class EmployeeOld
    {
        private int _empID;
        private string _empName;
        private string _empJob;

        private double _salary = 5000;
        private double _tax;

        private static string _companyName;

        public int EmpID
        {
            set
            {
                if (value > -100)
                {
                    _empID = value;
                }
            }
            get { return _empID; }
        }

        public string EmpName
        {
            set { _empName = value; }
            get { return _empName; }
        }

        public string EmpJob
        {
            set { _empJob = value; }
            get { return _empJob; }
        }

        public static string CompanyName
        {
            set { _companyName = value; }
            get { return _companyName; }
        }

        public double Salary
        {
            get { return _salary; }
        }

        public double Tax
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _tax = value;
                }
            }
        }

        public double CalculateNetSalary()
        {
            double netSalary = Salary - _tax;
            return netSalary;
        }

        public EmployeeOld(int empID, string empName, string empJob)
        {
            _empID = empID;
            _empName = empName;
            _empJob = empJob;
        }

        public EmployeeOld(int empID, string empName)
        {
            _empID = empID;
            _empName = empName;
        }

        public EmployeeOld()
        {
            _empID = 1;
        }
        static EmployeeOld()
        {
            _companyName = "ABC Industries";
        }

    }
}
