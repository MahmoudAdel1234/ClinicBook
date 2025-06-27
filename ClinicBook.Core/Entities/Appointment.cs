namespace ClinicBook.Core.Entities
{
    public class Appointment
    {
        //hello world
        public Guid Id { get; set; }

        public AppointmentStatus Status { get; set; }

        public Guid PatientId { get; set; }

        public Patient Patient { get; set; }

        public Guid DoctorId { get; set; }

        public Doctor Doctor { get; set; }  


    }

    public enum AppointmentStatus
    {
        Pending = 0,
        Cancelled = 1,
        Completed = 2
    }
}
