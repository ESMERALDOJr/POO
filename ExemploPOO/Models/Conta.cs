using System;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo; 

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            Console.WriteLine();
            Console.WriteLine("Seu saldo é: " + saldo);
            Console.WriteLine();
        }
        
    }
}