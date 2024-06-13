using PostgresWebAPI.Data;
using PostgresWebAPI.Models;
using PostgresWebAPI.Data;
using System.Linq;

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
            return _context.ConstructionProjects.Select(x => new ConstructionProject(x.projectId, x.projectName, x.description, x.startDate, x.endDate)).ToList();
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
                entry.projectId = project.projectId;
                entry.projectName = project.projectName;
                entry.description = project.description;
                entry.startDate = project.startDate;
                entry.endDate = project.endDate;
                
                _context.ConstructionProjects.Add(entry);
            }
                _context.SaveChanges();

        }
    }
} 