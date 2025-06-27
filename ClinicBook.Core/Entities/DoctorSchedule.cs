namespace ClinicBook.Core.Entities
{
    public class DoctorSchedule
    {
        public Guid Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime Date { get; set; }

        public bool IsBooked { get; set; }

        public Guid DoctorId { get; set; }

        public Doctor Doctor { get; set; }
    }
}
