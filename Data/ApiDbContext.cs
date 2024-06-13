using Microsoft.EntityFrameworkCore;

//DbContext to run inital mirgrations and run Postgresql for both logincredentials and construction project tables
namespace PostgresWebAPI.Data {
    public class ApiDbContext : DbContext {
        public virtual DbSet<ConstructionProjectEntity> ConstructionProjects {get; set;}

        public virtual DbSet<LoginCredentialsEntity> LogInCredentials {get; set;}
        
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }
    }
}