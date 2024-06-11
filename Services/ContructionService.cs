using System.Collections.Generic;
using PostgresWebAPI.Models;
namespace PostgresWebAPI.Services {
    
    public class ConstructionService {
        
        List<ConstructionProject> _projects;
        public ConstructionService ()
        {
            _projects = new List<ConstructionProject>();
        }

        public List<ConstructionProject> GetProjects() {
            return _projects;
        }
        
        public void AddProject(ConstructionProject project) {
            _projects.Add(project);
        }
    }
} 