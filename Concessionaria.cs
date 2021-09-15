using System;
using System.Collections.Generic;

namespace AVALIA__O__1___PROGRAMA__O_AVAN_ADA_DE_SISTEMAS
{
    public class Concessionaria
    {
        private string localizacao;
        private string gerente_principal;
        private int ano_fundacao;
        private List<Veiculo> carros_disponiveis = new List<Veiculo>();

        public Concessionaria(string localizacao, string gerente_principal, int ano_fundacao) {
            this.localizacao = localizacao;
            this.gerente_principal = gerente_principal;
            this.ano_fundacao = ano_fundacao;
        }

        public void adicionarCarro(Veiculo c) {
            carros_disponiveis.Add(c);
        }

        public double calcularPortifolio() {
            double total = 0;
            foreach (Veiculo v in carros_disponiveis) {
                total += v.Valor;
            }
            return total;
        }
    }
}