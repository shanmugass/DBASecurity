using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBASecurity.Data.Business
{
    public class Environment: BaseBusiness<Environment> 
    {
        /// <summary>
        /// Gets or sets the Environment identifier.
        /// </summary>
        /// <value>
        /// The Environment identifier.
        /// </value>
        public int EnvId { get; set; }

        /// <summary>
        /// Gets or sets the Environment Name.
        /// </summary>
        /// <value>
        /// The Environment Name.
        /// </value>
        public string EnvironmentName { get; set; }

        private static Environment instantObjcet;

        public static Environment Instant
        {
            get
            {
                if (instantObjcet == null)
                {
                    instantObjcet = new Environment();
                }
                return instantObjcet;
            }
        }

        public Environment GetObject(DataRow dr) {
            Environment newObject = new Environment();
            newObject.EnvId=(int)dr["EnvId"];
            newObject.EnvironmentName = dr["Environment"].ToString();
            return newObject;
        }

        public Collection<Environment> GetAll()
        {
            DAL.DALEnvironment dalEnvironment = new DAL.DALEnvironment();
            return dalEnvironment.getEnvironments();
        }
    }
}
