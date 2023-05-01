using WebShopping.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Xml.Linq;

namespace EcommerceWebUILab.Models.DataContext
{

    public class WebShoppingDbContext : DbContext
    {

        public WebShoppingDbContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}