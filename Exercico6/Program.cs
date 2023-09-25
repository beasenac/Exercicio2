int valor, precoFinal=0, quantparcela,parcela =0;

Console.WriteLine("Digite o valor do carro:");
valor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite quantas parcelas deseja :");
quantparcela = Convert.ToInt32(Console.ReadLine());

if (quantparcela == 0)
{
    precoFinal = valor - (valor * 20 / 100);
}
else if (quantparcela == 6)
{
    precoFinal = valor - (valor * 3 / 100);
    parcela = precoFinal / quantparcela;
}
if (quantparcela == 12)
{
    precoFinal = valor - (valor * 6 / 100);
    parcela = precoFinal / quantparcela;
}
if (quantparcela == 18)
{
    precoFinal = valor - (valor * 9 / 100);
    parcela = precoFinal / quantparcela; ;
}
if (quantparcela == 24)
{
    precoFinal = valor - (valor * 12 / 100);
    parcela = precoFinal / quantparcela; ;
}
if (quantparcela == 30)
{
    precoFinal = valor - (valor * 15 / 100);
    parcela = precoFinal / quantparcela;
}

 if (quantparcela == 36)
    {
        precoFinal = valor - (valor * 18 / 100);
        parcela = precoFinal / quantparcela; 
    }
if (quantparcela == 42)
    {
        precoFinal = valor - (valor * 21 / 100);
        parcela = precoFinal / quantparcela;
    }
if (quantparcela == 48)
    {
        precoFinal = valor - (valor * 24 / 100);
        parcela = precoFinal / quantparcela; ;
    }

if (quantparcela == 54)
    {
        precoFinal = valor - (valor *  27 / 100);
        parcela = precoFinal / quantparcela; ;
    }
if (quantparcela == 60)
    {
        precoFinal = valor - (valor * 30 / 100);
        parcela = precoFinal / quantparcela; ;
    }

Console.WriteLine("O preço final é:" + precoFinal);
Console.WriteLine("A quantidade de parcelas é:" + quantparcela); 
Console.WriteLine("O valor da parcela é:" + parcela);
