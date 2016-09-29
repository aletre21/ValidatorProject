using System.Windows;

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
            LoginValidator Login = new LoginValidator();

            if(Login.CheckLogin(LoginText.Text))
                LoginInfo.Content = "This login is valid";
            else
                LoginInfo.Content = "This login is incorrect";
        }
        
        private void buttonPassword_Click(object sender, RoutedEventArgs e)
        {
            PasswordV Password = new PasswordV().SetPasswordLength(0).CapitalLetter(false).Number(true).SpecialSign(true);

            if(Password.CheckPassword(PasswordText.Password))
            {
                PasswordInfo.Content = "This password is valid";
            }
            
            else
            {
                string error=null;
                foreach(var item in Password.PasswordErrorList)
                {
                    error+=item + "\n";
                }
                PasswordInfo.Content= error;
            }  
        }
    }
}
