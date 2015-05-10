using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DBASecurity.Data.Repository;
using DBASecurity.Data.Business;
using System.Collections.ObjectModel;
using System.Web.Http.Description;

namespace DBASecurity.Controllers.api
{
    public class EnvironmentController : ApiController
    {
        // GET: api/Environment
        [ResponseType(typeof(Collection<DBASecurity.Data.Business.Environment>))]
        public IHttpActionResult GetAll()
        {
            EnvironmentRepository repository = new EnvironmentRepository();
            return Ok(repository.GetAll());
        }

    }
}
