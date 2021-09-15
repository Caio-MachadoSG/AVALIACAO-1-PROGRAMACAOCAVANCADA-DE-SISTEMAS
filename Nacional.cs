namespace AVALIA__O__1___PROGRAMA__O_AVAN_ADA_DE_SISTEMAS
{
    public class Nacional : Veiculo
    {
        public Nacional(string cor, string marca, string modelo, double valor, int ano) {
            this.cor = cor;
            this.marca = marca;
            this.modelo = modelo;
            definirValorVeiculo(valor);
            this.ano = ano;
        }

        public override void definirValorVeiculo(double custo_fixo) {
            Valor = (custo_fixo*1.5) + (0.2*custo_fixo) + (custo_fixo/10);
        }
    }
}