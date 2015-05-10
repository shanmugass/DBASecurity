using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBASecurity.Data.Business;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DBASecurity.Data.DAL
{
    class DALAccount: BaseDAL<Business.Account>
    {
        SqlConnection cons = new SqlConnection(ConfigurationManager.ConnectionStrings["DBASecurity"].ConnectionString);

        public Collection<Business.Account> GetAccountsInEnv(int EnvId, string AccountName)
        {
            Collection<Business.Account> accounts = new Collection<Business.Account>();
            SqlCommand cmd = new SqlCommand("getAccountsInEnv", cons);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EnvId", EnvId));
            cmd.Parameters.Add(new SqlParameter("@AccountName", AccountName));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows )
            {
                accounts.Add(Business.Account.Instant.GetObject(dr));
            }
            return accounts;
        }
    }
}
