namespace API
{
    public class RequestBase<T>
    {
        public string? projectKey;

        public string? authorizationProvider;

        public T? providerParams;
    }
}