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

            public Boolean ValidateName(string firstName)
            {
                String Pattern = "[A-Z]{1}[a-z]{2,}";
                return Regex.IsMatch(firstName, Pattern);
            }

            public Boolean Validatemail(string email)
            {
                string Pattern = "^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-][a-zA-Z0-9]+)*.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, Pattern);
            }

            public Boolean validNumber(string Number)
            {
                string Pattern = "^91 [0-9]{10}";
                return Regex.IsMatch(Number, Pattern);
            }
            public Boolean validPassWord(string Password)
            {
                string Pattern = "^(?=.*[A-Z])(?=.*\\d).{8,}$";
                return Regex.IsMatch(Password, Pattern);
            }
        }
    }
}




        




