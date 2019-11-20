
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
            Manzanas Man1 = new Manzanas("manzana Royal",0.50,"red");
            Peras Pera1 = new Peras("Pera Chilena",0.9,"green");
            Console.WriteLine("mi pera vale {0} y es de color {1}",Pera1.Cost,Pera1.Color);

        } 
    }
    class Frutas
    {
        public string Kind{get;set;}
        public double Cost{get;set;}
    }
    class Manzanas : Frutas
    {
        public string Color{get:set;}

        public Manzanas(string k, double c, string co)
        {
            Kind = k;
            Cost = c;
            Color = co;
        }
        public double getCostCents()
        {
            return Cost*100;
        } 
    }
    class Peras:Frutas
    {
        public string Color{get;set;}

        public Peras(string k,double c,string co)
        {
            Kind = k;
            Cost = c;
            Color = co;
        }
        public double getCostCents()
        {
            return Cost*100;
        }
    }   

}