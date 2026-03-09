using StudentManager.Entities;
using StudentManager.Interfaces.IRepositories;

namespace StudentManager.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private static List<Curso> _cursos = new();

        public void Add(Curso curso)
        {
            _cursos.Add(curso);
        }

        public IEnumerable<Curso> GetAll()
        {
            return _cursos;
        }

        public Curso GetById(Guid id)
        {
            return _cursos.FirstOrDefault(c => c.Id == id);
        }

        public Curso GetByNome(string nome)
        {
            return _cursos.FirstOrDefault(c => c.Nome == nome);
        }
    }
}