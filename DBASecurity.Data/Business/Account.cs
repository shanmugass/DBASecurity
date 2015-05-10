using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBASecurity.Data.Business
{
    public class Account : BaseBusiness<Account> 
    {
        /// <summary>
        /// Gets or sets the Account identifier.
        /// </summary>
        /// <value>
        /// The Account identifier.
        /// </value>
        public int AccountId { get; set; }

        /// <summary>
        /// Gets or sets the Account Name.
        /// </summary>
        /// <value>
        /// The Account Name.
        /// </value>
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the Account Comment.
        /// </summary>
        /// <value>
        /// The Account Comment.
        /// </value>
        public string AccountComment { get; set; }

        /// <summary>
        /// Gets or sets the Account Encrypted Password.
        /// </summary>
        /// <value>
        /// The Account Encrypted Password.
        /// </value>
        public string AccountPwdEncrypted { get; set; }

        /// <summary>
        /// Gets or sets the Account Password Encryption Key.
        /// </summary>
        /// <value>
        /// The Account Account Password Encryption Key.
        /// </value>
        public string AccountPwdEncryptKey { get; set; }

        /// <summary>
        /// Gets or sets the Account Password Encryption Type.
        /// </summary>
        /// <value>
        /// The Account Account Password Encryption Type.
        /// </value>
        public int AccountPwdEncryptionTypeID { get; set; }

        /// <summary>
        /// Gets or sets the Account Password Encryption Type Name.
        /// </summary>
        /// <value>
        /// The Account Account Password Encryption Type Name.
        /// </value>
        public string AccountEncryptionTypeName { get; set; }

        /// <summary>
        /// Gets or sets the Account Application.
        /// </summary>
        /// <value>
        /// The Account Account Application.
        /// </value>
        public string AccountApplication { get; set; }

        private static Account instantObjcet;

        public static Account Instant
        {
            get
            {
                if (instantObjcet == null)
                {
                    instantObjcet = new Account();
                }
                return instantObjcet;
            }
        }

        public Account GetObject(DataRow dr)
        {
            Account newObject = new Account();
            newObject.AccountId = (int)dr["AccountId"];
            newObject.AccountName = dr["AccountName"].ToString();
            newObject.AccountComment = dr["AccountComment"].ToString();
            newObject.AccountPwdEncrypted = dr["AccountPwdEncrypted"].ToString();
            newObject.AccountPwdEncryptKey = dr["AccountPwdEncryptKey"].ToString();
            newObject.AccountPwdEncryptionTypeID = (int)dr["AccountPwdEncryptionTypeID"];
            newObject.AccountEncryptionTypeName = dr["AccountEncryptionTypeName"].ToString();
            newObject.AccountApplication = dr["AccountApplication"].ToString();
            return newObject;
        }

        /// <summary>
        /// Gets list of accounts of specific environment.
        /// </summary>
        public Collection<Account> GetAccountsInEnv(int EnvId, string AccountName)
        {
            DAL.DALAccount dalAccount = new DAL.DALAccount();
            return dalAccount.GetAccountsInEnv(EnvId, AccountName);
        }
    }
}
