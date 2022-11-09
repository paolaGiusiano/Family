using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Library{

    public class HijoMayor: Visitor<Persona>{

        public int mayor {get;set;}
        public override void Visit(Node<Persona> node)
        {

        }
    }

}