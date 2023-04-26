using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoBanco.clases
{
    internal class Credito : Cuenta
    {
        private double limiteDeCredito;
        private double disponible;
        private float tasaIntereses;

        public Credito() : base()
        {
            limiteDeCredito = 0;
            disponible = 0;
            tasaIntereses = 0;
        }

        public Credito(int numeroDeCuenta, string nombre, int nip, double saldo, double limiteDeCredito, double disponible, float tasaIntereses) : base(numeroDeCuenta, nombre, nip,saldo)
        {
            this.limiteDeCredito = limiteDeCredito;
            this.disponible = disponible;
            this.tasaIntereses = tasaIntereses;
        }

        public double LimiteDeCredito { get => limiteDeCredito; set => limiteDeCredito = value; }
        public double Disponible { get => disponible; set => disponible = value; }
        public float TasaIntereses { get => tasaIntereses; set => tasaIntereses = value; }
    }
}
