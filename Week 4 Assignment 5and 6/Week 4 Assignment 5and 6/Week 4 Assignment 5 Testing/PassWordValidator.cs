using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testUnit
{
    public class PassWordValidator
    {
        public bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            if (password.Length < 8) return false;
            if (!Regex.IsMatch(password, "[A-Z]")) return false;
            if (!Regex.IsMatch(password, "\\d")) return false;
            return true;
        }

    }
}
