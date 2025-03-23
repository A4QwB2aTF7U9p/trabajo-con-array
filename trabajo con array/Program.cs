/* Crear un programa que tenga un arreglo de 5 nombres empleados y otro
arreglo con 5 nombre de departamentos, unir cada uno de estos elementos
en un tercer arreglo, en el cual debe aparecer de esta forma “Juan Pérez –
Contabilidad”. Estos datos deben mostrarse en pantalla. La aplicación es por
consola y se debe pedir al usuario que pida los datos por teclado y luego
mostrar los resultados en pantalla.*/


using System;

class Program
{
    static void Main()
    {
        string[] empleados = new string[5];
        string[] departamentos = new string[5];
        string[] arreglo = new string[5];

        Console.WriteLine("Ingresa 5 nombre:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($" {i + 1} Empleado: ");
            empleados[i] = Console.ReadLine();
        }
        Console.WriteLine("\nIngrese 5 departamentos:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{i + 1} Departamento:  ");
            departamentos[i] = Console.ReadLine();
        }

        for (int i = 0; i < empleados.Length; i++)
        {
            arreglo[i] = empleados[i] + " – " + departamentos[i];
        }
        Console.WriteLine("\nempleados com departamentos");
        foreach (var item in arreglo)
        {
            Console.WriteLine(item);
        }
    }
}