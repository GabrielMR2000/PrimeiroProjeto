using ProjetoPaulo.Domain.Model;
using ProjetoPaulo.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaulo.Service.Interface
{
    public interface IQueijoService 
    {
        List<Queijo> BuscarQueijoPorFiltro(Guid Key);
        List<Queijo> BuscarTodosOsQueijos();
        Queijo Incluirqueijo(Queijo queijo);
        Task RemoverQueijo(Guid key);
    }
}
