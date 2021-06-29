namespace Exercicio_POO.Entities
{
    public class Caixa
    {
        public double calculaValorFinal(Produto produto, int quantidade)
        {
            double valor = produto.Valor;
            double total = 0;
            double x = produto.Valor * quantidade;

            if(produto.Tipo == 1)
            {
                total = x - (x * 0.1);
            }
            else if (produto.Tipo == 2)
            {
                total = x - (x * 0.2);
            }
            else if (produto.Tipo == 3)
            {
                if(quantidade > 5)
                {
                    total = x - (x * 0.1);
                }
                else
                {
                    total = x;
                }
            }
            return total;
        }
    }
}