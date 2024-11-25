using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Edital
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public List<string> Requisitos { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public DateTime DataFechamento { get; private set; }
        public StatusEdital Status { get; set; } = StatusEdital.Aberto;

        public Edital(
            string titulo,
            string descricao,
            List<string> requisitos,
            DateTime dataAbertura,
            DateTime dataFechamento
        )
        {
            Titulo = titulo;
            Descricao = descricao;
            Requisitos = requisitos;
            DataAbertura = dataAbertura;
            DataFechamento = dataFechamento;
        }

        public void Fechar()
        {
            if (Status != StatusEdital.Aberto)
                throw new InvalidOperationException("O edital deve estar aberto para ser fechado.");
            Status = StatusEdital.Fechado;
        }
    }
}
