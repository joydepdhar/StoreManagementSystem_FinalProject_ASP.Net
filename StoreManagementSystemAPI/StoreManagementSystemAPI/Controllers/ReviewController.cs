using BusinessLogicLayer.Services;
using BusinessLogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StoreManagementSystemAPI.Controllers
{
    public class ReviewController : ApiController
    {
        [HttpGet]
        [Route("api/review/get")]
        public HttpResponseMessage review()
        {
            try
            {
                var data = ReviewService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/review/get/{id}")]
        public HttpResponseMessage review(int id)
        {
            try
            {
                var data = ReviewService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/review/insert")]
        public HttpResponseMessage Insert(ReviewDTO cart)
        {
            try
            {
                var data = ReviewService.Create(cart);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = cart });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = cart });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/review/update")]
        public HttpResponseMessage Update(ReviewDTO cart)
        {
            try
            {
                var data = ReviewService.Update(cart);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Updated", Data = cart });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = "Not Updated", Data = cart });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/review/delete/{rid}")]
        public HttpResponseMessage Delete(int rid)
        {
            try
            {
                var data = ReviewService.Delete(rid);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
