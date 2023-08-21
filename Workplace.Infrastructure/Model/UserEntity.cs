namespace Workplace.Infrastructure.Model
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string NickName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;
        public string CreateDate { get; set; } = string.Empty;
    }
}
