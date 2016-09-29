using System.Collections.Generic;
using System.Linq;

namespace ValidatorProject
{
    public class PasswordV : IPasswordValidator
    {
        private int PasswordLength;

        private bool HasCapitalLetter;

        private bool HasSpecialSign;

        private bool HasNumber;

        public IList<string> PasswordErrorList { get; set; }

        public PasswordV()
        {
            PasswordLength = 8;
            HasCapitalLetter = true;
            HasSpecialSign = true;
            HasNumber = true;
            PasswordErrorList = new List<string>();
        }

        public PasswordV SetPasswordLength(int length)
        {
            if (length >= 8)
                this.PasswordLength = length;
            else
                this.PasswordLength = 8;
            return this;
        }

        public PasswordV CapitalLetter(bool capitalLetter)
        {
            this.HasCapitalLetter = capitalLetter;
            return this;
        }

        public PasswordV Number(bool number)
        {
            this.HasNumber = number;
            return this;
        }

        public PasswordV SpecialSign(bool specialSign)
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
