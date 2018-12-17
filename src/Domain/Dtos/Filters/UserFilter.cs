namespace Domain.Dtos
{
    public class UserFilter
    {
        public int Id { get; set; }
        public string NameLike { get; set; }
        public string EmailLike { get; set; }
        public bool? Active { get; set; }
    }
}
