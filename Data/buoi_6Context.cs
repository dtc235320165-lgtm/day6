using Microsoft.EntityFrameworkCore;

public class buoi_6Context(DbContextOptions<buoi_6Context> options) : DbContext(options)
{
    public DbSet<buoi_6.Models.Product> Product { get; set; } = default!;
}
