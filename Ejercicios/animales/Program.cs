using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();

            Perro p = new Perro();
            p.Nombre = "Firulais";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);

            Gato g = new Gato();
            g.Nombre = "Garfield";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);

             Mono m = new Mono();
            m.Nombre = "Manotas";
            m.Patas = 2;
            m.Pelaje = "Peludo";
            m.Comer();
            m.Caminar();
            m.Chilla();

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);

             Aguila a = new Aguila();
            a.Nombre = "Seuz";
            a.Patas = 2;
            a.Comer();
            a.Chilla();

            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.Patas);

    
        }
    }
}