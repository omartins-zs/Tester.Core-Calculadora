using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester.Core
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
