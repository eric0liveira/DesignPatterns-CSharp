using System;

namespace DesignPatterns_CSharp
{
    public class Orcamento 
    {
        public double Valor { get; private set; }

        public Orcamento(double Valor)
        {
            this.Valor = Valor;
        }
    }
}