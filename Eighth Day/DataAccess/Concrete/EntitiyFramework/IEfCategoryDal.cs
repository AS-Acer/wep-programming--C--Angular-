using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class IEfCategoryDal : ICategoryDal
    {
        public void Add(Category entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entitiy)
        {
            throw new NotImplementedException();
        }

        public Category Get()
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
