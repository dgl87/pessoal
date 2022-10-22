using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        #region GET
        [HttpGet]
        //usando queryString, exemplo: api/projects?query=net core
        public IActionResult Get(string query)
        {
            return Ok();
        }
        //usando parâmetro de URL, exemplo: api/projects/23
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //NotFound
            return Ok();
        }
        #endregion

        #region POST
        [HttpPost]
        public IActionResult Post(CreateProjectModel createProject)
        {
            if (createProject.Title.Length < 10)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetById), new { Id = createProject.Id }, createProject);
        }


        #endregion
    }
}
