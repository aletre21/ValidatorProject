﻿using NUnit.Framework;

namespace ValidatorProject
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        [TestCase("adamnowak1234!A", true)]
        [TestCase("as", false)]
        [TestCase("", false)]
        public void Password_length_default(string pass, bool expected)
        {
            PasswordValidator Password = new PasswordValidator();
            Assert.AreEqual(expected, Password.CheckPassword(pass));
        }

        [TestCase("adamnowak1234!A", 4, true)]
        [TestCase("as", 2, false)]
        [TestCase("", 0, false)]
        public void Password_length_custom(string pass, int length, bool expected)
        {
            PasswordValidator Password = new PasswordValidator().SetPasswordLength(length);
            Assert.AreEqual(expected, Password.CheckPassword(pass));
        }

        [TestCase("adamnowak1234!A", 4, true, true, true, true)]
        [TestCase("adamnowak!A", 6, false, true, true, true)]
        [TestCase("adamnowak1234A", 8, true, false, false, true)]
        [TestCase("adamnowak1234!A", 8, false, false, false, true)]
        [TestCase("adamnowakA", 4, true, false, false, false)]
        public void Password_mixed_conditions(string pass, int length, bool number, bool sign, bool capitalLetter, bool expected)
        {
            PasswordValidator Password = new PasswordValidator().SetPasswordLength(length).SpecialSign(sign).Number(number).CapitalLetter(capitalLetter);
            Assert.AreEqual(expected, Password.CheckPassword(pass));
        }
    }
}
