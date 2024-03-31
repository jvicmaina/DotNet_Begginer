namespace virtual_fitness_coach.Models.Domain
{
    public class OTP{
        public Guid Id {get; set;}
        public string Code {get; set;}
        public User SentTo {get; set;}
        public DateTime SentAt {get; set;}
        public double HoursBeforeExpiry {get; set;}
    }
}