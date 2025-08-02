using ConsoleApp1;
using System.Globalization;



Product product1, product2, product3;

product1 = new Product();
Task.Delay(1000).Wait();
Product.SetProductTotalNoProduct(Product.GetProductTotalNoProduct() + 1);
product2 = new Product();
Task.Delay(1000).Wait();
Product.SetProductTotalNoProduct(Product.GetProductTotalNoProduct() + 1);
product3 = new Product();
Task.Delay(1000).Wait();
Product.SetProductTotalNoProduct(Product.GetProductTotalNoProduct() + 1);

Product product4 = new Product();

Student s = new Student();

//s.DisplaySubjects("Theory of Computation", "Computer Networks", "Discrete Mathematics", "Digital Systems");

//s.DisplayMarks(80, 44, 60);

//Console.WriteLine("Fib of 7 is: " + s.Fib(7));

//Employee emp1 = new Employee(101,"Scott","Manager");
Employee emp1 = new Employee();
emp1.empID = 101;
emp1.empName = "Scott";
emp1.empJob = "Manager";

//Employee emp2 = new Employee(102,"Allen","Asst. Manager");
Employee emp2 = new Employee(102,"Allen");
emp2.empJob = "Asst. Manager";

Employee emp3 = new Employee(103,"Anna","Clerk");

Employee emp4 = new Employee() { empName = "Ford", empJob = "Executive" };

Console.WriteLine(Employee.companyName);

Console.WriteLine("First employee: ");
Console.WriteLine(emp1.empID);
Console.WriteLine(emp1.empName);
Console.WriteLine(emp1.empJob);
Console.WriteLine();

Console.WriteLine("Second employee: ");
Console.WriteLine(emp2.empID);
Console.WriteLine(emp2.empName);
Console.WriteLine(emp2.empJob);
Console.WriteLine();

Console.WriteLine("Third employee: ");
Console.WriteLine(emp3.empID);
Console.WriteLine(emp3.empName);
Console.WriteLine(emp3.empJob);
Console.WriteLine();

Console.WriteLine("Fourth employee: ");
Console.WriteLine(emp4.empID);
Console.WriteLine(emp4.empName);
Console.WriteLine(emp4.empJob);
Console.WriteLine();

product1.SetProductID(1001);
product1.SetProductName("Mobile");
product1.SetProductCost(20000);
product1.SetProductQuantityInStock(1200);
product1.SetProductDateTime(new DateTime(1990,01,20,0,0,0,0));
//product1.persianbirthDateTime = Convert.ToString(new DateTime(2025, 07, 26, myPersianCalendar));

product2.SetProductID(1002);
product2.SetProductName("Laptop");
product2.SetProductCost(40000);
product2.SetProductQuantityInStock(900);
product2.SetProductDateTime(new DateTime(1990, 01, 20, 0, 0, 0, 0));

product3.SetProductID(1003);
product3.SetProductName("Speaker");
product3.SetProductCost(10000);
product3.SetProductQuantityInStock(1100);
product3.SetProductDateTime(new DateTime(1990, 01, 20, 0, 0, 0, 0));

double p = 11;
double q = 10;
double r;
product1.CalculateTax(q);
product2.CalculateTax(out r);
Console.WriteLine("R: " + r);
Console.WriteLine("Q: " + q);
product3.CalculateTax(percentageLow:9, percentageHigh:13);

//Console.WriteLine("\n Product 1:");
//Console.WriteLine("Product ID: " + product1.GetProductID());
//Console.WriteLine("Product Name: " + product1.GetProductName());
//Console.WriteLine("Product cost: " + product1.GetProductCost());
//Console.WriteLine("Quantity in stock: " + product1.GetProductQuantityInStockID());
//Console.WriteLine("Date of produce: " + product1.GetProductDateOfProduce());
//Console.WriteLine("Product tax is: " + product1.GetProductTax());

//Console.WriteLine("\n Product 2:");
//Console.WriteLine("Product ID: " + product2.GetProductID());
//Console.WriteLine("Product Name: " + product2.GetProductName());
//Console.WriteLine("Product cost: " + product2.GetProductCost());
//Console.WriteLine("Quantity in stock: " + product2.GetProductQuantityInStockID());
//Console.WriteLine("Date of produce: " + product2.GetProductDateOfProduce());
//Console.WriteLine("Product tax is: " + product2.GetProductTax());

//Console.WriteLine("\n Product 3:");
//Console.WriteLine("Product ID: " + product3.GetProductID());
//Console.WriteLine("Product Name: " + product3.GetProductName());
//Console.WriteLine("Product cost: " + product3.GetProductCost());
//Console.WriteLine("Quantity in stock: " + product3.GetProductQuantityInStockID());
//Console.WriteLine("Date of produce: " + product3.GetProductDateOfProduce());
//Console.WriteLine("Product tax is: " + product3.GetProductTax());

//Console.WriteLine("\nTotal number of products: " + Product.GetProductTotalNoProduct());
//Console.WriteLine("Total quantity of products: " + Product.GetTotalQuantity(product1, product2, product3));
//Console.WriteLine("Category name is: " + Product.GetCategoryName());


Console.ReadKey();

//public class ForeignProduct: ConsoleApp1.Product
//{
//    public void MyMethod()
//    {
//        productID = 1;
//        productName = null;
//        cost = 0;
//        quantityInStock = 0;
//        birthDateTime = DateTime.Now;
//        //MyMethod1();
//        //MyMethod2();
//    }
//}

//public class ForeignOtherProduct
//{
//    public void MyMethod()
//    {
//        ConsoleApp1.Product product = new ConsoleApp1.Product();
//        product.productID = 1;
//        product.productName = null;
//        product.cost = 0 ;
//        product.quantityInStock = 0;
//        product.birthDateTime = DateTime.Now;
//        //MyMethod1();
//        //MyMethod2();
//    }
//}

