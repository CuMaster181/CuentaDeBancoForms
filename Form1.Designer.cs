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
            lblTitular = new Label();
            txtTitular = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            btnCrear = new Button();
            gbOperaciones = new GroupBox();
            nudCantidad = new NumericUpDown();
            btnDepositar = new Button();
            btnRetirar = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            txtSalida = new TextBox();
            gbOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(16, 16);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(51, 20);
            lblTitular.TabIndex = 0;
            lblTitular.Text = "Titular";
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(16, 34);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(260, 27);
            txtTitular.TabIndex = 1;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(16, 64);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(132, 20);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número de cuenta";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(16, 82);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(260, 27);
            txtNumero.TabIndex = 3;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(200, 128);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(76, 26);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            
            // 
            // gbOperaciones
            // 
            gbOperaciones.Controls.Add(nudCantidad);
            gbOperaciones.Controls.Add(btnDepositar);
            gbOperaciones.Controls.Add(btnRetirar);
            gbOperaciones.Location = new Point(16, 170);
            gbOperaciones.Name = "gbOperaciones";
            gbOperaciones.Size = new Size(260, 86);
            gbOperaciones.TabIndex = 7;
            gbOperaciones.TabStop = false;
            gbOperaciones.Text = "desea realizar:";

            // 
            // nudCantidad
            // 
            nudCantidad.DecimalPlaces = 2;
            nudCantidad.Location = new Point(12, 22);
            nudCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 27);
            nudCantidad.TabIndex = 0;
            // btnDepositar
            // 
            btnDepositar.Location = new Point(140, 16);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(100, 26);
            btnDepositar.TabIndex = 1;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(140, 48);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(100, 26);
            btnRetirar.TabIndex = 2;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(16, 266);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(120, 26);
            btnMostrar.TabIndex = 8;
            btnMostrar.Text = "Mostrar cuenta";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(156, 266);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 26);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtSalida
            // 
            txtSalida.Location = new Point(292, 16);
            txtSalida.Multiline = true;
            txtSalida.Name = "txtSalida";
            txtSalida.ReadOnly = true;
            txtSalida.ScrollBars = ScrollBars.Vertical;
            txtSalida.Size = new Size(492, 276);
            txtSalida.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 311);
            Controls.Add(txtSalida);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(gbOperaciones);
            Controls.Add(btnCrear);
            Controls.Add(nudSaldoInicial);
            Controls.Add(lblSaldoInicial);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtTitular);
            Controls.Add(lblTitular);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Banco - Pruebas Cuenta";
            gbOperaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
