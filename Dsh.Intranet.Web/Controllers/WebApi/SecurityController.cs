using DSH.Intranet.Data.Contracts;
using DSH.Intranet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

/// <summary>
/// Chad Corrin, 2/22/13 - This is just a placeholder controller as an example of how I like to layout controller methods
/// </summary>
namespace DSH.Intranet.Web.Controllers
{
    public class SecurityController : ApiControllerBase
    {
        public SecurityController(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public SecurityController() { }

        // Get all records
        // GET /api/security
        public IEnumerable<Security> Get()
        {
            return Uow.Security.GetAll().OrderBy(s => s.SecurityID);
        }

        // Get a single record by id
        // GET /api/security/id
        public Security Get(int id)
        {
            var record = Uow.Security.GetById(id);
            if (record != null) return record;
            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
        }

        // Create a new record
        // POST /api/security
        public HttpResponseMessage Post(Security security)
        {
            Uow.Security.Add(security);
            Uow.Commit();

            var response = Request.CreateResponse(HttpStatusCode.Created, security);

            // Compose location header that tells how to get this session
            // e.g. ~/api/security/id
            response.Headers.Location =
                new Uri(Url.Link(WebApiConfig.ControllerAndId, new { id = security.SecurityID }));

            return response;
        }

        // Update existing record
        // PUT /api/security
        public HttpResponseMessage Put(Security security)
        {
            Uow.Security.Update(security);
            Uow.Commit();
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        // Delete existing record
        // DELETE /api/security/id
        public HttpResponseMessage Delete(int id)
        {
            Uow.Security.Delete(id);
            Uow.Commit();
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
