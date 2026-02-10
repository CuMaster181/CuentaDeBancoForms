using System;
using System.Windows.Forms;

namespace CuentaDeBancoForms
{
    public partial class Form1 : Form
    {
        private Cuenta cuenta;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var titular = txtTitular.Text.Trim();
            var numero = txtNumero.Text.Trim();
            var saldoInicial = (double)nudSaldoInicial.Value;

            if (string.IsNullOrEmpty(titular))
            {
                MessageBox.Show("Introduce el titular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Introduce el número de cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cuenta = new Cuenta(titular, saldoInicial, numero);
            txtSalida.Text = $"Cuenta creada:\r\n{cuenta}\r\n";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (!VerificarCuenta()) return;

            var cantidad = (double)nudCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("Introduce una cantidad positiva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cuenta.Depositar(cantidad);
            txtSalida.AppendText($"Depositado {cantidad:F2}\r\nSaldo: {cuenta.Saldo:F2}\r\n");
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (!VerificarCuenta()) return;

            var cantidad = (double)nudCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("Introduce una cantidad positiva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantidad > cuenta.Saldo)
            {
                MessageBox.Show("Saldo insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cuenta.Retirar(cantidad);
            txtSalida.AppendText($"Retirado {cantidad:F2}\r\nSaldo: {cuenta.Saldo:F2}\r\n");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (!VerificarCuenta()) return;
            txtSalida.AppendText($"Estado actual:\r\n{cuenta}\r\n");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTitular.Clear();
            txtNumero.Clear();
            nudSaldoInicial.Value = 0;
            nudCantidad.Value = 0;
            txtSalida.Clear();
            cuenta = null;
        }

        private bool VerificarCuenta()
        {
            if (cuenta == null)
            {
                MessageBox.Show("Primero crea una cuenta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
