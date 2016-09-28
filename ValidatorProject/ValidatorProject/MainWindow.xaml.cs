using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static ValidatorProject.LoginValidator;

namespace ValidatorProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

           


        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {

            LoginValidator l = new LoginValidator().SetLoginLength(8);
            l.Login = LoginText.Text;

            if (l.CheckLogin())
            {
                LoginInfo.Content = "This login is valid";
            }

            else
            {
                LoginInfo.Content = "This login is incorrect\n";

                if (!l.CheckLength())
                    LoginInfo.Content += "Check length "+"(min "+l.LoginLength+ ")\n";
                 if(!l.CheckLetters())
                    LoginInfo.Content += "Check letters\n";
            }
        }

        private void buttonPassword_Click(object sender, RoutedEventArgs e)
        {
            PasswordValidator p = new PasswordValidator().SetPasswordLength(0).CapitalLetter(false).Number(true).SpecialSign(true);
            p.Password = PasswordText.Text;

            if(p.CheckPassword())
            {
                PasswordInfo.Content = "This password is valid";


            }

            else
            {
                PasswordInfo.Content = "This password is incorrect\n";
                if (!p.CheckNumber())
                    PasswordInfo.Content += "At least one digit is required\n";
                if(!p.CheckCapitalLetter())
                    PasswordInfo.Content += "At least one capital letter is required\n";
                if (!p.CheckSpecialSign())
                PasswordInfo.Content += "At least one special sign is required\n";
                if (!p.CheckLength())
                    PasswordInfo.Content += "Check length"+"(min "+p.PasswordLength+")\n";
            }

        }
    }
}
