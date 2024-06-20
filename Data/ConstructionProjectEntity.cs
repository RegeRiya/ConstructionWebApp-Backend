using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgresWebAPI.Data;

// Construction Project Table 
[Table("ConstructionProjects")]
public class ConstructionProjectEntity
{
    [Key, Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int projectId { get; set; }
    public string? projectName { get; set; }
    public string? description { get; set; }
    public string? startDate { get; set; }
    public string? endDate { get; set; }
}
