using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorProject
{
    interface ILoginValidator
    {
        bool CheckLength();
        bool CheckLetters();
        int LoginLength { get; set; }
        bool HasRightLetters { get; set; }
        bool CheckLogin();

        // wut
    }
}
