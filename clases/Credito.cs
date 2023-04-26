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

        public Credito(int numeroDeCuenta, string nombre, int nip, double saldo, string tipoDeCuenta, double limiteDeCredito, double disponible, float tasaIntereses) : base(numeroDeCuenta, nombre, nip, tipoDeCuenta, saldo)
        {
            this.limiteDeCredito = limiteDeCredito;
            this.disponible = disponible;
            this.tasaIntereses = tasaIntereses;
        }

        public double LimiteDeCredito { get => limiteDeCredito; set => limiteDeCredito = value; }
        public double Disponible { get => disponible; set => disponible = value; }
        public float TasaIntereses { get => tasaIntereses; set => tasaIntereses = value; }

        public override void Retirar(double retiro)
        {
            if(disponible - retiro >= 0)
            {
                disponible -= retiro;
                Saldo += retiro;
            }

        }

        public override void Abonar(double abono)
        {
            if(Saldo - abono >= 0)
            {
                Saldo -= abono;
                disponible += abono;
            }

        }

        public override void CorteCaja(double saldoActual)
        {
            double intereses = saldoActual * 0.10;
            Saldo += intereses;
        }
    }
}
