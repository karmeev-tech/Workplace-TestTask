namespace Workplace.Contracts.Requests
{
    public class UpdateRequest
    {
        public UpdateRequest(string nickName,
                             string email,
                             string comments)
        {
            NickName = nickName;
            Email = email;
            Comments = comments;
        }

        public string NickName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;
    }
}
