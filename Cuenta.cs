using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBancoForms
{
    internal class Cuenta
    {
        //atributos
        private string titular;
        private double saldo;
        private string numeroCuenta;

        //constructor
        public Cuenta(string titular, double saldo, string numeroCuenta)
        {
            this.titular = titular;
            this.saldo = saldo;
            this.numeroCuenta = numeroCuenta;
        }
        public string Titular { get => titular; set => titular = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        //metodos
        public void Depositar(double cantidad)
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
            }
        }
        public void Retirar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= saldo)
            {
                saldo -= cantidad;
            }
        }
        public override string ToString()
        {
            return $"Titular: {titular}, Saldo: {saldo}, Número de Cuenta: {numeroCuenta}";
        }
    }
}
