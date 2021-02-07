using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddToCart.Models
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>() {
                new Product
                {
                    Id = "F0001",
                    Name = "Akvaryum Vazo",
                    Price = 50,
                    Photo = "Flower1.PNG",
                    Stock = 1
                },
                new Product
                {
                    Id = "F0002",
                    Name = "Lilyum Aranjman",
                    Price = 80,
                   Photo = "Flower2.PNG",
                   Stock = 3
                },
                new Product
                {
                    Id = "F0003",
                    Name = "Doğal Ahşap Kütük",
                    Price = 60,
                    Photo = "Flower3.PNG",
                    Stock = 6
                },
                new Product
                {
                    Id = "F0004",
                    Name = "Papatya Bahçesi",
                    Price = 40,
                    Photo = "Flower4.PNG",
                    Stock = 7
                },
                new Product
                {
                    Id = "F0005",
                    Name = "Pembe Gerberalar",
                    Price = 70,
                    Photo = "Flower5.PNG",
                    Stock = 2
                }
            };
        }

        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(string id)
        {
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
