namespace Workplace.Contracts.Requests
{
    public class CreateRequest
    {
        public CreateRequest(string nickName,
                             string email,
                             string comments,
                             string createDate)
        {
            NickName = nickName;
            Email = email;
            Comments = comments;
            CreateDate = createDate;
        }

        public string NickName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;
        public string CreateDate { get; set; } = string.Empty;
    }
}
