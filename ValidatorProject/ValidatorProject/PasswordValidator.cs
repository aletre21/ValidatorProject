using System.Collections.Generic;
using System.Linq;

namespace ValidatorProject
{   /// <summary>
    /// Check if the password is valid by using defined rules
    /// </summary>
    public class PasswordValidator : IPasswordValidator
    {
        private int PasswordLength;

        private bool HasCapitalLetter;

        private bool HasSpecialSign;

        private bool HasNumber;

        public IList<string> PasswordErrorList { get; set; }

        public PasswordValidator()
        {
            PasswordLength = 8;
            HasCapitalLetter = true;
            HasSpecialSign = true;
            HasNumber = true;
            PasswordErrorList = new List<string>();
        }
        ///<summary>
        ///This value must be greater than or equal to 8
        ///</summary
        public PasswordValidator SetPasswordLength(int length)
        {
            if (length >= 8)
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

        private bool CheckCapitalLetter(string password)
        {
            if (HasCapitalLetter)
            {
                if (password.Any(c => char.IsUpper(c)))
                    return true;
                else
                {
                    PasswordErrorList.Add("Capital letter is required");
                    return false;
                }
            }
            else
                return true;
        }

        private bool CheckLength(string password)
        {
            if (password.Length >= PasswordLength)
                return true;
            else
            {
                PasswordErrorList.Add("Check length");
                return false;
            }
        }

        private bool CheckNumber(string password)
        {
            if (HasNumber)
            {

                if (password.Any(c => char.IsDigit(c)))
                    return true;

                else
                {
                    PasswordErrorList.Add("Digit is required");
                    return false;
                }
            }
            else
                return true;
        }

        private bool CheckSpecialSign(string password)
        {
            if (HasSpecialSign)
            {
                if (password.Any(c => !char.IsLetterOrDigit(c)))
                    return true;
                else
                {
                    PasswordErrorList.Add("Special sign is required");
                    return false;
                }
            }
            else
                return true;

        }

        public bool CheckPassword(string password)
        {
            PasswordErrorList.Clear();
            bool sign = CheckSpecialSign(password);
            bool length = CheckLength(password);
            bool capitalLetter = CheckCapitalLetter(password);
            bool number = CheckNumber(password);
            if (length && sign && number && capitalLetter)
                return true;
            else
                return false;
        }
    }
}
