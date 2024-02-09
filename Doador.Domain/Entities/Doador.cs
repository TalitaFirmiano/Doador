using Doador.Domain.Commands;
using Doador.Domain.Interfaces;

namespace Doador.Domain.Entities;
public class Doador
{
    public string NomeCompleto { get; set; }
    public string Idade { get; set; }
    public string Estado { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

}