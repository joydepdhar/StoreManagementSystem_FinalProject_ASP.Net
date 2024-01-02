using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class OrderProductDTO:OrderDTO
    {
        public List<ProductDTO> Products { get; set; }
        public OrderProductDTO()
        {
            Products = new List<ProductDTO>();
        }
    }
}
