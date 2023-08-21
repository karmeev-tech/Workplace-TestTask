namespace Workplace.Application.Services.Common
{
    public class CreateResult
    {
        public CreateResult(string status)
        {
            Status = status;
        }

        public string Status { get; }
    }
}
