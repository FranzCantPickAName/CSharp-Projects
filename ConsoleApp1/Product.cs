namespace ConsoleApp1
{
    public class Product
    {
        public int productID;
        public string? productName;
        public double cost;
        public int quantityInStock;
        public DateTime birthDateTime;
        public string? persianbirthDateTime;
        public void MyMethod()
        {
            productID = 1;
            productName = null;
            cost = 0;
            quantityInStock = 0;
            birthDateTime = DateTime.Now;
        }
    }

    public class DomesticProduct: Product
    {
        public void MyMethod()
        {
            productID = 1;
            productName = null;
            cost = 0;
            quantityInStock = 0;
            birthDateTime = DateTime.Now;
        }
    }
    public class OtherProductClass
    {
        public void MyMethod()
        {
            Product product = new Product();    
            product.productID = 1;
            product.productName = null;
            product.cost = 0;
            product.quantityInStock = 0;
            product.birthDateTime = DateTime.Now;
        }
        
    }



}
