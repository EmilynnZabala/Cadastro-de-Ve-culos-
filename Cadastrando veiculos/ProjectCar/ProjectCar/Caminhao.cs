using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCar
{
     public class Caminhao : Veiculo
    {
        private string porte;
        private string cabine;
        private string tipo_carga;

        public Caminhao()
        {
            cabine = null;
            tipo_carga = null;
            porte = null;
        }

        // Atributos herdados e criação de construtores com os defidos valores
        public Caminhao(string marca, string placa, string cor, string tipo_carga,
        int combustivel, string cabine, string chassi, string porte)
        {
            this.Marca = marca;
            this.Placa = placa;
            this.Cor = cor;
            this.Tipo_carga = tipo_carga;
            this.Combustivel = combustivel;
            this.Cabine = cabine;
            this.Chassi = chassi;
            this.Porte = porte;

        }

        public string Cabine
        {
            get { return cabine; }
            set { cabine = value; }
        }

        public string Tipo_carga
        {
            get { return tipo_carga; }
            set { tipo_carga = value; }
        }

        public string Porte
        {
            get { return porte; }
            set { porte = value; }
        }

        // valores dos atributos concatenados no onjeto 'result'
        public override string ApresentarDados()
        {
            string result = string.Empty;
            result = String.Concat("Marca: ", this.Marca, "\n", "Placa: ", this.Placa, "\n", "Cor: ", this.Cor, "\n", "Combústivel: ", this.Combustivel, "\n",
                                    "Cabine: ", this.Cabine, "\n", "Tipo de carga: ", this.Tipo_carga, "\n",
                                     "Chassi: ", this.Chassi, "\n", "Número de portas: ", this.Porte, "\n");
            return result;

        }


    }
}
