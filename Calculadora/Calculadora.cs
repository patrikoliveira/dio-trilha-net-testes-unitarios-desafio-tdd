namespace Calculadora
{
    public class CalculadoraImp
    {
        private readonly IList<string> historicoOperacoes;

        public CalculadoraImp()
        {
            historicoOperacoes = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            var result = num1 + num2;
            historicoOperacoes.Insert(0, $"{num1} + {num2} = {result}");
            return result;
        }

        public int Subtrair(int num1, int num2)
        {
            int result = num1 - num2;
            historicoOperacoes.Insert(0, $"{num1} - {num2} = {result}");
            return result;
        }

        public int Multiplicar(int num1, int num2)
        {
            int result = num1 * num2;
            historicoOperacoes.Insert(0, $"{num1} * {num2} = {result}");
            return result;
        }

        public int Dividir(int num1, int num2)
        {
            int result = num1 / num2;
            historicoOperacoes.Insert(0, $"{num1} + {num2} = {result}");
            return result;
        }

        public IList<string> Historico() => historicoOperacoes.Take(3).ToList();
    }
}

