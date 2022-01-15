using Xunit;
using Dominio;
using System.Collections.Generic;

namespace Tests;

public class CalcularDivisoresTests
{
    [Fact]
    public void DeveRetornarTodosOsDivisoresDoNumero()
    {
        var numero = 45;

        var divisores = new CalcularDivisores().Executar(numero);

        var retornoEsperado = new List<int> { 1, 3, 5, 9, 15, 45 };

        for (int i = 0; i < retornoEsperado.Count; i++)
            Assert.Equal(retornoEsperado[i], divisores[i]);

    }
}