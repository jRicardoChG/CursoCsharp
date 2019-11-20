// poder usar otrras clases para definr otras en este caso es el uso de los dos puntos apra decir que una clase se deriva de una mayor


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rextester {

    public class Program {
        public static void Main(string[] args) {
            Arboles unPero = new Arboles("Pera", "arbol alto", "1.75");
            Console.WriteLine("hola cree un pero alto {0}", unPero.Name);
        }
          
    }
    
    public class Frutas
    {
        private string name;
        // cuando la clase madre va a dejar que sus hijas la definan, no tiene contructor
        public string Name {get; protected set;} // otra forma de escribir una propiedad mas abreviada
    }

    class Arboles : Frutas // solo sirve asi para indicar que una clase deriva de la otra, si Arboles estuviera dentro de Frutas sin la derivacion, no puede reconocer a Name como una propiedad heredada
    {
        public string kind;
        public string altura;

        public Arboles(string nombre, string kind, string altura)
        {
            Name = nombre; // atributo heredado
            this.kind = kind;
            this.altura = altura;
        }

        public string Kind {get;set;}
        public string Altura{get;set;}

        public string getCost()
        {
            return "me llamo: " + Name + "la altura es:" + altura; 
        }
    }
}