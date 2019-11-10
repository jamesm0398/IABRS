using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NAD_IABRS.Models;
//using Microsoft.IdentityModel.Clients.ActiveDirectory;
namespace Ef6CoreForPosgreSQL.Models
{
    public class MyWebApiContext : DbContext
    {
        public MyWebApiContext(DbContextOptions<MyWebApiContext> options) : base(options) { }
        public DbSet<Author> authors { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Person> person { get; set; }
        public DbSet<YCourse> courses { get; set; }
       
        public DbSet<CourseUser> courseUsers { get; set; }
        public DbSet<BookUser> bookUsers { get; set; }
        public DbSet<BookCourse> bookCourses { get; set; }
        public DbSet<BookTag> bookTags { get; set; }
        /// <summary>
        /// Used for creating composite keys on model creation
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>()
            //    .HasKey(b => new { b.Id, b.isbn });
            modelBuilder.Entity<BookCourse>()
               .HasKey(b => new { b.BookId, b.CouseId });

                modelBuilder.Entity<BookTag>()
             .HasKey(x => new { x.BookId, x.TagId});

             modelBuilder.Entity<BookUser>()
            .HasKey(x => new { x.BookId, x.UserId });


            modelBuilder.Entity<CourseUser>()
            .HasKey(x => new { x.CouseId, x.UserId });

            modelBuilder.Entity<BookTag>()
                .HasOne(x => x.Book)
                .WithMany(y => y.bookTags)
                .HasForeignKey(y => y.BookId);

            modelBuilder.Entity<BookTag>()
                .HasOne(x => x.Tag)
                .WithMany(y => y.booksTags)
                .HasForeignKey(y => y.TagId);
        }
    }
}