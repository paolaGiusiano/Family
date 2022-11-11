using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Library{

    public class NombreLargo: Visitor<Persona>{

        public int largo = 0;

        public string name;
        public override void Visit(Node<Persona> node)
        {
            if (node.Dato.nombre.Length > this.largo){
                this.largo = node.Dato.nombre.Length;
                this.name = node.Dato.nombre;
            }

            foreach(Node<Persona> n in node.Children){
                n.Accept(this);
            }

        }
    }

}