using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Common
{
    public static class RandomValueGenerator
    {
        public static string GeneratePassword(int length)
        {
            //Random rnd = new Random();
            //string password = string.Empty;

            //string list = "abcdefghijklmnoprstuvzy";
            //list += list.ToUpper();
            //list += "0123456789";

            //for (int i = 0; i < length; i++)
            //    password += list[rnd.Next(list.Length)];

            //return password;
            //------------------------------------

            return Guid.NewGuid()
                       .ToString()
                       .Replace("-", "")
                       .Substring(0, length);
        }

        public static string GenerateFileName(string extension)
        {
            return Guid.NewGuid()
                       .ToString()
                       .Replace("-", "") + extension;
        }
    }
}
