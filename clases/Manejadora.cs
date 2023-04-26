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

        public static void CargarCuentasDefecto(DataGridView dgv)
        {
            cuentasBanco.Add(new Debito(1, "Dianita", 1673, "Debito", 1000, 5));
            cuentasBanco.Add(new Debito(2, "Beto", 4681, "Debito", 3000, 5));
            cuentasBanco.Add(new Debito(3, "Daniel", 4681, "Debito", 2000, 12));
            cuentasBanco.Add(new Debito(4, "Jimena", 1234, "Debito", 3000, 20));
            cuentasBanco.Add(new Debito(5, "David", 4629, "Debito", 4000, 3));

            cuentasBanco.Add(new Credito(6, "Nirvana", 7948, 0, "Credito", 1500, 1500, 10));
            cuentasBanco.Add(new Credito(7, "Jesús", 7826, 500, "Credito", 5000, 4500, 10));
            cuentasBanco.Add(new Credito(8, "Ignacio", 3569, 100, "Credito", 3000, 2900, 10));
            cuentasBanco.Add(new Credito(9, "Marcos", 8264, 0, "Credito", 800, 800, 10));
            cuentasBanco.Add(new Credito(10, "Angel", 1359, 0, "Credito", 10000, 10000, 10));

        }

        public static void RefrescarTabla(DataGridView dgv)
        {
            dgv.Rows.Clear();

            foreach (Cuenta cuenta in cuentasBanco)
            {
                if (cuenta.GetType() == typeof(Debito))
                {
                    Debito debito = (Debito)(cuenta);
                    dgv.Rows.Add(debito.NumeroDeCuenta, debito.Nombre, debito.Nip, debito.TipoDeCuenta, debito.Saldo, debito.NumerodeOperaciones, "N/A", "N/A", "N/A");
                }
                if (cuenta.GetType() == typeof(Credito))
                {
                    Credito credito = (Credito)(cuenta);
                    dgv.Rows.Add(credito.NumeroDeCuenta, credito.Nombre, credito.Nip, credito.TipoDeCuenta, credito.Saldo, "N/A", credito.LimiteDeCredito, credito.Disponible, credito.TasaIntereses);
                }

            }
        }

    }
}
