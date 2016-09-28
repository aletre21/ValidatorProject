using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// niepotrzebne usingi
namespace ValidatorProject
{
    interface ILoginValidator
    {//przerwy miedzy skladnikami, kolejnosc, najpierw property, potem metody
        bool CheckLength();
        bool CheckLetters();
        int LoginLength { get; set; }
        bool HasRightLetters { get; set; }
        bool CheckLogin();

        // wut
    }
}
