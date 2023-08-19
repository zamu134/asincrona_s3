// se declara el arreglo de palabras
List<string> miArreglo = new List<string>
        {
            "Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol"
        };

// Palabras a buscar
List<string> palabrasABuscar = new List<string> { "Sol", "Dedo", "Casa" };

// se encontrara las posiciones de las palabras
Dictionary<string, int> posiciones = new Dictionary<string, int>();
foreach (string palabra in palabrasABuscar)
{
    int posicion = -1; 
    for (int i = 0; i < miArreglo.Count; i++)
    {
        if (miArreglo[i] == palabra)
        {
            posicion = i;
            break;
        }
    }
    posiciones[palabra] = posicion;
}

// se va a imprimir las posiciones encontradas
foreach (var kvp in posiciones)
{
    string palabra = kvp.Key;
    int posicion = kvp.Value;
    if (posicion != -1)
    {
        Console.WriteLine($"La palabra '{palabra}' se encuentra en la posición {posicion + 1}.");
    }
    else
    {
        Console.WriteLine($"La palabra '{palabra}' no se encontró en el arreglo.");
    }
}
   