using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace virtual_fitness_coach.Data
{
    public class AppDbContext: IdentityDbContext<IdentityUser>{
        
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){

        }
       
    }
}