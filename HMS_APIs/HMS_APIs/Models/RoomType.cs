using System.ComponentModel.DataAnnotations;

namespace HMS_APIs.Models
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public float Cost { get; set; }
        public int Capacity { get; set; }
        public int Bed { get; set; }
    }
}
