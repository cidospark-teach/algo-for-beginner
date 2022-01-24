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

        public bool CompareHash(string str, byte[] strHash, byte[] strSalt)
        {
            using(var hash = new HMACSHA512(strSalt))
            {
                var genHash = hash.ComputeHash(Encoding.ASCII.GetBytes(str));
                for(int i = 0; i < genHash.Length; i++)
                {
                    if (genHash[i] != strHash[i])
                        return false;
                }
            }

            return true;
        }

    }
}
