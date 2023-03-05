int somaImpar = 0, somaPar = 0, aux = 0;

do
{
    if (aux % 2 == 0)
        somaPar += aux;
    else
        somaImpar += aux;

    Console.WriteLine("informe um numero de 1 a 999 para ser somado: ");
    aux = int.Parse(Console.ReadLine());
} while (aux > 0 && aux < 1000);

Console.WriteLine("par: " + somaPar);
Console.WriteLine("impar: " + somaImpar);
