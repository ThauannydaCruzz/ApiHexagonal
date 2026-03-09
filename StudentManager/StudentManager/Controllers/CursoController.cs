using Microsoft.AspNetCore.Mvc;
using StudentManager.Entities;
using StudentManager.Services;
using System;

namespace StudentManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly CursoService _service;

        public CursoController(CursoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Curso curso)
        {
            try
            {
                _service.CriarCurso(curso);
                return Ok("Curso criado com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.Listar());
        }
    }
}