//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rextester {

    public class Program {
        public static void Main(string[] args) {
            Fruit fruta = new Fruit("pera", 3.15);
            Console.WriteLine("el tipo de fruta es: {0}", fruta.Kind);
            Console.WriteLine("el precio de la fruta es: {0}",fruta.Cost);
            Console.WriteLine("el precio de la fruta en centavos es: {0}",fruta.GetDollarsToCents());
            
        }

        class Fruit {
            private string kind;
            private double cost;

            // //constructor
            // public Fruit(string k, double c) {
            //     kind = k;
            //     cost = c;
            // }

            public Fruit(string k,string c)
            {
                this.kind = k;
                this.cost = c;
            }
            
            //propiedad
            public string Kind {
                get {
                    // return kind;
                    return this.kind;
                }
                set {
                    kind = value;
                }
            }

            //propiedad
            public double Cost {
                get {
                    // return cost;
                    return this.cost;
                }
                set {
                    cost = value;
                }
            }

            //metodo
            public double GetDollarsToCents() {
                return cost * 100;
            }
        }

    }
}