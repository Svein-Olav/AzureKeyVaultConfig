using Azure.Core.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

ITokenCredential credential = AzureCredentialFactory.GetTokenUsingCLICredential();

using AzureEventSourceListener listener = AzureEventSourceListener.CreateConsoleLogger();

builder.Configuration.AddAzureKeyVault(
        new Uri($"https://kv-kompetanse.vault.azure.net/"),
        credential.GetCredential());

var app = builder.Build();

app.MapGet("/level", (IConfiguration config) => $" passord :  {config["level1:level2"]}"  );
app.MapGet("/passord", (IConfiguration config) => $" passord :  {config["passord"]}"  );

app.Run();
