namespace OpenSurvey.Domain.Entities.User
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public int? Age { get; set; }
    }
}