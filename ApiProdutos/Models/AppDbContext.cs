using Microsoft.EntityFrameworkCore;

namespace ApiProdutos.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    { }
    public DbSet<Produto> Produtos { get; set; }
}

