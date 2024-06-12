using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgresWebAPI.Data;

[Table("ConstructionProjects")]
public class ConstructionProjectEntity
{
    [Key, Required]
    public string projectName { get; set; }
}
