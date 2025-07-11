namespace Taskify.Services.DTOs.Responses
{
    public static class ResponseHelper
    {
        public static GenericResponse<T> Success<T>(T data, string message = "") =>
        new() { IsSuccess = true, Data = data, Message = message, Status = "Success" };

        public static GenericResponse<T> Failure<T>(string message) =>
            new() { IsSuccess = false, Message = message, Status = "Failure", Data = default! };
    }
}
