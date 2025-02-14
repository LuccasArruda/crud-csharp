using System;

namespace CRUD.API;

public class Main
{
    class CrudApi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
            
            // Exemplo de lógica adicional
            int a = 10;
            int b = 20;
            int resultado = Somar(a, b);
            Console.WriteLine($"A soma de {a} e {b} é {resultado}");
        }

        static int Somar(int x, int y)
        {
            return x + y;
        }
    }
  
}