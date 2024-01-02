using AutoMapper;
using BusinessLogicLayer.DTOs;
using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ManageUserOrderService
    {
        public static List<CustomerOrderDTO> Get()
        {
            var data = DataAccessFactory.ManageCustomerOrderData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerOrder, CustomerOrderDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CustomerOrderDTO>>(data);
            return mapped;
        }

        public static CustomerOrderDTO Get(int id)
        {
            var data = DataAccessFactory.ManageCustomerOrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerOrder, CustomerOrderDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerOrderDTO>(data);
            return mapped;
        }
        public static bool Create(CustomerOrderDTO uo)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerOrderDTO, CustomerOrder>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerOrder>(uo);
            var res = DataAccessFactory.ManageCustomerOrderData().Create(mapped);

            if (res) return true;
            return false;
        }
        public static bool Update(CustomerOrderDTO uo)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerOrderDTO, CustomerOrder>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerOrder>(uo);
            var res = DataAccessFactory.ManageCustomerOrderData().Update(mapped);

            if (res) return true;
            return false;
        }

        public static bool Delete(int uid)
        {
            return DataAccessFactory.ManageCustomerOrderData().Delete1(uid);
        }
    }
}
