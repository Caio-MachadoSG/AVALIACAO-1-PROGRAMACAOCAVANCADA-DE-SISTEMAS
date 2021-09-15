namespace AVALIA__O__1___PROGRAMA__O_AVAN_ADA_DE_SISTEMAS
{
    public class Veiculo
    {
        protected string cor;
        public string Cor {
            set {
                this.cor = value;
            }
        }

        protected string marca;
        public string Marca {
            set {
                this.marca = value;
            }
        }

        protected string modelo;
        public string Modelo {
            get {
                return this.modelo;
            }
            set {
                this.modelo = value;
            }
        }

        protected double valor;
        public double Valor {
            get {
                return this.valor;
            }
            set {
                this.valor = value;
            }
        }

        protected int ano;
        public int Ano {
            set {
                this.ano = value;
            }
        }

        public virtual void definirValorVeiculo(double custo_fixo) {
            //
        }
    }
}