
/// los static members  no pertenecen a un unico objeto declarado, pertenecen a la clase misma
// aca lo interesante es que la funcion fruitType  es propia de la clase y va a retorar lo mismo para todos los bojetos que pertencezca a la clase, nada raro

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rextester {

    public class Program {
        public static void Main(string[] args) {
            Frutas fruta = new Frutas{Kind = "Mac", Cost=0.5, Amount = 12}; // se usan corchetes en vez de curly bracers, no se definieron atributos privados asi uqe se definen al crear el objeto
            fruta.Kind = "windows";
            Frutas pera = fruta; 
            Console.WriteLine("Frutas: {0} {1} ", Frutas.FruitType, fruta.GetFruta()); // no puedo acceder a FruitType desde un objeto porque no va a hacer parte de los objetos, solo de la clase
            Console.WriteLine("hola soy la propiedad saludoClase: {0}", Frutas.saludoClase);
            Console.WriteLine("hola soy el metodo returnoNum: {0}", Frutas.retornoNum() );
            Console.WriteLine("hola soy el objeto copiado pera: {0}", pera.GetFruta());
            // Console.WriteLine("hola sera que puedo llamar metodos o propeidades estaticas desde un objeto de la clase frutas? {0}:", fruta.retornoNum()); // no puedo, para compiralar esta linea debe irse

        }

        class Frutas
        {
            // metodo de la clase, los objetos no tienen esta propiedad, es solo de la clase, no puedo decir fruta.FruitType, no esta definido
            // esto se logra porque se define la propiedad como public static string, si solo la defino como public string, necesitar aun objeto para ser llamada 
            public static string FruitType
            {
                get {return "Manzana";}
            }
            public static string saludoClase
            {
                get {return "Hola mundo soy de la clase mama y solo de ella";}
            }
            // en teoria yo seria sol ode la clase pero osl un metodo uqe reotrna cosas
            public static double retornoNum()
            {
                return 5;
            }

            // propiedades
            public string Kind {get;set;}
            public double Cost {get;set;}
            public double Amount {get;set;}
            
            // metodo get fruta
            public string GetFruta()
            {
                return this.Kind + " $" + this.Cost + "each, $" + this.Amount + " por docena";
            }
        }

    }
}