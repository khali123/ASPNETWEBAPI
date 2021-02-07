using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PAYASCONGES.Controllers
{
    //localhost/controller/aciton?id=.......
    [RoutePrefix("employee/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [Route("")]
        public string Get(int id)
        {
            return "value"+id;
        }

        //api/values/addCustomer
        [Route("addCustomer")]
        [HttpPost]
        public String AddCustomer(string customer)
        {
            return customer;
        }

        [Route("archive")]
        [HttpGet]
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
        public HttpResponseMessage Archive(int year,int month,int day)
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }






        // POST api/values
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
        public void Post([FromBody] string value)
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
        {
        }

        // PUT api/values/5
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
        public void Put(int id, [FromBody] string value)
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
        {
        }

        // DELETE api/values/5
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
        public void Delete(int id)
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
        {
        }
    }
}
