using MeditationApp.Helpers;
using MeditationApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MeditationApp.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }
        public ICommand GoToSignUpCommand { get; }

        public SignInViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            GoToSignUpCommand = new Command(async () => await GoToSignUp());
        }

        private async Task Login()
        {
            // Reset the stack and go to the main app experience
            await Shell.Current.GoToAsync($"///{nameof(WelcomePage)}");
        }

        private async Task GoToSignUp()
        {
            // Navigate from sign in to sign up
            await Shell.Current.GoToAsync($"../{nameof(SignUpPage)}");
        }
    }
}
