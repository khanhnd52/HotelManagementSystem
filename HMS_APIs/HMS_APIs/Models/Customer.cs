using System.ComponentModel.DataAnnotations;

namespace HMS_APIs.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Identity { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}
