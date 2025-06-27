namespace ClinicBook.Core.Entities
{
    public class Prescription
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Dosage { get; set; }

        public int Duration { get; set; }

        public Guid MedicalReportId { get; set; }

        public MedicalReport MedicalReport { get; set; }
    }
}
