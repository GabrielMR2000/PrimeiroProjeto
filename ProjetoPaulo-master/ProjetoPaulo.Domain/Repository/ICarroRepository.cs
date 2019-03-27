using ProjetoPaulo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPaulo.Domain.Repository
{
    public interface ICarroRepository :IRepositoryBase<Carro>
    {
        List<Carro> TodosOsCarros();
        List<Carro> BuscarCarrosComFiltro(Guid key);
        Carro IncluirCarro(Carro Carro);
    }
}
