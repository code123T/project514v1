namespace WebShopping.Controllers
{
    internal class WebShoppingDbContext
    {
        public IEnumerable<object> Baskets { get; internal set; }
        public object Contacts { get; internal set; }
        public object Database { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}