// See https://aka.ms/new-console-template for more information
//for 
/*for (int x = 0; x < 10; x++)
{
    Console.WriteLine(x);
}
for (int x = 10; x > 0; x--) 
{
    Console.WriteLine(x);
}*/
/*int x = 0;

Console.WriteLine(x++);
Console.WriteLine(++x);
String[] a = {"Hola", "Adiós"};
foreach (String s in a)
    Console.WriteLine(s);*/



//while
/*int w = 0;
bool ban = true;
while (ban)
{
    w++;
    if (w > 10){
        //break;
        ban= false;
    }else
    {
        Console.WriteLine(w);
    }
}
w = 0;
while (w < 10)
{
    w++;
    Console.WriteLine(w);
}*/
using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;

int a;
bool r = true;

while (true)
{
    Console.Write("Coloca un número ");
    a = Convert.ToInt32(Console.ReadLine());
    if ((a % 2 == 0)&& (a>0))
    {
        Console.WriteLine("Los elementos entre 0 y el número son: ");
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine(i);
        }
        
        r = true;
        break;
    }
    else
    {
        Console.WriteLine("Coloca un número par y positivo");
        r = false;
    }
}


//Hacer un programa que lea nombre, cantidad y precio de 5 productos, el programa mostrará al finalizar el porcentaje de iva
//y el total a pagar


//Hcaer un programa que lea un número, si el número no es par se volverá a pedir de lo contrario
//Mostrará todos los elementos que está entre 0 y el (El número no debe de ser negativo)

//do while