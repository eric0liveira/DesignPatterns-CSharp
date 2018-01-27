namespace DesignPatterns_CSharp
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public void Deposita(double valor) 
        { 
            this.Saldo += valor;    
        }
    }
}