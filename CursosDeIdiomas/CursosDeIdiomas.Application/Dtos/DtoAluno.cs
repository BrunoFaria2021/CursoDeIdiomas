namespace CursosDeIdiomas.Application.Dtos
{
    public class DtoAluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public int TurmaId { get; set; }
    }
}
