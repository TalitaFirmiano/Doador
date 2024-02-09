using Doador.Domain.Commands;
using Doador.Domain.Entities;
using Doador.Domain.Interfaces;

namespace Doador.Domain.Commands
{
    public class DoadorCommand
    {
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
