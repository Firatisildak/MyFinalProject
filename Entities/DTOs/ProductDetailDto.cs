using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int ProductId {  get; set; }
        public required string ProductName { get; set; }
        public required string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
