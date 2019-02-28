using System;

namespace Dados
{
    class Dado
    {
        //Atributos 
        private int valor;
        

        //Constructor
        public Dado(int valor)
        {
            this.valor=valor;
            
        }

        

        //metodo
        public static Dado operator + (Dado d, Dado d2)
        {
            Dado result = new Dado(d.valor+d2.valor);
            return result;
        }
       
        
        public void imprime()
        {
            Console.WriteLine("La suma es : {0}", valor);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Dado d1 = new Dado(rnd.Next(1,6));
            Dado d2 = new Dado(rnd.Next(1,6));
            Dado d3 = new Dado(rnd.Next(1,6));

           
           Dado d = d1+d2;

            d1.imprime();
            d3.imprime();
            d.imprime();
           
        }
    }
}
