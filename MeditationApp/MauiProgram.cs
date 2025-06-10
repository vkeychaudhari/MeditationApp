using CommunityToolkit.Maui;
using FFImageLoading.Maui;
using MeditationApp.ViewModels;
using MeditationApp.Views;
using Microsoft.Extensions.Logging;

namespace MeditationApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()  // Community Toolkit
                .UseFFImageLoading()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("AirbnbCereal_W_Bd.otf", "AirbnbCereal_W_Bd");
                    fonts.AddFont("AirbnbCereal_W_Bk.otf", "AirbnbCereal_W_Bk");
                    fonts.AddFont("AirbnbCereal_W_Blk.otf", "AirbnbCereal_W_Blk");
                    fonts.AddFont("AirbnbCereal_W_Lt.otf", "AirbnbCereal_W_Lt");
                    fonts.AddFont("AirbnbCereal_W_Md.otf.otf", "AirbnbCereal_W_Md");
                    fonts.AddFont("AirbnbCereal_W_XBd.otf", "AirbnbCereal_W_XBd");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            // Register Views (Pages)
            builder.Services.AddSingleton<GetStartedPage>();
            builder.Services.AddTransient<SignInPage>();
            builder.Services.AddTransient<SignUpPage>();
            builder.Services.AddTransient<WelcomePage>();
            builder.Services.AddTransient<ChooseTopicPage>();


            // Register ViewModels
            builder.Services.AddSingleton<GetStartedViewModel>();
            builder.Services.AddTransient<SignInViewModel>();
            builder.Services.AddTransient<SignUpViewModel>();
            builder.Services.AddTransient<WelcomeViewModel>();
            builder.Services.AddTransient<ChooseTopicViewModel>();


            return builder.Build();
        }
    }
}
