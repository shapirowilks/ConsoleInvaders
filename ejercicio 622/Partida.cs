using System;

public class Partida
{
    public  void Lanzar()
    {
        Console.WriteLine("Esta sería la pantalla de juego. Pulse Intro para salir.");
        Console.ReadKey();
        Nave n = new Nave();
        Enemigo e = new Enemigo();

        n.Mover(50, 60);
        n.Dibujar();
        e.Mover(10, 8);
        e.Dibujar();
    }
}