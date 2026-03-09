using StudentManager.Entities;

namespace StudentManager.Interfaces.IRepositories
{
    public interface ICursoRepository
    {
        void Add(Curso curso);

        IEnumerable<Curso> GetAll();

        Curso GetById(Guid id);

        Curso GetByNome(string nome);
    }
}