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
    public class CustomerService
    {
        public static CustomerDTO AddCustomer(CustomerDTO c)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Customer>(c);
            //var data2 = DataAccessFactory.UserData().Create(data);
            var data1 = DataAccessFactory.CustomerData().Create(data);
            return mapper.Map<CustomerDTO>(data1);
        }
        public static CustomerDTO UpdateCustomer(CustomerDTO u)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Customer>(u);
            var ret = DataAccessFactory.CustomerData().Update(data);
            //if (ret != false)
            return mapper.Map<CustomerDTO>(ret);
            //return false;
        }
        //public static UserDTO DeleteUser(int id)
        //{
        //  var ex = DataAccessFactory.UserData().Read(id);
        //var data = DataAccessFactory.UserData().Delete(ex);
        //return true;

        //      }
        public static List<CustomerDTO> ViewCustomer()
        {
            var data = DataAccessFactory.CustomerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CustomerDTO>>(data);
            return mapped;
        }
        public static CustomerDTO ViewCustomer(int id)
        {
            var data = DataAccessFactory.CustomerData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            //var RET = mapper.Map<User>(data);
            return mapper.Map<CustomerDTO>(data);
            //return RET;
        }
    }
}
