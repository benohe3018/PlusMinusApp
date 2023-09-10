using System;
using System.Collections.Generic;
using System.Linq;
class Result
{
    public static void plusMinus(List<int> arr)
    {
        int n = arr.Count;
        int positiveCount = arr.Count(x=>x>0);
        int negativeCount = arr.Count(x=>x<0);
        int zeroCount = arr.Count (x=>x==0);

        System.Console.WriteLine($"El porcentaje de numeros positivos encontrados en el arreglo es de: {(double)positiveCount/ n:0.000000}");
        System.Console.WriteLine($"El porcentaje de numeros negativos encontrados en el arreglo es de: {(double)negativeCount/ n:0.000000}");
        System.Console.WriteLine($"El porcentaje de ceros encontrados en el arreglo es de: {(double)zeroCount/ n:0.000000}");
    }    
}
class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingrese el numero de elementos que desea en el arreglo(hasta 100): ");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Console.Write("Por favor, ingrese los elementos del arreglo separados por espacios: ");
    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();        Result.plusMinus( arr);
    }
}