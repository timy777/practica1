Console.WriteLine("=== CALCULADORA BÁSICA ===");

Console.Write("Ingrese el primer número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nSeleccione una operación:");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicación");
Console.WriteLine("4. División");

Console.Write("Opción: ");
int opcion = Convert.ToInt32(Console.ReadLine());

double resultado = 0;

if (opcion == 1)
{
    resultado = num1 + num2;
    Console.WriteLine("Resultado de la suma: " + resultado);
}
else if (opcion == 2)
{
    resultado = num1 - num2;
    Console.WriteLine("Resultado de la resta: " + resultado);
}
else if (opcion == 3)
{
    resultado = num1 * num2;
    Console.WriteLine("Resultado de la multiplicación: " + resultado);
}
else if (opcion == 4)
{
    if (num2 != 0)
    {
        resultado = num1 / num2;
        Console.WriteLine("Resultado de la división: " + resultado);
    }
    else
    {
        Console.WriteLine("Error: No se puede dividir entre cero.");
    }
}
else
{
    Console.WriteLine("Opción no válida.");
}

Console.WriteLine("\nPrograma finalizado.");