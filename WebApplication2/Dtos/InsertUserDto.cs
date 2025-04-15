using WebApplication2.Constants;

namespace WebApplication2.Dtos
{
    public class InsertUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }

        public string? ImageURL { get; set; }

        public DateTime RegisteredDate { get; set; } = DateTime.Now;

    }
}
