using Azure.Core.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

ITokenCredential credential = AzureCredentialFactory.GetTokenUsingCLICredential();

//builder.Logging.ClearProviders().AddConsole();
using AzureEventSourceListener listener = AzureEventSourceListener.CreateConsoleLogger();

builder.Configuration.AddAzureKeyVault(
        new Uri($"https://kv-kompetanse.vault.azure.net/"),
        credential.GetCredential());

var app = builder.Build();

app.MapGet("/", (IConfiguration config) => $" passord :  {config["passord"]}"  );

app.Run();
