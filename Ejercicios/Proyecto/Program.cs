﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
 
    class Program
    {
        static void Main(string[] args)
        {
           /* int art1 = 0; int art2 = 0; int art3 = 0; int art4 = 0; int art5 = 0;*/ int PrecioM = 3000; int PrecioC = 4000; int PrecioB = 400; int PrecioT = 500;  int PrecioW = 1000; int sum = 0; int cant = 0; int importe = 0; int importe1 = 0; int importe2 = 0; int importe3 = 0; int importe4 = 0;


            Console.WriteLine("\tTodo Informatica .SA ");
            Console.WriteLine("\tVentas");

           
            Console.WriteLine("\n\nArticulo1");
            Console.WriteLine("\nMonitor :  ");
               //art1 = Int32.Parse(Console.ReadLine());

               
             Console.WriteLine("Precio Monitor : 3000 ");
                   

                   
             Console.WriteLine("Cantidad :  ");
             cant = Int32.Parse(Console.ReadLine());
                   
                   
             importe = cant * PrecioM;
             Console.WriteLine("Importe : {0}", importe);
                   
   
            Console.WriteLine("\n\nArticulo2");
            Console.WriteLine("\nCPU :  ");
          //  art2 = Int32.Parse(Console.ReadLine());

           
            Console.WriteLine("Precio CPU :4000 ");
               

             
            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
               
               
            importe1 = cant * PrecioC;
            Console.WriteLine("Importe : {0}", importe1);
               
         
            Console.WriteLine("\n\nArticulo3");
            Console.WriteLine("\nBocina :  ");
               // art3 = Int32.Parse(Console.ReadLine());

               
            Console.WriteLine("Precio Bocina : 400 ");
                   

                   
            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
                   
                   
            importe2 = cant * PrecioB;
            Console.WriteLine("Importe : {0}", importe2);
           
            Console.WriteLine("\n\nArticulo4");
            Console.WriteLine("\nTeclado :  ");
              //  art4 = Int32.Parse(Console.ReadLine());

               
            Console.WriteLine("Precio Teclado : 500 ");
                 

                   
            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
                   
            importe3 = cant * PrecioT;
            Console.WriteLine("Importe : {0}", importe3);
                   
         
           
            Console.WriteLine("\n\nArticulo5");
            Console.WriteLine("\nWebcam :  ");
               // art5 = Int32.Parse(Console.ReadLine());

             
            Console.WriteLine("Precio Webcam : 500 ");
                   

            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
                   
            importe4 = cant * PrecioW;
            Console.WriteLine("Importe : {0}", importe4);
             

            sum = importe + importe1 + importe2 + importe3 + importe4;
           
            Console.WriteLine("\n\n\tEl Total a Pagar es de : {0}", sum);
           
            Console.ReadKey();
        }
    }
}