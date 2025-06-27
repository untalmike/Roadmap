
/**
    * Cómo crear el primer proyecto:
    * Comando (Ctrl + Shift + P) para abrir el solucionador de VSCode
    * Escriba .NET
    * Elegir nuevo proyecto
    * Dar nombre
    * Elegir carpeta de destino
    * Crear proyecto
     

    * Soporte
    * https://dotnet.microsoft.com/es-es/learn/csharp
    
*/

// Variables uso recomendado de snakeCase
// Tipos de datos
int myNumber = 0;
double myDouble = 0.00;
bool myBool = true;
char myChar = 'a';
string myLanguaje = "C#";
var hello = "Hello World!";

// Las variables de asignación deben de ir antes de la declaración de la clase L:35
ClaseEjemplo claseEjemplo = new ClaseEjemplo();
claseEjemplo.Lenguaje = "C#";
claseEjemplo.Edad = 35;
claseEjemplo.Hello = "Hello";

Console.WriteLine($"{claseEjemplo.Hello} {claseEjemplo.Lenguaje}");

// El símbolo ? indica capacidad de ser nulo
class ClaseEjemplo
{
    public string? Lenguaje { get; set; }
    public int? Edad { get; set; }
    public string? Hello { get; set; }
}



