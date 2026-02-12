namespace CuentaDeBancoForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblSaldoInicial;
        private System.Windows.Forms.NumericUpDown nudSaldoInicial;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.ToolTip toolTip1;

        // Nuevos controles para la lista de clientes
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnCargarClientes;
        private System.Windows.Forms.Button btnSeleccionarCliente;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitular = new System.Windows.Forms.Label();
            txtTitular = new System.Windows.Forms.TextBox();
            lblNumero = new System.Windows.Forms.Label();
            txtNumero = new System.Windows.Forms.TextBox();
            lblSaldoInicial = new System.Windows.Forms.Label();
            nudSaldoInicial = new System.Windows.Forms.NumericUpDown();
            btnCrear = new System.Windows.Forms.Button();
            gbOperaciones = new System.Windows.Forms.GroupBox();
            nudCantidad = new System.Windows.Forms.NumericUpDown();
            btnDepositar = new System.Windows.Forms.Button();
            btnRetirar = new System.Windows.Forms.Button();
            btnMostrar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            txtSalida = new System.Windows.Forms.TextBox();
            toolTip1 = new System.Windows.Forms.ToolTip();

            // Inicialización nuevos controles
            lstClientes = new System.Windows.Forms.ListBox();
            btnCargarClientes = new System.Windows.Forms.Button();
            btnSeleccionarCliente = new System.Windows.Forms.Button();

            gbOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSaldoInicial).BeginInit();
            SuspendLayout();
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new System.Drawing.Point(16, 16);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new System.Drawing.Size(51, 20);
            lblTitular.TabIndex = 0;
            lblTitular.Text = "Titular";
            // 
            // txtTitular
            // 
            txtTitular.Location = new System.Drawing.Point(16, 34);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new System.Drawing.Size(260, 27);
            txtTitular.TabIndex = 1;
            toolTip1.SetToolTip(txtTitular, "Nombre completo del titular de la cuenta");
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new System.Drawing.Point(16, 64);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new System.Drawing.Size(132, 20);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número de cuenta";
            // 
            // txtNumero
            // 
            txtNumero.Location = new System.Drawing.Point(16, 82);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new System.Drawing.Size(260, 27);
            txtNumero.TabIndex = 3;
            toolTip1.SetToolTip(txtNumero, "Identificador único de la cuenta");
            // 
            // lblSaldoInicial
            // 
            lblSaldoInicial.AutoSize = true;
            lblSaldoInicial.Location = new System.Drawing.Point(16, 112);
            lblSaldoInicial.Name = "lblSaldoInicial";
            lblSaldoInicial.Size = new System.Drawing.Size(86, 20);
            lblSaldoInicial.TabIndex = 4;
            lblSaldoInicial.Text = "Saldo inicial";
            // 
            // nudSaldoInicial
            // 
            nudSaldoInicial.DecimalPlaces = 2;
            nudSaldoInicial.Location = new System.Drawing.Point(16, 130);
            nudSaldoInicial.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSaldoInicial.Name = "nudSaldoInicial";
            nudSaldoInicial.Size = new System.Drawing.Size(120, 27);
            nudSaldoInicial.TabIndex = 5;
            nudSaldoInicial.ThousandsSeparator = true;
            toolTip1.SetToolTip(nudSaldoInicial, "Saldo con el que se crea la cuenta");
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(200, 128);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(76, 26);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            toolTip1.SetToolTip(btnCrear, "Crear cuenta con los datos introducidos (Enter)");
            // 
            // gbOperaciones
            // 
            gbOperaciones.Controls.Add(nudCantidad);
            gbOperaciones.Controls.Add(btnDepositar);
            gbOperaciones.Controls.Add(btnRetirar);
            gbOperaciones.Location = new System.Drawing.Point(16, 170);
            gbOperaciones.Name = "gbOperaciones";
            gbOperaciones.Size = new System.Drawing.Size(260, 86);
            gbOperaciones.TabIndex = 7;
            gbOperaciones.TabStop = false;
            gbOperaciones.Text = "Operaciones";
            // 
            // nudCantidad
            // 
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Location = new System.Drawing.Point(12, 22);
            nudCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new System.Drawing.Size(120, 27);
            nudCantidad.TabIndex = 0;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new System.Drawing.Point(140, 16);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new System.Drawing.Size(100, 26);
            btnDepositar.TabIndex = 1;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new System.Drawing.Point(140, 48);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new System.Drawing.Size(100, 26);
            btnRetirar.TabIndex = 2;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 20;
            lstClientes.Location = new System.Drawing.Point(16, 266);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new System.Drawing.Size(260, 124);
            lstClientes.TabIndex = 8;
            lstClientes.DoubleClick += lstClientes_DoubleClick;
            toolTip1.SetToolTip(lstClientes, "Doble clic para seleccionar una cuenta destino");
            // 
            // btnCargarClientes
            // 
            btnCargarClientes.Location = new System.Drawing.Point(16, 402);
            btnCargarClientes.Name = "btnCargarClientes";
            btnCargarClientes.Size = new System.Drawing.Size(120, 26);
            btnCargarClientes.TabIndex = 9;
            btnCargarClientes.Text = "Cargar clientes";
            btnCargarClientes.UseVisualStyleBackColor = true;
            btnCargarClientes.Click += btnCargarClientes_Click;
            // 
            // btnSeleccionarCliente
            // 
            btnSeleccionarCliente.Location = new System.Drawing.Point(156, 402);
            btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            btnSeleccionarCliente.Size = new System.Drawing.Size(120, 26);
            btnSeleccionarCliente.TabIndex = 10;
            btnSeleccionarCliente.Text = "Seleccionar";
            btnSeleccionarCliente.UseVisualStyleBackColor = true;
            btnSeleccionarCliente.Click += btnSeleccionarCliente_Click;
            toolTip1.SetToolTip(btnSeleccionarCliente, "Seleccionar la cuenta marcada en la lista");
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new System.Drawing.Point(16, 440);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new System.Drawing.Size(120, 26);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "Mostrar cuenta";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(156, 440);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(120, 26);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtSalida
            // 
            txtSalida.Location = new System.Drawing.Point(292, 16);
            txtSalida.Multiline = true;
            txtSalida.Name = "txtSalida";
            txtSalida.ReadOnly = true;
            txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtSalida.Size = new System.Drawing.Size(492, 450);
            txtSalida.TabIndex = 13;
            txtSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            txtSalida.Font = new System.Drawing.Font("Consolas", 9F);
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(802, 480);
            Controls.Add(txtSalida);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnSeleccionarCliente);
            Controls.Add(btnCargarClientes);
            Controls.Add(lstClientes);
            Controls.Add(gbOperaciones);
            Controls.Add(btnCrear);
            Controls.Add(nudSaldoInicial);
            Controls.Add(lblSaldoInicial);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtTitular);
            Controls.Add(lblTitular);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Banco - Pruebas Cuenta";
            AcceptButton = btnCrear;
            gbOperaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSaldoInicial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
