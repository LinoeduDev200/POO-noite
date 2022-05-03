using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    class Conta
    {
        //declaração dos atributos encapsulados
        private int numero;
        private string titular;
        private double saldo;
        private static int contador;

        //declaração dos métodos CONSTRUTORES
        public Conta() //construtor padrão
        {
            contador++;
        }
        public Conta(int numero) //construtor padrão
        {
            this.numero = numero;
            contador += 1;
        }
        public Conta(int numero, string titular, double saldo) //construtor padrão
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
            contador = contador + 1;
        }

        //declaração de método
        public void Mostrar()
        {
            Console.WriteLine("Número da conta: " + numero +
                "\tNome do titular: " + titular +
                "\tSaldo: " + saldo);
        }
        //declaração de método de encapsulamento / propriedade
        public static int Contador
        {
            get { return contador; }
        }
    }
}
