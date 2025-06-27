namespace ClinicBook.Core.Entities
{
    public class MedicalReport
    {
        public Guid Id { get; set; }

        public DateTime Time { get; set; }

        public string Diagnosis { get; set; }

        public string Notes { get; set; }

        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
    }
}
