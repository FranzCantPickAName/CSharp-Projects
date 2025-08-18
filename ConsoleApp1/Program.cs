using HR;
using MyManager = HR.Mgr;
using HR.Mgr;
using FrontOffice;
using static System.Console;
using Warehouse;

IManager manager;
manager = new Manager();

MyManager.IManager myManager = new MyManager.Manager();

CustomerInquiry customerInquiry = new CustomerInquiry();

WriteLine("Manager class");
WriteLine();

Product product = new Product();

product.ProductID = 101;
product.Cost = 1000;

product.CallGetTax();

WriteLine();

WriteLine(Country.CountryName);
WriteLine(Country.NoOfStates);
WriteLine(Country.GetNoOfCities());

Person person = new Person();
person.PersonName = "John";
person.Email = "john@gmail.com";
//person.AgeGroup = ((int) AgeGroupEnumeration.Adult).ToString();

//WriteLine(person.AgeGroup);
//WriteLine(person.AgeGroup);

ReadKey();



