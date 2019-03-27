using ProjetoPaulo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaulo.Service.Interface
{
    public interface IBatataService
    {
        Task<Batata> IncluirBatata(Batata batata);
        Task<List<Batata>> BuscarBatata(string descricao);
        Task<Batata> AlterarBatata(Batata batata);
        Task RemoverBatata(Batata batata);
    }
}
