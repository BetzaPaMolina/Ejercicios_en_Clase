// Numeros pares e impares

//Declaración de variables
int numero;

Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
Console.WriteLine("°            PARES E IMPARES              °");
Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
//Solicitamos al usuario el ingreso del dato
Console.WriteLine("Bienvenido, por favor Ingrese un numero:");
numero = Convert.ToInt32(Console.ReadLine());
//Determinamos los numeros pares
if(numero % 2 == 0)
{
    Console.WriteLine($"Usted ingresó {numero}, corresponde a un numero par");
}
//determinamos los numeros impares
else 
{
    Console.WriteLine($"Usted ingresó {numero}, corresponde a un numero impar");
}