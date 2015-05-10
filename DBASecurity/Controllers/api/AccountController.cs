using DBASecurity.Data.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DBASecurity.Controllers.api
{
    public class AccountController : ApiController
    {
        // GET: api/Account/GetAccountsInEnv
        [ResponseType(typeof(Collection<DBASecurity.Data.Business.Account>))]
        [Route("~/api/Account/GetAccountsInEnv")]
        public IHttpActionResult GetAccountsInEnv(int envId, string AccountName)
        {
            AccountRepository repository = new AccountRepository();
            return Ok(repository.GetAccountsInEnv(envId, AccountName));
        }
    }
}
