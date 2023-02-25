// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Ingrese el valor inicial: ");
int inicio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor final: ");
int fin = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Los numeros pares en el rango son: ");

for (int i = inicio; i <= fin; i++)
{
    if(i % 2 == 0)
    {
        Console.Write("{0} ", i);
    }
}
