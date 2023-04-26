using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectoBanco.clases;

namespace projectoBanco.clases
{
    internal class Manejadora
    {
        static List<Cuenta> cuentasBanco = new List<Cuenta>();

        public static List<Cuenta> CuentasBanco { get => cuentasBanco; set => cuentasBanco = value; }

        public static void CargarCuentasDefecto()
        {
            cuentasBanco.Add(new Debito(1, "Dianita", 1673, 1000, 5));
            cuentasBanco.Add(new Debito(2, "Beto", 4681, 0, 5));
            cuentasBanco.Add(new Debito(3, "Daniel", 4681, 2000, 12));
            cuentasBanco.Add(new Debito(4, "Jimena", 1234, 3000, 20));
            cuentasBanco.Add(new Debito(5, "David", 4629, 4000, 3));

            cuentasBanco.Add(new Credito(6, "Nirvana", 7948, 0, 1500, 1500, 10));
            cuentasBanco.Add(new Credito(7, "Jesús", 7826, 500, 5000, 4500, 10));
            cuentasBanco.Add(new Credito(8, "Ignacio", 3569, 100, 3000, 2900, 10));
            cuentasBanco.Add(new Credito(9, "Marcos", 8264, 0, 800, 800, 10));
            cuentasBanco.Add(new Credito(10, "Angel", 1359, 0, 10000, 10000, 10));
        }
    }
}
