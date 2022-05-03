using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConta
{
    class Conta
    {
        //declaração dos atributos
        public int numero;
        public string titular;
        public double saldo;
        //declaração dos métodos
        public double Transferir(double valor,
                                 Conta contaDestino)
         // contaDestino é um objeto que vem da Main()
        {
            contaDestino.saldo -= valor;
            saldo += valor;
            return saldo;
        }
        public void Sacar(double valor)
        {
            saldo = saldo - valor;
        }
        public void Depositar(double valorDepositado)
        {
            saldo = saldo + valorDepositado;

        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número da conta: " + numero +
                "\tNome do titular: " + titular +
                "\tSaldo: " + saldo);
        }        
    }
}
