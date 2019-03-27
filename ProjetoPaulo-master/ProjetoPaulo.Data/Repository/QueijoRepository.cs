using AutoMapper.QueryableExtensions;
using ProjetoPaulo.Data.Context;
using ProjetoPaulo.Data.Entity;
using ProjetoPaulo.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DomainModel = ProjetoPaulo.Domain.Model;


namespace ProjetoPaulo.Data.Repository
{
    public class QueijoRepository : RepositoryBase<DomainModel.Queijo, Queijo>, IQueijoRepository
    {
        public QueijoRepository(PauloContext context) : base(context)
        {

        }

        public List<DomainModel.Queijo> BuscarQueijoComFiltro(Guid Key)
        {
            var Buscar = _db.Queijos.ProjectTo<DomainModel.Queijo>(_mapper.ConfigurationProvider)
                .Where(Q => Q.Id.Equals(Key))
                .ToList();
            return Buscar;
        }

        public List<DomainModel.Queijo> BuscarTodosQueijo()
        {
            var All = _db.Queijos.ProjectTo<DomainModel.Queijo>(_mapper.ConfigurationProvider)
           .ToList();
            return All;
        }
        
        public void SalvarQueijo(DomainModel.Queijo queijo)
        {
          var Salvar = _mapper.Map<Queijo>(queijo);
            _db.Add(Salvar);
        }
    }   
}
