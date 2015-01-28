using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Owin.POC.Controllers
{
    [RoutePrefix("api/v1/cardauthorization")]
    public class CardAuthorizationController : ApiController
    {
        public CardAuthorizationController()
        {
        }

        [Route("validate")]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(string.Format("Validate SUCCESS from CardAuthorization API: {0}", DateTime.Now.ToString()))
            };
        }

    }
}
