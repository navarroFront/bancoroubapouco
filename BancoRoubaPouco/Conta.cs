using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoRoubaPouco
{
    public class Conta
    {
        public string Numero { get; set; }
        public int Agencia { get; set; }
        public decimal Saldo { get; set; }

        public virtual decimal Saque(decimal valor)
        {
            Saldo = Saldo - valor;
            return Saldo;
        }
    }
}
