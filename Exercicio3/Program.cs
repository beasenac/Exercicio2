decimal salarioBruto=0, salarioLiquido,ir=0,fgts,sindicato,totalDesconto=0;
int valorHora, horasTrabalhadas;

Console.WriteLine("Digite o valor da hora trabalhada:");
valorHora = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite quantas horas trabalhadas:");
horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

salarioBruto = valorHora * horasTrabalhadas;
sindicato = salarioBruto * 3/ 100;
fgts = salarioBruto * 11 / 100;
salarioLiquido = salarioBruto - totalDesconto;

if(salarioBruto <= 900)
{
    ir = salarioBruto * 0;
}
else if(salarioBruto <= 1500)
{
    ir = salarioBruto * 5 / 100;
}
else if(salarioBruto <= 2500 )
{
    ir = salarioBruto * 10 / 100;
}
else 
{
    ir = salarioBruto * 20 / 100;
}

totalDesconto = ir + sindicato;

Console.WriteLine("Salário Bruto:" + salarioBruto);
Console.WriteLine("IR:" + ir);
Console.WriteLine("Sindicato:" + sindicato);
Console.WriteLine("FGTS:" + fgts);
Console.WriteLine("Total de Desconto:" + totalDesconto);
Console.WriteLine("Salário Líquido:" + salarioLiquido);


