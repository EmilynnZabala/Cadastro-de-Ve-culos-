using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCar
{
    public class Carro : Veiculo
    {
        private string capacid_porta_mala;
        private int num_portas;
        private string tipo_carroceria;

        public Carro()
        {
            capacid_porta_mala = null;
            num_portas = 0;
            tipo_carroceria = null;

        }

        public Carro(string marca, string placa, string cor, string tipo_carroceria,
        int combustivel, string capacid_porta_mala, int num_portas, string chassi)

        {
            this.Marca = marca; //
            this.Placa = placa; //
            this.Cor = cor; //
            this.Tipo_carroceria = tipo_carroceria; //
            this.Combustivel = combustivel; //
            this.Capacid_porta_mala = capacid_porta_mala; //
            this.Num_portas = num_portas;
            this.Chassi = chassi;

        }

        public string Capacid_porta_mala
        {
            get { return capacid_porta_mala; }
            set { capacid_porta_mala = value; }
        }

        public int Num_portas
        {
            get { return num_portas; }
            set { num_portas = value; }
        }

        public string Tipo_carroceria
        {
            get { return tipo_carroceria; }
            set { tipo_carroceria = value; }
        }

        // valores dos atributos concatenados no onjeto 'result'

        public override string ApresentarDados()
        {
            string result = string.Empty;
            result = String.Concat("Marca: ", this.Marca, "\n", "Placa: ", this.Placa, "\n", "Cor: ", this.Cor, "\n", "Combústivel: ", this.Combustivel, "\n",
                                    "Tipo de carroceria: ", this.Tipo_carroceria, "\n", "Capacidade do porta malas: ", this.Capacid_porta_mala, "\n",
                                     "Chassi: ", this.Chassi, "\n", "Número de portas: ", this.Num_portas, "\n");
            return result;

        }
    }
}
