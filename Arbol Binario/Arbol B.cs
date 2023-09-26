using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
     class Arbol_B
    {
        private Nodo raiz;
        private Nodo trabajo;

        private int i = 0;

        public Arbol_B()
        {
            raiz = null;
        }
        internal Nodo Raiz { get => raiz; set => raiz = value;}


        //Insertar
        public Nodo Insertar(int pDato, Nodo pNodo)
        {
            Nodo temp = null;

            // Si no hay a quien insertar creamos el nodo
            if (pNodo == null) 
            {
                temp= new Nodo();
                temp.Dato = pDato;

                return temp;
            }
            if (pDato<pNodo.Dato) 
            {
                pNodo.Izq=Insertar(pDato, pNodo.Izq);
            }
            if (pDato>pNodo.Dato)
            {
                pNodo.Der=Insertar(pDato,pNodo.Der);

            }
            return pNodo;
        }
            //Transversa
            public void Transversa(Nodo pNodo)
        {
            if (pNodo == null)
                return;

            // Me proceso primero a mi
            for (int n = 0; n < i; n++)
                Console.Write("");

            Console.WriteLine(pNodo.Dato);

            // Si tengo izquierda , proceso a la izquierda
            if (pNodo.Izq!=null)
            {
                i++;
                Console.Write("I");
                Transversa(pNodo.Izq);
                i--;
            }
            // Si tengo derecha, proceso a la derecha
            if(pNodo.Der!=null)
            {
                i++;
                Console.Write("D");
                Transversa(pNodo.Der);
                i--;
            }
        }
        
    }
}
