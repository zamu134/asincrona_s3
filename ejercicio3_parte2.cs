// vamos a declarar el arreglo
int[] miArreglo = { 4, 10, 45, -67, -7, 25, 89, 64 };

// se va a imprimir el arreglo en orden
Console.WriteLine("Arreglo en el orden original");
foreach (int elemento in miArreglo)
{
    Console.Write(elemento + " ");
}
Console.WriteLine();

// se utiliza la función Reverse y imprimir el arreglo
Array.Reverse(miArreglo);
Console.WriteLine("\nArreglo en orden inverso:");
foreach (int elemento in miArreglo)
{
    Console.Write(elemento + " ");
}
Console.WriteLine();

//se utiliza la función Sort e imprimir el arreglo ordenado
Array.Sort(miArreglo);
Console.WriteLine("\nArreglo ordenado:");
foreach (int elemento in miArreglo)
{
    Console.Write(elemento + " ");
}
Console.WriteLine(); 
    
