using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Aculocity.ProjectName.DAL
{
    class CryptoBaseEntity
    {
        private SHA512Managed m_isHasher;

        public CryptoBaseEntity()
        {
            m_isHasher = new SHA512Managed();
        }
        public String GetSalt(Int32 SaltSize)
        {
            Byte[] buffer = new Byte[SaltSize];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);

            return Convert.ToBase64String(buffer);
        }

        public String HashEncryptString(String Value)
        {
            Byte[] clearBytes = Encoding.UTF8.GetBytes(Value);
            Byte[] hashedBytes = m_isHasher.ComputeHash(clearBytes);

            return Convert.ToBase64String(hashedBytes);
        }

        public String HashEncriptStringWithSalt(String Value, String SaltValue)
        {
            return this.HashEncryptString(Value + SaltValue);
        }
    }
}
