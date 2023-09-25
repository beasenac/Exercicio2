int numero1, numero2, numero3,d1=0,d2=0,d3=0;
Console.WriteLine("Digite o primeiro números:");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{
    d1 = numero1;
} 
if (numero2 > numero1 && numero2 > numero3)
{
    d1 = numero2;
}
else if (numero3 > numero1 && numero3 > numero2)
{
    d1 = numero3;
}
if (numero1 < numero2 && numero1 < numero3 )
{
    d2 = numero1;
}
if (numero2 < numero1 &&  numero2 < numero3 )
{
    d2 = numero2;
}
else if (numero3 < numero1 && numero3 <numero2 )
{
    d2 = numero3;
}
if (numero1 > numero2 && numero1 < numero3 || numero1 > numero3 && numero1 < numero2)
{
    d3 = numero1;
}
if(numero2 > numero1 && numero2 < numero3 || numero2 > numero3 && numero2 < numero1 )
{
    d3= numero2;
}
else if (numero3 > numero1 && numero3 < numero2)
{
    d3 = numero3;
}
Console.WriteLine(d1);
Console.WriteLine(d3);
Console.WriteLine(d2);


