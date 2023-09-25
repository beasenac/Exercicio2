int tamanho, contador,contador2;

Console.WriteLine("Digite o tamanho:");
tamanho = Convert.ToInt32(Console.ReadLine());

for(contador = 1;contador <= tamanho ;contador++)
{
    
    
    for(contador2 = 1; contador2 <= tamanho ;contador2++)
    {
        Console.Write("*");
       
        
    }
    Console.WriteLine("*");
}
       
