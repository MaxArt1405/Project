using System.Linq;
using MobileStore.Domain.Entities;

namespace MobileStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
