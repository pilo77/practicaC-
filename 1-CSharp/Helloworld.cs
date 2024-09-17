
using System;
using Microsoft.VisualBasic;
/* ESTO ES UN COMENTARIO
DE VARIAS LINEAS*/

namespace CSharpHellosWorld
{

    class HelloWorld
    {

        static void Main(string[] args)
        {

            //CLASES 

            //ESTO ES UN COMENTARIO
            Console.WriteLine("holaaa cshart");

            string nombre = "CARLOS VILLAMIL";

            nombre = "CARLOS ANDRES VILLAMILL";
            Console.WriteLine(nombre);

            int edad = 19;
            Console.WriteLine(edad);
            double plata1 = 6.7;
            float plata = 6.5f;
            Console.WriteLine("este es el valor de la plata 1 es " + plata1 + " esto es el valor de la plata 2 es " + plata);


            //TIPO DE DATO DINAMICO NO ES MUY UTLIZADO POR QUE LA ESTRUCTURA Y LA RAZON PORLA QUE SE HIZO C# ES PARA SER FUERTE MENTE TIPADO
            dynamic datedinami = 4;
            datedinami = "hello world por un dato dinamico";
            var myvar = "Maria Angelica Del Rosario";
            //myvar=8;

            Console.WriteLine(datedinami + plata);

            //TIPOS DE DATOS BOLEANOS
            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            Console.WriteLine($"elvalor de mi boleano es {plata} y el valor resultado final de mi boleano es{myBool}");

            const String myConst = "mi constante";
            Console.WriteLine(myConst);



            //esttuctura
            var myArray = new string[] { "carlos", "maria" };

            Console.WriteLine(myArray[0]);


            var myDictionary = new Dictionary<string, int>{
        {"carlos",19},
        {"Pizza",99}

        };
            var mySet = new HashSet<string> { "brais", "moure", "mauroDev" };

            var myTuple = ("brais", "moure", "mauroDev");
            Console.WriteLine(myTuple);


            Console.WriteLine(myDictionary["carlos"]);

            //BUCLES
            for (int index = 1; index <= 10; index++)
            {
                Console.WriteLine(index);
            };

            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }
            foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }

            //FLUJOS
            int numero1 = 16;
            int numero2 = 2;

            if (numero1 == numero2 || myBool == false)
            {
                Console.WriteLine($"el numero es igual {numero1} con {numero2}");
            }
            else if (numero1 > numero2 || myBool == true)
            {
                Console.WriteLine($"el numero mayor es el {numero1}");

            }
            else
            {
                Console.WriteLine("no son iguales");
            }

            //FUNCIONES
            myFunction();
            myFunction();
            myFunction();
            Console.WriteLine(myFunctionReturn(5));

            //CLASES

            var esto= new MyClass("hola mundo");
            Console.WriteLine(esto.myName);
            esto.myName="Carlos Andres Villamil";

        }
        static void myFunction()
        {
            Console.WriteLine("esto es una funcionnnn");
        }

        static int myFunctionReturn(int param)
        {

            return 10 + param;

            //CLASES

        }
        class MyClass
        {
            public string myName{get; set;}

            public MyClass(string myName)
            {
                myName= myName;

            }


        }

    }

}


