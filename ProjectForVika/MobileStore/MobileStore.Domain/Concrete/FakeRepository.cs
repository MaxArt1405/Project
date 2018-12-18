using MobileStore.Domain.Abstract;
using MobileStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Domain.Concrete
{
    public class FakeRepository : IProductRepository
    {
        private IList<Product> products = new List<Product>()
        {
            new Product(){ProductID = 1, Name = "Xiaomi MI 8", Description = "Flagship of 2018", Category = "Xiaomi", Price = 500},
            new Product(){ProductID = 2, Name = "Xiaomi MI 6", Description = "Flagship of 2017", Category = "Xiaomi", Price = 350},
            new Product(){ProductID = 3, Name = "Xiaomi MI 5", Description = "Flagship of 2016", Category = "Xiaomi", Price = 250},
            new Product(){ProductID = 4, Name = "Xiaomi MI 4", Description = "Flagship of 2018", Category = "Xiaomi", Price = 170},
            new Product(){ProductID = 5, Name = "Xiaomi Redmi 5", Description = "Best EcoPhone of 2017", Category = "Xiaomi", Price = 300},
            new Product(){ProductID = 6, Name = "Apple Iphone X", Description = "Flagship of 2017", Category = "Apple", Price = 1200},
            new Product(){ProductID = 7, Name = "Apple Iphone 8", Description = "Flagship of 2016", Category = "Apple", Price = 800},
            new Product(){ProductID = 8, Name = "Apple Iphine 7", Description = "Flagship of 2015", Category = "Apple", Price = 700},
            new Product(){ProductID = 9, Name = "Apple Iphone 6s", Description = "Flagship of 2014", Category = "Apple", Price = 400},
            new Product(){ProductID = 10, Name = "Samsung Galaxy 9", Description = "Flagship of 2018", Category = "Samsung", Price = 750}
        };

        public IQueryable<Product> Products
        {
            get { return products.AsQueryable(); }
        }

        public void SaveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product DeleteProduct(int productID)
        {
            throw new NotImplementedException();
        }
    }
}
