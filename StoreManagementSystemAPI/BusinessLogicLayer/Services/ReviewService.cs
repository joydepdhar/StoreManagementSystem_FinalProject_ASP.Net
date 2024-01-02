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
    public class ReviewService
    {
        public static List<ReviewDTO> Get()
        {
            var data = DataAccessFactory.ReviewData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReviewDTO>>(data);
            return mapped;
        }

        public static ReviewDTO Get(int id)
        {
            var data = DataAccessFactory.ReviewData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReviewDTO>(data);
            return mapped;
        }
        public static bool Create(ReviewDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReviewDTO, Review>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Review>(cart);
            var res = DataAccessFactory.ReviewData().Create(mapped);

            if (res) return true;
            return false;
        }
        public static bool Update(ReviewDTO cart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReviewDTO, Review>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Review>(cart);
            var res = DataAccessFactory.ReviewData().Update(mapped);

            if (res) return true;
            return false;
        }

        public static bool Delete(int rid)
        {
            return DataAccessFactory.ReviewData().Delete(rid);
        }

    }
}
