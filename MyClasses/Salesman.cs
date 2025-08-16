
namespace MyClasses
{
    public class Salesman : Employee
    {
        //fields
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

        //methods
        public long GetSalesOfTheCurrentMonth()
        {
            return 10000;
        }

        public sealed override string GetHealthInsuranceAmount()
        {
            return "Health Insurance amount is: 500";
        }

        //constructors
        public Salesman(int empID, string empName, string location, string region) : base(empID, empName, location)
        {
            this.Region = region;
        }

    }
}
