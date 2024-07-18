using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Models.ApiResponse
{
    public class ApiResponse<T>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public int? TotalCount { get; set; }

        public ApiResponse<T> SetSuccessResponse(T data, int totalCount)
        {
            Status = 200; // HTTP OK
            Message = "Success";
            Data = data;
            TotalCount = totalCount;
            return this;

        }
        public ApiResponse<T> SetErrorResponse(string errorMessage)
        {
            Status = 400;
            Data = default;
            Message = errorMessage;
            return this;

        }

        internal ActionResult<ApiResponse<string>> SetSuccessResponse(string image)
        {
            throw new NotImplementedException();
        }
    }
}
