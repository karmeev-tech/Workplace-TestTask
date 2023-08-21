namespace Workplace.Contracts.Requests
{
    public class DeleteRequest
    {
        public DeleteRequest(string email)
        {
            Email = email;
        }

        public string Email { get; set; } = string.Empty;
    }
}
