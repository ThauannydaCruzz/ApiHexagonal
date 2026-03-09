using StudentManager.Entities;
using StudentManager.Interfaces.IRepositories;

namespace StudentManager.Services
{
    public class CursoService
    {
        private readonly ICursoRepository _repository;

        public CursoService(ICursoRepository repository)
        {
            _repository = repository;
        }

        public void CriarCurso(Curso curso)
        {
            if (string.IsNullOrWhiteSpace(curso.Nome))
                throw new Exception("Nome do curso é obrigatório.");

            if (curso.QuantidadeSemestres <= 0)
                throw new Exception("Quantidade de semestres deve ser maior que zero.");

            var existente = _repository.GetByNome(curso.Nome);

            if (existente != null)
                throw new Exception("Já existe um curso com este nome.");

            _repository.Add(curso);
        }

        public IEnumerable<Curso> Listar()
        {
            return _repository.GetAll();
        }
    }
}