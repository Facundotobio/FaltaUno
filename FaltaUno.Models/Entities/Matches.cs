namespace FaltaUno.Models.Entities
{
    public class Matches
    {
        public int Id { get; set; }
        public int MissingPlayers { get; set; }
        public string Description { get; set; }
        public DateTime DayAndhours { get; set; }
        public string Direction { get; set; }
        public int Status { get; set; } //definir un enum p los diferentes estados del partido
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Relación con Request (opcional, dependiendo de cómo quieras manejar las relaciones)
        public ICollection<Request> Requests { get; set; }
    }
}
