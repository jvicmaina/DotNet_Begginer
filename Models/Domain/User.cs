using Microsoft.AspNetCore.Identity;
namespace virtual_fitness_coach.Models.Domain{

    public class User: IdentityUser{
        public Guid Id { get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string role {get; set;}
        public DateTime DateJoined {get; set;}
        public bool EmailVerified {get; set;} =false;
        public ICollection<Group>? Groups {get; set;}
        public ICollection<Contest>? Contests {get; set;}
    }
}