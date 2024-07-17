namespace FaltaUno.Models.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public Matches Match { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
