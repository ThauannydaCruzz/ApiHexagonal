using StudentManager.Entities;
using StudentManager.Interfaces.IRepositories;

namespace StudentManager.Services
{
    public class AlunoService
    {
        private readonly IAlunoRepository _repository;
        private readonly ICursoRepository _cursoRepository;

        public AlunoService(IAlunoRepository repository, ICursoRepository cursoRepository)
        {
            _repository = repository;
            _cursoRepository = cursoRepository;
        }

        public void Matricular(Aluno aluno)
        {
            if (string.IsNullOrWhiteSpace(aluno.FirstName))
                throw new Exception("FirstName é um requisito obrigatório!");

            if (aluno.FirstName.Length > 50)
                throw new Exception("FirstName deve ter no máximo 50 caracteres.");

            if (!aluno.Email.EndsWith("@faculdade.edu"))
                throw new Exception("Email deve ser obrigatoriamente @faculdade.edu.");

            var existente = _repository.GetByEmail(aluno.Email);

            if (existente != null)
                throw new Exception("E-mail já registrado.");

            if (string.IsNullOrWhiteSpace(aluno.CursoNome))
                throw new Exception("O aluno deve informar um curso.");

            var curso = _cursoRepository.GetByNome(aluno.CursoNome);

            if (curso == null)
                throw new Exception("Curso informado não existe.");

            _repository.Add(aluno);
        }

        public IEnumerable<Aluno> Listar()
        {
            return _repository.GetAll();
        }
    }
}