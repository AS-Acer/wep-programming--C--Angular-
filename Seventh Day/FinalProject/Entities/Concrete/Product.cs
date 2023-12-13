using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //public ile her katmandan erişim sağlıyoruz
    //internal ile sadece o katmandan erişim sağlıyoruz
    public class Product : IEntitiy
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //short int'in bir küçük versiyonu
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
