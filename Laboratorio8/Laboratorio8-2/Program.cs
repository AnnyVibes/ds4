﻿using Laboratorio8_2;

internal class Program
{
    private static void Main(string[] args)
    {
        const string CUENTA = "100";

        Cuenta cuenta = new Cuenta(CUENTA);

        CuentaCorriente cuentaCorriente = new CuentaCorriente(CUENTA);

        CuentaAhorro cuentaAhorro = new CuentaAhorro(CUENTA);

        cuenta.CalcularIntereses();
        cuentaAhorro.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();    


        
    }
}