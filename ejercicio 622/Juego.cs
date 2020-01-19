using System;

public class Juego
{
    public void Lanzar()
    {
        //bool salirya = false;
        Bienvenida b = new Bienvenida();
        Partida p = new Partida();

        //do
        //{
           
            b.Lanzar();
            p.Lanzar();
        //    salirya = b.GetSalir();
        //}
        //while (salirya == false);
        Console.Clear();
    }

    public static void Main()
    {
        Juego j = new Juego();

        j.Lanzar();
        Console.ReadKey();
    }
}