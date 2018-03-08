using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AngularApi.Controllers
{
    [RoutePrefix("api/Home")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("Index")]
        public async Task<IHttpActionResult> Index()
        {
            return Ok("Hello Angular2");
        }
    }
}
