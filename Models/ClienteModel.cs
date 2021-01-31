using System;

namespace TesteStand.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        public string Razao_social { get; set; }

        public string Cnpj { get; set; }

        public DateTime Data_fundacao { get; set; }

        public double Capital { get; set; }

        public bool Quarentena { get; set; }

        public bool Status_cliente { get; set; }

        public char Classificacao { get; set; }
    }
}
