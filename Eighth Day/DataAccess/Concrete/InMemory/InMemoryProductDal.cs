using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq; //LİNQ : language integrated query
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //_product bu class için global list    
        List<Product> _products;
        public InMemoryProductDal()
        {
            //uygulama çalıştığı anda yeni liste oluştur
            _products = new List<Product>()
            {
                //liste elemanları kaynaktan geliyormuş gibi simüle ettik
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 },
                new Product{ProductId=2,CategoryId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3 },
                new Product{ProductId=3,CategoryId=3,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2 },
                new Product{ProductId=4,CategoryId=4,ProductName="Klavye",UnitPrice=150,UnitsInStock=65 },
                new Product{ProductId=5,CategoryId=5,ProductName="Fare",UnitPrice=85,UnitsInStock=1 }
            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
           
            //= new product yaparak ancak belleği yorarız yeni bir referans oluşturmaya gerek yok burda
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            //üstteki gibi tüm listeyi dolaşıp veriyi arayıp bulup seçmek yerine aynısını :
            Product productToDelete = null;   
            productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
            
           
        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //bütün verileri olduğu gibi döndür
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            //where ile şarta uyan elemanların yeni bir listesini oluşturduk && ile yeni şartlar eklenebilir
            return _products.Where(p=> p.CategoryId == categoryId).ToList();    
        }

        public void Update(Product product)
        {
            Product productToUpdate;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //gönderdiğim ürün id'sine ait ürünü listede bul
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
