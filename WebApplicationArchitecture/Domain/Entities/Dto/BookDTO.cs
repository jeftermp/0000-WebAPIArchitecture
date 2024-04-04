
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Dto
{
    public class BookDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? AlterDate { get; set; }
    }
}