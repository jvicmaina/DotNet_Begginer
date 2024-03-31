namespace virtual_fitness_coach.Models.Domain{
    public class CreditCard{
        public Guid Id {get; set;}
        public string CardHolderName { get; set; }
        public string CardExpiryDate { get; set;}
        public string CardNumber { get; set; }
        public string CardTypeCode { get; set;}
        public User CardHolder { get; set; }

    }
}