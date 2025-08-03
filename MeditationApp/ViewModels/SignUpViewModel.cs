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
    public class SignUpViewModel : BaseViewModel
    {
        public ICommand GetStartedCommand { get; }
        public ICommand GoToSignInCommand { get; }

        public SignUpViewModel()
        {
            GetStartedCommand = new Command(async () => await GetStarted());
            GoToSignInCommand = new Command(async () => await GoToSignIn());
        }

        private async Task GetStarted()
        {
            // After signing up, go to the welcome page
            // The /// resets the navigation stack so the user can't go "back" to the login screen
            await Shell.Current.GoToAsync($"///{nameof(WelcomePage)}");
        }

        private async Task GoToSignIn()
        {
            try
            {
                // Navigate from sign up to sign in. ".." means go up one level.
                //await Shell.Current.GoToAsync($"../{nameof(SignInPage)}");

                await Shell.Current.GoToAsync($"///{nameof(SignInPage)}");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during navigation
                Console.WriteLine($"Navigation error: {ex.Message}");

            }
        }
    }
}
