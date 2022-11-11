using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Library{


    public class SumaEdades: Visitor<Persona>{
        public int suma {get;set;}
        public override void Visit(Node<Persona> node)
        {
            suma += node.Dato.edad;
            foreach(Node<Persona> n in node.Children){
                n.Accept(this);
            }   

        }


    }


}