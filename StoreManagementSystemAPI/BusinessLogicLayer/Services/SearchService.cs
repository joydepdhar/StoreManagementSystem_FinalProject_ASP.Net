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
    public class SearchService
    {
        public static UserDTO ViewUser(int id)
        {
            var data = DataAccessFactory.UserData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            //var RET = mapper.Map<User>(data);
            return mapper.Map<UserDTO>(data);
            //return RET;
        }
        public static List<UserDTO> ViewUser()
        {
            var data = DataAccessFactory.UserData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserDTO>>(data);
            return mapped;
        }
        public static List<ProductDTO> ViewProduct()
        {
            var data = DataAccessFactory.ProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }
        public static ProductDTO ViewProduct(int id)
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            //var RET = mapper.Map<Product>(data);
            return mapper.Map<ProductDTO>(data);
            //return RET;
        }
        public static List<ProductDTO> ProductsSearch(string src)
        {
            var data = DataAccessFactory.ManageProductData().Search(src);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }
        public static List<ProductDTO> Filter(int min, int max)
        {
            var data = DataAccessFactory.ManageProductData().Filter(min, max);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }
        public static List<TopSearchSellingproductDTO> Get()
        {
            var data = DataAccessFactory.TopSearchSelleingproductdata().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TopSearchSelleingproduct, TopSearchSellingproductDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<TopSearchSellingproductDTO>>(data);
            return mapped;
        }

        public static TopSearchSellingproductDTO Get(string id)
        {
            var data = DataAccessFactory.TopSearchSelleingproductdata().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TopSearchSelleingproduct, TopSearchSellingproductDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<TopSearchSellingproductDTO>(data);
            return mapped;
        }

        public static bool Create(TopSearchSellingproductDTO search)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TopSearchSellingproductDTO, TopSearchSelleingproduct>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<TopSearchSelleingproduct>(search);
            var res = DataAccessFactory.TopSearchSelleingproductdata().Create(mapped);
            if (res != null) return true;
            return false;
        }

        public static TopSearchSelleingproduct Update(TopSearchSellingproductDTO tSelleingProduct)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TopSearchSellingproductDTO, TopSearchSelleingproduct>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TopSearchSelleingproduct>(tSelleingProduct);
            var res = DataAccessFactory.TopSearchSelleingproductdata().Update(mapped);
            return mapped;
        }

        public static bool Delete(string TopProductName)
        {
            return DataAccessFactory.TopSearchSelleingproductdata().Delete(TopProductName);
        }
    }
}
