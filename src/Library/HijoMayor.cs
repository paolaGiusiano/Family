using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Library{

    public class HijoMayor: Visitor<Persona>{

        public int mayor = 0;
        public override void Visit(Node<Persona> node)
        {
            if (node.Dato.edad > this.mayor){
                this.mayor = node.Dato.edad;
            }
            foreach(Node<Persona> n in node.Children){
                n.Accept(this);
            }

        }
    }

}