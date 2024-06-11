using System.ComponentModel.DataAnnotations;

namespace PostgresWebAPI.Models{
    
    public class ConstructionProject {
        
        [Key]
        public string Name{ get; set; }
    }
}