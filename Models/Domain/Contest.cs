namespace virtual_fitness_coach.Models.Domain
{
    public class Contest{
        public Guid Id {get; set;}
        public string Title {get; set;}
        public string Instructions {get; set;}
        public ICollection<User> Participants {get; set;}
    }
}