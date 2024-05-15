using Microsoft.EntityFrameworkCore;
using findfripes_dotnet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Bogus;

namespace findfripes_dotnet.Database;

public partial class PgFindfripesContext : IdentityDbContext<FFUser, IdentityRole<Guid>, Guid>
{
    public PgFindfripesContext()
    {
    }

    public PgFindfripesContext(DbContextOptions<PgFindfripesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Fripe> Fripes { get; set; }

    public virtual DbSet<FripeComment> FripeComments { get; set; }

    public virtual DbSet<FripePicture> FripePictures { get; set; }

    public virtual DbSet<FripeProductCategory> FripeProductCategories { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=127.0.0.1;Username=ffpg_back;Password=UBLIm3C15c0kDWh4tg0t;Database=pg-findfripes;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("addresses_pkey");

            entity.ToTable("addresses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(64)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(128)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Line1)
                .HasMaxLength(64)
                .HasColumnName("line_1");
            entity.Property(e => e.Line2)
                .HasMaxLength(64)
                .HasColumnName("line_2");
            entity.Property(e => e.Line3)
                .HasMaxLength(64)
                .HasColumnName("line_3");
            entity.Property(e => e.PostCode)
                .HasMaxLength(32)
                .HasColumnName("post_code");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<Fripe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fripes_pkey");

            entity.ToTable("fripes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.GpsCoordinates)
                .HasMaxLength(255)
                .HasColumnName("gps_coordinates");
            entity.Property(e => e.LongDescription)
                .HasMaxLength(2048)
                .HasColumnName("long_description");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.ShortDescription)
                .HasMaxLength(256)
                .HasColumnName("short_description");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Address).WithMany(p => p.Fripes)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fripes_address_id_foreign");
        });

        modelBuilder.Entity<FripeComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fripe_comments_pkey");

            entity.ToTable("fripe_comments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FripeId).HasColumnName("fripe_id");
            entity.Property(e => e.Text)
                .HasMaxLength(255)
                .HasColumnName("text");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Fripe).WithMany(p => p.FripeComments)
                .HasForeignKey(d => d.FripeId)
                .HasConstraintName("fripe_comments_fripe_id_foreign");

            entity.HasOne(d => d.User).WithMany(p => p.FripeComments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fripe_comments_user_id_foreign");
        });

        modelBuilder.Entity<FripePicture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fripe_pictures_pkey");

            entity.ToTable("fripe_pictures");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("filename");
            entity.Property(e => e.FripeId).HasColumnName("fripe_id");
            entity.Property(e => e.ShortDescription)
                .HasMaxLength(256)
                .HasColumnName("short_description");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Fripe).WithMany(p => p.FripePictures)
                .HasForeignKey(d => d.FripeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fripe_pictures_fripe_id_foreign");
        });

        modelBuilder.Entity<FripeProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fripe_product_categories_pkey");

            entity.ToTable("fripe_product_categories");

            entity.HasIndex(e => new { e.FripeId, e.ProductCategoryId }, "fripe_product_categories_fripe_id_product_category_id_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FripeId).HasColumnName("fripe_id");
            entity.Property(e => e.ProductCategoryId).HasColumnName("product_category_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Fripe).WithMany(p => p.FripeProductCategories)
                .HasForeignKey(d => d.FripeId)
                .HasConstraintName("fripe_product_categories_fripe_id_foreign");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.FripeProductCategories)
                .HasForeignKey(d => d.ProductCategoryId)
                .HasConstraintName("fripe_product_categories_product_category_id_foreign");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_categories_pkey");

            entity.ToTable("product_categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IconFilename)
                .HasMaxLength(255)
                .HasColumnName("icon_filename");
            entity.Property(e => e.LongDescription)
                .HasMaxLength(255)
                .HasColumnName("long_description");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.ShortDescription)
                .HasMaxLength(255)
                .HasColumnName("short_description");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        OnModelCreatingPartial(modelBuilder);

        // TODO condition this to development only
        // TODO associated migrations should be removed 
        // Seed data logic will go here
        var addressFaker = new Faker<Address>()
          .RuleFor(a => a.Id, f => f.IndexFaker + 1)
          .RuleFor(a => a.Line1, f => f.Address.StreetAddress())
          .RuleFor(a => a.City, f => f.Address.City())
          .RuleFor(a => a.PostCode, f => f.Address.ZipCode())
          .RuleFor(a => a.Country, f => f.Address.Country());
        var addresses = addressFaker.Generate(2500);
        modelBuilder.Entity<Address>().HasData(addresses);

        // TODO seed fake fripes 
        // TODO seed fake users 
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
