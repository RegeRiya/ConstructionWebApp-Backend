using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgresWebAPI.Data;

// Login Credentials Table
[Table("LoginCredentials")]
public class LoginCredentialsEntity
{
    [Key, Required]
    public string userName { get; set; }
    public string? password { get; set;  }
}