using System.Text.RegularExpressions;

namespace ValidatorProject
{
    /// <summary>
    /// Check if the login is valid by using regex
    /// </summary>
    public class LoginValidator : ILoginValidator
    {
        public bool CheckLogin(string login)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!string.IsNullOrEmpty(login))
            {
                Match match = regex.Match(login);
                return match.Success;
            }
            else
                return false;
        }
    }
}
         

        
      
    








