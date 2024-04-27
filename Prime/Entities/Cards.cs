namespace Prime.Entities
{
    public class Cards : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Number { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int CVV { get; set; }
        public string? Key { get; set; }
        public string? Bank { get; set; }
        public string? Tagline { get; set; }
        public string? Type { get; set; }
        public string? Notes { get; set; }
    }
}
