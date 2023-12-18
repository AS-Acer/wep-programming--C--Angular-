using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constraint : generic sınırlama
    //class:referans tip
    //IEntity : IEntitiy olabilir veya IEntitiy implemente eden bir class olabilir demektir
    //new(): new'lenebilir bir nesne olmalıdır
    public interface IEntitiyRepository<T> where T : class, IEntitiy,new()
    { 
        //generic class oluşturup category, product veya herhangi bir ürün için değişken değişkenli sınıf oluşturduk
        //expression ile değişken getirebilme özelliğini ekledik
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<Product, bool>> filter);    
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
       // bu görevi 15.satırda yaptık List<T> GetAllByCategoryId(int categoryId);
    }
}
