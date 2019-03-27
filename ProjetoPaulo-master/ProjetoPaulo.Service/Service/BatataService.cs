using ProjetoPaulo.Domain.Model;
using ProjetoPaulo.Domain.Repository;
using ProjetoPaulo.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPaulo.Service.Service
{
    public class BatataService : IBatataService
    {
        private readonly IUnitOfWork _untiOfWork;

        public BatataService(IUnitOfWork untiOfWork)
        {
            _untiOfWork = untiOfWork;
        }

        public async Task<Batata> AlterarBatata(Batata batata)
        {
            Batata batataCadastrada = ValidaSeJaExiste(batata);
            //Existe Descricao
            ValidarDescricaoBatata(batata);

            batataCadastrada.Descricao = batata.Descricao;
            batataCadastrada.Cor = batata.Cor;

            _untiOfWork.BatataRepository.Atualizar(batataCadastrada);
            await _untiOfWork.CommitAsync();
            return batata;
        }

        public async Task<List<Batata>> BuscarBatata(string descricao)
        {
            List<Batata> batatas = new List<Batata>();

            if (string.IsNullOrEmpty(descricao))
                batatas = await _untiOfWork.BatataRepository.BuscarTodasBatata();
            else
                batatas = await _untiOfWork.BatataRepository.BuscarBatataComFiltro(descricao);

            return batatas;
        }

        public async Task<Batata> IncluirBatata(Batata batata)
        {
            ValidarDescricaoBatata(batata);

            batata.Id = Guid.NewGuid();

            await _untiOfWork.BatataRepository.SalvarAsync(batata);
            //_untiOfWork.BatataRepository.SalvarBatata(batata);
            await _untiOfWork.CommitAsync();
            return batata;
        }

        public async Task RemoverBatata(Batata batata)
        {
            var bat = ValidaSeJaExiste(batata);
            _untiOfWork.BatataRepository.Remover(e => e.Id == batata.Id);
            await  _untiOfWork.CommitAsync();
        }

        private void ValidarDescricaoBatata(Batata batata)
        {
            if (string.IsNullOrEmpty(batata.Descricao))
                throw new Exception("A batata precisa ter uma descricao");
        }
        private Batata ValidaSeJaExiste(Batata batata)
        {
            if (batata.Id == Guid.Empty) //não enviou o Id
                throw new Exception("O vacilão, manda o Id, babaca");
            Batata batataCadastrada = _untiOfWork.BatataRepository.BuscarBatataProId(batata.Id);
            if (batataCadastrada == null)//ainda não foi cadastrada ou não existe
                throw new Exception("O vacilão, manda o Id certo");
            return batataCadastrada;
        }

    }
}
