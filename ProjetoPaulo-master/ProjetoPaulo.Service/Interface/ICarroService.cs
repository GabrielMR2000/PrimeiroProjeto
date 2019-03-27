using ProjetoPaulo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaulo.Service.Interface
{
    public interface ICarroService
    {
        Carro IncluirCarro(Carro Carro);
        List<Carro> TodosOsCarros();
        List<Carro> BuscarCarroId(Guid key);
        Task RemoverCarro(Guid key);
    }
}
