using Microsoft.AspNetCore.Mvc;
using PostgresWebAPI.Services;
using PostgresWebAPI.Models;
using PostgresWebAPI.Data;

namespace PostgresWebAPI.Controllers{
    
    [ApiController]
    [Route("api/[controller]")]
    public class ConstructionProjectController : ControllerBase
    {
        private ApiDbContext _context;
        ConstructionService _constructionService;
        
        public ConstructionProjectController (ApiDbContext _context)
        {
            _constructionService = new ConstructionService(_context);
        }

        [HttpGet]
        public ActionResult Get ()
        {
            List<ConstructionProject> projectsList = this._constructionService.GetProjects();
            return Ok(projectsList);
        }

        [HttpPost]
        public ActionResult Post ([FromBody] ConstructionProject project)
        {
            this._constructionService.AddProject(project);
            return Ok();
        }
            
        [HttpPut]
        public ActionResult EditProject ([FromBody] ConstructionProject project)
        {
            this._constructionService.UpdateProject(project);
            return Ok();
        }
   
        [HttpDelete]
        public ActionResult Delete ([FromBody] int projectId)
        {
            this._constructionService.DeleteProject(projectId);
            return Ok();
        }
    }
 
 }