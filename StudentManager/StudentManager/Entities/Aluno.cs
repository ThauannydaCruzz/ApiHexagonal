namespace StudentManager.Entities
{
    public class Aluno
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string Email { get; set; }
    }
}