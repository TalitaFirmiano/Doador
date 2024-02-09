using Doador.Api.ViewModel;
using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IDoadorRepository
    {
        Task create(DoadorCommand command);
        Task<IEnumerable<DoadorViewModel>> GetAll();
        Task<DoadorViewModel> GetById(int doadorId);
    }
}
