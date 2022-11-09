using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
     
        private T dato;


        public /*private*/ List<Node<T>> children = new List<Node<T>>();


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

    
       public Node(T t){
        this.dato = t;
       }



        public void AddChildren(Node<T> t)
        {
            this.children.Add(t);
        }

               
        public void Accept(Visitor<T> visitor) { 
            visitor.Visit(this);
        }

    }
}
