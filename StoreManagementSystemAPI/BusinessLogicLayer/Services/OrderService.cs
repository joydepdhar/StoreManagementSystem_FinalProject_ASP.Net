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
    public class OrderService
    {
        public static List<OrderDTO> Get()
        {
            var data = DataAccessFactory.OrderData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OrderDTO>>(data);
            return mapped;
        }

        public static OrderDTO Get(int id)
        {
            var data = DataAccessFactory.OrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDTO>(data);
            return mapped;
        }
        //find out order done by which prodcut
        public static OrderProductDTO GetwithOrders(int id)
        {
            var data = DataAccessFactory.OrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderProductDTO>();
                c.CreateMap<Product, ProductDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderProductDTO>(data);
            return mapped;
        }
        public static bool Create(OrderDTO order)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDTO, Order>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Order>(order);
            var res = DataAccessFactory.OrderData().Create(mapped);
            if (res) return true;
            return false;
        }
        public static bool Update(OrderDTO order)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDTO, Order>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Order>(order);
            var res = DataAccessFactory.OrderData().Update(mapped);
            if (res) return true;
            return false;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.OrderData().Delete(id);
        }
    }
}
