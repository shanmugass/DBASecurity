using System.Data;

namespace DBASecurity.Data.Business
{
    interface BaseBusiness<T>
    {
        T GetObject(DataRow dr);
    }

}
