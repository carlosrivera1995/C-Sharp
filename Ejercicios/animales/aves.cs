using System;

public abstract class  Huevo: Animal
{
    public int Patas { get; set; }

    public void Volar()
    {
        Console.WriteLine("Volar");
    }
}