using PostgresWebAPI.Data;
using PostgresWebAPI.Models;
using Microsoft.EntityFrameworkCore;

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
            {
                //POST
                entry.projectId = project.projectId;
                entry.projectName = project.projectName;
                entry.description = project.description;
                entry.startDate = project.startDate;
                entry.endDate = project.endDate;
                _context.ConstructionProjects.Add(entry);
            }
            // Save changes
            _context.SaveChanges();
        }

        public void UpdateProject(ConstructionProject project) {

            _context.ConstructionProjects.Where(update => update.projectId == project.projectId)
            .ExecuteUpdate(
                setters => setters
                .SetProperty(p => p.projectName, project.projectName)
                .SetProperty(p => p.description, project.description)
                .SetProperty(p => p.startDate, project.startDate)
                .SetProperty(p => p.endDate, project.endDate)
            );
            _context.SaveChanges();
        }

        public void DeleteProject(int projectId) {
            _context.ConstructionProjects.Where(update => update.projectId == projectId).ExecuteDelete();
            _context.SaveChanges();
        }
    }
} 