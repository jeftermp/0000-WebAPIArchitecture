namespace Domain.Entities
{
    public class Book
    {
        #region properties
        public int BookId{ get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Genre { get; set; }
        public int PublicationYear { get; set; }
        public required string ISBN { get; set; }
        public decimal Price { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? AlterDate { get; set; }
        #endregion
    }
}