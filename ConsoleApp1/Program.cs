using System.Globalization;
Product product1, product2, product3;

product1 = new Product();
product2 = new Product();
product3 = new Product();

Product product4 = new Product();

PersianCalendar myPersianCalendar = new PersianCalendar();

string myPersianConvertedDateTime = myPersianCalendar.GetYear(DateTime.Now) + "/" + myPersianCalendar.GetMonth(DateTime.Now) + "/" + myPersianCalendar.GetDayOfMonth(DateTime.Now);
string userPersianDateTime;
string[] userSeperatedPersianDateTime;

userPersianDateTime = Console.ReadLine();
userSeperatedPersianDateTime = userPersianDateTime.Split('/');

DateTime userGregoianDateTime = Convert.ToDateTime(Console.ReadLine());
string userConvertedPersianDateTime = myPersianCalendar.GetYear(userGregoianDateTime) + "/" + myPersianCalendar.GetMonth(userGregoianDateTime) + "/" + myPersianCalendar.GetDayOfMonth(userGregoianDateTime);

product1.productID = 1001;
product1.productName = "Mobile";
product1.cost = 20000;
product1.quantityInStock = 1200;
product1.birthDateTime = new DateTime(1990,01,20,0,0,0,0);
//product1.persianbirthDateTime = Convert.ToString(new DateTime(2025, 07, 26, myPersianCalendar));
product1.persianbirthDateTime = myPersianConvertedDateTime;
product2.productID = 1002;
product2.productName = "Laptop";
product2.cost = 40000;
product2.quantityInStock = 900;
product3.productID = 1003;
product3.productName = "Speaker";
product3.cost = 10000;
product3.quantityInStock = 1100;

Console.WriteLine("Product 1:");
Console.WriteLine("Product ID: " + product1.productID);
Console.WriteLine("Product Name: " + product1.productName);
Console.WriteLine("Product cost: " + product1.cost);
Console.WriteLine("Quantity in stock: " + product1.quantityInStock);
Console.WriteLine("Product produce Date and Time: " + product1.birthDateTime);
Console.WriteLine("Product produce Date and Time: " + product1.persianbirthDateTime);
Console.WriteLine("User birth date in Gregorian calendar is: " + myPersianCalendar.ToDateTime(Convert.ToInt16(userSeperatedPersianDateTime[0]), Convert.ToInt16(userSeperatedPersianDateTime[1]), Convert.ToInt16(userSeperatedPersianDateTime[2]), 0, 0, 0, 0));
Console.WriteLine("User birth date in Persian calendar is: " + userConvertedPersianDateTime);

var internationPizzaDay = new DateTime(2023, 2, 9);

Console.WriteLine();
Console.WriteLine("Year: " + internationPizzaDay.Year);
Console.WriteLine("Month: " + internationPizzaDay.Month);
Console.WriteLine("Day: " + internationPizzaDay.Day);
Console.WriteLine("Day of the week: " + internationPizzaDay.DayOfWeek);

var internationPizzaDayNext = internationPizzaDay.AddYears(1);

Console.WriteLine();
Console.WriteLine("Year: " + internationPizzaDayNext.Year);
Console.WriteLine("Month: " + internationPizzaDayNext.Month);
Console.WriteLine("Day: " + internationPizzaDayNext.Day);
Console.WriteLine("Day of the week: " + internationPizzaDayNext.DayOfWeek);

Console.ReadKey();
public class Product
{
    public int productID;
    public string? productName;
    public double cost;
    public int quantityInStock;
    public DateTime birthDateTime;
    public string? persianbirthDateTime;
}

