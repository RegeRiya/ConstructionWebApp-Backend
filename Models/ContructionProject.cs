using System.ComponentModel.DataAnnotations;

namespace PostgresWebAPI.Models{
    
    public class ConstructionProject(int projectId, string projectName, string description, string startDate, string endDate)
    {

        public int projectId { get; set; } = projectId;
        public string projectName { get; set; } = projectName;

        public string description { get; set; } = description;

        public string startDate { get; set; } = startDate;

        public string endDate { get; set; } = endDate;
    }
}