using DevFreelaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreelaAPI.Controllers
{
    [Route("api/projects")]
    public class ProjectController : ControllerBase
    {
        private readonly OpeningTimeOption _option;
        public ProjectController(IOptions<OpeningTimeOption> option)
        {
            _option = option.Value;
        }
        //api/projects?query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {            
            return Ok();
        }

        //api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //return NotFound();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
                return BadRequest();
            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        //api/projects/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
                return BadRequest();
            return NoContent();
        }

        //api/projects/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //NotFound();
            return NoContent();
        }

        //api/projects/1/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        //api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        //api/projects/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}
