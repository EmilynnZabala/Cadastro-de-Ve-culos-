using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCar
{
    public abstract class Veiculo
    {
        private int combustivel;
        private string cor;
        private string marca;
        private string chassi;
        private string placa;



        // Criando os contrutores sem valores
        public Veiculo()
        {

            this.placa = null;
            this.cor = null;
            this.marca = null;
            this.chassi = null;
            this.combustivel = 0;

        }


        // dandos valores aos construtores
        public Veiculo(string placa, string cor, string marca,
        string chassi, int combustivel)
        {

            this.placa = placa;
            this.cor = cor;
            this.marca = marca;
            this.chassi = chassi;
            this.combustivel = combustivel;

        }

        // Propriedades e tipos
        public string Placa
        {
            get { return placa; }
            set { placa = value; }

        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }

        public int Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }

        public abstract String ApresentarDados();
    }
}
