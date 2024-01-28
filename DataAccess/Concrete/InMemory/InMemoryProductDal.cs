using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;//Bunu veritabanı gibi düşünücez.

        public InMemoryProductDal()
        {
            //Oracle,Sql Server, Postgres, MongoDb aşağıdaki constructer çalıştığında bu yazdığım veritablarından herhangi birinden veri çekebilir.
            _products = new List<Product> { 
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product? productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);//C# 8 ve sonraki sürümlerinde, varsayılan olarak "nullable reference types" özelliği etkindir. Bu özellik, referans türlerinin null olup olamayacağını denetlemenizi sağlar. _products listesi null olma ihtimaline karşı kontrol ettiğiniz için, Product başına soru işareti konulur.
            if (productToDelete != null)//Burada productToDelete null olma dur0umu bizim için hata teşkil edeceği için böyle if içine aldık.
            {
                _products.Remove(productToDelete);
            }
            else
            {
                Console.WriteLine("Eksik veya Boş değer var.");
            }

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.CategoryId == categoryId).ToList();//burada filtreleme işlemi yapıyoruz girilen categoryId göre yeni liste oluşturur.
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Göndersiğim ürün id'sine sahip olan listedeki ürünü bul
            Product? productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            if(productToUpdate != null)
            {
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.UnitPrice = product.UnitPrice;
            }
            else
            {
                Console.WriteLine("Eksik veya Boş değer var.");
            }
            
            
        }
    }
}
