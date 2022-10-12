namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            // temporary hard coded values to return populated product instance
            if(productId == 1)
            {
                product.Name = "shoe";
                product.Description = "for feet";
            }
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;

            if (product.IsValid)
            {
                if (product.IsNew)
                {
                    // call insert stored procedure
                }
                else
                {
                    // call update stored procedure
                }
            }
            else
            {
                success = false;
            }
            return success;
        }
    }
}
