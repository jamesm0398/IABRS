using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

//Class: testsForNADContext
//Summary: This class will retreive information from the database relating to each of the models.

namespace IABRS.Models
{
    public partial class testsForNADContext : IdentityDbContext
    {
        public testsForNADContext()
        {
        }

        public testsForNADContext(DbContextOptions<testsForNADContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookCourse> BookCourse { get; set; }
        public virtual DbSet<BookUsers> BookUsers { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseUser> CourseUser { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupPermission> GroupPermission { get; set; }
        public virtual DbSet<Institution> Institution { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:iabrs.database.windows.net,1433;Initial Catalog=iabrs;Persist Security Info=False;User ID=NADFINALADMIN;Password=rgeiKHJ9(*3043pytqkjdfsdf!42ds;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");// "Data Source=JOHNCPLAPTOP;Initial Catalog=testsForNAD;User ID=sa;Password=mojoat13");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BookCourse>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.CourseId });

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookCourse)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookCourse_Book");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.BookCourse)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookCourse_Course");
            });

            modelBuilder.Entity<BookUsers>(entity =>
            {
                entity.ToTable("bookUsers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookUsers)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_bookUsers_books_BookId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BookUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_bookUsers_users_UserId");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_Institution");
            });

            modelBuilder.Entity<CourseUser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseUser)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseUser_Course");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CourseUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseUser_User");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GroupPermission>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.PermissionId });

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupPermission)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupPermission_Group");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.GroupPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupPermission_Permission");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();



                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.UserGroup)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGroup_Group");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGroup)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGroup_User");
            });
        }
    }
}
