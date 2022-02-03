using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{
    public class SHA1
    {
        public static string transform_sha1(string input)
        {
            byte[] Hash;
            var sha = new System.Security.Cryptography.SHA1CryptoServiceProvider();


            Hash = sha.ComputeHash(sha.ComputeHash(Encoding.UTF8.GetBytes(input)));

            string a = "";
            foreach (byte b in Hash)
                a += b.ToString("x2");

            return a;
        }


        public static void Main(string[] args)
        {
            string Data = "password" + "dfgdfhgdhg" + "343243";

            string result = transform_sha1(Data);

            Console.WriteLine(result + "\n");

        }
    }
}
