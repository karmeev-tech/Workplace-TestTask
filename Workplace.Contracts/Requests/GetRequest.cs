namespace Workplace.Contracts.Requests
{
    public class GetRequest
    {
        public GetRequest(string email)
        {
            Email = email;
        }

        public string Email { get; }
    }
}
