using System;

public class Enemigo
{
    int x, y;
    string imagen = "][";

    public void Mover(int nuevaX, int nuevaY)
    {
        Console.SetCursorPosition(nuevaX, nuevaY);
    }

    public void Dibujar()
    {
        Console.Write(imagen);
    }
}