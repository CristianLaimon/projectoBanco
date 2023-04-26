using projectoBanco.clases;

namespace projectoBanco
{
    public partial class Form1 : Form
    {
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRetirar100_Click(object sender, EventArgs e)
        {
            Manejadora.CuentasBanco[index].Retirar(100);
            Manejadora.RefrescarTabla(dataGridView1);
        }

        private void buttonAbonar100_Click(object sender, EventArgs e)
        {
            Manejadora.CuentasBanco[index].Abonar(100);
            Manejadora.RefrescarTabla(dataGridView1);

        }

        private void buttonRetirarTodos_Click(object sender, EventArgs e)
        {

            foreach (Cuenta cuenta in Manejadora.CuentasBanco)
            {
                if (cuenta.GetType() == typeof(Debito))
                {
                    Debito debito = (Debito)cuenta;
                    debito.Retirar(100);
                }
                if (cuenta.GetType() == typeof(Credito))
                {
                    Credito credito = (Credito)cuenta;
                    credito.Retirar(100);
                }
            }

            Manejadora.RefrescarTabla(dataGridView1);

        }

        private void buttonCorteCaja_Click(object sender, EventArgs e)
        {
            foreach (Cuenta cuenta in Manejadora.CuentasBanco)
            {
                if(cuenta.Saldo != 0)
                {
                    if (cuenta.GetType() == typeof(Debito))
                    {
                        Debito debito = (Debito)cuenta;
                        debito.CorteCaja(debito.NumerodeOperaciones);
                    }
                    if (cuenta.GetType() == typeof(Credito))
                    {
                        Credito credito = (Credito)cuenta;
                        credito.CorteCaja(credito.Saldo);
                    }
                }
            }

            Manejadora.RefrescarTabla(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Manejadora.CargarCuentasDefecto(dataGridView1);
            Manejadora.RefrescarTabla(dataGridView1);

        }
    }
}