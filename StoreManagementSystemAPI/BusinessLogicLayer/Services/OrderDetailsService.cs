using AutoMapper;
using BusinessLogicLayer.DTOs;
using DataAccessLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class OrderDetailsService
    {
        public static List<OrderDetailsDTO> Get()
        {
            var data = DataAccessFactory.OrderDetailsData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetails, OrderDetailsDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OrderDetailsDTO>>(data);
            return mapped;
        }

        public static OrderDetailsDTO Get(int id)
        {
            var data = DataAccessFactory.OrderDetailsData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetails, OrderDetailsDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDetailsDTO>(data);
            return mapped;
        }

        public static bool Create(OrderDetailsDTO order)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetailsDTO, OrderDetails>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDetails>(order);
            var res = DataAccessFactory.OrderDetailsData().Create(mapped);
            if (res) return true;
            return false;
        }
        public static bool Update(OrderDetailsDTO order)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetailsDTO, OrderDetails>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDetails>(order);
            var res = DataAccessFactory.OrderDetailsData().Update(mapped);
            if (res) return true;
            return false;
        }


        public static bool Delete(int id)
        {
            return DataAccessFactory.OrderDetailsData().Delete(id);
        }
    }
}
