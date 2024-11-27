using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class CuentaBancaria
    {
        private string numeroCuenta;
        private double saldo;

        public CuentaBancaria(string numeroCuenta, double saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
        }

        public void depositar(double deposito)
        {
            this.saldo += deposito;
        }

        public void retirar(double monto)
        {
            this.saldo -= monto;
        }

        public double mostrarSaldo()
        {
            return this.saldo;
        }
    }
}
