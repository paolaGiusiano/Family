using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        //private int number;
        private T dato;

        private List<Node<T>> children = new List<Node<T>>();

        /*public int Number {
            get
            {
                return this.number;
            }
        }*/

        public T Dato{
            get
            {
                return this.dato;
            }

        }


        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        /*public Node(int number)
        {
            this.number = number;
        }*/


       public Node(T dato)
       {
        this.dato = dato;
       }


        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        
    }
}
/*
public Persona p;
public Node(Persona) 

*/