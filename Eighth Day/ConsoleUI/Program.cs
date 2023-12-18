using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}