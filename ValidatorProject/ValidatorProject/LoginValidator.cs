using System;
using System.Text.RegularExpressions;

namespace ValidatorProject
{
    public class LoginValidator : ILoginValidator
    {
        public bool CheckLogin(string login)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(login);
            return match.Success;
        }
    }
}
         

        
      
    








