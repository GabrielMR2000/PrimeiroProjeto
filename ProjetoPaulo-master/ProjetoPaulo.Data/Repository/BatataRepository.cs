using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ProjetoPaulo.Data.Context;
using ProjetoPaulo.Data.Entity;
using ProjetoPaulo.Domain.Repository;
using DomainModel = ProjetoPaulo.Domain.Model;

namespace ProjetoPaulo.Data.Repository
{
    public class BatataRepository : RepositoryBase<DomainModel.Batata, Batata>, IBatataRepository
    {
        public BatataRepository(PauloContext context) : base(context)
        {
            
        }

        public async Task<List<DomainModel.Batata>> BuscarBatataComFiltro(string descricao)
        {
            var batatas = await _db.Batata.ProjectTo<DomainModel.Batata>(_mapper.ConfigurationProvider)
                .Where(e => e.Descricao.Contains(descricao))
                .ToListAsync();
            return batatas;
        }

        public DomainModel.Batata BuscarBatataProId(Guid id)
        {
            var batata = _db.Batata
                .ProjectTo<DomainModel.Batata>(_mapper.ConfigurationProvider)
                .Where(e => e.Id == id)
                .FirstOrDefault();
            return batata;
        }

        public async Task<List<DomainModel.Batata>> BuscarTodasBatata()
        {
            var batatas = await _db.Batata.ProjectTo<DomainModel.Batata>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return batatas;
        }

        public void SalvarBatata(DomainModel.Batata batataModel)
        {
            var batataEntity = _mapper.Map<Batata>(batataModel);
            _db.Add(batataEntity);
        }
    }
}
