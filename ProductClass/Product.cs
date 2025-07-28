namespace ConsoleApp1
{
    public class Product
    {
        private int productID;
        private string? productName;
        private double cost;
        private int quantityInStock;
        public DateTime birthDateTime;
        //public string? persianbirthDateTime;
        public static int totalNoProducts;
        public const string categoryName = "Electronics";
        private readonly string dateOfProduce;
        private double calculatedTax;

        public Product()
        {
            //totalNoProducts = 0;
            dateOfProduce = DateTime.Now.ToString();
        }

        public void SetProductID(int value)
        {
            productID = value;
        }
        public int GetProductID()
        {
            return productID;
        }

        public void SetProductName(string value)
        {
            productName = value;
        }
        public string GetProductName()
        {
            return productName;
        }

        public void SetProductCost(double value)
        {
            cost = value;
        }
        public double GetProductCost()
        {
            return cost;
        }

        public void SetProductQuantityInStock(int value)
        {
            quantityInStock = value;
        }
        public int GetProductQuantityInStockID()
        {
            return quantityInStock;
        }

        public void SetProductDateTime(DateTime value)
        {
            birthDateTime = value;
        }
        public DateTime GetProductDateTime()
        {
            return birthDateTime;
        }

        public static void SetProductTotalNoProduct(int value)
        {
            totalNoProducts = value;
        }
        public static int GetProductTotalNoProduct()
        {
            return totalNoProducts;
        }

        public string GetProductDateOfProduce()
        {
            return dateOfProduce;
        }

        public static string GetCategoryName()
        {
            return categoryName;
        }

        public static int GetTotalQuantity(Product product1, Product product2, Product product3)
        {
            int total = 0;
            total = product1.GetProductQuantityInStockID() + product2.GetProductQuantityInStockID() + product3.GetProductQuantityInStockID();
            return total;
        }

        private void MyMethod1()
        {

        }

        private protected void MyMethod2()
        {

        }

        public void MyMethod()
        {
            productID = 1;
            productName = null;
            cost = 0;
            quantityInStock = 0;
            birthDateTime = DateTime.Now;
            MyMethod1();
            MyMethod2();
        }

        public void CalculateTax()
        {
            double tax;

            if (cost <= 20000)
            {
                tax = cost * 10 / 100;
            }
            else
            {
                tax = cost * 12.5 / 100;
            }
            calculatedTax = tax;
        }

        public double GetProductTax()
        {
            return calculatedTax;
        }

    }

    //public class DomesticProduct: Product
    //{
    //    public void MyMethod()
    //    {
    //        productID = 1;
    //        productName = null;
    //        cost = 0;
    //        quantityInStock = 0;
    //        birthDateTime = DateTime.Now;
    //        //MyMethod1();
    //        MyMethod2();
    //    }
    //}
    //public class OtherProductClass
    //{
    //    public void MyMethod()
    //    {
    //        Product product = new Product();    
    //        product.productID = 1;
    //        product.productName = null;
    //        product.cost = 0;
    //        product.quantityInStock = 0;
    //        product.birthDateTime = DateTime.Now;
    //        //MyMethod1();
    //        //MyMethod2();
    //    }
        
    //}



}
