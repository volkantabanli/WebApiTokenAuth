using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTokenAuht.Controllers
{
    public class FaturaController : ApiController
    {
        [HttpGet]
        [Authorize]
        public IEnumerable<string> Get()
        {
            var firmaList = new List<string>()
            {
                "Firma 1",
                "Firma 2",
                "Firma 3",
            };
            return firmaList;
        }
    }
}
