using System;
using System.Security.Cryptography;
using System.Text;

namespace ClassLib
{
    public class Challenge
    {
        public HashResult GenHash(string str)
        {
            byte[] strHash;
            byte[] strSalt;

            using (var hash = new HMACSHA512())
            {
                strSalt = hash.Key;
                strHash = hash.ComputeHash(Encoding.ASCII.GetBytes(str));
            }

            var result = new HashResult();
            result.Salt = strSalt;
            result.HashValue = strHash;

            return result;
        }

        public class HashResult
        {
            public byte[] Salt { get; set; }
            public byte[] HashValue { get; set; }
        }
    }
}
