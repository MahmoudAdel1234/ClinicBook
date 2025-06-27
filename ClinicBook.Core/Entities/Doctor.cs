namespace ClinicBook.Core.Entities
{
    public class Doctor
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string NationalId { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Specialize { get; set; }

        public Guid DepartmentId { get; set; }

        public Department Department { get; set; }

    }
}
