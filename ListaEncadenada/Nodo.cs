using System;

namespace ListaEncadenada
{
    class Nodo
    {
        private int num;
        private Nodo siguiente;
        
        public int Num { get => num; set => num = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }

        public Nodo(int num){
            this.num = num;
        }
    }
}