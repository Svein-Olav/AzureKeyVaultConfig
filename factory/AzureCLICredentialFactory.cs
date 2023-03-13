public class AzureCLICredentialFactory : AzureCredentialFactory
    {
        public override ITokenCredential CreateCredential()
        {
            return new TokenCredentialCLI();

        }
    }