using System.ComponentModel.DataAnnotations;

namespace PostgresWebAPI.Models{
    
    public class ConstructionProject(string projectName)
    {

        public string projectName { get; set; } = projectName;
    }
}