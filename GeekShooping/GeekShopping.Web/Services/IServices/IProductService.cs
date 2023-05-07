using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductModel>> FindAllProducts( string token);
        public Task<ProductModel> FindProductById(long id, string token);
        public Task<ProductModel> CretateProduct(ProductModel productModel, string token);
        public Task<ProductModel> UpdateProduct(ProductModel productModel, string token);
        public Task<bool> DeleteProductById(long id, string token);
    }
}
