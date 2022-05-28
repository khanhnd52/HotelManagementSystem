using System.ComponentModel.DataAnnotations;

namespace HMS_APIs.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public bool IsActive { get; set; }
        
    }
}
