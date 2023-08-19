int[] numeros;

//realizara el pedido del tamaño del arreglo
Console.WriteLine("ingrese el tamaño del arrreglo minimo de 5 posiciones");
int tamaño = Convert.ToInt32(Console.ReadLine());

//verificar si el tamaño es minimo de 5 posiciones 
    if (tamaño < 5)
    {
        Console.WriteLine("El tamaño minimo es de 5 posiciones");
        return;
    }
// se iniciara el arreglo con el tamaño dado
    numeros = new int[tamaño];

// Pedira que ingrese los valores del arreglo
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write($"Ingrese el valor {i + 1}: ");
        numeros[i] = Convert.ToInt32(Console.ReadLine());
    }
//va a imprimir los valores dados
        Console.WriteLine("Valores ingresados en el arreglo:");
    foreach (int valor in numeros)
    {
        Console.WriteLine(valor);
    }
    

