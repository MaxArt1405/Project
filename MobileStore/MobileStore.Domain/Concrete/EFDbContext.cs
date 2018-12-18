using MobileStore.Domain.Entities;
using System.Data.Entity;

namespace MobileStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
