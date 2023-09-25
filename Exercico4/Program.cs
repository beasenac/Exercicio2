decimal numero = 0, soma = 0, contador;

Console.WriteLine("Digite um número:");
numero = Convert.ToDecimal(Console.ReadLine());

for (contador = 1;contador <= numero;contador++) 
{
    if (contador == 1)
    {
        soma = 1;
    }
    else
    {
        soma += 1 / contador;
    }
    if (contador == 1)
    {
        Console.Write("S = 1");
    }
    else
    {
        Console.Write(" + 1/" + contador);
    }
}
Console.WriteLine("=" + soma);