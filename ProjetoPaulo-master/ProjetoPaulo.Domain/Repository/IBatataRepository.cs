using ProjetoPaulo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaulo.Domain.Repository
{
    public interface IBatataRepository : IRepositoryBase<Batata>
    {
        void SalvarBatata(Batata batata);
        Task<List<Batata>> BuscarBatataComFiltro(string descricao);
        Task<List<Batata>> BuscarTodasBatata();
        Batata BuscarBatataProId(Guid id);
    }
}
