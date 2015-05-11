using System.Data;
using System.Data.SqlClient;

namespace DBASecurity.Data.Business
{
    interface BaseBusiness<T>
    {
        T GetObject(SqlDataReader dr);
    }

}
