using System;

namespace ClassLib
{
    public class Challenge
    {
        public HashResult GenHash(string str)
        {
            byte[] strHash;
            byte[] strSalt;

            return new HashResult();
        }

        public class HashResult
        {
            public byte[] Salt { get; set; }
            public byte[] HashValue { get; set; }
        }
    }
}
