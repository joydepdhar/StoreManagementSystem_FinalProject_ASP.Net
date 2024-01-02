using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class OrderDTO
    {

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderQuantity { get; set; }
        public string Location { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        
    }
}
