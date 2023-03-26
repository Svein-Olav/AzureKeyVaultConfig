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
                            
            defaultAzureCredentialOptions.ExcludeAzureCliCredential = true; // false ;
            defaultAzureCredentialOptions.ExcludeEnvironmentCredential = true;
            defaultAzureCredentialOptions.ExcludeInteractiveBrowserCredential = false;
            defaultAzureCredentialOptions.ExcludeManagedIdentityCredential = true;
            defaultAzureCredentialOptions.ExcludeSharedTokenCacheCredential = true;
            defaultAzureCredentialOptions.ExcludeVisualStudioCodeCredential = true;
            defaultAzureCredentialOptions.ExcludeVisualStudioCredential = true;

            

            var credential = new DefaultAzureCredential(defaultAzureCredentialOptions);

            return credential;

        }
    }