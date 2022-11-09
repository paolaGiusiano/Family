﻿using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona P1 = new Persona("Pepe", 80);
            Persona P2 = new Persona("Juan", 40);
            Persona P3 = new Persona("José", 43);
            Persona P4 = new Persona("Maria", 20);
            Persona P5 = new Persona("Laura", 22);
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
           
            SumaEdades sum = new SumaEdades();
            sum.Visit(nP1);
            Console.WriteLine($"La suma de todas las edades es: {sum.suma}");

            
            /*Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);*/

            // visitar el árbol aquí
        }
    }
}
