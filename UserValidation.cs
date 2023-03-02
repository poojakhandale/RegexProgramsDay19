using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class UserValidation
    {


        public class User
        {

            public Boolean ValidateFirstName(string firstName)
            {
                String Pattern = "[A-Z]{1}[a-z]{2,}";
                return Regex.IsMatch(firstName, Pattern);
            }
        }
    }
}
