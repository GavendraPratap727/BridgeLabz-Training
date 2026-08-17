namespace FundooNotes.Common
{
    /// <summary>
    /// A consistent envelope returned by every action method.
    /// </summary>
    public class ResponseModel<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }

        public static ResponseModel<T> Ok(string message, T? data = default) =>
            new() { Success = true, Message = message, Data = data };

        public static ResponseModel<T> Fail(string message) =>
            new() { Success = false, Message = message, Data = default };
    }
}