using StudentManager.Entities;

namespace StudentManager.Interfaces.IRepositories
{
    public interface IAlunoRepository
    {
       
         void Add(Aluno aluno);
         Aluno GetByEmail(string email);
         IEnumerable<Aluno> GetAll();
        
    }
}
