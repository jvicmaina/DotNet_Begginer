namespace virtual_fitness_coach.Models.Domain
{
    public class Reward{
        public Guid Id {get; set;}
        public User Beneficiary {get; set;}
        public Contest Challange {get; set;}
        public int Points {get; set;}
    }
}