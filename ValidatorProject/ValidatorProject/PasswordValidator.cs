using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidatorProject
{
    public class PasswordValidator : IPasswordValidator
    {
        public int PasswordLength { get; set; }
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
            this.HasCapitalLetter = capitalLetter;
            return this;
        }

        public PasswordValidator Number(bool number)
        {
            this.HasNumber = number;
            return this;
        }

        public PasswordValidator SpecialSign(bool specialSign)
        {
            this.HasSpecialSign = specialSign;
            return this;
        }

        public bool CheckCapitalLetter()
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

                    if (Password.Any(c => char.IsDigit(c)))
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
                    if (Password.Any(c => !char.IsLetterOrDigit(c)))
                        return true;
                    else return false;
                }
                else
                    return true;

            }


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
