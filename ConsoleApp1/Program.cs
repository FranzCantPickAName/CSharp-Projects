using ConsoleApp1;
using MyClasses;
using System.Globalization;
using System.Threading.Channels;
using System.Xml;

//create object of Employee
//Employee emp1 = new Employee(101, "Scott", "Hyderabad");
////emp1.EmpID = 101;
////emp1.EmpName = "Scott";
////emp1.Location = "Hyderabad";
//Console.WriteLine("Object of Parent class (Employee): ");
//Console.WriteLine(emp1.EmpID);
//Console.WriteLine(emp1.EmpName);
//Console.WriteLine(emp1.Location);
//Console.WriteLine();

//create object of Manager
Manager mgr1 = new Manager(102, "Allen", "New York", "Accounting");
mgr1.DateOfBirth = Convert.ToDateTime("1990-07-15");
//mgr1.EmpID = 102;
//mgr1.EmpName = "Allen";
//mgr1.Location = "New York";
//mgr1.DepartmentName = "Accounting";
Console.WriteLine("Object of Child class (Manager): ");
Console.WriteLine(mgr1.EmpID);
Console.WriteLine(mgr1.EmpName);
Console.WriteLine(mgr1.GetAge());
Console.WriteLine(mgr1.Location);
Console.WriteLine(mgr1.DepartmentName);
Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
Console.WriteLine(mgr1.GetFullDepartmentName());
Console.WriteLine(mgr1.GetHealthInsuranceAmount());
Console.WriteLine();

//create object of Salesman
Salesman salesman1 = new Salesman(103, "John", "Washington", "East");
//salesman1.EmpID = 103;
//salesman1.EmpName = "John";
//salesman1.Location = "Washington";
//salesman1.Region = "East";
Console.WriteLine("Object of Child class (Salesman): ");
Console.WriteLine(salesman1.EmpID);
Console.WriteLine(salesman1.EmpName);
Console.WriteLine(salesman1.Location);
Console.WriteLine(salesman1.Region);
Console.WriteLine(salesman1.GetSalesOfTheCurrentMonth());
Console.WriteLine(salesman1.GetHealthInsuranceAmount());
Console.WriteLine();

Console.ReadKey();



