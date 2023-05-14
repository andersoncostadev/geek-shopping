namespace GeekShopping.CartAPI.Data.ValueObjects
{
    public class ProductVO
    {
        public long Id { get; set; }
        public string? Name { get; private set; }
        public decimal Price { get; private set; }
        public string? Description { get; private set; }
        public string? CategoryName { get; private set; }
        public string? ImageUrl { get; private set; }
    }
}
