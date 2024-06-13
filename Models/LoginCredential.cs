using System.ComponentModel.DataAnnotations;

namespace PostgresWebAPI.Models{
    
    public class LogInCredentials(string userName, string password )
    {

        public string userName { get;  } = userName;

        public string password { get;  } = password;
    }

}