using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_5and6_Testing
{
    public class StringUtils
    {
        public string Reverse(string str)
        {
            if (str == null) return null;
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool IsPalindrome(string str)
        {
            if (str == null) return false;
            string reversed = Reverse(str);
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        public string ToUpperCase(string str)
        {
            return str?.ToUpper();
        }
    }
}
