using ApiFuncionarios.Enums;

namespace ApiFuncionarios.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public SetorEnum Setor { get; set; }
        public TurnoEnum Turno { get; set; }
    }
}
