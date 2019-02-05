namespace BibleStudy.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbBible : DbContext
    {
        public DbBible()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<ChapterQty> ChapterQties { get; set; }
        public virtual DbSet<VerseContent> VerseContents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(e => e.AuthorName)
                .IsUnicode(false);

            modelBuilder.Entity<ChapterQty>()
                .Property(e => e.AuthorName)
                .IsUnicode(false);

            modelBuilder.Entity<VerseContent>()
                .Property(e => e.VerseContent1)
                .IsUnicode(false);
        }
    }
}
