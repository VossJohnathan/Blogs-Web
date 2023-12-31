using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
  public DataContext(DbContextOptions<DataContext> options) : base(options) { }

  public DbSet<Blog> Blogs { get; set; }
  public DbSet<Post> Posts { get; set; }

  //Check here for issues??
  public DbSet<Category> Categorys {get; set; }
  public DbSet<Product> Products {get; set; }
}