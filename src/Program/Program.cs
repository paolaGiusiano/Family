using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola);

            Persona P1 = new Persona("Pp", 80);
            Persona P2 = new Persona("Juan", 40);
            Persona P3 = new Persona("Jose", 43);
            Persona P4 = new Persona("Maria", 20);
            Persona P5 = new Persona("Lau", 22);
            Persona P6 = new Persona("Paz", 18);
            Persona P7 = new Persona("Sol", 15);
            Persona P8 = new Persona("Lolo", 3);
            Node<Persona> nP1 = new Node<Persona>(P1);
            Node<Persona> nP2 = new Node<Persona>(P2);
            Node<Persona> nP3 = new Node<Persona>(P3);
            Node<Persona> nP4 = new Node<Persona>(P4);
            Node<Persona> nP5 = new Node<Persona>(P5);
            Node<Persona> nP6 = new Node<Persona>(P6);
            Node<Persona> nP7 = new Node<Persona>(P7);
            Node<Persona> nP8 = new Node<Persona>(P8);

            nP1.AddChildren(nP2);
            nP1.AddChildren(nP3);
            nP2.AddChildren(nP4);
            nP2.AddChildren(nP7);
            nP3.AddChildren(nP5);
            nP3.AddChildren(nP6);
            nP5.AddChildren(nP8);
           
            Console.WriteLine();

            SumaEdades sum = new SumaEdades();
            sum.Visit(nP1);
            Console.WriteLine($"La suma de todas las edades es: {sum.suma}");

            HijoMayor m = new HijoMayor();
            m.Visit(nP1);
            Console.WriteLine($"{m.name_persona_mayor} es la persona mayor con {m.edad_persona_mayor} años");
            Console.WriteLine($"El hijo mayor de {m.edad_persona_mayor} es {m.name_persona_mayor} con {m.edad_hijo_mayor}");

            NombreLargo nam = new NombreLargo();
            nam.Visit(nP1);
            Console.WriteLine($"El nombre más largo tiene {nam.largo} letras y es el de {nam.name}");

            Console.WriteLine();
           

        }
    }
}
