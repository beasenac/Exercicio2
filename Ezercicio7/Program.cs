int numero,fatorial=1,contador=1;

Console.WriteLine("Digite um número:");
numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("0! = 1");

}
else 
{
    for(contador = 1;contador <= numero; contador++)
    {
        fatorial *= contador;
       
    }
    Console.WriteLine(numero + "!" + "=" + fatorial);

}
