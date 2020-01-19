using System;

public class Bienvenida
{
    bool salir = false;
    public  void Lanzar()
    {
       
        Console.WriteLine("Bienvenido a Console Invaders. Pulse Intro para jugar o ESC para salir.");
        ConsoleKeyInfo tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.Escape)
            salir = true;
        else if (tecla.Key == ConsoleKey.Enter)
            salir = false;
    }

    public bool GetSalir()
    {      
        return salir;
    }
}