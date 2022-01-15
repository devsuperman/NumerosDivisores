namespace Dominio;

public static class IntExtensions
{
    public static bool ÉNúmeroPrimo(this int numero)
    {
        var éPrimo = true;

        for (int i = 1; i <= numero; i++)
        {
            if (i == 1 || i == numero)
                continue;

            éPrimo = (numero % i) != 0;

            if (!éPrimo)
                return false;
        }

        return éPrimo;
    }
}
