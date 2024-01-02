using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StoreManagementSystemAPI.Controllers
{
    public class StaffController : ApiController
    {
        [HttpGet]
        [Route("API/ViewProduct/{Id}")]
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

    }

}
