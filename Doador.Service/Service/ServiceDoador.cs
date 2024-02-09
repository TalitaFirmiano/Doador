using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
namespace Doador.Service.Service;

using Doador.Api.ViewModel;
using Doador.Domain.Entities;
using Repository.Repositorys;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ServiceDoador : IDoadorService
{
    private readonly IDoadorRepository _doadorRepository;
    public ServiceDoador(IDoadorRepository doadorRepository)
    {
        _doadorRepository = doadorRepository;
    }

    public async Task create(DoadorCommand command)
    {
        await _doadorRepository.create(command);
 
    }

    public Task<IEnumerable<DoadorViewModel>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<DoadorCommand> GetById(int doadorId)
    {
        throw new NotImplementedException();
    }
    public async Task Update(int doadorId, string nomeCompleto)
    {
        throw new NotImplementedException();
    }


    Task<DoadorViewModel> IDoadorService.GetById(int doadorId)
    {
        throw new NotImplementedException();
    }

    void IDoadorService.Update(int doadorId, string nomeCompleto)
    {
        throw new NotImplementedException();
    }
}
