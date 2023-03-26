public class TokenCredentialCLI : ITokenCredential
    {
        public TokenCredential GetCredential()
        {
            var defaultAzureCredentialOptions = new DefaultAzureCredentialOptions
            {
                 Diagnostics =
                    {
                        LoggedHeaderNames = { "x-ms-request-id" },
                        LoggedQueryParameters = { "api-version" },
                        IsAccountIdentifierLoggingEnabled = true,
                        IsLoggingContentEnabled = true,
                        IsLoggingEnabled = true,                        
                    }
            };
                            
            defaultAzureCredentialOptions.ExcludeAzureCliCredential = true;
            defaultAzureCredentialOptions.ExcludeEnvironmentCredential = true;
            defaultAzureCredentialOptions.ExcludeInteractiveBrowserCredential = true;
            defaultAzureCredentialOptions.ExcludeManagedIdentityCredential = true;
            defaultAzureCredentialOptions.ExcludeSharedTokenCacheCredential = true;
            defaultAzureCredentialOptions.ExcludeVisualStudioCodeCredential = false;
            defaultAzureCredentialOptions.ExcludeVisualStudioCredential = false;

            

            var credential = new DefaultAzureCredential(defaultAzureCredentialOptions);

            return credential;

        }
    }