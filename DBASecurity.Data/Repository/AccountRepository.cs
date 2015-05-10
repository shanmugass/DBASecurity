using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBASecurity.Data;
using System.Collections.ObjectModel;

namespace DBASecurity.Data.Repository
{
    public class AccountRepository
    {
        public Collection<Business.Account> GetAccountsInEnv(int EnvId, string AccountName)
        {
            return Business.Account.Instant.GetAccountsInEnv(EnvId, AccountName);
        }
    }
}
