﻿using Laboratorio8_8;

internal class Program
{
    private static void Main(string[] args)
    {
        ClaseConcreta1 concreta1 = new ClaseConcreta1();
        concreta1.printOut();
        Console.WriteLine(concreta1.prefixValor("Es_"));

        ClaseConcreta2 concreta2 = new ClaseConcreta2();  
        concreta2.printOut();
        Console.WriteLine(concreta2.prefixValor("Es_"));
    }
}