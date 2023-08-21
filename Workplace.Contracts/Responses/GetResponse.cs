namespace Workplace.Contracts.Responses
{
    public class GetResponse
    {
        public string NickName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;
        public string CreateDate { get; set; } = string.Empty;
    }
}
