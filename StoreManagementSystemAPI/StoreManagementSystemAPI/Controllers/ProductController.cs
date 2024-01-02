using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StoreManagementSystemAPI.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("api/products")]
        public HttpResponseMessage Products()
        {
            try
            {
                var data = ProductService.ViewProduct();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/products/{id}")]
        public HttpResponseMessage Prodcut(int id)
        {
            try
            {
                var data = ProductService.ViewProduct(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        // product seller man find 
        [HttpGet]
        [Route("api/Product/{id}/seller")]
        public HttpResponseMessage ProductSeller(int id)
        {
            try
            {
                // Assuming you want to view a product with the seller information
                var data = ProductService.ViewProduct(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/product/add")]
        public HttpResponseMessage Add(ProductDTO obj)
        {
            try
            {
                var res = ProductService.AddProduct(obj);
                if (res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = obj });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = obj });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = obj });
            }
        }

        [HttpPost]
        [Route("api/product/update")]
        public HttpResponseMessage Update(ProductDTO obj)
        {
            try
            {
                var res = ProductService.UpdateProduct(obj);
                if (res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Updated", Data = obj });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = "Not Updated", Data = obj });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, Data = obj });
            }
        }

        [HttpPost]
        [Route("api/product/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, ProductService.Delete(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
}
