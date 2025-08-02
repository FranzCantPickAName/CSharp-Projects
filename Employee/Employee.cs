namespace ConsoleApp1
{
    public class Employee
    {
        public int empID;
        public string empName;
        public string empJob;

        public static string companyName;

        public Employee(int empID, string empName, string empJob)
        {
            this.empID = empID;
            this.empName = empName;
            this.empJob = empJob;
        }

        public Employee(int empID, string empName)
        {
            this.empID = empID;
            this.empName = empName;
        }

        public Employee()
        {
            empID = 1;
        }
        static Employee()
        {
            companyName = "ABC Industries";
        }

    }
}
