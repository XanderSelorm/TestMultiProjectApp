﻿using Fluxor;

using Microsoft.Extensions.Logging;

using System.Reflection;

using TestBlazorMaui.Data;

namespace TestBlazorMaui;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<WeatherForecastService>();

        builder.Services.AddFluxor(options =>
        {
            options.UseRouting();
            options.ScanAssemblies(Assembly.GetExecutingAssembly());
            options.ScanAssemblies(typeof(TestFluxorStore.TestFluxorStore).Assembly);
            options.UseReduxDevTools();
        });

        return builder.Build();
    }
}
