using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoBanco.clases
{
    internal class Debito : Cuenta
    {
        private int numeroDeOperaciones;

        public Debito() : base()
        {
            numeroDeOperaciones = 0;
        }

        public Debito(int numeroDeCuenta, string nombre, int nip, double saldo, int numeroDeOperaciones) : base(numeroDeCuenta, nombre, nip, saldo)
        {
            this.numeroDeOperaciones = numeroDeOperaciones;
        }

        public int NumerodeOperaciones { get => numeroDeOperaciones; set => numeroDeOperaciones = value; }
    }
}
