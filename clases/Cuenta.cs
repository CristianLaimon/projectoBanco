using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace projectoBanco.clases
{
    internal class Cuenta
    {
        private int numeroDeCuenta;
        private string nombre;
        private int nip;
        private double saldo;

        public Cuenta()
        {
            numeroDeCuenta = 0;
            nombre = string.Empty;
            nip = 0;
            saldo = 0;
        }

        public Cuenta(int numeroDeCuenta, string nombre, int nip, double saldo)
        {
            this.numeroDeCuenta = numeroDeCuenta;
            this.nombre = nombre;
            this.nip = nip;
            this.saldo = saldo;
        }

        public int NumeroDeCuenta { get => numeroDeCuenta; set => numeroDeCuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Nip { get => nip; set => nip = value; }
        public double Saldo { get => saldo; set => saldo = value; }
    }
}
