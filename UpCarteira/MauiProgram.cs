using LiteDB;
using Microsoft.Extensions.Logging;
using System.Transactions;
using UpCarteira.Repositories;

namespace UpCarteira;

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .RegisterDatabaseAndRepositories();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        var app = builder.Build();
        ServiceHelper.Initialize(app.Services);

        return app;
    }

    private static MauiAppBuilder RegisterDatabaseAndRepositories(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<LiteDatabase>(
            options =>
            {
                return new LiteDatabase($"Filename={AppSettings.DatabasePath};Connection=Shared");
            })
            .AddTransient<TransactionRepository>();
        return mauiAppBuilder;
    }
}