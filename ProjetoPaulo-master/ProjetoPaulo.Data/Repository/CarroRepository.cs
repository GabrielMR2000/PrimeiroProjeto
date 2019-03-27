using ProjetoPaulo.Data.Context;
using ProjetoPaulo.Domain.Model;
using ProjetoPaulo.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using DomainModel = ProjetoPaulo.Domain.Model;

namespace ProjetoPaulo.Data.Repository
{
    public class CarroRepository : RepositoryBase<DomainModel.Carro, Carro>, ICarroRepository
    {
        public CarroRepository(PauloContext context) : base(context)
        {
            
        }

        public List<Carro> BuscarCarrosComFiltro(Guid key)
        {
            throw new NotImplementedException();
        }

        public Carro IncluirCarro(Carro Carro)
        {
            throw new NotImplementedException();
        }

        public List<Carro> TodosOsCarros()
        {
            //var All = _db.Carros.
            return null;
        }
    }
}
