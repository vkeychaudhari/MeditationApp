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
    public class GetStartedViewModel : BaseViewModel
    {
        public ICommand GoToSignUpCommand { get; }
        public ICommand GoToSignInCommand { get; }

        public GetStartedViewModel()
        {
            GoToSignUpCommand = new Command(async () => await GoToSignUp());
            GoToSignInCommand = new Command(async () => await GoToSignIn());
        }

        private async Task GoToSignUp()
        {
            // Navigate by pushing the page onto the stack. This will show a back button.
            await Shell.Current.GoToAsync(nameof(SignUpPage));
        }

        private async Task GoToSignIn()
        {
            // Navigate by pushing the page onto the stack. This will show a back button.
            await Shell.Current.GoToAsync(nameof(SignInPage));
        }
    }
}
