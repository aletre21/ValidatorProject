using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorProject
{
    interface IPasswordValidator
    {
        bool CheckLength();
        bool CheckSpecialSign();
        bool CheckNumber ();
        bool CheckCapitalLetter();
        int PasswordLength { get; set; }
        bool HasCapitalLetter { get; set; }
        bool HasSpecialSign { get; set; }
        bool HasNumber { get; set; }
        bool CheckPassword();
    }
}
