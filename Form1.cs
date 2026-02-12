using System;
using System.Windows.Forms;

namespace CuentaDeBancoForms
{
    public partial class Form1 : Form
    {
        private Cuenta? cuenta;
        private readonly ClientesRegistrados clientesRegistrados = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var titular = txtTitular.Text.Trim();
            var numero = txtNumero.Text.Trim();
            var saldoInicial = (double)nudSaldoInicial.Value;

            if (string.IsNullOrWhiteSpace(titular))
            {
                MessageBox.Show("Introduce el titular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitular.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Introduce el número de cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return;
            }

            if (clientesRegistrados.ObtenerPorNumero(numero) != null)
            {
                MessageBox.Show("Ya existe una cuenta con ese número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return;
            }

            var nueva = new Cuenta(titular, saldoInicial, numero);
            var añadido = clientesRegistrados.AgregarCliente(nueva);
            if (!añadido)
            {
                MessageBox.Show("No se pudo crear la cuenta (posible duplicado).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cuenta = nueva;
            txtSalida.Clear();
            txtSalida.AppendText($"Cuenta creada:\r\n{cuenta}\r\n");
            txtTitular.SelectAll();
            txtTitular.Focus();
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
            nudCantidad.Value = 0;
            nudSaldoInicial.Value = 0;
            txtSalida.Clear();
            cuenta = null;
            txtTitular.Focus();
        }

        private bool VerificarCuenta()
        {
            if (cuenta == null)
            {
                MessageBox.Show("Primero crea una cuenta o selecciona una desde la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        // Nuevo: carga los clientes registrados en la lista
        private void btnCargarClientes_Click(object sender, EventArgs e)
        {
            lstClientes.Items.Clear();
            var lista = clientesRegistrados.ObtenerClientes();
            foreach (var c in lista)
            {
                lstClientes.Items.Add(c);
            }

            if (lstClientes.Items.Count == 0)
            {
                txtSalida.AppendText("No hay clientes registrados.\r\n");
            }
            else
            {
                txtSalida.AppendText($"Cargados {lstClientes.Items.Count} cliente(s).\r\n");
            }
        }

        // Nuevo: selecciona la cuenta marcada en la lista como la cuenta activa
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem is Cuenta seleccion)
            {
                cuenta = seleccion;
                txtSalida.AppendText($"Cuenta seleccionada:\r\n{cuenta}\r\n");
            }
            else
            {
                MessageBox.Show("Selecciona una cuenta de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nuevo: doble clic en la lista selecciona la cuenta rápidamente
        private void lstClientes_DoubleClick(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem is Cuenta seleccion)
            {
                cuenta = seleccion;
                txtSalida.AppendText($"Cuenta seleccionada:\r\n{cuenta}\r\n");
            }
        }
    }
}
