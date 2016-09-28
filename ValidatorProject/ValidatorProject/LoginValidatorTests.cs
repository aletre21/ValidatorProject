using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorProject
{
    [TestFixture]
    public class LoginValidatorTests
    {
        [TestCase("adamnowakA", false)]
        [TestCase("adam@now.com", true)]
        [TestCase("adamno@wakA", false)]
        [TestCase("ada.mnowakA", false)]
        public void Login_is_valid(string login, bool expected)
        {
            LoginValidator l = new LoginValidator();
            l.Login = login;

            Assert.AreEqual(l.CheckLogin(), expected);

        }

        [Test]
        public void Login_is_null()
        {
            LoginValidator l = new LoginValidator();           
            Assert.IsFalse(l.CheckLogin());
        }

        [TestCase("adamnowakA", true)]
        [TestCase("adam@now.com", true)]
        [TestCase("adamno@wakA", true)]
        [TestCase("as", false)]
        public void Letter_control_is_switched_off(string login, bool expected)
        {
            LoginValidator l = new LoginValidator();
            l.HasRightLetters = false;
            l.Login = login;
            Assert.AreEqual(l.CheckLogin(), expected);

        }

        [TestCase("",5, false)]
        [TestCase("adamd",5, true)]
        [TestCase("adamno@wakA",6,true)]
        [TestCase("as",2, false)]
        public void Check_number_of_letters(string login,int length, bool expected)
        {
            LoginValidator l = new LoginValidator();
            l.Login = login;
            l.LoginLength = length;
            Assert.AreEqual(l.CheckLength(), expected);

        }
    }
}
