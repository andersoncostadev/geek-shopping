using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductModel>> FindAllProducts();
        public Task<ProductModel> FindProductById(long id);
        public Task<ProductModel> CretateProduct(ProductModel productModel);
        public Task<ProductModel> UpdateProduct(ProductModel productModel);
        public Task<bool> DeleteProductById(long id);
    }
}
