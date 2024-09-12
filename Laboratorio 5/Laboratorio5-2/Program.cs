﻿namespace Laboratorio5
{
    //Problema 5-2
    internal class Problema5_2
    {
        private int[,] mat;
        public void Ingresar()
        {
            mat = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("Ingrese posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                    string linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Problema5_2 ma = new Problema5_2(); 
            ma.Ingresar();
            ma.Imprimir();
        }
    }
}

