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
    public class OrderDetailsDTO
    {
 
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }        
        public int CustomerId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Status { get; set; }
            }
}
