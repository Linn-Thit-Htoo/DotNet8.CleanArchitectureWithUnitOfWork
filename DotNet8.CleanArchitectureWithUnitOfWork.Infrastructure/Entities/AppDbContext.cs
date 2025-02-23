﻿namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Entities;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBlog> TblBlogs { get; set; }

    public virtual DbSet<TblOrder> TblOrders { get; set; }

    public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; }

    public virtual DbSet<TblStudent> TblStudents { get; set; }

    public virtual DbSet<TestTable> TestTables { get; set; }

    public virtual DbSet<TestTableN> TestTableNs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=testDb;User ID=sa;Password=sasa@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBlog>(entity =>
        {
            entity.HasKey(e => e.BlogId);

            entity.ToTable("Tbl_Blog");

            entity.Property(e => e.BlogAuthor).HasMaxLength(50);
            entity.Property(e => e.BlogContent).HasMaxLength(50);
            entity.Property(e => e.BlogTitle).HasMaxLength(50);
        });

        modelBuilder.Entity<TblOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("Tbl_Order");

            entity.Property(e => e.OrderId).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblOrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId);

            entity.ToTable("Tbl_Order_Detail");

            entity.Property(e => e.OrderDetailId).HasMaxLength(50);
            entity.Property(e => e.OrderId).HasMaxLength(50);
            entity.Property(e => e.PricePerItem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TblStudent>(entity =>
        {
            entity.HasKey(e => e.StudentId);

            entity.ToTable("Tbl_Student");

            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Major).HasMaxLength(50);
            entity.Property(e => e.StudentName).HasMaxLength(50);
        });

        modelBuilder.Entity<TestTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TestTable");

            entity.Property(e => e.ColVc)
                .HasMaxLength(1200)
                .IsUnicode(false)
                .HasColumnName("ColVC");
        });

        modelBuilder.Entity<TestTableN>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TestTableN");

            entity.Property(e => e.ColVc)
                .HasMaxLength(1200)
                .HasColumnName("ColVC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
