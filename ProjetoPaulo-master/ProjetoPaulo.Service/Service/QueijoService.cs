using ProjetoPaulo.Domain.Model;
using ProjetoPaulo.Domain.Repository;
using ProjetoPaulo.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaulo.Service.Service
{
    public class QueijoService : IQueijoService
    {
        public readonly IUnitOfWork _unitOfWork;

        public QueijoService(IUnitOfWork untiOfWork)
        {
            _unitOfWork = untiOfWork;
        }

        public List<Queijo> BuscarQueijoPorFiltro(Guid key)
        {
            var Buscar = _unitOfWork.QueijoRepository.BuscarQueijoComFiltro(key);
            return Buscar;
        }
        
        public List<Queijo> BuscarTodosOsQueijos()
        {
            var Todas = _unitOfWork.QueijoRepository.BuscarTodosQueijo();
            return Todas;
        }

        public Queijo Incluirqueijo(Queijo queijo)
        {
            queijo.Id = new Guid();
            _unitOfWork.QueijoRepository.SalvarQueijo(queijo);
            _unitOfWork.Commit();
            return queijo;
        }

        public async Task RemoverQueijo(Guid Key)
        {
            _unitOfWork.QueijoRepository.Remover(e => e.Id == Key);
            await _unitOfWork.CommitAsync();
        }
    }
}
