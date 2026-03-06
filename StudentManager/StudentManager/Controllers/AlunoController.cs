using Microsoft.AspNetCore.Mvc;
using StudentManager.Entities;
using StudentManager.Services;

namespace StudentManager.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class AlunoController : ControllerBase
        {
            private readonly AlunoService _service;

            public AlunoController(AlunoService service)
            {
                _service = service;
            }

            [HttpPost]
            public IActionResult Post([FromBody] Aluno aluno)
            {
                try
                {
                    _service.Matricular(aluno);
                    return Ok("Aluno matriculado!.");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [HttpGet]
            public IActionResult Get()
            {
                var alunos = _service.Listar();
                return Ok(alunos);
            }
        
    }
}
