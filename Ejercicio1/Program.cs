// Numeros del 1 al 12 con sus nombres correspondientes en el calendario.

//Declaración de variables
int mes;

Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
Console.WriteLine("°             Meses del año              °");
Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
//Solicitamos al usuario el ingreso del dato
Console.WriteLine("Bienvenido, por favor Ingrese un numero del 1 al 12:");
mes = Convert.ToInt32(Console.ReadLine());
//Enviamos el dato al caso al que corresponda en el switch
switch (mes)
{
    case 1:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Enero");
        break;
    case 2:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Febrero");
        break;
    case 3:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Marzo");
        break;
    case 4:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Abril");
        break;
    case 5:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Mayo");
        break;
    case 6:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Junio");
        break;
    case 7:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Julio");
        break;
    case 8:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Agosto");
        break;
    case 9:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Septiembre");
        break;
    case 10:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Octubre");
        break;
    case 11:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Noviembre");
        break;
    case 12:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario corresponde a : Diciembre");
        break;
    default:
        Console.WriteLine($"Usted ingresó {mes}, en el calendario no corresponde a ningún mes.");
        break;
}