namespace WebApplication4.Models.service
{
    public class ProductService : Iproductservice
    {
        public List<product> products { get; set; }

        public ProductService()
        {
            products = new List<product>
            {
                new product { id = 1, Name = "Product 1", Price = 10.99m },
                new product { id = 2, Name = "Product 2", Price = 19.99m },
                new product { id = 3, Name = "Product 3", Price = 5.99m }
            };
        }
        public void AddProduct(product product)
        {
            products.Add(product);
        }
        public product GetProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.id == id);
            return product;
        }
        public void DeleteProduct(int id)
        {
            var product= GetProductById(id);
            products.Remove(product);
        }

        public List<product> GetAllProducts()
        { 
            return products;
        }

       

        public void UpdateProduct(product product)
        {
            var pro= products.FirstOrDefault(p => p.id == product.id);
            pro.Name = product.Name;
            pro.Price = product.Price;

        }
    }
}
