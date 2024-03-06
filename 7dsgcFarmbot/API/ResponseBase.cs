namespace API
{
    public class ResponseBase<T>
    {
        public int code;

        public string? errmsg;

        public object? errmsgvariablemap;

        public string? errorCase;

        public string? key;

        public T? data;
    }
}
