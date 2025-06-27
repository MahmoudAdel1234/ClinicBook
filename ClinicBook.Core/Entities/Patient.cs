namespace ClinicBook.Core.Entities
{
    public class Patient
    {
        public Guid Id { get; set; }

        public string NationalId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1,
    }
}
