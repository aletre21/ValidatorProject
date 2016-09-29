using System.Collections.Generic;

namespace ValidatorProject
{
    interface IPasswordValidator
    {
        IList<string> PasswordErrorList { get; set; }

        bool CheckPassword(string password);
    }
}
