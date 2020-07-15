using System;

namespace app01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textos = new string[] { "Escribe un número: ", " da un resultado de: ", "La resta es negativa", "La resta es positiva" };
            Console.Write(textos[0]);
            int i = int.Parse(Console.ReadLine());
            Console.Write(textos[0]);
            int j = int.Parse(Console.ReadLine());

            int suma = i + j;
            int resta = i - j;
            int multiplicacion = i * j;
            double division = (double)i / (double)j;

            Console.WriteLine("La suma de: " + i + " " + "+" + " " + j + textos[1] + suma);
            Console.WriteLine("La resta de: " + i + " " + "-" + " " + j + textos[1] + resta);
            Console.WriteLine("La multiplicación de: " + i + " " + "x" + " " + j + textos[1] + multiplicacion);
            Console.WriteLine("La división de: " + i + " " + "/" + " " + j + textos[1] + division);

            if (resta < 0)
            {
                Console.WriteLine(textos[2]);
            }
            else { Console.WriteLine(textos[3]); }

            // Número inverso

            int numero, resto, numero_i;

            do
            {
                Console.Write(textos[0] + "de 3 cifras: ");
                numero = int.Parse(Console.ReadLine());

            } while (numero < 100 || numero > 999);

            int x = numero;

            resto = numero % 10;
            numero = (int)numero / 10;
            numero_i = resto * 10;

            resto = numero % 10;
            numero = (int)numero / 10;
            numero_i = (numero_i + resto) * 10;

            numero_i = (int)numero_i + numero;

            Console.WriteLine("El número invertido de xxxx" + x + textos[1] + numero_i);
            Console.ReadKey();
        }
    }
}
