using Microsoft.EntityFrameworkCore;
using PostgresWebAPI.Models;

namespace PostgresWebAPI.Data {
    public class ApiDbContext : DbContext {
        public virtual DbSet<ConstructionProjectEntity> ConstructionProjects {get; set;}
        
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }
    }
}