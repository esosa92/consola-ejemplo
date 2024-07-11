// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingresa tu nombre a continuacion:"); //print de python
string? nombre = Console.ReadLine(); //Recibo input del usuario
Console.WriteLine($"Hola {nombre}"); //Esto es una template string
Console.WriteLine("Ingresa un numero:");
int numero1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingresa otro numero:");
//Unsigned int

//Divison
var divison = 5 / 5;
var multiplicaion = 5 * 1;
//Potencia
var potencia = 5 * 5; //esto es 5 elevado a la 5ta
var potenciaCorrecta = Math.Pow(5, 5); //Esto es eqvuicalente a 5^5
var potenciaCorrecta2 = Math.Pow(5, 2);//esto es equivalente a 5^2



//1 = 8 bit -> el bit es la unidad minima de computo. 
//1 bit puede tener los valores 0 y 1.
//
//2^cantidad de bits
//00000000-> puedo representar hasta 256
//8 bit es igual a un byte
//2 bit 
//00 -> 0
//01 -> 1
//10 -> 2
//11 -> 3
//3 bit puedo representar 
//000 1
//001 2
//010 3
//011 4
//100 5
//101 6
//110 7
//111 8

//10 -0
//11 -1
//00 +0
//01 +1

int b = 255;
Console.WriteLine((byte)(b+1));
Console.WriteLine(Int32.MaxValue);
Console.WriteLine(Int16.MinValue);

Console.WriteLine($"La suma es: {numero1 + numero2}");