using ProjetoPaulo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPaulo.Data.Entity
{
    public class Batata
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public Cor Cor { get; set; }
        public Guid TipoBatataId { get; set; }

        public TipoBatata TipoBatata { get; set; }
    }
}
