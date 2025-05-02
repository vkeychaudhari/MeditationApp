using CommunityToolkit.Maui;
using FFImageLoading.Maui;
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

            return builder.Build();
        }
    }
}
