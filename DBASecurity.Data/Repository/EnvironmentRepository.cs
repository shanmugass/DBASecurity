using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBASecurity.Data;
using System.Collections.ObjectModel;

namespace DBASecurity.Data.Repository
{
    public class EnvironmentRepository
    {
        public Collection<Business.Environment> GetAll()
        {
            return Business.Environment.Instant.GetAll();
        }
    }
}
