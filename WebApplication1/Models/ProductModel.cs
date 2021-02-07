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
                    Id = "f01",
                    Name = "Flower 1",
                    Price = 50,
                    Photo = "Flower1.PNG"
                },
                new Product
                {
                    Id = "f02",
                    Name = "Flower 2",
                    Price = 80,
                   Photo = "Flower2.PNG"
                },
                new Product
                {
                    Id = "f03",
                    Name = "Flower 3",
                    Price = 60,
                    Photo = "Flower3.PNG"
                },
                new Product
                {
                    Id = "f04",
                    Name = "Flower 4",
                    Price = 40,
                    Photo = "Flower4.PNG"
                },
                new Product
                {
                    Id = "f05",
                    Name = "Flower 5",
                    Price = 70,
                    Photo = "Flower5.PNG"
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
