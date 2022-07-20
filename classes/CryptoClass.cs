using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Organiser
{
    static class CryptoClass
    {
        public static bool MatchSHA1(byte[] p1, byte[] p2)
        {
            bool result = false;
            if (p1 != null && p2 != null)
            {
                if (p1.Length == p2.Length)
                {
                    result = true;
                    for (int i = 0; i < p1.Length; i++)
                    {
                        if (p1[i] != p2[i])
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }
            return result;
        }

        //public static string Hash(string input)
        //{
        //    var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
        //    return string.Concat(hash.Select(b => b.ToString("x2")));
        //}

        public static byte[] GetSHA1(string userID, string password)
        {
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            return sha.ComputeHash(System.Text.Encoding.ASCII.GetBytes(userID + password));
        }
    }
}
