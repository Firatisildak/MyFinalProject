using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public required string CustomerID { get; set; }
        public required string CustomerName { get; set; }
        public required string CompanyName { get; set; }
        public required string City { get; set; }
    }
}
