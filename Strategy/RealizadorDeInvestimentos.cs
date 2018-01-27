namespace DesignPatterns_CSharp
{
    public class RealizadorDeInvestimento
    {
        public void Realiza(Conta conta, IInvestimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Deposita( resultado * 0.75 );
            
        }
    }
}