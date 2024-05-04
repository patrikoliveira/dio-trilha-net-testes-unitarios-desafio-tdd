using Calculadora;
namespace CalculadoraTestes;

public class CalculadoraTest
{
    private readonly CalculadoraImp calc;

    public CalculadoraTest()
    {
        calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-2, 3, 1)]
    public void DeveSomarDoisNumerosERetornarOResultado(int num1, int num2, int resultadoEsperado)
    {
       // Act
        var resultadoCalculado = calc.Somar(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultadoCalculado);
    }

    [Theory]
    [InlineData(2, 3, -1)]
    [InlineData(-2, 3, -5)]
    [InlineData(5, 1, 4)]
    public void DeveSubtrairDoisNumerosERetornarOResultado(int num1, int num2, int resultadoEsperado)
    {
        // Act
        var resultadoCalculado = calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultadoCalculado);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-2, 3, -6)]
    [InlineData(-5, -5, 25)]
    public void DeveMultiplicarDoisNumerosERetornarOResultado(int num1, int num2, int resultadoEsperado)
    {
        // Act
        var resultadoCalculado = calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultadoCalculado);
    }

    [Theory]
    [InlineData(5, 1, 5)]
    [InlineData(10, 5, 2)]
    public void DeveDividirDoisNumerosERetornarOResultado(int num1, int num2, int resultadoEsperado)
    {
        // Act
        var resultadoCalculado = calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultadoCalculado);
    }

    [Theory]
    [InlineData(5, 0)]
    public void DeveLancarExcecaoAoDividirUmNumeroPorZero(int num1, int num2)
    {
        // Assert
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(num1, num2));
    }

    [Fact]
    public void DeveHaverHistorico()
    {
        calc.Somar(1, 1);
        calc.Somar(2, 1);
        calc.Somar(3, 1);
        calc.Somar(5, 1);
        var historico = calc.Historico();

        Assert.NotEmpty(historico);
        Assert.Equal(3, historico.Count);
    }
}