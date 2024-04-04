using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Context.EntityConfig
{
    public class BookEntityConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder) 
        {
            builder.ToTable("Books");
            builder.HasKey(p => p.BookId);
            builder.Property(p => p.Title).HasColumnName("TITLE");
            builder.Property(p => p.Author).HasColumnName("AUTHOR");
            builder.Property(p => p.Genre).HasColumnName("GENRE");
            builder.Property(p => p.PublicationYear).HasColumnName("PUBLICATIONYEAR");
            builder.Property(p => p.ISBN).HasColumnName("ISBN");
            builder.Property(p => p.Price).HasColumnName("PRICE");
            builder.Property(p => p.InsertDate).HasColumnName("INSERTDATE");
            builder.Property(p => p.AlterDate).HasColumnName("ALTERDATE");
        }
    }
}