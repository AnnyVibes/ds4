﻿using Laboratorio8;

class Program
{
    public static void Main()
    {
        Trabajador p = new Trabajador("Jose", 22,"172782-0", 100000);
        Console.WriteLine("Nombre:  " + p.Nombre);
        Console.WriteLine("Edad:  " + p.Edad);
        Console.WriteLine("NIF:  " + p.NIF);
        Console.WriteLine("Sueldo:  " + p.Sueldo);
        Console.ReadKey();

    }
}

