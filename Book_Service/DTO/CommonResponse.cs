namespace Book_Service.DTO
{
    public class CommonResponse
    {
        public object? Result { get; set; }
        public bool isSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
