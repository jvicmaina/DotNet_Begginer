using Microsoft.EntityFrameworkCore;
using virtual_fitness_coach.Models.Domain;

namespace virtual_fitness_coach.Data
{
    public class VfcDbContext: DbContext{
        public VfcDbContext(DbContextOptions options): base(options){}
        public DbSet<User> Users {get; set;}
        public DbSet<Group> Groups {get; set;}
        public DbSet<Reward> Rewards {get; set;}
        public DbSet<Contest> Contests {get; set;}
        public DbSet<OTP> VerificationCodes {get; set;}
        public DbSet<CreditCard> CreditCards {get; set;}
    }
}