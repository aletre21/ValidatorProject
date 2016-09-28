using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// to samo
namespace ValidatorProject
{
    // wtf


    public class LoginValidator : ILoginValidator
    {

        public int LoginLength { get; set; }// to samo
        public bool HasRightLetters { get; set; } // 
        public string Login { get; set; } // przekazywane do metody

        public LoginValidator()
        {
         LoginLength = 6;
         HasRightLetters = true;
        }


        public LoginValidator SetLoginLength(int length) // lenght dla emaila do wywalenia
        {
            if (length >= 6) // ustawiając mniej niż 6 , uzytkownik twojej klasy zdziwi sie ze nie dziala
                LoginLength = length;
            else
                LoginLength = 6;
            return this;
        }// przerwa
        public LoginValidator CheckLetters(bool letters)
        {
            HasRightLetters = letters;
            return this;
        }

        public bool CheckLength() // jedna metoda sprawdzajaca czy mail jest prawidlowy np. Validate
        {
            try
            {
                if (Login.Length >= LoginLength && Login.Length >= 5) // try catch ? co sie moze wywalic tu ?
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
            try // try catch nie potrzebny
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
         

        
      
    








