namespace Workplace.Application.Queries
{
    public class GetQuery
    {
        public GetQuery(string email)
        {
            Email = email;
        }

        public string Email { get; }
    }
}
