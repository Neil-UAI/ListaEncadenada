using System;

namespace ListaEncadenada
{
    class Lista
    {
        private Nodo primero;
        private Nodo ultimo;

        private int largo;

        public int Largo { get => largo; }

        public Lista(){
            this.primero = null;            
            this.ultimo = null;        
            this.largo = 0;    
        }

        public void InsertarNodo(int num){
            Console.WriteLine("Insertando nodo...");
            Nodo nodo = new Nodo(num);
            nodo.Siguiente = null;
            this.largo++;

            if(this.primero == null){
                this.primero = nodo;
                //this.primero.Siguiente = null;
                this.ultimo = this.primero;
                Console.WriteLine("Nodo insertado.");
                Console.WriteLine();
                return;
            } 
            
            this.ultimo.Siguiente = nodo;
            this.ultimo = nodo;     
            Console.WriteLine("Nodo insertado.");
            Console.WriteLine();       
        }

        public Nodo BuscarNodo(int valorBuscado){            
            Nodo nodo = this.primero;

            while(nodo != null){                              
                if(nodo.Num == valorBuscado){
                    Console.WriteLine("Nodo encontrado...");
                    Console.WriteLine();
                    return nodo;
                }
                
                nodo = nodo.Siguiente;
            }

            Console.WriteLine("No existe nodo con ese valor");
            Console.WriteLine();
            return null;
        }

        public Nodo BuscarNodoByIndex(int indice){            
            if(indice >= this.largo){
                Console.WriteLine("El indice no existe.\n");                
                return null;
            }
            
            Nodo nodo = this.primero;
            int contador = 0;
            
            while(nodo != null){                              
                if(contador == indice){
                    Console.WriteLine("Nodo encontrado.\n");
                    Console.WriteLine();
                    return nodo;
                }
                
                nodo = nodo.Siguiente;
                contador++;
            }

            return null;
        }

        public void ModificarNodo(int valorViejo, int valornuevo){
            Nodo nodo = this.BuscarNodo(valorViejo);
            if(nodo != null){
                nodo.Num = valornuevo;
                Console.WriteLine("Nodo modificado. \n");
            }
        }

        public void ModificarNodoByIndex(int indice, int valornuevo){
            Nodo nodo = this.BuscarNodoByIndex(indice);
            if(nodo != null){
                nodo.Num = valornuevo;
                Console.WriteLine("Nodo modificado. \n");
            }
        }

        public void Mostrar(){
            Console.WriteLine("Mostrando lista...");
            
            Nodo nodo = this.primero;

            while(nodo != null){
                Console.WriteLine(nodo.Num);
                nodo = nodo.Siguiente;
            }

            Console.WriteLine();
        }
    
        public void EliminarNodo(int valorAEliminar){
            Nodo nodo = this.primero;
            Nodo anterior = null;

            Console.WriteLine("Buscando nodo a eliminar...");
            while(nodo != null){                              
                if(nodo.Num == valorAEliminar){
                    Console.WriteLine("Nodo encontrado...");

                    if(anterior == null){
                        anterior = this.primero;
                        this.primero = this.primero.Siguiente;
                        anterior = null;
                        Console.WriteLine("Nodo eliminado.");
                        Console.WriteLine();
                        this.largo--;
                        return;
                    }
                    
                    anterior.Siguiente = nodo.Siguiente;    
                    nodo = null;
                    Console.WriteLine("Nodo eliminado.");
                    Console.WriteLine();
                    this.largo--;
                    return;
                }

                anterior = nodo;
                nodo = nodo.Siguiente;
            }

            Console.WriteLine("No existe nodo con ese valor");            
            Console.WriteLine();
        }
    }
}