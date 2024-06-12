using Microsoft.AspNetCore.Mvc;
using PostgresWebAPI.Services;
using PostgresWebAPI.Models;

 namespace PostgresWebAPI.Controllers{
    
    [ApiController]
    [Route("api/[controller]")]
    public class ConstructionProjectController : ControllerBase 
    {
        ConstructionService _constructionService;
        
         public ConstructionProjectController ()
        {
            _constructionService = new ConstructionService();
        }

        [HttpGet]
        public ActionResult Get ()
        {
            return Ok("hello world!");
        }

        [HttpPost]
        public ActionResult Post (ConstructionProject project) 
        {
            this._constructionService.AddProject(project);
            return Ok("posted!");
        }
    }
 
 }