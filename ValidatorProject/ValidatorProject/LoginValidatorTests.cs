using NUnit.Framework;

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
            LoginValidator Login = new LoginValidator();
            Assert.AreEqual(Login.CheckLogin(login), expected);
        }
    }
}
