using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MediaCertificateUtility.Utility
{
    internal class PasswordIntegrity
    {
        public static bool IsStrongPasswordNonStrict(string Password)
        {
            if (Password.Count() >= 8 && Regex.IsMatch(Password, "[0-9]") && Regex.IsMatch(Password, "[a-z]") && Regex.IsMatch(Password,"[A-Z]"))
            {
                foreach(char X in Password)
                {
                    if (Char.IsSymbol(X) || Char.IsPunctuation(X))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
