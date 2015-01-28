﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Owin.POC.Controllers
{
    [RoutePrefix("api/v1/receiptprinter")]
    public class ReceiptPrinterController : ApiController
    {
        public ReceiptPrinterController()
        {
        }

        [Route("validate")]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(string.Format("Validate SUCCESS from ReceiptPrinter API: {0}", DateTime.Now.ToString()))
            };
        }

    }
}
