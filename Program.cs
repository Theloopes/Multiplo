Console.Clear();
Console.WriteLine("--- Multiplo ---");
Console.WriteLine("");
Console.WriteLine("Digite um numero");
double numero = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("");
Console.WriteLine("Avaliar se é multiplo de:");
double multiplo = Convert.ToDouble(Console.ReadLine()!);
double resultado = numero % multiplo;
Console.WriteLine("");

if(resultado == 0){
    Console.WriteLine($"{numero} é multiplo de {multiplo}");
}
else{
    Console.WriteLine($"{numero} não é multiplo de {multiplo}");
}
