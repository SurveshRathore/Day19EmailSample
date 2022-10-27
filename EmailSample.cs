using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationProblem
{
    internal class UC9EmailSample
    {
        public void CheckEmail()
        {
            //email regex
            String nameRegex = "^[A-Za-z][A-Za-z0-9]{2,}([.]([A-Za-z0-9]{3,}))?@[a-z]{2}[.][a-z]{2}([.][a-z]{2})?";
            //starts with A-Za-z then must have two or more A-Za-z0-9
            //([.]([A-Za-z0-9]{3,}))? optional
            //([.][a-z]{2})? optional
            Console.Write("Enter the Email: ");
            String email = Console.ReadLine();
            //compare the email regex with the user entered email
            bool valid = Regex.IsMatch(email, nameRegex);
            if (!valid)
            {
                //validate whether the email @ symbol or not
                bool result = Regex.IsMatch(email, "(?=.*[@])");
                if (!result)
                {
                    Console.WriteLine("must contains “@” symbol");
                }

                //validate whether the email is starting with the . dot or not
                char emailfirstCharacter = email[0];
                if(emailfirstCharacter == '.')
                {
                    Console.WriteLine("email’s 1st character can not start with “.”");
                }

                //validate whether the email contais two or more @ symbol or not
                int CountAtTheRateSymbol = 0;
                foreach (char chr in email)
                {
                    if (chr == '@')
                    {
                        CountAtTheRateSymbol++;
                    }
                }

                if (CountAtTheRateSymbol > 1)
                {
                    Console.WriteLine("double “@” is not allow");
                }
            }
            else
            {
                Console.WriteLine("valid Email.");
            }
            
        }
    }
}
