public abstract class AzureCredentialFactory
    {
        public abstract ITokenCredential CreateCredential();

        public static ITokenCredential GetTokenUsingCLICredential()
        {
            return new AzureCLICredentialFactory().CreateCredential();
        }

    }