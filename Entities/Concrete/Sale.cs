using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.VisualBasic;

namespace Entities.Concrete
{
    public class Sale : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int TotalPrice { get; set; }
        public int Custom { get; set; }
        public DateTime SaleTime { get; set; }
    }
}
