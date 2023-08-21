namespace Workplace.Application.Services.Common
{
    public class DeleteResult
    {
        public DeleteResult(string status)
        {
            Status = status;
        }

        public string Status { get; }
    }
}
