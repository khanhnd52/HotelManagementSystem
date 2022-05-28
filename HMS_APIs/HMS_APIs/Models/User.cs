using System.ComponentModel.DataAnnotations;

namespace HMS_APIs.Models
{
    public class User
    {
        [Key]
        public int UId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }


    }
}
