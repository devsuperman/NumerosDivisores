using Xunit;
using Dominio;

namespace Tests;

public class CalcularPrimosTests
{
    [Theory]    
    [InlineData(1)]
    [InlineData(3)]
    [InlineData(5)]
    public void DeveRetornarVerdadeiroSeForNumeroPrimo(int numero)
    {
        Assert.True(numero.ÉNúmeroPrimo());       

    }

    [Theory]    
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(12)]
    [InlineData(14)]
    public void DeveRetornarFalsoeSeNãoForNumeroPrimo(int numero)
    {
        Assert.False(numero.ÉNúmeroPrimo());       
    }
}