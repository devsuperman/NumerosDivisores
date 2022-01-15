namespace Dominio;

public class CalcularDivisores
{
    public List<int> Executar(int numero)
    {
        var divisores = new List<int>();

        for (int i = 1; i <= numero; i++)
        {
            var éDivisor = ((numero % i) == 0);

            if (éDivisor)
                divisores.Add(i);
        }

        return divisores;
    }    
}
