using PostgresWebAPI.Data;
using PostgresWebAPI.Models;

namespace PostgresWebAPI.Services;

public class LogInCredentialsService {

    List<LogInCredentials> _credentials;

    private ApiDbContext _context;
    public LogInCredentialsService(ApiDbContext context)
    {
        _context = context;
    }

    public bool checkCredentials(LogInCredentials credentials) {
        // list of all credentails from postgresql
        List<LogInCredentials> logInCredentials = _context.LogInCredentials.Select(x => new LogInCredentials(x.userName, x.password)).ToList();

        //Check logIn credentials       
        foreach(var item in logInCredentials)
            if(item.userName == credentials.userName && item.password == credentials.password){
                // return true if credentials are valid
                return true;
            }           
        return false;
                

        }
}