using ProjetoPaulo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaulo.Domain.Repository
{
    public interface IQueijoRepository : IRepositoryBase<Queijo>
    {
        void SalvarQueijo(Queijo queijo);
        List<Queijo> BuscarQueijoComFiltro(Guid Key);
        List<Queijo> BuscarTodosQueijo();
    }
}
