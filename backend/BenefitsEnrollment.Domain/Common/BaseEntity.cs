namespace BenefitsEnrollment.Domain
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDateUtc { get; set; }

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime ModifiedDateUtc { get; set; }

        public string? ModifiedBy { get; set; }

        public bool IsDeleted {  get; set; }
    }
}
