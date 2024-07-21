//Pide 10 números por consola, muestra el resultado por consola de sumar los pares y restarle los impares.
int sumaPares = 0;
int restaImpares = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Ingrese un número:");
    int numero121 = Convert.ToInt32(Console.ReadLine());
    if (numero121 % 2 == 0)
    {
        sumaPares += numero121;
    }
    else
    {
        restaImpares -= numero121;
    }
}
Console.WriteLine("La suma de los números pares es: " + sumaPares);
Console.WriteLine("La resta de los números impares es: " + restaImpares);