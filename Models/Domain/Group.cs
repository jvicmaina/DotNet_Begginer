namespace virtual_fitness_coach.Models.Domain
{
    public class Group{
        public Guid Id {get; set;}
        public string Name {get; set;}
        public ICollection<User>? Members {get; set;}
    }
}