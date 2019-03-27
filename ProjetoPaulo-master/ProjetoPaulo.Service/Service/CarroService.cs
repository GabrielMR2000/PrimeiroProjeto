using ProjetoPaulo.Domain.Model;
using ProjetoPaulo.Domain.Repository;
using ProjetoPaulo.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaulo.Service.Service
{
    public class CarroService : ICarroService
    {
        private readonly IUnitOfWork _untiOfWork;

        public CarroService(IUnitOfWork untiOfWork)
        {
            _untiOfWork = untiOfWork;
        }
        
        public List<Carro> BuscarCarroId(Guid key)
        {
            var Buscar = _untiOfWork.CarroRepository.BuscarCarrosComFiltro(key);
            return Buscar;
        }

        public Carro IncluirCarro(Carro Carro)
        {
            var Criar = _untiOfWork.CarroRepository.IncluirCarro(Carro);
            return Criar;
        }
        
        public async Task  RemoverCarro(Guid key)
        {
            _untiOfWork.CarroRepository.Remover(e => e.Id.Equals(key));
            await _untiOfWork.CommitAsync();
        }

        public List<Carro> TodosOsCarros()
        {
            var All = _untiOfWork.CarroRepository.TodosOsCarros();
            return All;
        }
    }
}
