using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CuentaDeBancoForms
{
    internal class ClientesRegistrados
    {
        private readonly List<Cuenta> clientes = new();
        private readonly object sync = new();

        // Intenta agregar; devuelve true si se agregó, false si ya existía una cuenta con el mismo número.
        public bool AgregarCliente(Cuenta cuenta)
        {
            if (cuenta is null) throw new ArgumentNullException(nameof(cuenta));

            lock (sync)
            {
                if (clientes.Any(c => c.NumeroCuenta == cuenta.NumeroCuenta))
                    return false;

                clientes.Add(cuenta);
                return true;
            }
        }

        // Retorna vista de solo lectura para evitar modificaciones externas.
        public IReadOnlyList<Cuenta> ObtenerClientes()
        {
            lock (sync) { return clientes.AsReadOnly(); }
        }

        // Buscar por número de cuenta.
        public Cuenta? ObtenerPorNumero(string numeroCuenta)
        {
            if (string.IsNullOrEmpty(numeroCuenta)) return null;
            lock (sync) { return clientes.FirstOrDefault(c => c.NumeroCuenta == numeroCuenta); }
        }

        // Eliminar por número de cuenta.
        public bool EliminarPorNumero(string numeroCuenta)
        {
            if (string.IsNullOrEmpty(numeroCuenta)) return false;
            lock (sync)
            {
                var c = clientes.FirstOrDefault(x => x.NumeroCuenta == numeroCuenta);
                if (c is null) return false;
                return clientes.Remove(c);
            }
        }

        // Persistencia simple a JSON (opcional).
        public void GuardarEnJson(string ruta)
        {
            if (string.IsNullOrEmpty(ruta)) throw new ArgumentNullException(nameof(ruta));
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            lock (sync)
            {
                File.WriteAllText(ruta, JsonSerializer.Serialize(clientes, opciones));
            }
        }

        public void CargarDesdeJson(string ruta)
        {
            if (string.IsNullOrEmpty(ruta) || !File.Exists(ruta)) return;
            lock (sync)
            {
                var texto = File.ReadAllText(ruta);
                var cargados = JsonSerializer.Deserialize<List<Cuenta>>(texto);
                if (cargados is not null)
                {
                    clientes.Clear();
                    clientes.AddRange(cargados);
                }
            }
        }
    }
}
