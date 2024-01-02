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
    public class ProductOrderDTO
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
    }
}
