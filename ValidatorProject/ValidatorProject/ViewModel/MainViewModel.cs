using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;
using System.Windows.Input;

namespace ValidatorProject.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {        
        LoginValidator LoginValidator;
        PasswordValidator PasswordValidator;
        
        public MainViewModel()
        {
            this.LoginValidator = new LoginValidator();
            this.PasswordValidator = new PasswordValidator().SetPasswordLength(0).CapitalLetter(false).Number(true).SpecialSign(true);
        }

        private string isLoginValid;

        public string IsLoginValid
        {
            get
            {
                return isLoginValid;
            }
            set
            {
                isLoginValid = value;
                RaisePropertyChanged();
            }
        }

        private string isPasswordValid;

        public string IsPasswordValid
        {
            get
            {
                return isPasswordValid;
            }
            set
            {
                isPasswordValid = value;
                RaisePropertyChanged();
            }
        }

        private string writtenLogin;

        public string WrittenLogin
        {
            get
            {
                return writtenLogin;
            }
            set
            {
                writtenLogin = value;
                RaisePropertyChanged();
            }
        }

        private string writtenPassword;

        public string WrittenPassword
        {
            get
            {
                return writtenPassword;
            }
            set
            {
                writtenPassword = value;
                RaisePropertyChanged();
            }
        }

        private ICommand checkLogin;

        public ICommand CheckLogin
        {
            get
            {
                if (checkLogin == null)
                {
                    checkLogin = new RelayCommand(CheckLoginMethod, CanCheckLogin);
                }
                return checkLogin;
            }
        }

        private bool CanCheckLogin()
        {
                return true;
        }

        private void CheckLoginMethod()
        {
            if (LoginValidator.CheckLogin(WrittenLogin))
                IsLoginValid = "This login is valid";
            else
                IsLoginValid = "This login is incorrect";
        }

        private ICommand checkPassword;

        public ICommand CheckPassword
        {
            get
            {
                if (checkPassword == null)
                {
                    checkPassword = new RelayCommand<object>(CheckPasswordMethod, CanCheckPassword);
                }
                return checkPassword;
            }
        }

        private bool CanCheckPassword(object parameter)
        {
            return true;
        }

        private void CheckPasswordMethod(object parameter)
        {
            IsPasswordValid = "";
            WrittenPassword = (parameter as PasswordBox).Password;        
            if (PasswordValidator.CheckPassword(WrittenPassword))
            {
                IsPasswordValid = "This password is valid";
            }

            else
            {
                foreach (var item in PasswordValidator.PasswordErrorList)
                {
                    IsPasswordValid += item + "\n";
                }
            }
        }
    }
}
    
