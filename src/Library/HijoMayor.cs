using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Library{

    public class HijoMayor: Visitor<Persona>{

        public int edad_persona_mayor = 0;
        public string name_persona_mayor;
        public int edad_hijo_mayor = 0;
        public string name_hijo_mayor;
        public override void Visit(Node<Persona> node)
        {
            if (node.Dato.edad > this.edad_persona_mayor){
                this.edad_persona_mayor = node.Dato.edad;
                this.name_persona_mayor = node.Dato.nombre;
            }

            if ( (node.Dato.edad != this.edad_persona_mayor) && (node.Dato.edad > this.edad_hijo_mayor) ){
                this.edad_hijo_mayor = node.Dato.edad;
                this.name_hijo_mayor = node.Dato.nombre;
            }

            foreach(Node<Persona> n in node.Children){
                n.Accept(this);
            }

        }
    }

}