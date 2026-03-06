using StudentManager.Entities;
using StudentManager.Interfaces.IRepositories;

namespace StudentManager.Services
{
    public class AlunoService
    {

            private readonly IAlunoRepository _repository;

            public AlunoService(IAlunoRepository repository)
            {
                _repository = repository;
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
                    throw new Exception("E-mail já registrado");

                _repository.Add(aluno);
            }

            public IEnumerable<Aluno> Listar()
            {
                return _repository.GetAll();
            }
        

    }
}
