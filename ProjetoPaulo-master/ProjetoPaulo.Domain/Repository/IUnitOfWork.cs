using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaulo.Domain.Repository
{
    public interface IUnitOfWork
    {
        IExemploRepository ExemploRepository { get; }
        IBatataRepository BatataRepository { get; }
        IQueijoRepository QueijoRepository { get; }
        ICarroRepository CarroRepository { get; }
        int Commit();
        Task<int> CommitAsync();
    }
}
