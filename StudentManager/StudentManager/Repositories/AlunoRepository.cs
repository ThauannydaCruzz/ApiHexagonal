using StudentManager.Entities;
using StudentManager.Interfaces.IRepositories;

namespace StudentManager.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private static List<Aluno> _alunos = new();

        public void Add(Aluno aluno)
        {
            _alunos.Add(aluno);
        }

        public Aluno GetByEmail(string email)
        {
            return _alunos.FirstOrDefault(a => a.Email == email);
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _alunos;
        }
    }
}