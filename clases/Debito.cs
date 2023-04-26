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

        public Debito(int numeroDeCuenta, string nombre, int nip, string tipoDeCuenta, double saldo, int numeroDeOperaciones) : base(numeroDeCuenta, nombre, nip, tipoDeCuenta, saldo)
        {
            this.numeroDeOperaciones = numeroDeOperaciones;
        }

        public int NumerodeOperaciones { get => numeroDeOperaciones; set => numeroDeOperaciones = value; }

        public override void Retirar(double retiro)
        {
            if (Saldo - retiro >= 0)
            {
                Saldo -= retiro;
                numeroDeOperaciones++;
            }
            else 
            {
                if(Form1.AdvertenciaToggle == false)
                {
                    MessageBox.Show("No se puede retirar a " + Nombre + " debido a que tiene fondos insuficientes. Si desea quitar estas advertencias seleccione la casilla 'Desactivar advertencias'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        public override void Abonar(double retiro)
        {
            Saldo += retiro;
            numeroDeOperaciones++;
        }

        public override void CorteCaja(double numOperaciones)
        {
            if(numOperaciones > 10)
            {
                double  sobra = numOperaciones - 10;
                double comision = sobra * 1.50;
                Saldo -= comision;
            }
        }
    }
}
