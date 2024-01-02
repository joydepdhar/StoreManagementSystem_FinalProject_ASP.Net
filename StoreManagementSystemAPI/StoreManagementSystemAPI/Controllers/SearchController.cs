using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StoreManagementSystemAPI.Controllers
{
    public class SearchController : ApiController
    {
        [HttpGet]
        [Route("api/user/search/{id}")]
        public HttpResponseMessage ViewUser(int id)
        {
            try
            {
                var data = SearchService.ViewUser(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/users/search")]
        public HttpResponseMessage ViewUsers()
        {
            try
            {
                var data = SearchService.ViewUser();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/product/search/{id}")]
        public HttpResponseMessage ViewProduct(int id)
        {
            try
            {
                var data = SearchService.ViewProduct(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/products/search")]
        public HttpResponseMessage ViewProducts()
        {
            try
            {
                var data = SearchService.ViewProduct();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


    }
}
