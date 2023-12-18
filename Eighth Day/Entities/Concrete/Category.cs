using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category:IEntitiy
    {
        public int CateogoryID { get; set; }

        public string? CategoryName { get; set; }
       
    }
}
