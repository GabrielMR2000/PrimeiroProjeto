using ProjetoPaulo.Data.Context;
using ProjetoPaulo.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaulo.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PauloContext _context;

        private IExemploRepository _exemploRepository;
        private IBatataRepository _batatRepository;
        private IQueijoRepository _QueijoRepository;
        private ICarroRepository _CarroRepository;

        public UnitOfWork(PauloContext context)
        {
            _context = context;
        }

        public IExemploRepository ExemploRepository
        {
            get
            {
                return _exemploRepository ?? (_exemploRepository = new ExemploRepository(_context));
            }
        }

        public IBatataRepository BatataRepository
        {
            get
            {
                return _batatRepository ?? (_batatRepository = new BatataRepository(_context));
            }
        }
        public IQueijoRepository QueijoRepository
        {
            get
            {
                return _QueijoRepository ?? (_QueijoRepository = new QueijoRepository(_context));
            }
        }

        public ICarroRepository CarroRepository
        {
            get
            {
                return _CarroRepository ?? (_CarroRepository = new CarroRepository(_context));
            }
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
