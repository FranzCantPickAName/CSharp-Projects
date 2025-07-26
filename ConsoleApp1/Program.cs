
Product product1, product2, product3;

product1 = new Product();
product2 = new Product();
product3 = new Product();

Product product4 = new Product();

product1.productID = 1001;
product1.productName = "Mobile";
product1.cost = 20000;
product1.quantityInStock = 1200;
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
public class Product
{
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
}

