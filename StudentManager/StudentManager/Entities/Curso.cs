using System;

namespace StudentManager.Entities
{
    public class Curso
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Nome { get; set; }

        public int QuantidadeSemestres { get; set; }
    }
}