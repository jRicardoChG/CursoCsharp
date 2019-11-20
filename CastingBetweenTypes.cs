// entre clases los objetos se pueden cambiar de tipo CASTEANDOLOS
// vamos a ver que tan flexibles son
// se puede castear de una clase obejct a una clase menor
// entre clases del mismo nivel no se pueden castear aunque sean iguales y hermanas
// entre clases del mismo nivel no se pueden castear, tampoco si son de familias distintas
// El casteo se usa cuando quiero copiar un objeto o instancia de un tipo, lo copio a un objeto del mismo tipo. en este caso el casteo no puede ser implicito, asi uqe se hace un casteo explicito. Es para lo unico uqe veo necesidad de casteo, todos losd emas casos observados no son posibles

// se puedencrear los objetos usando al principio una clase madre, pero igual va a quedar del tipo que define el constructor utilizado

// IS es un operador logico que retorna true o false si el la isntancia es de una clase o es hija de la mism
// AS se usa para castear igual que (NombreDeclase)Objecto == Objecto as NombreDeClase; 

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
            Frutas manza = new Manzanas("Apple",1.7,"roja"); // como manzanas es una clase de Frutas , todobien no  pasa nada
            // Frutas pepino = new Vegetales();  // no se puede hacer, vegetales no tiene nada que ver con frutas, estan al mismo nivel
            Object esta = new Peras();
            // Manzanas miratu = (Manzanas)esta; // no se puede pasar una pera a ser manzana asi sean iguales y hermanas
            // Peras miratu = (Peras)esta; este sirve pero tambien se puede usar as para castear
            Peras miratu = esta as Peras;
            Vegetales veggie = new Vegetales();
            Console.WriteLine("mi objeto es una {0}",manza.Kind);
            veggie.Nombre = "tomate";
            Console.WriteLine("mi objeto es un {0}",veggie.getNombre());
            Console.WriteLine("mi objeto {0} es de tipo {1}",manza.Kind,manza.GetType());
            // CASTENADO
            if(manza is Object)
            {
                Console.WriteLine("manza es un hijo remoto de Object, todos son hijos de Object que ejemplo tan malo");
            }
            if(esta is Vegetales)
            {
                Console.WriteLine("esta es un hijo de vegetales asi sea declarado como Object");
            }
            if(miratu is Vegetales)
            {
                Console.WriteLine("mi objeto copiado de vegetales necesita que esta tenga un casteo externo a Vegetales para poder funcionar");
            }
            

        } 
    }

    abstract class Frutas // clase base
    {
        public string Kind{get;set;}
        public double Cost{get;set;}
        abstract public double getDozen();
    }
    
    class Manzanas:Frutas // 
    {
        public string Color{get;set;}

        public Manzanas()
        {

        }

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
        public override double getDozen()
        {
            return 0;
        } 
    }

    class Peras:Frutas // 
    {
        public string Color{get;set;}

        public Peras()
        {

        }

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
        public override double getDozen()
        {
            return 0;
        }
    }   
    class Vegetales
    {
        public string Nombre {get;set;}

        public Vegetales()
        {

        }
        public string getNombre()
        {
            return Nombre;
        }
    }
}