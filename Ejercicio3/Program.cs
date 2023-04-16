// Precio por servicio de estacionamiento

//Declaración de variables
int numero;

Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
Console.WriteLine("°            SERVICIO DE ESTACIONAMIENTO              °");
Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
Console.WriteLine("Primera hora: $5");
Console.WriteLine("Primeras 2 horas: $15");
Console.WriteLine("Más de 2 horas: $40");
//Solicitamos al usuario el ingreso del dato
Console.WriteLine("Bienvenido, ingrese la cantidad de horas que ha estado utilizando el servicio:");
numero = Convert.ToInt32(Console.ReadLine());
//Evaluamos el dato
if(numero == 1)
{
    Console.WriteLine("El monto que usted debe pagar por el uso del servicio es: $5");
}
else if (numero ==2)
{
    Console.WriteLine("El monto que usted debe pagar por el uso del servicio es: $15");
}
else if (numero > 2)
{
    Console.WriteLine("El monto que usted debe pagar por el uso del servicio es: $40");
}
else{
    Console.WriteLine("El monto que usted ingresó no es válido en el sistema");
}
