namespace WebShopping.Models.Entity
{
    public class Basket
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
    }
}
