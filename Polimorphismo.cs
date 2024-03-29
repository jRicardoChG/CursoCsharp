// Cuando no se define un connstructor de ninguna manera, la creacion de un objeto acepta por defecto un contructor vacio
// Para que la fucnion peuda se rmodificada por cada clase hija, el metodo 
// 

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
            Frutas obj2 = new Naranja();
            Frutas obj3 = new Pera();
            Console.WriteLine(obj1.getCost());
            Console.WriteLine(obj2.getCost());
            Console.WriteLine(obj3.getCost());
        }

        class Frutas
        {
            public string Nombre{get;set;}
            public double Costo{get;set;}

            // public Frutas(string k, double c)
            // {
            //     Nombre = k;
            //     Costo = c; 
            // }

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

            public override string getCost()
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