// las clases abstractas son clases incompletas y deben ser implementadas por clases derivadas
// no se puedencrear objetos de las clases abstractas ni interfaces
// las clases selladas si se pueden instanciar (crerles objetos) a diferencia de las abstractas
// las clases selladas NUNCA  se puede usar como clases bases o madres, esto las hace mas rapidas de compilar
// usualmente las clases selladas no requieren modificaciones adicionales por ello no necesitan clases derivadas de ellas
// una clase sealed no puede tener clases hijas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rextester 
{
    public class Program 
    {
        public static void Main(string[] args) 
        {
            Owners nana = new Owners("Orange",1.00,"Naranja");
            Console.WriteLine("mi fruta vale: {0} y la docena vale {1} y en centavos vale {2}",nana.Cost,nana.getDozen(),nana.getCents());
            Citricos non = new Citricos("toronja",1.50,"Naranja-rojo");
            Console.WriteLine("mi Citrico vale: {0} y la docena vale {1} y en centavos vale {2}",non.Cost,non.getDozen(),non.getCents());
        } 
    }

    abstract class Frutas // clase base, la clase abstract define que copsas van a tener las hijas como valore inicial, que metodos deben tener y las hijas los definiran cada una por su cuenta
    {
        public string Kind{get;set;}
        public double Cost{get;set;}
        abstract public double getDozen();
    }

    class Citricos : Frutas // clase derivada
    {
        public string Color{get;set;}
        
        public Citricos()// debo crear un contructor vacio para que pueda crear un objeto de una clase hija  
        {

        }

        public Citricos(string k, double c, string co)
        {
            Kind = k;
            Cost = c;
            Color = co;
        }
        sealed public override double getDozen() // defino el metodo que heredo de la clase abstracta, asi el metodo se define como sealed no podra ser modificado por otra clase hija
        {
            return Cost*12;
        }
        virtual public double getCents() // virtual  em permite definir el metodo y permite que pueda ser override por una clase hija
        {
            return Cost*100;
        }
    }

    class Owners : Citricos
    {
        public Owners(string k, double c, string co)
        {
            Kind = k;
            Cost = c;
            Color = co;
        }
        // public override double getDozen()
        // {
        //     return Cost*15;
        // }
        public override double getCents()
        {
            return Cost*110;
        } 
    }
}