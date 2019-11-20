// En este caso se quiere demostrar como al crear un objeto de una clase se reescriben los metodos al usar override, y new crea un neuvo metodo definido en le objeto
// en este caso al crear el objeto
//  Frutas obj = new Manzana();
// si el metodo getCost() esta como new, al llamar est eemtodo , llamara al metodo de la clase prinicpal
// si el metodo esta como override, sobreescribe el metodo de la clase madre en la definicion del objeto obj
// al crear un objeto:
// Manzana obj = new Manzana();
// tanto el metodo new y el override retornaran la nueva definicion del mismo, dado uqe el objeto esta definido sobre su propia clase y no sobre la clase madre.

rite
var algo = {
    "este" : 123,
    este1 : 234.45
}

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
            Frutas obj1 = new Manzana();
            Manzana objMain = new Manzana();
            Frutas obj2 = new Naranja();
            Frutas obj3 = new Pera();
            Console.WriteLine(obj1.getCost());
            Console.WriteLine(obj2.getCost());
            Console.WriteLine(obj3.getCost());
            Console.WriteLine(objMain.getCost());
        }

        class Frutas
        {
            public string Nombre{get;set;}
            public double Costo{get;set;}

            public virtual string getCost()
            {
                return "Soy el metodo de la clase principal, estoy definido pero no hago nada";
            } 
        }

        class Manzana : Frutas
        {
            public Manzana()
            {

            }
            
            public Manzana(string n, double c)
            {
                Nombre = n;
                Costo = c;
            }

            public new string getCost()
            {
                return "soy al funcion de manzanas";
            }
        }

        class Pera : Frutas
        {
            public Pera()
            {

            }
            public Pera(string n, double c)
            {
                Nombre = n;
                Costo = c;
            }
            public override string getCost()
            {
                return "soy al funcion de Pera";
            }
        }

        class Naranja : Frutas
        {
            public Naranja()
            {

            }
            public Naranja(string n, double c)
            {
                Nombre = n;
                Costo = c;
            }
            public override string getCost()
            {
                return "soy al funcion de Naranja";
            }
        }        
    }
}