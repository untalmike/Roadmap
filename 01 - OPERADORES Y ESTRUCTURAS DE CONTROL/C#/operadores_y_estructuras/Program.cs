// See https://aka.ms/new-console-template for more information

/**
    *   Operadores
**/

// Aritmética

Console.WriteLine($"Suma: 10 + 3 = {10 + 3}");
Console.WriteLine($"Resta: 10 - 3 = {10 - 3}");
Console.WriteLine($"Multiplicación: 10 * 3 = {10 * 3}");
Console.WriteLine($"División: 10 / 3 = {10 / 3}");
Console.WriteLine($"Módulo: 10 % 3 = {10 % 3}");
Console.WriteLine($"Exponente: 10 ** 3 = {Math.Pow(10, 3)}");
Console.WriteLine($"División entera: 10 // 3 = {Math.DivRem(10, 3)}");

// Operadores de comparación
Console.WriteLine($"Igualdad: suma == 13 - {((10 + 3) == 13)}");
Console.WriteLine($"Diferencia: suma != resta - {((10 + 3) != (10 - 3))}");
Console.WriteLine($"Mayor que: suma > resta - {((10 + 3) > (10 - 3))}");
Console.WriteLine($"Menor que : suma < resta - {((10 + 3) < (10 - 3))}");
Console.WriteLine($"Mayor o igual que: suma >= resta - {((10 + 3) >= (10 - 3))}");
Console.WriteLine($"Menor o igual que: suma <= resta - {((10 + 3) <= (10 - 3))}");

// Operadores Lógicos
Console.WriteLine($"AND &&: (10 + 3) == 13 && (10 - 3) == 7 - {((10 + 3) == 13 && (10 - 3) == 7)}");
Console.WriteLine($"OR ||: (10 + 3) == 14 || (10 - 3) == 7 - {((10 + 3) == 14 || (10 - 3) == 7)}");
Console.WriteLine($"NOT !: !((10 + 3) == 14) - {!((10 + 3) == 14)}");

// Operadores de asignación
int myNumber = 10;
Console.WriteLine(myNumber); // asignación directa
myNumber += 2;
Console.WriteLine(myNumber); // asignación de suma
myNumber -= 2;
Console.WriteLine(myNumber); // asignación de resta
myNumber *= 2;
Console.WriteLine(myNumber); // asignación de multiplicación
myNumber /= 2;
Console.WriteLine(myNumber); // asignación de división
myNumber %= 2;
Console.WriteLine(myNumber); // asignación de módulo
Console.WriteLine(Math.Pow(myNumber, 2)); // asignación de exponente
Console.WriteLine(Math.DivRem(myNumber, 2)); // asignación de división entera

// Operadores de identidad
int myNewNumber = myNumber;
Console.WriteLine(ReferenceEquals(myNumber.ToString(), myNewNumber.ToString()));
Console.WriteLine(myNewNumber.CompareTo(myNumber));

// operadores de pertenencia
string myName = "Miguel";
string mySecondName = "Angel";
char findBowel = 'i';

Console.WriteLine($"'i' in 'Miguel': {myName.Any(i => i == findBowel)}'");
Console.WriteLine($"'i' not in 'Angel': {!mySecondName.Any(i => i == findBowel)}'");

// Operadores de bit
var a = 10;
var b = 3;

Console.WriteLine($"AND: 10 & 3 = {a & b}");
Console.WriteLine($"OR: 10 | 3 = {a | b}");
Console.WriteLine($"XOR: 10 ^ 3 = {a ^ b}");
Console.WriteLine($"NOT: ~10 = {~a}");
Console.WriteLine($"Desplazamiento a la derecha: 10 >> 2 = {a >> 2}");
Console.WriteLine($"Desplazamiento a la izquierda: 10 << 2 = {a << 2}");

/**
 Esctucturas de control
 **/
// Condicionales
int otherNumber = 10;

if(otherNumber == 0)
{
    Console.WriteLine($"{otherNumber} es igual a cero");
}
else if(otherNumber < 0)
{
    Console.WriteLine($"{otherNumber} es menor a cero");
}
else
{
    Console.WriteLine($"El número es: {otherNumber}");
}

// Iterativas
for (int i = 0; i < otherNumber; i++)
{
    Console.WriteLine(i);
}

int number = 0;
int newNumber = 10;
while (number <= newNumber)
{
    Console.WriteLine(number);
    number += 1;
}

// Excepciones
try
{
    Console.WriteLine($"Resultado de la operación: {10/2}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error ocurred {ex.Message}");
}
finally
{
    Console.WriteLine("Finalización del código");
}

// Dificultad Extra
int inicial = 10;
int final = 56;

for (int i = inicial; i < final; i++)
{
    if(i % 2 == 0 && i != 16 && i % 3 != 0)
    {
        Console.WriteLine($"- {i}");
    }
}