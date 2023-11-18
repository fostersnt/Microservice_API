using System.ComponentModel.DataAnnotations;

namespace Book_Service.Model
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
