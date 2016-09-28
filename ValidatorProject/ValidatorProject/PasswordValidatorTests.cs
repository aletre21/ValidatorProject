using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorProject
{   
    [TestFixture]
   public class PasswordValidatorTests
    {
        [TestCase("adamnowak1234!A", true)]
        [TestCase("as", false)]
        [TestCase("", false)]
        public void Password_length_default (string pass, bool expected)

        {
            PasswordValidator p = new PasswordValidator();
            p.Password = pass;
            Assert.AreEqual(expected, p.CheckLength());
        }

        [TestCase("adamnowak1234!A",4, true)]
        [TestCase("as",2,false)]
        [TestCase("",0, false)]
        public void Password_length_custom(string pass, int length, bool expected)

        {
            PasswordValidator p = new PasswordValidator();
            p.Password = pass;
            p.PasswordLength = length;
            Assert.AreEqual(expected, p.CheckLength());
        }

        [Test]
        public void Password_is_null()
        {
            PasswordValidator p = new PasswordValidator();
            Assert.IsFalse(p.CheckPassword());
        }


        [TestCase("adamnowak1234!A", 4, true,true,true,true)]
        [TestCase("adamnowak!A", 6, false,true,true,true)]
        [TestCase("adamnowak1234A", 8, true,false,false,true)]
        [TestCase("adamnowak1234!A", 8, false,false,false,true)]
        [TestCase("adamnowakA", 4, true,false,false,false)]
        public void Password_is_null(string password, int length, bool number, bool sign, bool capitalLetter, bool expected)
        {
            PasswordValidator p = new PasswordValidator();
            p.Password = password;
            p.HasNumber = number;
            p.HasCapitalLetter = capitalLetter;
            p.HasSpecialSign = sign;
            Assert.AreEqual(expected, p.CheckPassword());
        }





    }
}
