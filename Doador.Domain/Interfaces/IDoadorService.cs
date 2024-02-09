using Doador.Api.ViewModel;
using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IDoadorService
    {
        Task<DoadorViewModel> GetById(int doadorId);
        Task create ( DoadorCommand command );
        Task<IEnumerable<DoadorViewModel>> GetAll();
        void Update(int doadorId, string nomeCompleto);
    }
  
}
