// la encapsulacion protege a la data de acceso no autorizado
// solo se puede acceder usando los metodos apropiados
// se definen los metodos solo para uqe modifique ciertas partes de la data
// solo se permite el acceso a la data atraves de metodos
// si las variables se definen como publicas, no limita a nadie para modificarlas a su antojo
// "loose coupling" es lo que apsa cuando una clase solo permite a otra tener conocimiento de su interior atraves de metodos
// "tight coupling" cuando una clase puede interactuar con ltodos los elementos de otra clase
// no se recomienda este acceso dado uqe puede generar error
// las demas clases solo podran usar los methodos publicos del objeto


// los static members  no pertenecen a un unico objeto declarado, pertenecen a la clase misma
// aca lo interesante es que la funcion fruitType  es propia de la clase y va a retorar lo mismo para todos los bojetos que pertencezca a la clase, nada raro
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rextester {

    public class Program {
        public static void Main(string[] args) {
         Frutas esta = new Frutas();
		Console.WriteLine("Hola se ha creado un objeto: {0}", esta.Name );	
		Console.WriteLine("Nombre cambiado");
		esta.Name = "Carol";
		Console.WriteLine("Hola se ha creado un objeto: {0}", esta.getNameMethod() );
			
        }

        class Frutas
        {
			private string nombre; // si fuera public bastaria con hacer objetonombre.nombre para retornar su valor
			
            // contructor 1, si no ingresan un valor, por defecto queda Naomi
			public Frutas() 
			{
				nombre = "Naomi";
			}
            // contructor 3, si ingresa valor de nombre al crear el objeto lo toma
			public void setName(string a)
			{
				nombre = a;
			}
			
            // proiedad con get y set
			public string Name
			{
				get{return this.nombre;}
				set{this.nombre = value;}
			}
			// metodo para obtener el nombre
			public string getNameMethod()
			{
				return nombre;
			}
		}
    }
}