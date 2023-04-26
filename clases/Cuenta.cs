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
        private string tipoDeCuenta;
        private bool alreadyChecked;

        public Cuenta()
        {
            numeroDeCuenta = 0;
            nombre = string.Empty;
            nip = 0;
            saldo = 0;
            tipoDeCuenta = string.Empty;
        }

        public Cuenta(int numeroDeCuenta, string nombre, int nip, string tipoDeCuenta, double saldo) 
        {
            this.numeroDeCuenta = numeroDeCuenta;
            this.nombre = nombre;
            this.nip = nip;
            this.saldo = saldo;
            this.tipoDeCuenta = tipoDeCuenta;
        }

        public int NumeroDeCuenta { get => numeroDeCuenta; set => numeroDeCuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Nip { get => nip; set => nip = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string TipoDeCuenta { get => tipoDeCuenta; set => tipoDeCuenta = value; }
        public bool AlreadyChecked { get => alreadyChecked; set => alreadyChecked = value; }

        public virtual void Retirar(double retiro)
        {

        }

        public virtual void Abonar(double retiro)
        {
            
        }

        public virtual void CorteCaja(double generico)
        {
            
        }
    }
}
