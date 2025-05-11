

// // Simple
// using System.Numerics;
// using System.Runtime.CompilerServices;

 /**
//     Funciones definidas por el usuario
 **/
// static void Greet()
// {
//     Console.WriteLine("Hola, C#");
// } 

// Greet();

// // Con retornos de valor
// static string ReturnGreet()
// {
//     return ("Hola, CSharp");
// }

// Console.WriteLine(ReturnGreet());

// // Funciones con argumento
// static void TextGreet(string saludo, string name)
// {
//     Console.WriteLine($"{saludo} {name}");
// }

// TextGreet("Hola de nuevo", "C#");
// TextGreet("C#", "Hola de nuevo");

// // Funciones con argumento por default
// static void Text_Greet(string saludo="Hola desde", string name="CSharp")
// {
//     Console.WriteLine($"{saludo} {name}");
// }

// Text_Greet();

// // Funciones con argumentos y return
// string Return_Greet(string saludo, string name)
// {
//     return saludo + " " + name;
// }

// Console.WriteLine(Return_Greet(saludo:"Holi holi", name:"CCharp"));

// // Funciones dentro de funciones
// int n = 25;

// static void ExtraLongFactorials(int n)
// {
//     BigInteger result = 1;
//     for (int i = 1; i <= n; i++)
//     {        
//         result *= i;
//     }

//     Console.WriteLine(result);
    
// }

// ExtraLongFactorials(n);
string s = "abcdefghhgfedecba";

static void isValid(string s)
{
    char[] chars = s.ToCharArray();
    int countChars = 0;

    foreach (char c in chars)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if(c == chars[i]){
                countChars = countChars+1;

                Console.WriteLine(countChars);
            }
        }
    }


}

isValid(s);

using System;
using System.Linq;

class Program
{
    static int FindTheVulnerabilityFactor(int[] key, int maxChange)
    {
        // Contamos la frecuencia de cada número en la clave
        var frequency = key.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        
        // Calculamos la vulnerabilidad inicial como la cantidad de números únicos
        int vulnerabilityFactor = frequency.Count;

        // Si maxChange es 0, no se hacen cambios
        if (maxChange == 0)
            return vulnerabilityFactor;

        // Ordenamos las frecuencias de menor a mayor
        var sortedFrequencies = frequency.OrderBy(kv => kv.Value).ToList();

        // Aplicamos cambios reduciendo los valores menos frecuentes
        foreach (var pair in sortedFrequencies)
        {
            if (maxChange >= pair.Value)
            {
                // Eliminamos completamente este número
                vulnerabilityFactor--;
                maxChange -= pair.Value;
            }
            else
            {
                // No podemos eliminar completamente otro número sin exceder maxChange
                break;
            }
        }

        return vulnerabilityFactor;
    }

    static void Main()
    {
        int[] key = { 5, 3, 8, 3, 5, 2, 8, 7 };
        int maxChange = 3;

        int minVulnerability = FindTheVulnerabilityFactor(key, maxChange);
        Console.WriteLine("Mínimo factor de vulnerabilidad posible: " + minVulnerability);
    }
}

using System;
using System.Linq;

class Program
{
    static string FindTime(string genome, char[] mutation)
    {
        string vowels = "aeiouAEIOU"; // Vocales que se deben eliminar
        return new string(genome.Where(c => mutation.Contains(c) && !vowels.Contains(c)).ToArray());
    }

    static void Main()
    {
        Console.Write("Introduce el genoma: ");
        string genome = Console.ReadLine();
        
        Console.Write("Introduce los caracteres de mutación (sin espacios, ej: tm): ");
        char[] mutation = Console.ReadLine().ToCharArray();

        string result = FindTime(genome, mutation);
        Console.WriteLine($"Resultado: \"{result}\"");
    }
}
{
    static string FindTime(string genome, char[] mutation)
    {
        return new string(genome.Where(c => mutation.Contains(c)).ToArray());
    }

    static void Main()
    {
        Console.Write("Introduce el genoma: ");
        string genome = Console.ReadLine();
        
        Console.Write("Introduce los caracteres de mutación (separados sin espacios, ej: tm): ");
        char[] mutation = Console.ReadLine().ToCharArray();

        string result = FindTime(genome, mutation);
        Console.WriteLine($"Resultado: \"{result}\"");
    }
}

using System;
using System.Linq;

class Program
{
    static string FindTime(string genome, char mutation)
    {
        string vowels = "aeiouAEIOU"; // Vocales que deben eliminarse
        return new string(genome.Where(c => c == mutation && !vowels.Contains(c)).ToArray());
    }

    static void Main()
    {
        Console.Write("Introduce el genoma: ");
        string genome = Console.ReadLine();

        Console.Write("Introduce el carácter de mutación (ej: m): ");
        char mutation = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Salto de línea después de la entrada

        string result = FindTime(genome, mutation);
        Console.WriteLine($"Resultado: \"{result}\"");
    }
}