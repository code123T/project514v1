using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopping.Models.Entity
{
    public class Contact
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public string Answer { get; set; }
    }
}
