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
    class DALEnvironment:BaseDAL<Business.Environment>
    {
        SqlConnection cons = new SqlConnection(ConfigurationManager.ConnectionStrings["DBASecurity"].ConnectionString);

        public Collection<Business.Environment> getEnvironments()
        {
            Collection<Business.Environment> environments = new Collection<Business.Environment>();
            SqlCommand cmd = new SqlCommand("getEnvironments",  cons);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cons.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    environments.Add(Business.Environment.Instant.GetObject(dr));
                }
            }
            finally
            {
                cons.Close();
            }
            return environments;
        }
    }
}
