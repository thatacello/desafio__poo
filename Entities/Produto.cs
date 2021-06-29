namespace Exercicio_POO.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Tipo { get; set; }
        public Produto(string nome, double valor, int tipo)
        {
            Nome = nome;
            Valor = valor;
            Tipo = tipo;
        }
    }
}