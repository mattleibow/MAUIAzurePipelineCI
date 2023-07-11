using CommunityToolkit.Maui;
using Esri.ArcGISRuntime.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter;
//using ZXing.Net.Maui;

namespace Infor.PublicSector.Mobile.FieldWorks
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseArcGISRuntime();

#if DEBUG
		builder.Logging.AddDebug();
#endif

            AppCenter.Start("windowsdesktop=18cfbd30-9754-4a87-a989-388658e13053;" +
                "android=954d1828-4270-470f-9fed-153282eea2aa;" +
                "ios=a8b9acba-3428-422b-bb95-c31f2f9d8e86;",
                typeof(Analytics), typeof(Crashes));

            return builder.Build();
        }
    }
}