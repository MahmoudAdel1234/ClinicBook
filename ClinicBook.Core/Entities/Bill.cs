namespace ClinicBook.Core.Entities
{
    public class Bill
    {
        public Guid Id { get; set; }

        public int Amount { get; set; }

        public DateTime CreatedAt { get; set; }

        public BillStatus Status { get; set; }

        public Guid AppointmentId { get; set; }

        public Appointment Appointment { get; set; }

    }

    public enum BillStatus
    {
        Paid,
        Unpaid,
    }
}
