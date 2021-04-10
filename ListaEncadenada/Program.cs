using System;

namespace ListaEncadenada
{
    class Program
    {
        static void Main(string[] args)
        {            
            Lista l = new Lista();
            l.InsertarNodo(9);
            l.InsertarNodo(10);
            l.InsertarNodo(45);            
            l.Mostrar();

            Console.WriteLine("Largo: " + l.Largo + "\n");

            Nodo n = l.BuscarNodo(5);
            if(n != null)
                Console.WriteLine("Valor del nodo encontrado: " + n.Num + "\n");

            l.ModificarNodo(10, 30);
            l.Mostrar();

            l.EliminarNodo(45);
            l.Mostrar();
            l.EliminarNodo(9);
            l.Mostrar();
            l.EliminarNodo(20);
            l.Mostrar();
            l.EliminarNodo(30);
            l.Mostrar();

            Console.WriteLine("Largo: " + l.Largo + "\n");

            l.InsertarNodo(60);
            l.Mostrar();
            Console.WriteLine("Largo: " + l.Largo + "\n");

            n = l.BuscarNodoByIndex(1);
            if(n != null)
                Console.WriteLine("Valor del nodo encontrado: " + n.Num + "\n");

            l.InsertarNodo(20);
            l.InsertarNodo(40);

            n = l.BuscarNodoByIndex(1);
            if(n != null)
                Console.WriteLine("Valor del nodo encontrado: " + n.Num + "\n");

            l.ModificarNodoByIndex(1, 600);
            l.Mostrar();
        }
    }
}
