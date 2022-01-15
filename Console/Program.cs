using Dominio;

Console.WriteLine("Olá! Por favor digite um número:");

var valorDigitado = Console.ReadLine();

var numeroDigitadoCorretamente = int.TryParse(valorDigitado, out int numeroDigitado);

if (!numeroDigitadoCorretamente)
{
    Console.WriteLine("Aceitamos somente números inteiros! Para adicionar essa funcionalidade favor tratar com o comercial xD");
    return;
}

var divisores = new CalcularDivisores().Executar(numeroDigitado);

Console.WriteLine("Os divisores desses número são:");
divisores.ForEach(f => Console.WriteLine(f));

Console.WriteLine("Os números primos desse número são:");

var primos = divisores
    .Where(s => s.ÉNúmeroPrimo())
    .ToList();

primos.ForEach(f => Console.WriteLine(f));