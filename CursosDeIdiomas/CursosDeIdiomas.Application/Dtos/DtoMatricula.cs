using System.Text.Json.Serialization;

namespace CursosDeIdiomas.Application.Dtos
{
    public class DtoMatricula
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public int TurmaId { get; set; }

    }
}
