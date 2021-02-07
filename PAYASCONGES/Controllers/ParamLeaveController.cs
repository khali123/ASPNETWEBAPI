using PAYASCONGES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace PAYASCONGES.Controllers
{
    public class ParamLeaveController : ApiController
    {
        // GET: api/ParamLeave
        public IEnumerable<ParamLeave> Get()
        {
            return null;

        }

        // GET: api/ParamLeave/5
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
        public string Get(int id)
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
        {
            return "value";
        }

        // POST: api/ParamLeave
        public HttpResponseMessage Post(ParamLeave paramLeave)
        {
            if (ModelState.IsValid)
                return new HttpResponseMessage(HttpStatusCode.OK);
            else
                return new HttpResponseMessage(HttpStatusCode.BadRequest);

        }

        // PUT: api/ParamLeave/5
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
        public void Put(int id, [FromBody]string value)
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
        {
        }

        // DELETE: api/ParamLeave/5
#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
        public void Delete(int id)
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
        {
        }
    }
}
