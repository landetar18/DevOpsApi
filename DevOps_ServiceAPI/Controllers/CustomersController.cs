using System.Net;
using System.Threading;
using System.Web.Http;
using DevOps_ServiceAPI.Models;

namespace DevOps_ServiceAPI.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        [HttpPost]
        [Route("message")]
        public IHttpActionResult Message(MessageRequest messagetext)
        {
            var messageReturn = "messsage: Hello " + messagetext.To + " your messsage will be send";
            return Ok(messageReturn);
        }
    }
}
