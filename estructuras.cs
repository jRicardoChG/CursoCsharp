// las estructuras sirven para crear tipos de datos, guardan valores a diferentecia de las clases que guardan referencias, son mas simples que las clases y retornan valores de manera mas simple
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rextester {

    public class Program {
        public static void Main(string[] args) {
            
            Coords c1 = new Coords();
            c1.x = 100;
            c1.y = 200;
            Coords c2 = c1;
            Console.WriteLine(c2.x + c2.y);
        }
        public struct Coords {
            public double x, y;
        }

    }
}