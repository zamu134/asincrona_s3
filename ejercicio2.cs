string[] nombrecompleto= new string[] {"Saul", "Alfredo","Guardado","Lopez" };
    Console.WriteLine("valores en el arreglo");
foreach (string valor in nombrecompleto)
{
    Console.WriteLine(valor);

}
int tamañoArreglo = nombrecompleto.Length;

    Console.WriteLine($"Tamaño del arreglo: {tamañoArreglo}");
    Console.WriteLine("Valores en el arreglo:");

for (int i = 0; i < tamañoArreglo; i++)
{
    Console.WriteLine($"Posición {i + 1}: {nombrecompleto[i]}");
}
