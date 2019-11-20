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
            Frutas algo = new Manzana();
        }

        class Frutas
        {
            public string Nombre{get;set;}
            public double Costo{get;set;}

            public double getCost()
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

            public double getCost()
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
            public double getCost()
            {
                return "soy al funcion de manzanas";
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
            public double getCost()
            {
                return "soy al funcion de manzanas";
            }
        }        

    }
}