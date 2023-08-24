using System.Diagnostics.CodeAnalysis;
using System.Xml;
public class MiprimerPrograma
{
    static void Main(string[] args)
    {
        //Enciciado ingresa por pantalla 2 numeros y calcular las 4 operaciones ariméticas con dicho números
        //imprimir en pantalla el resultado de cada operacion//

        // Declaracion de mis variables (datos de entrada)
        int num1, num2, suma, resta, producto, cociente;

        // calculos (procesos)
        Console.Write("Ingrese su primer número:");
    num1 = Convert .ToInt32(Console.ReadLine());

    Console .Write("Ingrese su segundo número: " ) ;
    num2 = Convert .ToInt32(Console.ReadLine());

        // calcular
        suma = num1 + num2;
        resta = num1 - num2;
        producto = num1 * num2;
        cociente = num1 * num2;

        // imprimir los resultadoo ( salida)
        Console.Write("La suma es:", suma);
        Console.Write("La resta es:", resta);
        Console.Write("La producto es:", producto);
        Console.Write("La cociente es:", cociente);


    }
}