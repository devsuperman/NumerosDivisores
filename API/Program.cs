using Dominio;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/NumerosDivisoresEPrimos", (int numero) =>{

    var divisores = new CalcularDivisores().Executar(numero);
    var primos = divisores.Where(w => w.ÉNúmeroPrimo()).ToList();

    var retorno = new {numero, divisores, primos};
    return Results.Ok(retorno);
});

app.Run();
