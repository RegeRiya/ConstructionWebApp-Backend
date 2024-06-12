using System.Collections.Generic;
using PostgresWebAPI.Data;
using PostgresWebAPI.Models;
using PostgresWebAPI.Data;
namespace PostgresWebAPI.Services {
    
    public class ConstructionService {
        
        List<ConstructionProject> _projects;
        private ApiDbContext _context;
        public ConstructionService (ApiDbContext context)
        {
            _projects = new List<ConstructionProject>();
            _context = context;
        }

        public List<ConstructionProject> GetProjects() {
            return _projects;
        }
        
        //Post call
        public void AddProject(ConstructionProject project) {
            ConstructionProjectEntity entry = new ConstructionProjectEntity();
            //if(project.projectName > 0)
            {
                //PUT
                
            }
            //else
            {
                //POST
                entry.projectName = project.projectName;
                
                _context.ConstructionProjects.Add(entry);
            }
                _context.SaveChanges();

        }
    }
} 