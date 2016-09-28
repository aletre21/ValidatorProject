using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// to samo
namespace ValidatorProject
{
    public class PasswordValidator : IPasswordValidator
    {
        public int PasswordLength { get; set; } // przerwy
        public bool HasCapitalLetter { get; set; }
        public bool HasSpecialSign { get; set; }
        public bool HasNumber { get; set; }
        public string Password { get; set; }

       public PasswordValidator()
        {
            PasswordLength = 8;
            HasCapitalLetter = true;
            HasSpecialSign = true;
            HasNumber = true;
    }
        public PasswordValidator SetPasswordLength(int length)
        {   if (length >= 8)
                this.PasswordLength = length;
            else
                this.PasswordLength = 8;
            return this;
        }

        public PasswordValidator CapitalLetter(bool capitalLetter)
        {
            this.HasCapitalLetter = capitalLetter; // this nie potrzebne
            return this;
        }

        public PasswordValidator Number(bool number)
        {
            this.HasNumber = number;  // this nie potrzebne
            return this;
        }

        public PasswordValidator SpecialSign(bool specialSign)
        {
            this.HasSpecialSign = specialSign;  // this nie potrzebne
            return this;
        }

        public bool CheckCapitalLetter() // jedna metoda do sprawdzenia Validate.
        {
            try
            {
                if (HasCapitalLetter)
                {
                    if (Password.Any(c => char.IsUpper(c)))
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }

            catch(Exception ex)
            {
                return false;
            }
            }

        public bool CheckLength()
        {
            try
            {  

                if (Password.Length >= PasswordLength && Password.Length >= 3)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                return false;
            }
            }

        public bool CheckNumber()
        {  
            
            try
            {
                if (HasNumber) {

                    if (Password.Any(c => char.IsDigit(c))) // linq git
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
        public bool CheckSpecialSign()
        {
            try
            {

                if (HasSpecialSign)
                {
                    if (Password.Any(c => !char.IsLetterOrDigit(c))) // fajne linq
                        return true;
                    else return false;
                }
                else
                    return true;

            }

            // wut 
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CheckPassword()
        {
            try
            {
                if ((CheckSpecialSign() && CheckNumber() && CheckLength() && CheckSpecialSign()))
                    return true;

                else
                    return false;
            }

            catch (Exception ex)
            {
                return false;
            }
        }
        } 
}
