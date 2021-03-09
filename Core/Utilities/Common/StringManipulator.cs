using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Common
{
    public static class StringManipulator
    {
        public static string GetSeoFriendlyString(string original)
        {
            return original.ToLower()
                    .Replace("ç", "c")
                    .Replace("ğ", "g")
                    .Replace("ı", "i")
                    .Replace("ş", "s")
                    .Replace("ö", "o")
                    .Replace("ü", "u")
                    .Replace(" ", "-");
        }
    }
}
