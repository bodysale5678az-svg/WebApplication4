namespace WebApplication4.Models.service
{
    public interface Iproductservice
    {
        public List<product> GetAllProducts();
        public product GetProductById(int id);
        public void AddProduct(product product);
        public void UpdateProduct(product product);
        public void DeleteProduct(int id);


    }
}
