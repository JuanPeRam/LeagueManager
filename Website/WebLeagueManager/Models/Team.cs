namespace WebLeagueManager.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Origin { get; set; }
        public DateTime CreationDate { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
