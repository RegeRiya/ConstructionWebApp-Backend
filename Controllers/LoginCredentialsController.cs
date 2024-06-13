using Microsoft.AspNetCore.Mvc;
using PostgresWebAPI.Services;
using PostgresWebAPI.Models;
using PostgresWebAPI.Data;

namespace PostgresWebAPI.Controllers{
    
    [ApiController]
    [Route("api/[controller]")]
    public class LogInCredentialsController : ControllerBase 
    {
        private ApiDbContext _context;
        LogInCredentialsService _logInCredentialsService;
        
         public LogInCredentialsController (ApiDbContext _context)
        {
            _logInCredentialsService = new LogInCredentialsService(_context);
        }



        [HttpPost]
        public ActionResult Post ([FromBody] LogInCredentials credential)
        {
            return Ok(_logInCredentialsService.checkCredentials(credential));
        }
    }
 
 }