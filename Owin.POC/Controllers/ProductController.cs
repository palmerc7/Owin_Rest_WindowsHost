using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

using Owin.POC.Data;

namespace Owin.POC.Controllers
{
    [RoutePrefix("api/v1/product")]
    public class ProductController : ApiController
    {
        public ProductController()
        {
        }

        [Route("validate")]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(string.Format("Validate SUCCESS from Product API: {0}", DateTime.Now.ToString()))
            };
        }

        [HttpGet]
        [Route("getProductById")]
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProductById(string productId)
        {
            if (string.IsNullOrEmpty(productId))
                return NotFound();

            var product = new Product();
            try
            {
                // Just returning fake data
                product = new Product
                {
                    ProductId = productId,
                    Name = "Test Product",
                    QtyInStock = 11,
                    RetailPrice = 1.99m,
                    Sku = "1001",
                    Status = "Active"
                };
            }
            catch
            {
            }

            return Ok(product);
        }

        [HttpGet]
        [Route("searchProduct")]
        [ResponseType(typeof(Product))]
        public IHttpActionResult SearchProduct(string searchCriteria)
        {
            if (string.IsNullOrEmpty(searchCriteria))
                return NotFound();

            var product = new Product();
            try
            {
                // Just returning fake data
                product = new Product
                {
                    ProductId = "1",
                    Name = "Test Product Search",
                    QtyInStock = 12,
                    RetailPrice = 1.88m,
                    Sku = "1001",
                    Status = "InActive"
                };
            }
            catch
            {
            }

            return Ok(product);
        }

    }
}
