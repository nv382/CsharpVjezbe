using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace Lab4.Models
{
    public class UplatnicaContext : DbContext
    {
        public UplatnicaContext(DbContextOptions<UplatnicaContext> options)
            : base(options)
        {
        }

        public DbSet<Uplatnica> Uplatnicas { get; set; } = null!;
    }
}
