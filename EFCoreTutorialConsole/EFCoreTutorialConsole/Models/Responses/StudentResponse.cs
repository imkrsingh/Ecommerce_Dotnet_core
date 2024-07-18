namespace EFCoreTutorialConsole.Models.Responses
{
    public class BaseResponse<T>
    {
        public string Message { get; set; } 
        public int Status { get; set; }
        public T Data { get; set; }
    }
}

