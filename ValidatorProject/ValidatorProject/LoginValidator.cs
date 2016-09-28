using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidatorProject
{



    public class LoginValidator : ILoginValidator
    {

        public int LoginLength { get; set; }
        public bool HasRightLetters { get; set; }
        public string Login { get; set; }

        public LoginValidator()
        {
         LoginLength = 6;
         HasRightLetters = true;
        }


        public LoginValidator SetLoginLength(int length)
        {
            if (length >= 6)
                LoginLength = length;
            else
                LoginLength = 6;
            return this; }
        public LoginValidator CheckLetters(bool letters) { HasRightLetters = letters; return this; }

        public bool CheckLength()
        {
            try
            {
                if (Login.Length >= LoginLength && Login.Length >= 5)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckLetters()
        {
            try
            {
                if (HasRightLetters)
                {
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = regex.Match(Login);
                    if (match.Success)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckLogin()
        {
            
            if (CheckLength() && CheckLetters())
                return true;
            else
                return false;

        }
    }
}
         

        
      
    








