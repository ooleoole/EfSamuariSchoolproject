namespace EfSamuariDomain.Entities
{
    public class Quote
    {
        public int Id { get; set; }
        public string SamuraiQuote { get; set; }
        public QuoteType Type { get; set; }
        public Samurai Samurai { get; set; }
    }

    public enum QuoteType
    {
        Good,
        Bad,
        Normal,
    }

    
}
