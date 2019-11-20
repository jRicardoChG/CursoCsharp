// PUBLIC : el acceso no esta restringido
// PRIVATE : el acceso esta restringido para todo lo externo menos la clase contenedora
// PROTECTED: el acceso esta limitado para todo lo que esta fuera de la clase contenedora y permite a las clases hijas acceso
// INTERNAL : el acceso esta limitado para todos excepto para el mismo assembly (.dll o .exe)
// PROTECTED INTERNAL: combinacion de PROTECTED e INTERNAL, sola hay acceso dentro del mismo aseembly o no es permitido para clases o metodos hijos 


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

            Frutas fruta = new Frutas("naomi");
            Console.WriteLine("soy el nombre de la fruta: {0}", fruta.Nombre);
			Frutas.getNombre.mGetNombre(fruta);
        }
    }
    // como queda fuera de la clase program, al ser privado la clase program no tiene acceso directo a los atributos x, y.
    public struct Coords {
            public double x, y;
        }
    // en este caso, public permite el acceso
    // internal tambien porque todo esta en el mismo archivo
    // protected no, porque es igual a private (no logro ver la diferencia)
    // protected internal seria como un private para el mismo assembly

    public class Frutas
    {
        protected string name;
        public Frutas(string n)
        {
            this.name = n;
        }
        public string Nombre
        {
            get {return this.name;}
            set {this.name = value;} 
        }

        public class getNombre
        {
            public static void mGetNombre(object coso)
            {
                Console.WriteLine("hola soy el objeto: {0}",coso); 
            }
        }

    }
}